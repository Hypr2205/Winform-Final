using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final {
    public partial class AccessoryInvoiceReport : Form {
        public AccessoryInvoiceReport() {
            InitializeComponent();
        }

        private void AccessoryInvoice_Load(object sender, EventArgs e) {

            this.AccessoryInvoiceReport.RefreshReport();
        }
    }
}
