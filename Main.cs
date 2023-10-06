using System.Windows.Forms;

namespace Final {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e) {

        }

        private void BtnChooseLaptop_Click(object sender, System.EventArgs e) {
            BuyLaptop buyLaptopForm = new BuyLaptop();
            buyLaptopForm.FormClosed += BuyLaptop_FormClosed;
            Hide();
            buyLaptopForm.Show();
        }

        private void BuyLaptop_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnExit_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void BtnBuildPC_Click(object sender, System.EventArgs e) {
            BuildPC buildPCForm = new BuildPC();
            buildPCForm.FormClosed += BuildPCForm_FormClosed;
            Hide();
            buildPCForm.Show();
        }

        private void BuildPCForm_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnSellHistory_Click(object sender, System.EventArgs e) {
            OrderHistory orderHistoryForm = new OrderHistory();
            orderHistoryForm.FormClosed += OrderHistoryForm_FormClosed;
            Hide();
            orderHistoryForm.Show();
        }

        private void OrderHistoryForm_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnLaptopMangement_Click(object sender, System.EventArgs e) {
            LaptopManagement laptopManagement = new LaptopManagement();
            laptopManagement.FormClosed += LaptopManagement_FormClosed;
            laptopManagement.Show();
            Hide();
        }

        private void LaptopManagement_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private void BtnAccessoryManagement_Click(object sender, System.EventArgs e) {
            AccessoryManagement accessoryManagement = new AccessoryManagement();
            accessoryManagement.FormClosed += AccessoryManagement_FormClosed;
            accessoryManagement.Show();
            Hide();
        }

        private void AccessoryManagement_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }
    }
}
