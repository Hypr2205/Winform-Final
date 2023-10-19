namespace Final {
    partial class BuyLaptop {
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
                  this.LbTitle = new System.Windows.Forms.Label();
                  this.DgvLaptops = new System.Windows.Forms.DataGridView();
                  this.LaptopIDCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.LaptopNameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.CategoryCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.SellPriceCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.SaleCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.QuantityCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.LaptopInfoContainer = new System.Windows.Forms.GroupBox();
                  this.BtnRefresh = new System.Windows.Forms.Button();
                  this.TbSale = new System.Windows.Forms.TextBox();
                  this.TbBuyQuantity = new System.Windows.Forms.TextBox();
                  this.BtnAddToCart = new System.Windows.Forms.Button();
                  this.TbLaptopPrice = new System.Windows.Forms.TextBox();
                  this.TbLaptopCategory = new System.Windows.Forms.TextBox();
                  this.TbLaptopName = new System.Windows.Forms.TextBox();
                  this.TbLaptopID = new System.Windows.Forms.TextBox();
                  this.label8 = new System.Windows.Forms.Label();
                  this.label7 = new System.Windows.Forms.Label();
                  this.label6 = new System.Windows.Forms.Label();
                  this.label5 = new System.Windows.Forms.Label();
                  this.label4 = new System.Windows.Forms.Label();
                  this.FilterContainer = new System.Windows.Forms.GroupBox();
                  this.ChkIsInStock = new System.Windows.Forms.CheckBox();
                  this.TbIdFilter = new System.Windows.Forms.TextBox();
                  this.label9 = new System.Windows.Forms.Label();
                  this.BtnCancel = new System.Windows.Forms.Button();
                  this.label3 = new System.Windows.Forms.Label();
                  this.CbBrandFilter = new System.Windows.Forms.ComboBox();
                  this.ChkIsSale = new System.Windows.Forms.CheckBox();
                  this.BtnFilter = new System.Windows.Forms.Button();
                  this.label2 = new System.Windows.Forms.Label();
                  this.TbNameFilter = new System.Windows.Forms.TextBox();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.Cart = new System.Windows.Forms.ToolStripMenuItem();
                  ((System.ComponentModel.ISupportInitialize)(this.DgvLaptops)).BeginInit();
                  this.LaptopInfoContainer.SuspendLayout();
                  this.FilterContainer.SuspendLayout();
                  this.menuStrip1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // LbTitle
                  // 
                  this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
                  this.LbTitle.Location = new System.Drawing.Point(533, 24);
                  this.LbTitle.Name = "LbTitle";
                  this.LbTitle.Size = new System.Drawing.Size(347, 53);
                  this.LbTitle.TabIndex = 1;
                  this.LbTitle.Text = "MUA LAPTOP";
                  this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // DgvLaptops
                  // 
                  this.DgvLaptops.AllowUserToAddRows = false;
                  this.DgvLaptops.AllowUserToDeleteRows = false;
                  this.DgvLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.DgvLaptops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                  this.DgvLaptops.BackgroundColor = System.Drawing.Color.White;
                  this.DgvLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.DgvLaptops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaptopIDCell,
            this.LaptopNameCell,
            this.CategoryCell,
            this.SellPriceCell,
            this.SaleCell,
            this.QuantityCell});
                  dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                  dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
                  dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
                  dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
                  dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                  dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                  this.DgvLaptops.DefaultCellStyle = dataGridViewCellStyle1;
                  this.DgvLaptops.Location = new System.Drawing.Point(458, 243);
                  this.DgvLaptops.Name = "DgvLaptops";
                  this.DgvLaptops.ReadOnly = true;
                  this.DgvLaptops.RowHeadersWidth = 51;
                  this.DgvLaptops.RowTemplate.Height = 24;
                  this.DgvLaptops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  this.DgvLaptops.Size = new System.Drawing.Size(921, 468);
                  this.DgvLaptops.TabIndex = 2;
                  this.DgvLaptops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLaptops_CellContentClick);
                  // 
                  // LaptopIDCell
                  // 
                  this.LaptopIDCell.HeaderText = "Mã máy";
                  this.LaptopIDCell.MinimumWidth = 6;
                  this.LaptopIDCell.Name = "LaptopIDCell";
                  this.LaptopIDCell.ReadOnly = true;
                  // 
                  // LaptopNameCell
                  // 
                  this.LaptopNameCell.HeaderText = "Tên máy";
                  this.LaptopNameCell.MinimumWidth = 6;
                  this.LaptopNameCell.Name = "LaptopNameCell";
                  this.LaptopNameCell.ReadOnly = true;
                  // 
                  // CategoryCell
                  // 
                  this.CategoryCell.HeaderText = "Hãng";
                  this.CategoryCell.MinimumWidth = 6;
                  this.CategoryCell.Name = "CategoryCell";
                  this.CategoryCell.ReadOnly = true;
                  // 
                  // SellPriceCell
                  // 
                  this.SellPriceCell.HeaderText = "Giá bán";
                  this.SellPriceCell.MinimumWidth = 6;
                  this.SellPriceCell.Name = "SellPriceCell";
                  this.SellPriceCell.ReadOnly = true;
                  // 
                  // SaleCell
                  // 
                  this.SaleCell.HeaderText = "Khuyến mãi";
                  this.SaleCell.MinimumWidth = 6;
                  this.SaleCell.Name = "SaleCell";
                  this.SaleCell.ReadOnly = true;
                  // 
                  // QuantityCell
                  // 
                  this.QuantityCell.HeaderText = "Số lượng tồn kho";
                  this.QuantityCell.MinimumWidth = 6;
                  this.QuantityCell.Name = "QuantityCell";
                  this.QuantityCell.ReadOnly = true;
                  // 
                  // LaptopInfoContainer
                  // 
                  this.LaptopInfoContainer.Controls.Add(this.BtnRefresh);
                  this.LaptopInfoContainer.Controls.Add(this.TbSale);
                  this.LaptopInfoContainer.Controls.Add(this.TbBuyQuantity);
                  this.LaptopInfoContainer.Controls.Add(this.BtnAddToCart);
                  this.LaptopInfoContainer.Controls.Add(this.TbLaptopPrice);
                  this.LaptopInfoContainer.Controls.Add(this.TbLaptopCategory);
                  this.LaptopInfoContainer.Controls.Add(this.TbLaptopName);
                  this.LaptopInfoContainer.Controls.Add(this.TbLaptopID);
                  this.LaptopInfoContainer.Controls.Add(this.label8);
                  this.LaptopInfoContainer.Controls.Add(this.label7);
                  this.LaptopInfoContainer.Controls.Add(this.label6);
                  this.LaptopInfoContainer.Controls.Add(this.label5);
                  this.LaptopInfoContainer.Controls.Add(this.label4);
                  this.LaptopInfoContainer.Location = new System.Drawing.Point(11, 243);
                  this.LaptopInfoContainer.Name = "LaptopInfoContainer";
                  this.LaptopInfoContainer.Size = new System.Drawing.Size(441, 468);
                  this.LaptopInfoContainer.TabIndex = 3;
                  this.LaptopInfoContainer.TabStop = false;
                  this.LaptopInfoContainer.Text = "Thông Tin Laptop";
                  // 
                  // BtnRefresh
                  // 
                  this.BtnRefresh.Image = global::Final.Properties.Resources.icons8_refresh_32;
                  this.BtnRefresh.Location = new System.Drawing.Point(379, 409);
                  this.BtnRefresh.Name = "BtnRefresh";
                  this.BtnRefresh.Size = new System.Drawing.Size(56, 43);
                  this.BtnRefresh.TabIndex = 12;
                  this.BtnRefresh.UseVisualStyleBackColor = true;
                  this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
                  // 
                  // TbSale
                  // 
                  this.TbSale.Location = new System.Drawing.Point(143, 318);
                  this.TbSale.Name = "TbSale";
                  this.TbSale.ReadOnly = true;
                  this.TbSale.Size = new System.Drawing.Size(280, 30);
                  this.TbSale.TabIndex = 10;
                  this.TbSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // TbBuyQuantity
                  // 
                  this.TbBuyQuantity.Location = new System.Drawing.Point(203, 416);
                  this.TbBuyQuantity.Name = "TbBuyQuantity";
                  this.TbBuyQuantity.Size = new System.Drawing.Size(161, 30);
                  this.TbBuyQuantity.TabIndex = 9;
                  this.TbBuyQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  this.TbBuyQuantity.Enter += new System.EventHandler(this.TbBuyQuantity_Enter);
                  this.TbBuyQuantity.Leave += new System.EventHandler(this.TbBuyQuantity_OnLeave);
                  // 
                  // BtnAddToCart
                  // 
                  this.BtnAddToCart.Location = new System.Drawing.Point(14, 409);
                  this.BtnAddToCart.Name = "BtnAddToCart";
                  this.BtnAddToCart.Size = new System.Drawing.Size(167, 43);
                  this.BtnAddToCart.TabIndex = 6;
                  this.BtnAddToCart.Text = "Thêm vào giỏ hàng";
                  this.BtnAddToCart.UseVisualStyleBackColor = true;
                  this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
                  // 
                  // TbLaptopPrice
                  // 
                  this.TbLaptopPrice.Location = new System.Drawing.Point(143, 251);
                  this.TbLaptopPrice.Name = "TbLaptopPrice";
                  this.TbLaptopPrice.ReadOnly = true;
                  this.TbLaptopPrice.Size = new System.Drawing.Size(280, 30);
                  this.TbLaptopPrice.TabIndex = 7;
                  this.TbLaptopPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // TbLaptopCategory
                  // 
                  this.TbLaptopCategory.Location = new System.Drawing.Point(143, 187);
                  this.TbLaptopCategory.Name = "TbLaptopCategory";
                  this.TbLaptopCategory.ReadOnly = true;
                  this.TbLaptopCategory.Size = new System.Drawing.Size(280, 30);
                  this.TbLaptopCategory.TabIndex = 6;
                  this.TbLaptopCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // TbLaptopName
                  // 
                  this.TbLaptopName.Location = new System.Drawing.Point(143, 120);
                  this.TbLaptopName.Name = "TbLaptopName";
                  this.TbLaptopName.ReadOnly = true;
                  this.TbLaptopName.Size = new System.Drawing.Size(280, 30);
                  this.TbLaptopName.TabIndex = 5;
                  this.TbLaptopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // TbLaptopID
                  // 
                  this.TbLaptopID.Location = new System.Drawing.Point(144, 53);
                  this.TbLaptopID.Name = "TbLaptopID";
                  this.TbLaptopID.ReadOnly = true;
                  this.TbLaptopID.Size = new System.Drawing.Size(279, 30);
                  this.TbLaptopID.TabIndex = 4;
                  this.TbLaptopID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // label8
                  // 
                  this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label8.Location = new System.Drawing.Point(10, 247);
                  this.label8.Name = "label8";
                  this.label8.Size = new System.Drawing.Size(77, 37);
                  this.label8.TabIndex = 3;
                  this.label8.Text = "GIÁ BÁN";
                  this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // label7
                  // 
                  this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label7.Location = new System.Drawing.Point(10, 183);
                  this.label7.Name = "label7";
                  this.label7.Size = new System.Drawing.Size(60, 37);
                  this.label7.TabIndex = 2;
                  this.label7.Text = "HÃNG";
                  this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // label6
                  // 
                  this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label6.Location = new System.Drawing.Point(1, 318);
                  this.label6.Name = "label6";
                  this.label6.Size = new System.Drawing.Size(118, 37);
                  this.label6.TabIndex = 2;
                  this.label6.Text = "KHUYẾN MÃI";
                  this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // label5
                  // 
                  this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label5.Location = new System.Drawing.Point(10, 120);
                  this.label5.Name = "label5";
                  this.label5.Size = new System.Drawing.Size(84, 37);
                  this.label5.TabIndex = 1;
                  this.label5.Text = "TÊN MÁY";
                  this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // label4
                  // 
                  this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label4.Location = new System.Drawing.Point(10, 53);
                  this.label4.Name = "label4";
                  this.label4.Size = new System.Drawing.Size(82, 37);
                  this.label4.TabIndex = 0;
                  this.label4.Text = "MÃ MÁY";
                  this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // FilterContainer
                  // 
                  this.FilterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.FilterContainer.Controls.Add(this.ChkIsInStock);
                  this.FilterContainer.Controls.Add(this.TbIdFilter);
                  this.FilterContainer.Controls.Add(this.label9);
                  this.FilterContainer.Controls.Add(this.BtnCancel);
                  this.FilterContainer.Controls.Add(this.label3);
                  this.FilterContainer.Controls.Add(this.CbBrandFilter);
                  this.FilterContainer.Controls.Add(this.ChkIsSale);
                  this.FilterContainer.Controls.Add(this.BtnFilter);
                  this.FilterContainer.Controls.Add(this.label2);
                  this.FilterContainer.Controls.Add(this.TbNameFilter);
                  this.FilterContainer.Location = new System.Drawing.Point(12, 80);
                  this.FilterContainer.Name = "FilterContainer";
                  this.FilterContainer.Size = new System.Drawing.Size(1367, 141);
                  this.FilterContainer.TabIndex = 4;
                  this.FilterContainer.TabStop = false;
                  this.FilterContainer.Text = "Lọc";
                  // 
                  // ChkIsInStock
                  // 
                  this.ChkIsInStock.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.ChkIsInStock.Location = new System.Drawing.Point(967, 96);
                  this.ChkIsInStock.Name = "ChkIsInStock";
                  this.ChkIsInStock.Size = new System.Drawing.Size(186, 35);
                  this.ChkIsInStock.TabIndex = 11;
                  this.ChkIsInStock.Text = "Còn hàng";
                  this.ChkIsInStock.UseVisualStyleBackColor = true;
                  // 
                  // TbIdFilter
                  // 
                  this.TbIdFilter.Location = new System.Drawing.Point(152, 26);
                  this.TbIdFilter.Name = "TbIdFilter";
                  this.TbIdFilter.Size = new System.Drawing.Size(298, 30);
                  this.TbIdFilter.TabIndex = 10;
                  // 
                  // label9
                  // 
                  this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label9.Location = new System.Drawing.Point(24, 31);
                  this.label9.Name = "label9";
                  this.label9.Size = new System.Drawing.Size(101, 30);
                  this.label9.TabIndex = 9;
                  this.label9.Text = "Mã máy";
                  // 
                  // BtnCancel
                  // 
                  this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
                  this.BtnCancel.Location = new System.Drawing.Point(1210, 96);
                  this.BtnCancel.Name = "BtnCancel";
                  this.BtnCancel.Size = new System.Drawing.Size(129, 39);
                  this.BtnCancel.TabIndex = 8;
                  this.BtnCancel.Text = "Huỷ";
                  this.BtnCancel.UseVisualStyleBackColor = true;
                  this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
                  // 
                  // label3
                  // 
                  this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label3.Location = new System.Drawing.Point(524, 26);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(101, 30);
                  this.label3.TabIndex = 7;
                  this.label3.Text = "Hãng";
                  // 
                  // CbBrandFilter
                  // 
                  this.CbBrandFilter.FormattingEnabled = true;
                  this.CbBrandFilter.Location = new System.Drawing.Point(642, 26);
                  this.CbBrandFilter.Name = "CbBrandFilter";
                  this.CbBrandFilter.Size = new System.Drawing.Size(236, 30);
                  this.CbBrandFilter.TabIndex = 6;
                  // 
                  // ChkIsSale
                  // 
                  this.ChkIsSale.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.ChkIsSale.Location = new System.Drawing.Point(967, 32);
                  this.ChkIsSale.Name = "ChkIsSale";
                  this.ChkIsSale.Size = new System.Drawing.Size(186, 35);
                  this.ChkIsSale.TabIndex = 5;
                  this.ChkIsSale.Text = "Đang khuyến mãi";
                  this.ChkIsSale.UseVisualStyleBackColor = true;
                  // 
                  // BtnFilter
                  // 
                  this.BtnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
                  this.BtnFilter.Location = new System.Drawing.Point(1210, 29);
                  this.BtnFilter.Name = "BtnFilter";
                  this.BtnFilter.Size = new System.Drawing.Size(129, 39);
                  this.BtnFilter.TabIndex = 4;
                  this.BtnFilter.Text = "Lọc";
                  this.BtnFilter.UseVisualStyleBackColor = true;
                  this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
                  // 
                  // label2
                  // 
                  this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.label2.Location = new System.Drawing.Point(24, 85);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(100, 30);
                  this.label2.TabIndex = 3;
                  this.label2.Text = "Tên máy";
                  this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // TbNameFilter
                  // 
                  this.TbNameFilter.Location = new System.Drawing.Point(152, 85);
                  this.TbNameFilter.Name = "TbNameFilter";
                  this.TbNameFilter.Size = new System.Drawing.Size(298, 30);
                  this.TbNameFilter.TabIndex = 2;
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
                  this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cart});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Size = new System.Drawing.Size(1391, 36);
                  this.menuStrip1.TabIndex = 5;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // Cart
                  // 
                  this.Cart.BackColor = System.Drawing.Color.LightSkyBlue;
                  this.Cart.Font = new System.Drawing.Font("Segoe UI", 12F);
                  this.Cart.Name = "Cart";
                  this.Cart.Size = new System.Drawing.Size(148, 32);
                  this.Cart.Text = "Xem giỏ hàng";
                  this.Cart.Click += new System.EventHandler(this.Cart_Click);
                  // 
                  // BuyLaptop
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.BackColor = System.Drawing.Color.SkyBlue;
                  this.ClientSize = new System.Drawing.Size(1391, 741);
                  this.Controls.Add(this.FilterContainer);
                  this.Controls.Add(this.LaptopInfoContainer);
                  this.Controls.Add(this.DgvLaptops);
                  this.Controls.Add(this.LbTitle);
                  this.Controls.Add(this.menuStrip1);
                  this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.MainMenuStrip = this.menuStrip1;
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "BuyLaptop";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "Mua Laptop";
                  this.Load += new System.EventHandler(this.BuyLaptop_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.DgvLaptops)).EndInit();
                  this.LaptopInfoContainer.ResumeLayout(false);
                  this.LaptopInfoContainer.PerformLayout();
                  this.FilterContainer.ResumeLayout(false);
                  this.FilterContainer.PerformLayout();
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.DataGridView DgvLaptops;
        private System.Windows.Forms.GroupBox LaptopInfoContainer;
        private System.Windows.Forms.GroupBox FilterContainer;
        private System.Windows.Forms.CheckBox ChkIsSale;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNameFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbBrandFilter;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbLaptopPrice;
        private System.Windows.Forms.TextBox TbLaptopCategory;
        private System.Windows.Forms.TextBox TbLaptopName;
        private System.Windows.Forms.TextBox TbLaptopID;
        private System.Windows.Forms.TextBox TbIdFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ChkIsInStock;
        private System.Windows.Forms.TextBox TbBuyQuantity;
        private System.Windows.Forms.TextBox TbSale;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cart;
            private System.Windows.Forms.DataGridViewTextBoxColumn LaptopIDCell;
            private System.Windows.Forms.DataGridViewTextBoxColumn LaptopNameCell;
            private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCell;
            private System.Windows.Forms.DataGridViewTextBoxColumn SellPriceCell;
            private System.Windows.Forms.DataGridViewTextBoxColumn SaleCell;
            private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCell;
      }
}