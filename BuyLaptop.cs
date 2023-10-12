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

    }
}
