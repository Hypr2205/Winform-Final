using Final.Model.BuildPCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class BuildPC : Form {
        public BuildPC() {
            InitializeComponent();
        }

        private void BuildPC_Load(object sender, System.EventArgs e) {
            try {
                BuildPcDBContext context = new BuildPcDBContext();
                FillDataView(context.Accessory.ToList());
                FillCategoryBox(context.AccessoryCategory.ToList());
                FillBrandBox(context.AccessoryBrand.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvAccessory_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var row = DgvAccessory.Rows[e.RowIndex];
            TbAccessoryName.Text = row.Cells[1].Value.ToString();
            TbAccessoryCategory.Text = row.Cells[2].Value.ToString();
            TbAccessoryBrand.Text = row.Cells[3].Value.ToString();
            TbAccessoryPrice.Text = row.Cells[4].ToString();
            TbQuantity.Text = row.Cells[5].ToString();
            TbSale.Text = row.Cells[6].ToString();
        }

        private void CartActions_Click(object sender, System.EventArgs e) {

        }

        private void BtnFilter_Click(object sender, System.EventArgs e) {

        }

        private void BtnAddToCart_Click(object sender, System.EventArgs e) {
            //Cái này để t
        }

        private void FillCategoryBox(List<AccessoryCategory> categories) {
            CbxCategory.DataSource = categories;
            CbxCategory.DisplayMember = "CategoryName";
            CbxCategory.ValueMember = "CategoryID";
            CbxCategory.SelectedIndex = -1;
        }

        private void FillBrandBox(List<AccessoryBrand> brands) {
            CbxBrand.DataSource = brands;
            CbxBrand.DisplayMember = "BrandName";
            CbxBrand.ValueMember = "BrandID";
            CbxBrand.SelectedIndex = -1;
        }

        private void FillDataView(List<Accessory> accessories) {
            DgvAccessory.Rows.Clear();
            foreach (var item in accessories) {
                var index = DgvAccessory.Rows.Add();
                DgvAccessory.Rows[index].Cells[0].Value = item.AccessoryID;
                DgvAccessory.Rows[index].Cells[1].Value = item.AccessoryName;
                DgvAccessory.Rows[index].Cells[2].Value = item.AccessoryCategory.CategoryName;
                DgvAccessory.Rows[index].Cells[3].Value = item.AccessoryBrand.BrandName;
                DgvAccessory.Rows[index].Cells[4].Value = item.SalePrice;
                DgvAccessory.Rows[index].Cells[5].Value = item.Quantity;
                DgvAccessory.Rows[index].Cells[6].Value = item.Sale;
            }
        }
    }
}