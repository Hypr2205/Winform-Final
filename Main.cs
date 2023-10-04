using System;
using System.Globalization;
using System.Windows.Forms;

namespace Final {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e) {
            LoadTime();
        }

        private void LoadTime() {
            CultureInfo culture = new CultureInfo("vi-VN");
            DateTime time = DateTime.Now;
            LbTime.Text = culture.DateTimeFormat.GetDayName(time.DayOfWeek) + ", " + time.Day + " " + culture.DateTimeFormat.GetMonthName(time.Month) + " " + time.Year;
        }

        private void BtnPrevious_Click(object sender, EventArgs e) {

        }

        private void BtnNext_Click(object sender, EventArgs e) {

        }

    }
}
