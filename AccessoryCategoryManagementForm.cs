using Final.Model.AccessoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class AccessoryCategoryManagementForm : Form {
        public AccessoryCategoryManagementForm() {
            InitializeComponent();
        }

        private void DgvCategories_CellClick(object sender, DataGridViewCellEventArgs e) {
            var id = DgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
            AccessoryContext context = new AccessoryContext();
            var find = context.AccessoryCategories.FirstOrDefault(b => b.CategoryID.ToString() == id);
            if (find != null) {
                TbId.Text = find.CategoryID.ToString();
                TbName.Text = find.CategoryName.ToString();
            }
        }

        private void BtnReload_Click(object sender, System.EventArgs e) {
            AccessoryCategoryManagementForm_Load(sender, e);
        }

        private void BtnSearch_Click(object sender, System.EventArgs e) {
            var context = new AccessoryContext();

            var idFilter = string.IsNullOrEmpty(TbId.Text) ? null : TbId.Text;
            var nameFilter = string.IsNullOrEmpty(TbName.Text) ? null : TbName.Text;

            var findById = idFilter != null
                ? context.AccessoryCategories.Where(b => b.CategoryID.ToString().Contains(TbId.Text))
                : null;
            var findByname = nameFilter != null
                ? context.AccessoryCategories.Where(b => b.CategoryName.Contains(nameFilter))
                : null;

            var queryList = new List<IQueryable<AccessoryCategory>>();
            if (findById != null) queryList.Add(findById);
            if (findByname != null) queryList.Add(findByname);
            var result = queryList.Any()
                ? queryList.Aggregate((a, b) => a.Union(b)).ToList()
                : new List<AccessoryCategory>();
            if (result.Any()) {
                FillDataView(result);
                ClearInput();
            } else {
                MessageBox.Show(@"Không tìm thấy sản phẩm phù hợp");
                ClearInput();
            }
        }

        private void BtnEdit_Click(object sender, System.EventArgs e) {
            try {
                var context = new AccessoryContext();
                if (TbId.Text == string.Empty || TbName.Text == string.Empty) {
                    MessageBox.Show(@"Nhập đầy đủ thông tin");
                }

                var selectedRow = GetRowIndex(TbId.Text);
                if (selectedRow == -1) {
                    AccessoryCategory category = new AccessoryCategory();
                    category.CategoryID = int.Parse(TbId.Text);
                    category.CategoryName = TbName.Text;
                    context.AccessoryCategories.Add(category);
                    context.SaveChanges();
                    MessageBox.Show(@"Thêm thành công");
                    ClearInput();

                    context = new AccessoryContext();
                    FillDataView(context.AccessoryCategories.ToList());
                } else {
                    var find = context.AccessoryCategories.FirstOrDefault(b => b.CategoryID.ToString() == TbId.Text);
                    if (find != null) {
                        find.CategoryID = int.Parse(TbId.Text);
                        find.CategoryName = TbName.Text;
                        context.SaveChanges();
                        MessageBox.Show(@"Cập nhật thành công");
                        ClearInput();
                        FillDataView(context.AccessoryCategories.ToList());
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, System.EventArgs e) {
            var context = new AccessoryContext();
            var find = context.AccessoryCategories.FirstOrDefault(b => b.CategoryID.ToString() == TbId.Text);
            if (find != null) {
                context.AccessoryCategories.Remove(find);
                context.SaveChanges();
                MessageBox.Show(@"Xoá thành công");
                FillDataView(context.AccessoryCategories.ToList());
                ClearInput();
            } else {
                MessageBox.Show(@"Không có hãng tồn tại");
            }
        }

        private void AccessoryCategoryManagementForm_Load(object sender, System.EventArgs e) {
            try {
                AccessoryContext context = new AccessoryContext();
                FillDataView(context.AccessoryCategories.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDataView(List<AccessoryCategory> categories) {
            DgvCategories.Rows.Clear();
            foreach (var item in categories) {
                var index = DgvCategories.Rows.Add();
                DgvCategories.Rows[index].Cells[0].Value = item.CategoryID;
                DgvCategories.Rows[index].Cells[1].Value = item.CategoryName;
            }
        }

        private void ClearInput() {
            TbId.Text = string.Empty;
            TbName.Text = string.Empty;
        }

        private int GetRowIndex(string id) {
            for (var i = 0; i < DgvCategories.Rows.Count; i++) {
                if (DgvCategories.Rows[i].Cells[0].Value.ToString() == id) {
                    return i;
                }
            }
            return -1;
        }
    }
}