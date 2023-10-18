using Final.Model.AccessoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
      public partial class AccessoryManagement : Form {
            public AccessoryManagement() {
                  InitializeComponent();
            }

            private void AccessoryManagement_Load(object sender, EventArgs e) {
                  try {
                        AccessoryContext context = new AccessoryContext();
                        FillBrandBox(context.AccessoryBrands.ToList());
                        FillCategoryBox(context.AccessoryCategories.ToList());
                        FillDataView(context.Accessories.ToList());
                  } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                  }
            }

            private void BtnSearch_Click(object sender, EventArgs e) {
                  var context = new AccessoryContext();

                  var idFilter = string.IsNullOrEmpty(TbIdFilter.Text) ? null : TbIdFilter.Text;
                  var nameFilter = string.IsNullOrEmpty(TbNameFilter.Text) ? null : TbNameFilter.Text;
                  var selectedCategory = CbxCategoryFilter.SelectedItem as AccessoryCategory;
                  var selectedBrand = CbxBrandFilter.SelectedItem as AccessoryBrand;

                  var findById = idFilter != null ? context.Accessories.Where(a => a.AccessoryID.Contains(idFilter)) : null;
                  var findByName = nameFilter != null ? context.Accessories.Where(a => a.AccessoryName.Contains(nameFilter)) : null;
                  var findByCategory = CbxCategoryFilter.SelectedIndex != -1 ? context.Accessories.Where(a => a.CategoryID == selectedCategory.CategoryID) : null;
                  var findByBrand = CbxBrandFilter.SelectedIndex != -1 ? context.Accessories.Where(a => a.BrandID == selectedBrand.BrandID) : null;
                  var findInStock = ChkIsInStock.Checked ? context.Accessories.Where(a => a.Quantity > 0) : null;
                  var findIfSale = ChkIsSale.Checked ? context.Accessories.Where(a => a.Sale > 0) : null;

                  var queryList = new List<IQueryable<Accessory>>();
                  if (findById != null) queryList.Add(findById);

                  if (findByName != null) queryList.Add(findByName);

                  if (findByCategory != null) queryList.Add(findByCategory);

                  if (findByBrand != null) queryList.Add(findByBrand);

                  if (findInStock != null) queryList.Add(findInStock);

                  if (findIfSale != null) queryList.Add(findIfSale);

                  var result = queryList.Any() ? queryList.Aggregate((a, b) => a.Union(b)).ToList() : new List<Accessory>();
                  if (result.Any()) {
                        FillDataView(result);
                        ClearFilter();
                  } else {
                        MessageBox.Show(@"Không tìm thấy sản phẩm phù hợp");
                        ClearFilter();
                  }
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
                              context = new AccessoryContext();
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
                              var dialogResult = MessageBox.Show("Xoá sản phẩm?", "YES/NO", MessageBoxButtons.YesNo);
                              if (dialogResult == DialogResult.Yes) {
                                    find.Quantity -= quantity;
                                    MessageBox.Show("Xoá thành công");
                              } 
                        }
                        context.SaveChanges();
                        ClearInput();
                        
                  } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                  }
            }

            private void FillCategoryBox(List<AccessoryCategory> categories) {
                  CbxAccessoryCategory.DataSource = categories;
                  CbxAccessoryCategory.DisplayMember = "CategoryName";
                  CbxAccessoryCategory.ValueMember = "CategoryID";
                  CbxAccessoryCategory.SelectedIndex = -1;

                  CbxCategoryFilter.DataSource = categories;
                  CbxCategoryFilter.DisplayMember = "CategoryName";
                  CbxCategoryFilter.ValueMember = "CategoryID";
                  CbxCategoryFilter.SelectedIndex = -1;
            }

            private void FillBrandBox(List<AccessoryBrand> brands) {
                  CbxAccessoryBrand.DataSource = brands;
                  CbxAccessoryBrand.DisplayMember = "BrandName";
                  CbxAccessoryBrand.ValueMember = "BrandID";
                  CbxAccessoryBrand.SelectedIndex = -1;

                  CbxBrandFilter.DataSource = brands;
                  CbxBrandFilter.DisplayMember = "BrandName";
                  CbxBrandFilter.ValueMember = "BrandID";
                  CbxBrandFilter.SelectedIndex = -1;
            }

            private void FillDataView(List<Accessory> accessories) {
                  DgvAccessories.Rows.Clear();
                  foreach (var accessory in accessories) {
                        var index = DgvAccessories.Rows.Add();
                        DgvAccessories.Rows[index].Cells[0].Value = accessory.AccessoryID;
                        DgvAccessories.Rows[index].Cells[1].Value = accessory.AccessoryName;
                        DgvAccessories.Rows[index].Cells[2].Value = accessory.AccessoryBrand.BrandName;
                        DgvAccessories.Rows[index].Cells[3].Value = accessory.AccessoryCategory.CategoryName;
                        DgvAccessories.Rows[index].Cells[4].Value = accessory.SellPrice;
                        DgvAccessories.Rows[index].Cells[5].Value = accessory.Sale;
                        DgvAccessories.Rows[index].Cells[6].Value = accessory.Quantity;
                  }
            }

            private int GetRowIndex(string id) {
                  for (var i = 0; i < DgvAccessories.Rows.Count; i++)
                        if (DgvAccessories.Rows[i].Cells[0].Value.ToString() == id) {
                              return i;
                        }
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

            private void ClearFilter() {
                  TbIdFilter.Text = string.Empty;
                  TbNameFilter.Text = string.Empty;
                  CbxBrandFilter.SelectedIndex = -1;
                  CbxCategoryFilter.SelectedIndex = -1;
                  ChkIsInStock.Checked = false;
                  ChkIsSale.Checked = false;
            }

            private void BtnCancel_Click(object sender, EventArgs e) {
                  ClearFilter();
            }

            private void DgvAccessories_CellContentClick(object sender, DataGridViewCellEventArgs e) {
                  var row = DgvAccessories.Rows[e.RowIndex];
                  TbAccessoryID.Text = row.Cells[0].Value.ToString();
                  TbAccessoryName.Text = row.Cells[1].Value.ToString();
                  CbxAccessoryBrand.Text = row.Cells[2].Value.ToString();
                  CbxAccessoryCategory.Text = row.Cells[3].Value.ToString();
                  TbPrice.Text = row.Cells[4].Value.ToString();
                  TbSale.Text = row.Cells[5].Value.ToString();
                  TbQuantity.Text = row.Cells[6].Value.ToString();
            }

            private void AccessoryBrandManagement_Click(object sender, EventArgs e) {
                  AccessoryBrandManagementForm accessoryBrandManagementForm = new AccessoryBrandManagementForm();
                  accessoryBrandManagementForm.FormClosed += AccessoryBrandManagementForm_FormClosed;
                  accessoryBrandManagementForm.Show();
                  Hide();
            }

            private void AccessoryBrandManagementForm_FormClosed(object sender, FormClosedEventArgs e) {
                  Show();
            }

            private void AccessoryCategoryManagement_Click(object sender, EventArgs e) {
                  AccessoryCategoryManagementForm accessoryCategoryManagementForm = new AccessoryCategoryManagementForm();
                  accessoryCategoryManagementForm.FormClosed += AccessoryCategoryManagementForm_FormClosed;
                  Hide();
                  accessoryCategoryManagementForm.Show();
            }

            private void AccessoryCategoryManagementForm_FormClosed(object sender, FormClosedEventArgs e) {
                  Show();
            }

            private void button1_Click(object sender, EventArgs e) {
                  AccessoryManagement_Load(sender, e);
            }
      }
}
