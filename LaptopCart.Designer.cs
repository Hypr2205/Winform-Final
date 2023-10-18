namespace Final {
    partial class LaptopCart {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvLaptopCart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.DtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLaptopCart)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLaptopCart
            // 
            this.DgvLaptopCart.AllowUserToAddRows = false;
            this.DgvLaptopCart.AllowUserToDeleteRows = false;
            this.DgvLaptopCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLaptopCart.BackgroundColor = System.Drawing.Color.White;
            this.DgvLaptopCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLaptopCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.IsSelected});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLaptopCart.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLaptopCart.Location = new System.Drawing.Point(13, 231);
            this.DgvLaptopCart.Name = "DgvLaptopCart";
            this.DgvLaptopCart.ReadOnly = true;
            this.DgvLaptopCart.RowHeadersWidth = 51;
            this.DgvLaptopCart.RowTemplate.Height = 24;
            this.DgvLaptopCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLaptopCart.Size = new System.Drawing.Size(975, 376);
            this.DgvLaptopCart.TabIndex = 1;
            this.DgvLaptopCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLaptopCart_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã máy";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên máy";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hãng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá bán";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Khuyến mãi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng mua";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // IsSelected
            // 
            this.IsSelected.HeaderText = "Xác nhận mua";
            this.IsSelected.MinimumWidth = 6;
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.ReadOnly = true;
            this.IsSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TbNote
            // 
            this.TbNote.Location = new System.Drawing.Point(12, 46);
            this.TbNote.Multiline = true;
            this.TbNote.Name = "TbNote";
            this.TbNote.Size = new System.Drawing.Size(384, 159);
            this.TbNote.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ghi chú";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày giao hàng dự kiến";
            // 
            // BtnBuy
            // 
            this.BtnBuy.Location = new System.Drawing.Point(867, 185);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(121, 40);
            this.BtnBuy.TabIndex = 6;
            this.BtnBuy.Text = "Mua";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // DtpDeliveryDate
            // 
            this.DtpDeliveryDate.Location = new System.Drawing.Point(449, 46);
            this.DtpDeliveryDate.Name = "DtpDeliveryDate";
            this.DtpDeliveryDate.Size = new System.Drawing.Size(310, 30);
            this.DtpDeliveryDate.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 619);
            this.reportViewer1.TabIndex = 8;
            // 
            // LaptopCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.DtpDeliveryDate);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNote);
            this.Controls.Add(this.DgvLaptopCart);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LaptopCart";
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.LaptopCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLaptopCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLaptopCart;
        private System.Windows.Forms.TextBox TbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.DateTimePicker DtpDeliveryDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
    }
}