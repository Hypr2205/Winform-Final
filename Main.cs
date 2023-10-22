using Final.Model.LoginModel;
using System;
using System.Windows.Forms;

namespace Final {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            switch (Login.model.Role) {
                case UserRole.EMPLOYEE:
                    BtnAccessoryManagement.Enabled = false;
                    BtnLaptopMangement.Enabled = false;
                    BtnSellHistory.Enabled = false;
                    break;
                case UserRole.ADMIN:
                    BtnAccessoryManagement.Enabled = true;
                    BtnLaptopMangement.Enabled = true;
                    BtnSellHistory.Enabled = true;
                    break;
            }
        }

        private void BtnChooseLaptop_Click(object sender, EventArgs e) {
            var buyLaptopForm = new BuyLaptop();
            buyLaptopForm.FormClosed += BuyLaptop_FormClosed;
            Hide();
            buyLaptopForm.Show();
        }

        private void BuyLaptop_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            Close();
        }


        private void BtnSellHistory_Click(object sender, EventArgs e) {
            var orderHistoryForm = new OrderHistory();
            orderHistoryForm.FormClosed += OrderHistoryForm_FormClosed;
            Hide();
            orderHistoryForm.Show();
        }

        private void OrderHistoryForm_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnLaptopMangement_Click(object sender, EventArgs e) {
            var laptopManagement = new LaptopManagement();
            laptopManagement.FormClosed += LaptopManagement_FormClosed;
            laptopManagement.Show();
            Hide();
        }

        private void LaptopManagement_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnAccessoryManagement_Click(object sender, EventArgs e) {
            AccessoryManagement accessoryManagement = new AccessoryManagement();
            accessoryManagement.FormClosed += AccessoryManagement_FormClosed;
            Hide();
            accessoryManagement.Show();
        }

        private void AccessoryManagement_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnBuyAccessory_Click(object sender, EventArgs e) {
            var buyAccessoryForm = new BuyAccessory();
            buyAccessoryForm.FormClosed += BuyAccessory_FormClosed;
            Hide();
            buyAccessoryForm.Show();
        }

        private void BuyAccessory_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }
    }
}