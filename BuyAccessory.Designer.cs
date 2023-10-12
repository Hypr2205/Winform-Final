using System.ComponentModel;

namespace Final {
    partial class BuyAccessory {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.DgvAccessories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbBuyQuantity = new System.Windows.Forms.TextBox();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.TbCategoryName = new System.Windows.Forms.TextBox();
            this.TbAccessoryName = new System.Windows.Forms.TextBox();
            this.TbBrandName = new System.Windows.Forms.TextBox();
            this.TbAccessoryID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ChkInStock = new System.Windows.Forms.CheckBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.ChkIsSale = new System.Windows.Forms.CheckBox();
            this.CbxBrandFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CbxCategoryFilter = new System.Windows.Forms.ComboBox();
            this.TbNameFillter = new System.Windows.Forms.TextBox();
            this.TbIdFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessories)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAccessories
            // 
            this.DgvAccessories.AllowUserToAddRows = false;
            this.DgvAccessories.AllowUserToDeleteRows = false;
            this.DgvAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAccessories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAccessories.BackgroundColor = System.Drawing.Color.White;
            this.DgvAccessories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAccessories.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAccessories.Location = new System.Drawing.Point(438, 274);
            this.DgvAccessories.Name = "DgvAccessories";
            this.DgvAccessories.ReadOnly = true;
            this.DgvAccessories.RowHeadersWidth = 51;
            this.DgvAccessories.RowTemplate.Height = 24;
            this.DgvAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccessories.Size = new System.Drawing.Size(900, 438);
            this.DgvAccessories.TabIndex = 0;
            this.DgvAccessories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccessories_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hãng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá bán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Khuyến mãi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LbTitle.Location = new System.Drawing.Point(489, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(347, 53);
            this.LbTitle.TabIndex = 2;
            this.LbTitle.Text = "Shop Máy Tính PC88";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbBuyQuantity);
            this.groupBox1.Controls.Add(this.BtnAddToCart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbPrice);
            this.groupBox1.Controls.Add(this.TbCategoryName);
            this.groupBox1.Controls.Add(this.TbAccessoryName);
            this.groupBox1.Controls.Add(this.TbBrandName);
            this.groupBox1.Controls.Add(this.TbAccessoryID);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 438);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // TbBuyQuantity
            // 
            this.TbBuyQuantity.Location = new System.Drawing.Point(223, 389);
            this.TbBuyQuantity.Name = "TbBuyQuantity";
            this.TbBuyQuantity.Size = new System.Drawing.Size(147, 30);
            this.TbBuyQuantity.TabIndex = 10;
            this.TbBuyQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbBuyQuantity.Enter += new System.EventHandler(this.TbBuyQuantity_Enter);
            this.TbBuyQuantity.Leave += new System.EventHandler(this.TbBuyQuantity_OnLeave);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(10, 384);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(166, 39);
            this.BtnAddToCart.TabIndex = 9;
            this.BtnAddToCart.Text = "Thêm vào giỏ hàng";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại sản phẩm";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hãng";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sản phẩm";
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(161, 325);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.ReadOnly = true;
            this.TbPrice.Size = new System.Drawing.Size(253, 30);
            this.TbPrice.TabIndex = 3;
            this.TbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbCategoryName
            // 
            this.TbCategoryName.Location = new System.Drawing.Point(161, 191);
            this.TbCategoryName.Name = "TbCategoryName";
            this.TbCategoryName.ReadOnly = true;
            this.TbCategoryName.Size = new System.Drawing.Size(253, 30);
            this.TbCategoryName.TabIndex = 2;
            this.TbCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbAccessoryName
            // 
            this.TbAccessoryName.Location = new System.Drawing.Point(161, 119);
            this.TbAccessoryName.Name = "TbAccessoryName";
            this.TbAccessoryName.ReadOnly = true;
            this.TbAccessoryName.Size = new System.Drawing.Size(253, 30);
            this.TbAccessoryName.TabIndex = 1;
            this.TbAccessoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbBrandName
            // 
            this.TbBrandName.Location = new System.Drawing.Point(161, 256);
            this.TbBrandName.Name = "TbBrandName";
            this.TbBrandName.ReadOnly = true;
            this.TbBrandName.Size = new System.Drawing.Size(253, 30);
            this.TbBrandName.TabIndex = 1;
            this.TbBrandName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbAccessoryID
            // 
            this.TbAccessoryID.Location = new System.Drawing.Point(161, 48);
            this.TbAccessoryID.Name = "TbAccessoryID";
            this.TbAccessoryID.ReadOnly = true;
            this.TbAccessoryID.Size = new System.Drawing.Size(253, 30);
            this.TbAccessoryID.TabIndex = 0;
            this.TbAccessoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnCancel);
            this.groupBox2.Controls.Add(this.ChkInStock);
            this.groupBox2.Controls.Add(this.BtnFilter);
            this.groupBox2.Controls.Add(this.ChkIsSale);
            this.groupBox2.Controls.Add(this.CbxBrandFilter);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CbxCategoryFilter);
            this.groupBox2.Controls.Add(this.TbNameFillter);
            this.groupBox2.Controls.Add(this.TbIdFilter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1326, 167);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc sản phẩm";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(1180, 110);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(140, 33);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Huỷ";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ChkInStock
            // 
            this.ChkInStock.AutoSize = true;
            this.ChkInStock.Location = new System.Drawing.Point(967, 114);
            this.ChkInStock.Name = "ChkInStock";
            this.ChkInStock.Size = new System.Drawing.Size(107, 26);
            this.ChkInStock.TabIndex = 17;
            this.ChkInStock.Text = "Còn hàng";
            this.ChkInStock.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(1180, 42);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(140, 36);
            this.BtnFilter.TabIndex = 10;
            this.BtnFilter.Text = "Lọc";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // ChkIsSale
            // 
            this.ChkIsSale.AutoSize = true;
            this.ChkIsSale.Location = new System.Drawing.Point(967, 47);
            this.ChkIsSale.Name = "ChkIsSale";
            this.ChkIsSale.Size = new System.Drawing.Size(166, 26);
            this.ChkIsSale.TabIndex = 16;
            this.ChkIsSale.Text = "Đang khuyến mãi";
            this.ChkIsSale.UseVisualStyleBackColor = true;
            // 
            // CbxBrandFilter
            // 
            this.CbxBrandFilter.FormattingEnabled = true;
            this.CbxBrandFilter.Location = new System.Drawing.Point(668, 109);
            this.CbxBrandFilter.Name = "CbxBrandFilter";
            this.CbxBrandFilter.Size = new System.Drawing.Size(253, 30);
            this.CbxBrandFilter.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(513, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 30);
            this.label10.TabIndex = 14;
            this.label10.Text = "Hãng";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(513, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "Loại sản phẩm";
            // 
            // CbxCategoryFilter
            // 
            this.CbxCategoryFilter.FormattingEnabled = true;
            this.CbxCategoryFilter.Location = new System.Drawing.Point(668, 45);
            this.CbxCategoryFilter.Name = "CbxCategoryFilter";
            this.CbxCategoryFilter.Size = new System.Drawing.Size(253, 30);
            this.CbxCategoryFilter.TabIndex = 12;
            // 
            // TbNameFillter
            // 
            this.TbNameFillter.Location = new System.Drawing.Point(161, 112);
            this.TbNameFillter.Name = "TbNameFillter";
            this.TbNameFillter.Size = new System.Drawing.Size(253, 30);
            this.TbNameFillter.TabIndex = 11;
            this.TbNameFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbIdFilter
            // 
            this.TbIdFilter.Location = new System.Drawing.Point(161, 42);
            this.TbIdFilter.Name = "TbIdFilter";
            this.TbIdFilter.Size = new System.Drawing.Size(253, 30);
            this.TbIdFilter.TabIndex = 10;
            this.TbIdFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã sản phẩm";
            // 
            // BuyAccessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 717);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.DgvAccessories);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuyAccessory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyAccessory";
            this.Load += new System.EventHandler(this.BuyAccessory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessories)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAccessories;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.TextBox TbCategoryName;
        private System.Windows.Forms.TextBox TbAccessoryName;
        private System.Windows.Forms.TextBox TbBrandName;
        private System.Windows.Forms.TextBox TbAccessoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.TextBox TbNameFillter;
        private System.Windows.Forms.TextBox TbIdFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbxCategoryFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbxBrandFilter;
        private System.Windows.Forms.CheckBox ChkIsSale;
        private System.Windows.Forms.CheckBox ChkInStock;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.TextBox TbBuyQuantity;
        private System.Windows.Forms.Button BtnCancel;
    }
}