namespace Final {
    partial class OrderHistory {
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.CbxAccessoryInvoices = new System.Windows.Forms.ComboBox();
            this.CbxLaptopInvoices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtLaptopInvoice = new System.Windows.Forms.RadioButton();
            this.RbtAccessoryInvoice = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(2, 218);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(997, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtAccessoryInvoice);
            this.groupBox1.Controls.Add(this.BtnExport);
            this.groupBox1.Controls.Add(this.RbtLaptopInvoice);
            this.groupBox1.Controls.Add(this.CbxAccessoryInvoices);
            this.groupBox1.Controls.Add(this.CbxLaptopInvoices);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(237, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử đơn hàng";
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(375, 160);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 33);
            this.BtnExport.TabIndex = 6;
            this.BtnExport.Text = "In";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // CbxAccessoryInvoices
            // 
            this.CbxAccessoryInvoices.FormattingEnabled = true;
            this.CbxAccessoryInvoices.Location = new System.Drawing.Point(295, 124);
            this.CbxAccessoryInvoices.Name = "CbxAccessoryInvoices";
            this.CbxAccessoryInvoices.Size = new System.Drawing.Size(155, 30);
            this.CbxAccessoryInvoices.TabIndex = 5;
            // 
            // CbxLaptopInvoices
            // 
            this.CbxLaptopInvoices.FormattingEnabled = true;
            this.CbxLaptopInvoices.Location = new System.Drawing.Point(295, 67);
            this.CbxLaptopInvoices.Name = "CbxLaptopInvoices";
            this.CbxLaptopInvoices.Size = new System.Drawing.Size(155, 30);
            this.CbxLaptopInvoices.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại đơn hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn hàng";
            // 
            // RbtLaptopInvoice
            // 
            this.RbtLaptopInvoice.AutoSize = true;
            this.RbtLaptopInvoice.Location = new System.Drawing.Point(41, 71);
            this.RbtLaptopInvoice.Name = "RbtLaptopInvoice";
            this.RbtLaptopInvoice.Size = new System.Drawing.Size(149, 26);
            this.RbtLaptopInvoice.TabIndex = 2;
            this.RbtLaptopInvoice.TabStop = true;
            this.RbtLaptopInvoice.Text = "Đơn bán laptop";
            this.RbtLaptopInvoice.UseVisualStyleBackColor = true;
            // 
            // RbtAccessoryInvoice
            // 
            this.RbtAccessoryInvoice.AutoSize = true;
            this.RbtAccessoryInvoice.Location = new System.Drawing.Point(41, 128);
            this.RbtAccessoryInvoice.Name = "RbtAccessoryInvoice";
            this.RbtAccessoryInvoice.Size = new System.Drawing.Size(166, 26);
            this.RbtAccessoryInvoice.TabIndex = 7;
            this.RbtAccessoryInvoice.TabStop = true;
            this.RbtAccessoryInvoice.Text = "Đơn bán phụ kiện";
            this.RbtAccessoryInvoice.UseVisualStyleBackColor = true;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử đơn hàng";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxAccessoryInvoices;
        private System.Windows.Forms.ComboBox CbxLaptopInvoices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.RadioButton RbtLaptopInvoice;
        private System.Windows.Forms.RadioButton RbtAccessoryInvoice;
    }
}