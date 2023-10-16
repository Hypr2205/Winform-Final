using Final.Model.AccessoryModel;
using Final.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final {
    public partial class AccessoryCart : Form {
        public AccessoryCart() {
            InitializeComponent();
        }

        private void AccessoryCart_Load(object sender, System.EventArgs e) {
            try {
                FillDataView(CartList.accessoryCart);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDataView(List<AccessoryCartDto> accessories) {
            DgvAccessoryCart.Rows.Clear();
            foreach (var accessory in accessories) {
                var index = DgvAccessoryCart.Rows.Add();
                DgvAccessoryCart.Rows[index].Cells[0].Value = accessory.AccessoryID;
                DgvAccessoryCart.Rows[index].Cells[1].Value = accessory.AccessoryName;
                DgvAccessoryCart.Rows[index].Cells[2].Value = accessory.SellPrice;
                DgvAccessoryCart.Rows[index].Cells[3].Value = accessory.Sale;
                DgvAccessoryCart.Rows[index].Cells[4].Value = accessory.BuyQuantity;
                DgvAccessoryCart.Rows[index].Cells[5].Value = accessory.BuyPrice;
            }
        }

        private void DgvAccessoryCart_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) {
                // Chuyển đổi trạng thái của ô checkbox
                if (DgvAccessoryCart.Rows[e.RowIndex].Cells[6] is DataGridViewCheckBoxCell cell) {
                    cell.Value = cell.Value == null || (bool)cell.Value == false;
                }
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e) {
            AccessoryInvoice invoice = new AccessoryInvoice();
            invoice.InvoiceID = GenerateRandomString(6);
            invoice.Note = TbNote.Text;
            invoice.OrderDate = DateTime.Now;
            var selectedDate = DtpDeliveryDate.Value;
            if (selectedDate < invoice.OrderDate) {
                MessageBox.Show(@"Thời gian được chọn nhỏ hơn ngày hiện tại");
            } else {
                invoice.DeliveryDate = selectedDate;
            }
            var context = new AccessoryContext();

            for (var i = 0; i < DgvAccessoryCart.Rows.Count; i++) {
                bool isChecked = (bool)DgvAccessoryCart.Rows[i].Cells[6].Value;
                if (isChecked) {
                    var item = CartList.accessoryCart.FirstOrDefault(a => a.AccessoryID == DgvAccessoryCart.Rows[i].Cells[0].Value.ToString());
                    if (item == null) continue;
                    var order = new AccessoryOrder {
                        InvoiceID = invoice.InvoiceID,
                        OrderID = item.OrderID,
                        AccessoryID = item.AccessoryID,
                        AccessoryName = item.AccessoryName,
                        BrandID = item.BrandID,
                        CategoryID = item.CategoryID,
                        SellPrice = item.SellPrice,
                        BuyPrice = item.BuyPrice,
                        BuyQuantity = item.BuyQuantity,
                        Sale = item.Sale
                    };
                    context.AccessoryOrders.Add(order);
                    CartList.accessoryCart.Remove(item);
                }
            }
            context.AccessoryInvoices.Add(invoice);
        }

        private static string GenerateRandomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++) {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();
        }
    }
}
