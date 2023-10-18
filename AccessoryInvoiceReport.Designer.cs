namespace Final {
    partial class AccessoryInvoiceReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AccessoryInvoiceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // AccessoryInvoiceReport
            // 
            this.AccessoryInvoiceReport.Location = new System.Drawing.Point(13, 13);
            this.AccessoryInvoiceReport.Name = "AccessoryInvoiceReport";
            this.AccessoryInvoiceReport.ServerReport.BearerToken = null;
            this.AccessoryInvoiceReport.Size = new System.Drawing.Size(975, 594);
            this.AccessoryInvoiceReport.TabIndex = 0;
            // 
            // AccessoryInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.AccessoryInvoiceReport);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccessoryInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng báo giá";
            this.Load += new System.EventHandler(this.AccessoryInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer AccessoryInvoiceReport;
    }
}