using Final.Model.AccessoryModel;
using Final.Model.DTO;
using Microsoft.Reporting.WinForms;
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

        private void AccessoryCart_Load(object sender, EventArgs e) {
            reportViewer1.Visible = false;
            try {
                FillDataView(CartList.accessoryCart);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                // Chuyển đổi trạng thái của ô checkbox
                if (DgvAccessoryCart.Rows[e.RowIndex].Cells[6] is DataGridViewCheckBoxCell cell)
                    cell.Value = cell.Value == null || (bool)cell.Value == false;
        }

        private void BtnBuy_Click(object sender, EventArgs e) {
            var invoice = new AccessoryInvoice();
            invoice.InvoiceID = GenerateRandomString(6);
            invoice.Note = TbNote.Text;
            invoice.OrderDate = DateTime.Now;
            var selectedDate = DtpDeliveryDate.Value;
            if (selectedDate < invoice.OrderDate) {
                MessageBox.Show(@"Thời gian được chọn nhỏ hơn ngày hiện tại");
            } else if (selectedDate >= invoice.OrderDate) {
                invoice.DeliveryDate = selectedDate;
            }

            var context = new AccessoryContext();

            for (var i = 0; i < DgvAccessoryCart.Rows.Count; i++) {
                var isChecked = (bool)DgvAccessoryCart.Rows[i].Cells[6].Value;
                if (isChecked) {
                    var item = CartList.accessoryCart.FirstOrDefault(a =>
                        a.AccessoryID == DgvAccessoryCart.Rows[i].Cells[0].Value.ToString());
                    if (item == null) continue;
                    var order = new AccessoryOrder {
                        InvoiceID = invoice.InvoiceID,
                        OrderID = item.OrderID,
                        AccessoryID = item.AccessoryID,
                        AccessoryName = item.AccessoryName,
                        BrandName = item.BrandName,
                        CategoryName = item.CategoryName,
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
            context.SaveChanges();
            ShowReport(context, invoice.InvoiceID);
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e) {
            Show();
        }

        private string GenerateRandomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var sb = new StringBuilder();
            var random = new Random();

            for (var i = 0; i < length; i++) {
                var index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void ShowReport(AccessoryContext context, string id) {
            reportViewer1.Visible = true;
            var invoice = context.AccessoryInvoices.FirstOrDefault(i => i.InvoiceID == id);
            var orders = context.AccessoryOrders.Where(o => o.InvoiceID == id).ToList();
            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("InvoiceID", invoice.InvoiceID);
            param[1] = new ReportParameter("OrderDate", string.Format("Ngày mua: " + invoice.OrderDate.ToString("dd/MM/yyyy")));

            reportViewer1.LocalReport.ReportPath = "./Model/ReportModel/AccessoryReport.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            var dataSource = new ReportDataSource("AccessoryDataSet", orders);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();
        }
    }
}
