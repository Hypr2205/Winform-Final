using Final.Model.LaptopModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class BuyLaptop : Form {
        public BuyLaptop() {
            InitializeComponent();
        }

        private void BuyLaptop_Load(object sender, System.EventArgs e) {
            LoadTime();
            FilterContainer.Visible = false;
            try {
                LaptopDBContext context = new LaptopDBContext();
                FillDataView(context.Laptop.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTime() {
            DateTime time = DateTime.Now;
            CultureInfo culture = new CultureInfo("vi-VN");
            LbTime.Text = culture.DateTimeFormat.GetDayName(time.DayOfWeek) + ", " +
                            time.Day + " " +
                            culture.DateTimeFormat.GetMonthName(time.Month) + " " +
                            time.Year;
        }

        private void FilterAction_Click(object sender, EventArgs e) {
            FilterContainer.Visible = true;
            try {
                LaptopDBContext context = new LaptopDBContext();
                FillLaptopCategoryFilter(context.LaptopCategory.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            FilterContainer.Visible = false;
        }

        private void FillLaptopCategoryFilter(List<LaptopCategory> categories) {
            CbxLaptopCategoryFilter.DataSource = categories;
            CbxLaptopCategoryFilter.DisplayMember = "CategoryName";
            CbxLaptopCategoryFilter.ValueMember = "CategoryID";
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
            if (int.Parse(row.Cells[4].Value.ToString()) != 0) {
                TbSalePercent.Text = row.Cells[4].Value.ToString();
            } else {
                TbSalePercent.Text = "Không có khuyến mãi";
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e) {
            LaptopDBContext context = new LaptopDBContext();

            //Lọc theo tên hãng 
            var filterByCategoryName = context.Laptop.Where(l => l.LaptopCategory.CategoryName == (CbxLaptopCategoryFilter.SelectedItem as LaptopCategory).CategoryName).ToList();
            if (filterByCategoryName != null) {
                FillDataView(filterByCategoryName);
            }

            //Lọc theo tên máy hoặc mã máy
            if (TbLaptopNameFilter.Text != "" || TbLaptopIdFilter.Text != "") {
                FillDataView(context.Laptop.Where(l => l.LaptopName.Contains(TbLaptopNameFilter.Text) || l.LaptopID.Contains(TbLaptopIdFilter.Text)).ToList());
            }

            //Lọc nếu chọn ô xem khuyến mãi
            if (CbIsSale.Checked) {
                FillDataView(context.Laptop.Where(l => l.Sale != 0).ToList());
            }

            //Lọc theo khoảng giá
            var selectedPriceRange = CbxPriceRange.SelectedIndex;
            if (selectedPriceRange == 0) {
                FillDataView(context.Laptop.Where(l => l.SellPrice < 15_000_000).ToList());
            } else if (selectedPriceRange == 1) {
                FillDataView(context.Laptop.Where(l => l.SellPrice >= 15_000_000 && l.SellPrice < 20_000_000).ToList());
            } else if (selectedPriceRange == 2) {
                FillDataView(context.Laptop.Where(l => l.SellPrice >= 20_000_000 && l.SellPrice < 30_000_000).ToList());
            } else if (selectedPriceRange == 3) {
                FillDataView(context.Laptop.Where(l => l.SellPrice > 30_000_000).ToList());
            }
        }
    }
}
