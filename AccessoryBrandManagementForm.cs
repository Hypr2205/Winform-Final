using Final.Model.AccessoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class AccessoryBrandManagementForm : Form {
        public AccessoryBrandManagementForm() {
            InitializeComponent();
        }

        private void AccessoryBrandManagement_Load(object sender, EventArgs e) {
            try {
                AccessoryContext context = new AccessoryContext();
                FillDataView(context.AccessoryBrands.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvAccessoryBrands_CellClick(object sender, DataGridViewCellEventArgs e) {
            var id = DgvAccessoryBrands.Rows[e.RowIndex].Cells[0].Value.ToString();
            AccessoryContext context = new AccessoryContext();
            var find = context.AccessoryBrands.FirstOrDefault(b => b.BrandID.ToString() == id);
            if (find == null) return;
            TbID.Text = find.BrandID.ToString();
            TbName.Text = find.BrandName;
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            var context = new AccessoryContext();

            var idFilter = string.IsNullOrEmpty(TbID.Text) ? null : TbID.Text;
            var nameFilter = string.IsNullOrEmpty(TbName.Text) ? null : TbName.Text;

            var findById = idFilter != null
                ? context.AccessoryBrands.Where(b => b.BrandID.ToString().Contains(TbID.Text))
                : null;
            var findByName = nameFilter != null
                ? context.AccessoryBrands.Where(b => b.BrandName.Contains(nameFilter))
                : null;

            var queryList = new List<IQueryable<AccessoryBrand>>();
            if (findById != null) queryList.Add(findById);
            if (findByName != null) queryList.Add(findByName);
            var result = queryList.Any()
                ? queryList.Aggregate((a, b) => a.Union(b)).ToList()
                : new List<AccessoryBrand>();
            if (result.Any()) {
                FillDataView(result);
                ClearInput();
            } else {
                MessageBox.Show(@"Không tìm thấy sản phẩm phù hợp");
                ClearInput();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            try {
                var context = new AccessoryContext();
                if (TbID.Text == string.Empty || TbName.Text == string.Empty) {
                    MessageBox.Show(@"Nhập đầy đủ thông tin");
                }

                var selectedRow = GetRowIndex(TbID.Text);
                if (selectedRow == -1) {
                    AccessoryBrand brand = new AccessoryBrand();
                    brand.BrandID = int.Parse(TbID.Text);
                    brand.BrandName = TbName.Text;
                    context.AccessoryBrands.Add(brand);
                    context.SaveChanges();
                    MessageBox.Show(@"Thêm thành công");
                    ClearInput();

                    context = new AccessoryContext();
                    FillDataView(context.AccessoryBrands.ToList());
                } else {
                    var find = context.AccessoryBrands.FirstOrDefault(b => b.BrandID.ToString() == TbID.Text);
                    if (find != null) {
                        find.BrandID = int.Parse(TbID.Text);
                        find.BrandName = TbName.Text;
                        context.SaveChanges();
                        MessageBox.Show(@"Cập nhật thành công");
                        ClearInput();
                        FillDataView(context.AccessoryBrands.ToList());
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            var context = new AccessoryContext();
            var find = context.AccessoryBrands.FirstOrDefault(b => b.BrandID.ToString() == TbID.Text);
            if (find != null) {
                context.AccessoryBrands.Remove(find);
                context.SaveChanges();
                MessageBox.Show(@"Xoá thành công");
                FillDataView(context.AccessoryBrands.ToList());
                ClearInput();
            } else {
                MessageBox.Show(@"Không có hãng tồn tại");
            }
        }

        private void FillDataView(List<AccessoryBrand> brands) {
            DgvAccessoryBrands.Rows.Clear();
            foreach (var brand in brands) {
                var index = DgvAccessoryBrands.Rows.Add();
                DgvAccessoryBrands.Rows[index].Cells[0].Value = brand.BrandID;
                DgvAccessoryBrands.Rows[index].Cells[1].Value = brand.BrandName;
            }
        }

        private void ClearInput() {
            TbID.Text = string.Empty;
            TbName.Text = string.Empty;
        }

        private void BtnReload_Click(object sender, EventArgs e) {
            AccessoryBrandManagement_Load(sender, e);
        }

        private int GetRowIndex(string id) {
            for (var i = 0; i < DgvAccessoryBrands.Rows.Count; i++) {
                if (DgvAccessoryBrands.Rows[i].Cells[0].Value.ToString() == id) {
                    return i;
                }
            }
            return -1;
        }
    }
}