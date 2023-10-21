using Final.Model.DTO;
using Final.Model.LaptopModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final {
    public partial class LaptopCart : Form {
        public LaptopCart() {
            InitializeComponent();
        }

        private void LaptopCart_Load(object sender, EventArgs e) {
            reportViewer1.Visible = false;
            try {
                FillDataView(CartList.laptopCart);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void FillDataView(List<LaptopCartDto> laptops) {
            DgvLaptopCart.Rows.Clear();
            foreach (var item in laptops) {
                var index = DgvLaptopCart.Rows.Add();
                DgvLaptopCart.Rows[index].Cells[0].Value = item.LaptopId;
                DgvLaptopCart.Rows[index].Cells[1].Value = item.LaptopName;
                DgvLaptopCart.Rows[index].Cells[2].Value = item.BrandName;
                DgvLaptopCart.Rows[index].Cells[3].Value = item.SellPrice;
                DgvLaptopCart.Rows[index].Cells[4].Value = item.Sale;
                DgvLaptopCart.Rows[index].Cells[5].Value = item.BuyQuantity;
                DgvLaptopCart.Rows[index].Cells[6].Value = item.BuyPrice;
            }
        }

        private void DgvLaptopCart_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7) {
                // Chuyển đổi trạng thái của ô checkbox
                if (DgvLaptopCart.Rows[e.RowIndex].Cells[7] is DataGridViewCheckBoxCell cell) {
                    cell.Value = cell.Value == null || (bool)cell.Value == false;
                }
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e) {
            LaptopInvoice invoice = new LaptopInvoice();
            invoice.InvoiceID = GenerateRandomString(6);
            invoice.Note = TbNote.Text;
            invoice.OrderDate = DateTime.Now;
            var selectedDate = DtpDeliveryDate.Value;
            if (selectedDate < invoice.OrderDate) {
                MessageBox.Show(@"Thời gian được chọn nhỏ hơn ngày hiện tại");
            } else {
                invoice.DeliveryDate = selectedDate;
            }
            var context = new LaptopContext();

            using (var trans = context.Database.BeginTransaction()) {
                try {
                    for (var i = 0; i < DgvLaptopCart.Rows.Count; i++) {
                        bool isChecked = (bool)DgvLaptopCart.Rows[i].Cells[7].Value;
                        if (isChecked) {
                            var item = CartList.laptopCart.FirstOrDefault(a => a.LaptopId == DgvLaptopCart.Rows[i].Cells[0].Value.ToString());
                            if (item == null) continue;
                            var order = new LaptopOrder {
                                InvoiceID = invoice.InvoiceID,
                                OrderID = item.OrderId,
                                LaptopID = item.LaptopId,
                                LaptopName = item.LaptopName,
                                BrandName = item.BrandName,
                                SellPrice = item.SellPrice,
                                BuyPrice = item.BuyPrice,
                                BuyQuantity = item.BuyQuantity,
                                Sale = item.Sale
                            };
                            context.LaptopOrders.Add(order);
                            CartList.laptopCart.Remove(item);
                        }
                    }
                    context.LaptopInvoices.Add(invoice);
                    context.SaveChanges();
                    trans.Commit();
                } catch {
                    trans.Rollback();
                }
            }
            ShowReport(context, invoice.InvoiceID);
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

        private void ShowReport(LaptopContext context, string id) {
            reportViewer1.Visible = true;
            var invoice = context.LaptopInvoices.FirstOrDefault(i => i.InvoiceID == id);
            var orders = context.LaptopOrders.Where(o => o.InvoiceID == id).ToList();
            ReportParameter[] param = new ReportParameter[3];
            param[0] = new ReportParameter("InvoiceID", invoice.InvoiceID);
            param[1] = new ReportParameter("OrderDate", string.Format("Ngày mua: " + invoice.OrderDate.ToString("dd/MM/yyyy")));
            param[2] = new ReportParameter("DeliveryDate", invoice.DeliveryDate.ToString("dd/MM/yyyy"));

            reportViewer1.LocalReport.ReportPath = "./Model/ReportModel/LaptopReport.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            var dataSource = new ReportDataSource("LaptopDataSet", orders);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();
        }
    }
}