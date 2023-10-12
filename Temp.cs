using Final.Model.AccessoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class Temp : Form {
        public Temp() {
            InitializeComponent();
        }

        private void AccessoryManagement_Load(object sender, EventArgs e) {
            try {
                var context = new AccessoryContext();
                FillDataView(context.Accessories.ToList());

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e) {


        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            try {
                var context = new AccessoryContext();
                var selectedRow = GetRowIndex(TbAccessoryID.Text);

                if (selectedRow == -1) { //Nếu không tồn tại
                    var accessory = new Accessory();
                    if (TbAccessoryID.Text != string.Empty) {
                        accessory.AccessoryID = TbAccessoryID.Text;
                    } else {
                        MessageBox.Show("Mã sản phẩm còn thiếu!");
                    }

                    if (TbAccessoryName.Text != string.Empty) {
                        accessory.AccessoryName = TbAccessoryName.Text;
                    } else {
                        MessageBox.Show("Tên sản phẩm còn thiếu");
                    }

                    accessory.CategoryID = ((AccessoryCategory)CbxAccessoryCategory.SelectedItem).CategoryID;
                    accessory.BrandID = ((AccessoryBrand)CbxAccessoryBrand.SelectedItem).BrandID;

                    if (TbPrice.Text != string.Empty && decimal.TryParse(TbPrice.Text, out var price)) {
                        accessory.SellPrice = price;
                    } else {
                        MessageBox.Show("Giá bán không hợp lệ hoặc còn thiếu");
                    }

                    if (TbQuantity.Text != string.Empty && int.TryParse(TbQuantity.Text, out var quantity) &&
                        quantity > 0) {
                        accessory.Quantity = quantity;
                    } else {
                        MessageBox.Show("Số lượng không hợp lệ hoặc còn thiếu");
                    }

                    if (TbSale.Text != string.Empty && int.TryParse(TbSale.Text, out var sale) && sale > 0) {
                        accessory.Sale = sale;
                    } else {
                        accessory.Sale = 0;
                    }

                    context.Accessories.Add(accessory);
                    context.SaveChanges();
                    ClearInput();
                    MessageBox.Show("Thêm mới thành công");
                    FillDataView(context.Accessories.ToList());
                } else {
                    var find = context.Accessories.FirstOrDefault(a => a.AccessoryID == TbAccessoryID.Text);
                    if (find == null) return;

                    find.AccessoryID = TbAccessoryID.Text;
                    find.AccessoryName = TbAccessoryName.Text;
                    find.CategoryID = ((AccessoryCategory)CbxAccessoryCategory.SelectedItem).CategoryID;
                    find.BrandID = ((AccessoryBrand)CbxAccessoryBrand.SelectedItem).BrandID;
                    if (decimal.TryParse(TbPrice.Text, out var price) && price > 0) {
                        find.SellPrice = price;
                    } else {
                        MessageBox.Show("Giá nhập vào không hợp lệ");
                    }

                    if (int.TryParse(TbQuantity.Text, out var quantity) && quantity > 0) {
                        find.Quantity = quantity;
                    } else {
                        MessageBox.Show("Số lượng nhập vào không hợp lệ");
                    }

                    if (TbSale.Text != string.Empty && int.TryParse(TbSale.Text, out var sale) && sale > 0) {
                        find.Sale = sale;
                    } else {
                        find.Sale = 0;
                    }

                    context.SaveChanges();
                    ClearInput();
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    FillDataView(context.Accessories.ToList());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            try {
                var context = new AccessoryContext();
                var find = context.Accessories.FirstOrDefault(a => a.AccessoryID == TbAccessoryID.Text);
                var isValidQuantity = int.TryParse(TbQuantity.Text, out var quantity);
                if (find == null) return;
                if (find.Quantity == 0) {
                    MessageBox.Show("Không thể xoá sản phẩm này!");
                } else if (isValidQuantity && quantity < find.Quantity) {
                    MessageBox.Show("Số lượng xoá không hợp lệ!");
                } else {
                    var dialogResult = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) find.Quantity -= quantity;
                }

                context.SaveChanges();
                ClearInput();
                MessageBox.Show("Xoá thành công");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillCategoryBox(List<AccessoryCategory> categories) {
            CbxAccessoryCategory.DataSource = categories;
            CbxAccessoryCategory.DisplayMember = "CategoryName";
            CbxAccessoryCategory.ValueMember = "CategoryID";
            CbxAccessoryCategory.SelectedIndex = -1;
        }

        private void FillBrandBox(List<AccessoryBrand> brands) {
            CbxAccessoryBrand.DataSource = brands;
            CbxAccessoryBrand.DisplayMember = "BrandName";
            CbxAccessoryBrand.ValueMember = "BrandID";
            CbxAccessoryBrand.SelectedIndex = -1;
        }

        private void FillDataView(List<Accessory> accessories) {
            DgvAccessories.Rows.Clear();
            foreach (var accessory in accessories) {
                var index = DgvAccessories.Rows.Add();
                DgvAccessories.Rows[index].Cells[0].Value = accessory.AccessoryID;
                DgvAccessories.Rows[index].Cells[1].Value = accessory.AccessoryName;

            }
        }

        private int GetRowIndex(string id) {
            for (var i = 0; i < DgvAccessories.Rows.Count; i++)
                if (DgvAccessories.Rows[i].Cells[0].Value.ToString() == id)
                    return i;

            return -1;
        }

        private void ClearInput() {
            TbAccessoryID.Text = string.Empty;
            TbAccessoryName.Text = string.Empty;
            CbxAccessoryBrand.SelectedIndex = -1;
            CbxAccessoryCategory.SelectedIndex = -1;
            TbPrice.Text = string.Empty;
            TbQuantity.Text = string.Empty;
            TbSale.Text = string.Empty;
        }

        private void DgvAccessories_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}