using Final.Model.LaptopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class LaptopManagement : Form {
        public LaptopManagement() {
            InitializeComponent();
        }

        private void LaptopManagement_Load(object sender, EventArgs e) {
            try {
                LaptopDBContext context = new LaptopDBContext();
                FillCategoryData(context.LaptopCategories.ToList());
                FillDataView(context.Laptops.ToList());
                CbxLaptopCategory.SelectedItem = null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            try {
                LaptopDBContext context = new LaptopDBContext();
                var find = context.Laptops.FirstOrDefault(l => l.LaptopID == TblaptopID.Text);
                //Nếu đã tồn tại
                if (find != null) {
                    if (TbLaptopName.Text == "" || TblaptopID.Text == "" || TbPrice.Text == "" ||
                        TbQuantity.Text == "") {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }

                    find.LaptopName = TbLaptopName.Text;
                    find.CategoryID = ((LaptopCategory)CbxLaptopCategory.SelectedItem).CategoryID;
                    if (decimal.TryParse(TbPrice.Text, out decimal price)) {
                        find.SellPrice = price;
                    } else {
                        MessageBox.Show("Giá trị nhập vào không đúng");
                    }

                    if (TbSale.Text != "" && int.TryParse(TbSale.Text, out int sale)) {
                        find.Sale = sale;
                    } else {
                        MessageBox.Show("Giá trị nhập vào không đúng");
                    }

                    if (int.TryParse(TbQuantity.Text, out int quantity)) {
                        find.Quantity += quantity; // update SL len
                    } else {
                        MessageBox.Show("Giá trị nhập vào không đúng");
                    }

                    //Lưu thay đổi
                    context.SaveChanges();
                    FillDataView(context.Laptops.ToList());
                } else {
                    Laptop lap = new Laptop() {
                        LaptopID = TblaptopID.Text,
                        LaptopName = TbLaptopName.Text,
                        CategoryID = ((LaptopCategory)CbxLaptopCategory.SelectedItem).CategoryID,
                        SellPrice = decimal.Parse(TbSale.Text),
                        Sale = int.Parse(TbSale.Text),
                        Quantity = int.Parse(TbQuantity.Text),
                    };
                    context.Laptops.Add(lap);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    context = new LaptopDBContext();
                    FillDataView(context.Laptops.ToList());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            //Làm phần xoá, khi xoá sẽ kiểm tra số lượng trong ô Số lượng xoá chỉ trừ đi số lượng sau đó lưu thay đổi và gọi lại hàm FillDataView()
            try {
                LaptopDBContext context = new LaptopDBContext();
                var find = context.Laptops.FirstOrDefault(l => l.LaptopID == TblaptopID.Text);
                //Nếu không tồn tại
                if (find == null) {
                    MessageBox.Show("Laptop này không tồn tại!");
                    return;
                }

                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);
                if (int.TryParse(TbQuantity.Text, out int quantity) && quantity > 0 && quantity <= find.Quantity) {
                    if (dialog == DialogResult.Yes) {
                        find.Quantity -= quantity;
                        context.SaveChanges();
                        FillDataView(context.Laptops.ToList());
                    }
                } else {
                    MessageBox.Show("Số lượng xoá ngoài phạm vi có thể xoá !",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvLaptops_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var lapId = DgvLaptops.Rows[e.RowIndex].Cells[0].Value.ToString();
            var context = new LaptopDBContext();
            var find = context.Laptops.FirstOrDefault(l => l.LaptopID == lapId);
            if (find == null) {
                return;
            }

            TblaptopID.Text = lapId;
            TbLaptopName.Text = find.LaptopName;
            TbPrice.Text = find.SellPrice.ToString();
            TbSale.Text = find.Sale != 0 ? find.Sale.ToString() : "";
            CbxLaptopCategory.SelectedValue = find.CategoryID;
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            //Tìm kiếm: thoả mãn 1 trong các ô: mã máy, tên máy, tìm xong gọi hàm FillDataView() để load giá trị 
            try {
                var context = new LaptopDBContext();
                var findById = context.Laptops.Where(l => l.LaptopID == TblaptopID.Text);
                var findByName = context.Laptops.Where(l => l.LaptopName == TbLaptopName.Text);
                var findByCategory = context.Laptops.Where(l =>
                    l.CategoryID == ((LaptopCategory)CbxLaptopCategory.SelectedItem).CategoryID);
                var findByPrice = context.Laptops.Where(l => l.SellPrice <= decimal.Parse(TbPrice.Text));
                FillDataView(findById.Union(findByName).Union(findByCategory).Union(findByPrice).ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillCategoryData(IReadOnlyCollection<LaptopCategory> categories) {
            CbxLaptopCategory.DataSource = categories;
            CbxLaptopCategory.DisplayMember = "CategoryName";
            CbxLaptopCategory.ValueMember = "CategoryID";
            CbxLaptopCategory.SelectedIndex = -1;
        }

        private void FillDataView(List<Laptop> laptops) {
            DgvLaptops.Rows.Clear();
            foreach (var item in laptops) {
                var index = DgvLaptops.Rows.Add();
                DgvLaptops.Rows[index].Cells[0].Value = item.LaptopID;
                DgvLaptops.Rows[index].Cells[1].Value = item.LaptopName;
                DgvLaptops.Rows[index].Cells[2].Value = item.LaptopCategory.CategoryName;
                DgvLaptops.Rows[index].Cells[3].Value = item.SellPrice;
                DgvLaptops.Rows[index].Cells[4].Value = item.Sale.ToString();
                DgvLaptops.Rows[index].Cells[5].Value = item.Quantity.ToString();
            }
        }
    }
}