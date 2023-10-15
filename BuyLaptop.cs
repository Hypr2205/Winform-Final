﻿using Final.Model.DTO;
using Final.Model.LaptopModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Final {
      public partial class BuyLaptop : Form {
            public BuyLaptop() {
                  InitializeComponent();
            }
            private void BuyLaptop_Load(object sender, System.EventArgs e) {
                  TbBuyQuantity_OnLeave(sender, e);
                  try {
                        LaptopContext context = new LaptopContext();
                        FillDataView(context.Laptops.ToList());
                  } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                  }
            }
            private void BtnCancel_Click(object sender, EventArgs e) {
                  ClearFilter();
            }

            private void FillDataView(List<Laptop> laptops) {
                  DgvLaptops.Rows.Clear();
                  foreach (var lap in laptops) {
                        var index = DgvLaptops.Rows.Add();
                        DgvLaptops.Rows[index].Cells[0].Value = lap.LaptopID;
                        DgvLaptops.Rows[index].Cells[1].Value = lap.LaptopName;
                        DgvLaptops.Rows[index].Cells[2].Value = lap.LaptopCategory.CategoryName;
                        DgvLaptops.Rows[index].Cells[3].Value = lap.SellPrice.ToString();
                        if (lap.Sale != 0) {
                              DgvLaptops.Rows[index].Cells[4].Value = lap.Sale;
                        } else {
                              DgvLaptops.Rows[index].Cells[4].Value = "";
                        }
                        DgvLaptops.Rows[index].Cells[5].Value = lap.Quantity.ToString();
                  }
            }

            private void DgvLaptops_CellContentClick(object sender, DataGridViewCellEventArgs e) {
                  var row = DgvLaptops.Rows[e.RowIndex];
                  TbLaptopID.Text = row.Cells[0].Value.ToString();
                  TbLaptopName.Text = row.Cells[1].Value.ToString();
                  TbLaptopCategory.Text = row.Cells[2].Value.ToString();
                  TbLaptopPrice.Text = row.Cells[3].Value.ToString();
                  TbSale.Text = row.Cells[4].Value.ToString();

            }
/*            private void RefreshTextBox() {
                  if (TbLaptopID.Text != "") {
                        TbLaptopID.Text = "";
                        TbLaptopName.Text = "";
                        TbLaptopPrice.Text = "";
                        TbLaptopCategory.Text = "";
                        TbSale.Text = "";
                  }
            }*/

            private void BtnFilter_Click(object sender, EventArgs e) {
                  var context = new LaptopContext();

                  var idFilter = string.IsNullOrEmpty(TbIdFilter.Text) ? null : TbIdFilter.Text;
                  var nameFilter = string.IsNullOrEmpty(TbNameFilter.Text) ? null : TbNameFilter.Text;
                  var selectedCategory = CbxCategoryFilter.SelectedItem as LaptopCategory;

                  var findById = idFilter != null ? context.Laptops.Where(l => l.LaptopID.Contains(idFilter)) : null;
                  var findByName = nameFilter != null ? context.Laptops.Where(l => l.LaptopName.Contains(nameFilter)) : null;
                  var findByCategory = CbxCategoryFilter.SelectedIndex != -1 ? context.Laptops.Where(l => l.CategoryID == selectedCategory.CategoryID) : null;
                  var findIfSale = ChkIsSale.Checked ? context.Laptops.Where(l => l.Sale != 0) : null;

                  var queryList = new List<IQueryable<Laptop>>();
                  if (findById != null) queryList.Add(findById);
                  if (findByName != null) queryList.Add(findByName);
                  if (findByCategory != null) queryList.Add(findByCategory);
                  if (findIfSale != null) queryList.Add(findIfSale);

                  var result = queryList.Any() ? queryList.Aggregate((a, b) => a.Union(b)).ToList() : new List<Laptop>();
                  if (result.Any()) {
                        FillDataView(result);
                        ClearFilter();
                  } else {
                        MessageBox.Show("Không tìm thấy sản phẩm phù hợp");
                        ClearFilter();
                  }
            }

            private void BtnAddToCart_Click(object sender, EventArgs e) {
                  LaptopContext dbContext = new LaptopContext();
                  Laptop setFlag = dbContext.Laptops.FirstOrDefault(l => l.LaptopID == TbLaptopID.Text);
                  List<LaptopCartDto> listLaptopCart = CartList.laptopCart;
                  LaptopCartDto item = new LaptopCartDto();
                  item.LaptopID = setFlag.LaptopID;
                  item.LaptopName = setFlag.LaptopName;
                  item.CategoryID = setFlag.CategoryID;
                  if(setFlag.Sale != 0) {
                        item.Sale = setFlag.Sale;
                  }
                  item.SellPrice = setFlag.SellPrice; 
                  if(int.Parse(TbBuyQuantity.Text) > setFlag.Quantity) {
                        MessageBox.Show("So luong lon hon hang ton kho");
                  } else if(item.Quantity == 0) {
                        MessageBox.Show("Het Hang");
                  } else {
                        item.Quantity = int.Parse(TbBuyQuantity.Text);
                  }
                  item.BuyPrice = (int)(setFlag.SellPrice - setFlag.SellPrice * (setFlag.Sale / 100)) * item.Quantity;
                  if(setFlag.Quantity == 0) {
                        MessageBox.Show("Het hang nen khong the them vao gio hang");
                  } else {
                        LaptopCartDto checkExitst = listLaptopCart.FirstOrDefault(l => l.LaptopID == item.LaptopID);
                        if (listLaptopCart.Contains(checkExitst)) {
                              checkExitst.BuyQuantity += int.Parse(TbBuyQuantity.Text);
                              setFlag.Quantity -= int.Parse(TbBuyQuantity.Text);
                              dbContext.SaveChanges();
                              FillDataView(dbContext.Laptops.ToList());
                        } else {
                              listLaptopCart.Add(item);
                              setFlag.Quantity -= item.BuyQuantity;
                              dbContext.SaveChanges();
                              FillDataView(dbContext.Laptops.ToList());
                        }
                  }

            }

            private void TbBuyQuantity_Enter(object sender, EventArgs e) {
                  if (TbBuyQuantity.Text == "Số lượng mua") {
                        TbBuyQuantity.Text = string.Empty;
                        TbBuyQuantity.ForeColor = Color.Black;
                  }
            }

            private void TbBuyQuantity_OnLeave(object sender, EventArgs e) {
                  if (TbBuyQuantity.Text == "") {
                        TbBuyQuantity.Text = "Số lượng mua";
                        TbBuyQuantity.ForeColor = Color.Silver;
                  }
            }
            private void ClearFilter() {
                  TbIdFilter.Text = string.Empty;
                  TbNameFilter.Text = string.Empty;
                  CbxCategoryFilter.SelectedIndex = -1;
            }

            private void BtnRefresh_Click(object sender, EventArgs e) {
                  BuyLaptop_Load(sender, e);
            }

            private void Cart_Click(object sender, EventArgs e) {
                  LaptopCart cart = new LaptopCart();
                  cart.Show();
                  cart.FormClosed += Cart_FormClosed;
                  Hide();
            }

            private void Cart_FormClosed(object sender, FormClosedEventArgs e) {
                  Show();
            }
      }
}
