namespace Final {
    partial class BuildPcCart {
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
            this.DgvCartItems = new System.Windows.Forms.DataGridView();
            this.TbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbBuyPrice = new System.Windows.Forms.TextBox();
            this.TbSellPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbTotalItems = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvCartItems
            // 
            this.DgvCartItems.AllowUserToAddRows = false;
            this.DgvCartItems.AllowUserToDeleteRows = false;
            this.DgvCartItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCartItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvCartItems.Location = new System.Drawing.Point(12, 305);
            this.DgvCartItems.Name = "DgvCartItems";
            this.DgvCartItems.ReadOnly = true;
            this.DgvCartItems.RowHeadersWidth = 51;
            this.DgvCartItems.RowTemplate.Height = 24;
            this.DgvCartItems.Size = new System.Drawing.Size(1248, 382);
            this.DgvCartItems.TabIndex = 0;
            // 
            // TbTotalPrice
            // 
            this.TbTotalPrice.Location = new System.Drawing.Point(237, 152);
            this.TbTotalPrice.Name = "TbTotalPrice";
            this.TbTotalPrice.ReadOnly = true;
            this.TbTotalPrice.Size = new System.Drawing.Size(199, 34);
            this.TbTotalPrice.TabIndex = 1;
            this.TbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng giá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMinus);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbBuyPrice);
            this.groupBox1.Controls.Add(this.TbSellPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // TbBuyPrice
            // 
            this.TbBuyPrice.Location = new System.Drawing.Point(197, 181);
            this.TbBuyPrice.Name = "TbBuyPrice";
            this.TbBuyPrice.ReadOnly = true;
            this.TbBuyPrice.Size = new System.Drawing.Size(221, 34);
            this.TbBuyPrice.TabIndex = 5;
            // 
            // TbSellPrice
            // 
            this.TbSellPrice.Location = new System.Drawing.Point(197, 113);
            this.TbSellPrice.Name = "TbSellPrice";
            this.TbSellPrice.ReadOnly = true;
            this.TbSellPrice.Size = new System.Drawing.Size(221, 34);
            this.TbSellPrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(197, 49);
            this.TbName.Name = "TbName";
            this.TbName.ReadOnly = true;
            this.TbName.Size = new System.Drawing.Size(221, 34);
            this.TbName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExport);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TbTotalPrice);
            this.groupBox2.Controls.Add(this.TbTotalItems);
            this.groupBox2.Location = new System.Drawing.Point(457, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 278);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giỏ hàng";
            // 
            // TbTotalItems
            // 
            this.TbTotalItems.Location = new System.Drawing.Point(237, 66);
            this.TbTotalItems.Name = "TbTotalItems";
            this.TbTotalItems.ReadOnly = true;
            this.TbTotalItems.Size = new System.Drawing.Size(199, 34);
            this.TbTotalItems.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(81, 34);
            this.textBox1.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(357, 240);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(61, 37);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(197, 238);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(67, 37);
            this.BtnMinus.TabIndex = 9;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(51, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng số sản phẩm";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên linh kiện";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Loại linh kiện";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hãng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Khuyến mãi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(294, 223);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(142, 34);
            this.BtnExport.TabIndex = 5;
            this.BtnExport.Text = "Xuất hoá đơn";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // BuildPcCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvCartItems);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuildPcCart";
            this.Text = "Giỏ hàng";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCartItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCartItems;
        private System.Windows.Forms.TextBox TbTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbBuyPrice;
        private System.Windows.Forms.TextBox TbSellPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TbTotalItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button BtnExport;
    }
}