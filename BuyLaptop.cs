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

        private void FilterAction_Click(object sender, EventArgs e) {
            FilterContainer.Visible = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            FilterContainer.Visible = false;
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

        }

        private void BtnFilter_Click(object sender, EventArgs e) {

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
    }
}
