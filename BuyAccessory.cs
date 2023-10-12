using Final.Model.AccessoryModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

        private void BtnAddToCart_Click(object sender, EventArgs e) { }

        private void DgvAccessories_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var row = DgvAccessories.Rows[e.RowIndex];
            TbAccessoryID.Text = row.Cells[0].Value.ToString();
            TbAccessoryName.Text = row.Cells[1].Value.ToString();
            TbCategoryName.Text = row.Cells[2].Value.ToString();
            TbBrandName.Text = row.Cells[3].Value.ToString();
            TbPrice.Text = row.Cells[4].Value.ToString();
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

        private void BtnFilter_Click(object sender, EventArgs e) {
            var context = new AccessoryContext();

            var idFilter = string.IsNullOrEmpty(TbAccessoryID.Text) ? null : TbAccessoryID.Text;
            var nameFilter = string.IsNullOrEmpty(TbAccessoryName.Text) ? null : TbAccessoryName.Text;
            var selectedCategory = CbxCategoryFilter.SelectedItem as AccessoryCategory;
            var selectedBrand = CbxBrandFilter.SelectedItem as AccessoryBrand;

            var findById = idFilter != null ? context.Accessories.Where(a => a.AccessoryID.Contains(idFilter)) : null;
            var findByName = nameFilter != null ? context.Accessories.Where(a => a.AccessoryName.Contains(nameFilter)) : null;
            var findByCategory = CbxCategoryFilter.SelectedIndex != -1 ? context.Accessories.Where(a => a.CategoryID == selectedCategory.CategoryID) : null;
            var findByBrand = CbxBrandFilter.SelectedIndex != -1 ? context.Accessories.Where(a => a.BrandID == selectedBrand.BrandID) : null;
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
                ClearTextbox();
            } else {
                MessageBox.Show(@"Không tìm thấy sản phẩm phù hợp");
                ClearTextbox();
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

        private void ClearTextbox() {
            TbIdFilter.Text = string.Empty;
            TbNameFillter.Text = string.Empty;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            ClearTextbox();
            CbxBrandFilter.SelectedIndex = -1;
            CbxCategoryFilter.SelectedIndex = -1;
            ChkInStock.Checked = false;
            ChkIsSale.Checked = false;
        }
    }
}