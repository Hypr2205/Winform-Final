using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Final.Model.AccessoryModel;
using Final.Model.DTO;

namespace Final {
    public partial class BuyAccessory : Form {
        public BuyAccessory() {
            InitializeComponent();
        }

        private void BuyAccessory_Load(object sender, EventArgs e) {
            TbBuyQuantity_OnLeave(sender, e);
            try {
                var context = new AccessoryContext();
                FillDataView(context.Accessories.ToList());
                FillBrandFilterBox(context.AccessoryBrands.ToList());
                FillCategoryFilterBox(context.AccessoryCategories.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e) {
            var context = new AccessoryContext();
            var find = context.Accessories.FirstOrDefault(a => a.AccessoryID == TbAccessoryID.Text);
            var cartList = CartList.accessoryCart;

            if (find == null) return;
            var cartDto = new AccessoryCartDto {
                AccessoryID = find.AccessoryID,
                AccessoryName = find.AccessoryName,
                BrandID = find.BrandID,
                CategoryID = find.CategoryID,
                SellPrice = find.SellPrice,
                Sale = find.Sale
            };

            if (int.Parse(TbBuyQuantity.Text) > find.Quantity) {
                MessageBox.Show(@"Giá trị không hợp lệ");
            } else if (find.Quantity == 0) {
                MessageBox.Show(@"Hết hàng");
                find.Quantity = 0;
            } else {
                cartDto.BuyQuantity = int.Parse(TbBuyQuantity.Text);
            }

            if (find.Sale != 0) cartDto.Sale = find.Sale;

            cartDto.SellPrice = find.SellPrice;
            cartDto.BuyPrice = (cartDto.SellPrice - cartDto.SellPrice * cartDto.Sale) * cartDto.BuyQuantity;

            var exists = cartList.FirstOrDefault(i => i.AccessoryID.Equals(find.AccessoryID));
            if (cartList.Contains(exists)) {
                if (exists != null) exists.BuyQuantity += int.Parse(TbBuyQuantity.Text);
                find.Quantity -= int.Parse(TbBuyQuantity.Text);
                context.SaveChanges();
                FillDataView(context.Accessories.ToList());
            } else {
                cartList.Add(cartDto);
                find.Quantity -= cartDto.BuyQuantity;
                context.SaveChanges();
                FillDataView(context.Accessories.ToList());
            }
        }

        private void DgvAccessories_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var row = DgvAccessories.Rows[e.RowIndex];
            TbAccessoryID.Text = row.Cells[0].Value.ToString();
            TbAccessoryName.Text = row.Cells[1].Value.ToString();
            TbCategoryName.Text = row.Cells[2].Value.ToString();
            TbBrandName.Text = row.Cells[3].Value.ToString();
            TbPrice.Text = row.Cells[4].Value.ToString();
        }

        private void TbBuyQuantity_Enter(object sender, EventArgs e) {
            if (TbBuyQuantity.Text == @"Số lượng mua") {
                TbBuyQuantity.Text = string.Empty;
                TbBuyQuantity.ForeColor = Color.Black;
            }
        }

        private void TbBuyQuantity_OnLeave(object sender, EventArgs e) {
            if (TbBuyQuantity.Text == "") {
                TbBuyQuantity.Text = @"Số lượng mua";
                TbBuyQuantity.ForeColor = Color.Silver;
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e) {
            var context = new AccessoryContext();

            var idFilter = string.IsNullOrEmpty(TbAccessoryID.Text) ? null : TbAccessoryID.Text;
            var nameFilter = string.IsNullOrEmpty(TbAccessoryName.Text) ? null : TbAccessoryName.Text;
            var selectedCategory = CbxCategoryFilter.SelectedItem as AccessoryCategory;
            var selectedBrand = CbxBrandFilter.SelectedItem as AccessoryBrand;

            var findById = idFilter != null ? context.Accessories.Where(a => a.AccessoryID.Contains(idFilter)) : null;
            var findByName = nameFilter != null
                ? context.Accessories.Where(a => a.AccessoryName.Contains(nameFilter))
                : null;
            var findByCategory = CbxCategoryFilter.SelectedIndex != -1
                ? context.Accessories.Where(a => a.CategoryID == selectedCategory.CategoryID)
                : null;
            var findByBrand = CbxBrandFilter.SelectedIndex != -1
                ? context.Accessories.Where(a => a.BrandID == selectedBrand.BrandID)
                : null;
            var findInStock = ChkInStock.Checked ? context.Accessories.Where(a => a.Quantity > 0) : null;
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
                ClearTextBox();
            } else {
                MessageBox.Show(@"Không tìm thấy sản phẩm phù hợp");
                ClearTextBox();
            }
        }

        private void FillDataView(List<Accessory> accessories) {
            DgvAccessories.Rows.Clear();
            foreach (var accessory in accessories) {
                var index = DgvAccessories.Rows.Add();
                DgvAccessories.Rows[index].Cells[0].Value = accessory.AccessoryID;
                DgvAccessories.Rows[index].Cells[1].Value = accessory.AccessoryName;
                DgvAccessories.Rows[index].Cells[2].Value = accessory.AccessoryCategory.CategoryName;
                DgvAccessories.Rows[index].Cells[3].Value = accessory.AccessoryBrand.BrandName;
                DgvAccessories.Rows[index].Cells[4].Value = accessory.SellPrice;
                DgvAccessories.Rows[index].Cells[5].Value = accessory.Sale;
                DgvAccessories.Rows[index].Cells[6].Value = accessory.Quantity;
            }
        }

        private void FillCategoryFilterBox(List<AccessoryCategory> categories) {
            CbxCategoryFilter.DataSource = categories;
            CbxCategoryFilter.DisplayMember = "CategoryName";
            CbxCategoryFilter.ValueMember = "CategoryID";
            CbxCategoryFilter.SelectedIndex = -1;
        }

        private void FillBrandFilterBox(List<AccessoryBrand> brands) {
            CbxBrandFilter.DataSource = brands;
            CbxBrandFilter.DisplayMember = "BrandName";
            CbxBrandFilter.ValueMember = "BrandID";
            CbxBrandFilter.SelectedIndex = -1;
        }

        private void ClearTextBox() {
            TbIdFilter.Text = string.Empty;
            TbNameFillter.Text = string.Empty;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            ClearTextBox();
            CbxBrandFilter.SelectedIndex = -1;
            CbxCategoryFilter.SelectedIndex = -1;
            ChkInStock.Checked = false;
            ChkIsSale.Checked = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            BuyAccessory_Load(sender, e);
        }

        private void Cart_Click(object sender, EventArgs e) {
            var cart = new AccessoryCart();
            cart.Show();
            cart.FormClosed += Cart_FormClosed;
            Hide();
        }

        private void Cart_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }
    }
}