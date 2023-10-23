using Final.Model.AccessoryModel;
using Final.Model.LaptopModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Final {
    public partial class OrderHistory : Form {
        public OrderHistory() {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, System.EventArgs e) {
            reportViewer1.Visible = false;
            try {
                var lapContext = new LaptopContext();
                var accessoryContext = new AccessoryContext();
                FillLaptopInvoiceBox(lapContext.Invoices.ToList());
                FillAccessoryInvoiceBox(accessoryContext.Invoices.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void BtnExport_Click(object sender, System.EventArgs e) {
            reportViewer1.Visible = true;
            if (ChkLaptopInvoice.Checked) {
                ExportLaptopInvoices();
            } else if (ChkAccessoryInvoice.Checked) {
                ExportAccessoryInvoices();
            } else {
                MessageBox.Show("Vui lòng chọn loại hoá đơn!");
            }
        }

        private void FillLaptopInvoiceBox(List<Model.LaptopModel.Invoice> laptopInvoices) {
            CbxLaptopInvoices.DataSource = laptopInvoices;
            CbxLaptopInvoices.DisplayMember = "InvoiceID";
            CbxLaptopInvoices.ValueMember = "InvoiceID";
            CbxLaptopInvoices.SelectedIndex = -1;
        }

        private void FillAccessoryInvoiceBox(List<Model.AccessoryModel.Invoice> accessoryInvoices) {
            CbxAccessoryInvoices.DataSource = accessoryInvoices;
            CbxAccessoryInvoices.DisplayMember = "InvoiceID";
            CbxAccessoryInvoices.ValueMember = "InvoiceID";
            CbxAccessoryInvoices.SelectedIndex = -1;
        }

        private void ExportLaptopInvoices() {
            var context = new LaptopContext();
            var selectedItem = (Model.LaptopModel.Invoice)CbxLaptopInvoices.SelectedItem;
            var invoice = context.Invoices.FirstOrDefault(i => i.InvoiceID == selectedItem.InvoiceID);
            var orders = context.LaptopOrders.Where(o => o.InvoiceID == selectedItem.InvoiceID).ToList();
            ReportParameter[] param = new ReportParameter[4];
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

        private void ExportAccessoryInvoices() {
            var context = new AccessoryContext();
            var selectedItem = (Model.AccessoryModel.Invoice)CbxAccessoryInvoices.SelectedItem;
            var invoice = context.Invoices.FirstOrDefault(i => i.InvoiceID == selectedItem.InvoiceID);
            var orders = context.AccessoryOrders.Where(o => o.InvoiceID == selectedItem.InvoiceID).ToList();
            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("InvoiceID", invoice.InvoiceID);
            param[1] = new ReportParameter("OrderDate", string.Format("Ngày mua: " + invoice.OrderDate.ToString("dd/MM/yyyy")));
            param[2] = new ReportParameter("DeliveryDate", invoice.DeliveryDate.ToString("dd/MM/yyyy"));

            reportViewer1.LocalReport.ReportPath = "./Model/ReportModel/AccessoryReport.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            var dataSource = new ReportDataSource("AccessoryDataSet", orders);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.RefreshReport();
        }
    }
}