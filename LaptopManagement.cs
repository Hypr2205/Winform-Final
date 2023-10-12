﻿using Final.Model.LaptopModel;
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
            CbxLaptopCategory.SelectedItem = null;
            try {
                var context = new LaptopContext();
                FillCategoryData(context.LaptopCategories.ToList());
                FillDataView(context.Laptops.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            try {
                LaptopContext context = new LaptopContext();
                var selectedRow = GetRowIndex(TblaptopID.Text);
                if (selectedRow == -1) { //Nếu không tồn tại
                    var laptop = new Laptop();
                    if (TblaptopID.Text != string.Empty) {
                        laptop.LaptopID = TblaptopID.Text;
                    } else {
                        MessageBox.Show("Mã laptop còn thiếu!");
                    }

                    if (TbLaptopName.Text != string.Empty) {
                        laptop.LaptopName = TbLaptopName.Text;
                    } else {
                        MessageBox.Show("Tên laptop còn thiếu");
                    }

                    if (TbPrice.Text != string.Empty && decimal.TryParse(TbPrice.Text, out var price)) {
                        laptop.SellPrice = price;
                    } else {
                        MessageBox.Show("Giá bán không hợp lệ hoặc còn thiếu");
                    }

                    if (int.TryParse(TbSale.Text, out var sale) && sale > 0) {
                        laptop.Sale = sale;
                    } else {
                        laptop.Sale = 0;
                    }

                    if (TbQuantity.Text != string.Empty && int.TryParse(TbQuantity.Text, out var quantity)) {
                        laptop.Quantity = quantity;
                    } else {
                        MessageBox.Show("Số lượng không hợp lệ hoặc còn thiếu");
                    }

                    laptop.CategoryID = ((LaptopCategory)CbxLaptopCategory.SelectedItem).CategoryID;

                    context.Laptops.Add(laptop);
                    context.SaveChanges();
                    ClearInput();
                    MessageBox.Show("Thêm thành công");
                    context = new LaptopContext();
                    FillDataView(context.Laptops.ToList());
                } else {
                    var find = context.Laptops.FirstOrDefault(l => l.LaptopID == TblaptopID.Text);
                    if (find == null) return;
                    find.LaptopID = TblaptopID.Text;
                    find.LaptopName = TbLaptopName.Text;
                    find.CategoryID = ((LaptopCategory)CbxLaptopCategory.SelectedItem).CategoryID;
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
                    FillDataView(context.Laptops.ToList());
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            try {
                var context = new LaptopContext();
                var find = context.Laptops.FirstOrDefault(a => a.LaptopID == TblaptopID.Text);
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

        private void DgvLaptops_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var lapId = DgvLaptops.Rows[e.RowIndex].Cells[0].Value.ToString();
            var context = new LaptopContext();
            var find = context.Laptops.FirstOrDefault(l => l.LaptopID == lapId);
            if (find == null) return;

            TblaptopID.Text = lapId;
            TbLaptopName.Text = find.LaptopName;
            TbPrice.Text = find.SellPrice.ToString();
            TbSale.Text = find.Sale != 0 ? find.Sale.ToString() : "";
            TbQuantity.Text = find.Quantity.ToString();
            CbxLaptopCategory.SelectedValue = find.CategoryID;
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            try {
                var context = new LaptopContext();
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

        private void FillCategoryData(List<LaptopCategory> categories) {
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

        private int GetRowIndex(string id) {
            for (var i = 0; i < DgvLaptops.Rows.Count; i++)
                if (DgvLaptops.Rows[i].Cells[0].Value.ToString() == id)
                    return i;
            return -1;
        }

        private void ClearInput() {
            TblaptopID.Text = string.Empty;
            TbLaptopName.Text = string.Empty;
            CbxLaptopCategory.SelectedIndex = -1;
            TbPrice.Text = string.Empty;
            TbSale.Text = string.Empty;
            TbQuantity.Text = string.Empty;
        }
    }
}