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
                FillCategoryData(context.LaptopCategory.ToList());
                FillDataView(context.Laptop.ToList());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            try {
                LaptopDBContext context = new LaptopDBContext();
                var find = context.Laptop.FirstOrDefault(l => l.LaptopID == TblaptopID.Text);
                //Nếu đã tồn tại
                if (find != null) {
                    if (TbLaptopName.Text == "" || TblaptopID.Text == "" || TbPrice.Text == "" ||
                        TbQuantity.Text == "") {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    }

                    find.LaptopName = TbLaptopName.Text;
                    find.CategoryID = (CbxLaptopCategory.SelectedItem as LaptopCategory).CategoryID;
                    if (decimal.TryParse(TbPrice.Text, out decimal price)) {
                        find.SellPrice = price;
                    }
                    else {
                        MessageBox.Show("Giá trị nhập vào không đúng");
                    }

                    if (!(TbSale.Text == "") && int.TryParse(TbSale.Text, out int sale)) {
                        find.Sale = sale;
                    }
                    else {
                        MessageBox.Show("Giá trị nhập vào không đúng");
                    }

                    if (int.TryParse(TbQuantity.Text, out int quantity)) {
                        find.Quantity = quantity;
                    }
                    else {
                        MessageBox.Show("Giá trị nhập vào không đúng");
                    }

                    //Lưu thay đổi
                    context.SaveChanges();
                    FillDataView(context.Laptop.ToList());
                }
                else {
                    Laptop lap = new Laptop() {
                        LaptopID = TblaptopID.Text,
                        LaptopName = TbLaptopName.Text,
                        CategoryID = (CbxLaptopCategory.SelectedItem as LaptopCategory).CategoryID,
                        SellPrice = decimal.Parse(TbSale.Text),
                        Sale = int.Parse(TbSale.Text),
                        Quantity = int.Parse(TbQuantity.Text),
                    };
                    context.Laptop.Add(lap);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    context = new LaptopDBContext();
                    FillDataView(context.Laptop.ToList());
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            //Làm phần xoá, khi xoá sẽ kiểm tra số lượng trong ô Số lượng xoá chỉ trừ đi số lượng sau đó lưu thay đổi và gọi lại hàm FillDataView()
            try {
                LaptopDBContext context = new LaptopDBContext();
                var find = context.Laptop.FirstOrDefault(l => l.LaptopID == TblaptopID.Text);
                //Nếu không tồn tại
                if (find == null) {
                    MessageBox.Show("Laptop này không tồn tại nên không xoá được!");
                    return;
                }

                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);

                if (int.Parse(TbQuantity.Text) < find.Quantity) {
                    if (dialog == DialogResult.Yes) {
                        find.Quantity = find.Quantity - int.Parse(TbQuantity.Text);
                        context.SaveChanges();
                        FillDataView(context.Laptop.ToList());
                    }
                }
                else {
                    MessageBox.Show("Số lượng Xoá ngoài phạm vi có thể Xoá !");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvLaptops_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var lapId = DgvLaptops.Rows[e.RowIndex].Cells[0].Value.ToString();
            LaptopDBContext context = new LaptopDBContext();
            var find = context.Laptop.FirstOrDefault(l => l.LaptopID == lapId);
            if (find != null) {
                TblaptopID.Text = lapId;
                TbLaptopName.Text = find.LaptopName;
                TbPrice.Text = find.SellPrice.ToString();
                if (find.Sale != 0) {
                    TbSale.Text = find.Sale.ToString();
                }
                else {
                    TbSale.Text = "";
                }

                CbxLaptopCategory.SelectedValue = find.CategoryID;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            //Tìm kiếm: thoả mãn 1 trong các ô: mã máy, tên máy, tìm xong gọi hàm FillDataView() để load giá trị 
        }

        private void FillCategoryData(List<LaptopCategory> categories) {
            CbxLaptopCategory.DataSource = categories;
            CbxLaptopCategory.DisplayMember = "CategoryName";
            CbxLaptopCategory.ValueMember = "CategoryID";
        }

        private void FillDataView(List<Laptop> laptops) {
            DgvLaptops.Rows.Clear();
            foreach (var item in laptops) {
                var index = DgvLaptops.Rows.Add();
                DgvLaptops.Rows[index].Cells[0].Value = item.LaptopID;
                DgvLaptops.Rows[index].Cells[1].Value = item.LaptopName;
                DgvLaptops.Rows[index].Cells[2].Value = item.LaptopCategory.CategoryName;
                DgvLaptops.Rows[index].Cells[3].Value = item.SellPrice.ToString();
                DgvLaptops.Rows[index].Cells[4].Value = item.Sale.ToString();
                DgvLaptops.Rows[index].Cells[5].Value = item.Quantity.ToString();
            }
        }
    }
}