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
            this.LbTime = new System.Windows.Forms.Label();
            this.LbTitle = new System.Windows.Forms.Label();
            this.DgvLaptops = new System.Windows.Forms.DataGridView();
            this.LaptopNameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaptopIDCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPriceCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaptopInfoContainer = new System.Windows.Forms.GroupBox();
            this.TbSalePercent = new System.Windows.Forms.TextBox();
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
            this.TbLaptopIdFilter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxPriceRange = new System.Windows.Forms.ComboBox();
            this.CbIsSale = new System.Windows.Forms.CheckBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbLaptopNameFilter = new System.Windows.Forms.TextBox();
            this.MenuFuntion = new System.Windows.Forms.MenuStrip();
            this.ChooseFunctionStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCartAction = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLaptops)).BeginInit();
            this.LaptopInfoContainer.SuspendLayout();
            this.FilterContainer.SuspendLayout();
            this.MenuFuntion.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbTime
            // 
            this.LbTime.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.Location = new System.Drawing.Point(1109, 9);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(345, 47);
            this.LbTime.TabIndex = 0;
            this.LbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LbTitle.Location = new System.Drawing.Point(597, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(347, 53);
            this.LbTitle.TabIndex = 1;
            this.LbTitle.Text = "Shop Máy Tính PC88";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvLaptops
            // 
            this.DgvLaptops.AllowUserToAddRows = false;
            this.DgvLaptops.AllowUserToDeleteRows = false;
            this.DgvLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLaptops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaptopNameCell,
            this.LaptopIDCell,
            this.CategoryCell,
            this.SellPriceCell,
            this.SaleCell,
            this.QuantityCell});
            this.DgvLaptops.Location = new System.Drawing.Point(605, 243);
            this.DgvLaptops.Name = "DgvLaptops";
            this.DgvLaptops.ReadOnly = true;
            this.DgvLaptops.RowHeadersWidth = 51;
            this.DgvLaptops.RowTemplate.Height = 24;
            this.DgvLaptops.Size = new System.Drawing.Size(849, 468);
            this.DgvLaptops.TabIndex = 2;
            this.DgvLaptops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLaptops_CellContentClick);
            // 
            // LaptopNameCell
            // 
            this.LaptopNameCell.HeaderText = "Tên máy";
            this.LaptopNameCell.MinimumWidth = 6;
            this.LaptopNameCell.Name = "LaptopNameCell";
            this.LaptopNameCell.ReadOnly = true;
            this.LaptopNameCell.Width = 125;
            // 
            // LaptopIDCell
            // 
            this.LaptopIDCell.HeaderText = "Mã máy";
            this.LaptopIDCell.MinimumWidth = 6;
            this.LaptopIDCell.Name = "LaptopIDCell";
            this.LaptopIDCell.ReadOnly = true;
            this.LaptopIDCell.Width = 125;
            // 
            // CategoryCell
            // 
            this.CategoryCell.HeaderText = "Hãng";
            this.CategoryCell.MinimumWidth = 6;
            this.CategoryCell.Name = "CategoryCell";
            this.CategoryCell.ReadOnly = true;
            this.CategoryCell.Width = 125;
            // 
            // SellPriceCell
            // 
            this.SellPriceCell.HeaderText = "Giá bán";
            this.SellPriceCell.MinimumWidth = 6;
            this.SellPriceCell.Name = "SellPriceCell";
            this.SellPriceCell.ReadOnly = true;
            this.SellPriceCell.Width = 125;
            // 
            // SaleCell
            // 
            this.SaleCell.HeaderText = "Khuyến mãi";
            this.SaleCell.MinimumWidth = 6;
            this.SaleCell.Name = "SaleCell";
            this.SaleCell.ReadOnly = true;
            this.SaleCell.Width = 125;
            // 
            // QuantityCell
            // 
            this.QuantityCell.HeaderText = "Số lượng";
            this.QuantityCell.MinimumWidth = 6;
            this.QuantityCell.Name = "QuantityCell";
            this.QuantityCell.ReadOnly = true;
            this.QuantityCell.Width = 125;
            // 
            // LaptopInfoContainer
            // 
            this.LaptopInfoContainer.Controls.Add(this.TbSalePercent);
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
            this.LaptopInfoContainer.Size = new System.Drawing.Size(587, 407);
            this.LaptopInfoContainer.TabIndex = 3;
            this.LaptopInfoContainer.TabStop = false;
            this.LaptopInfoContainer.Text = "Thông tin Laptop";
            // 
            // TbSalePercent
            // 
            this.TbSalePercent.Location = new System.Drawing.Point(203, 357);
            this.TbSalePercent.Name = "TbSalePercent";
            this.TbSalePercent.ReadOnly = true;
            this.TbSalePercent.Size = new System.Drawing.Size(334, 30);
            this.TbSalePercent.TabIndex = 8;
            this.TbSalePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbLaptopPrice
            // 
            this.TbLaptopPrice.Location = new System.Drawing.Point(203, 271);
            this.TbLaptopPrice.Name = "TbLaptopPrice";
            this.TbLaptopPrice.ReadOnly = true;
            this.TbLaptopPrice.Size = new System.Drawing.Size(334, 30);
            this.TbLaptopPrice.TabIndex = 7;
            this.TbLaptopPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbLaptopCategory
            // 
            this.TbLaptopCategory.Location = new System.Drawing.Point(203, 191);
            this.TbLaptopCategory.Name = "TbLaptopCategory";
            this.TbLaptopCategory.ReadOnly = true;
            this.TbLaptopCategory.Size = new System.Drawing.Size(334, 30);
            this.TbLaptopCategory.TabIndex = 6;
            this.TbLaptopCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbLaptopName
            // 
            this.TbLaptopName.Location = new System.Drawing.Point(203, 120);
            this.TbLaptopName.Name = "TbLaptopName";
            this.TbLaptopName.ReadOnly = true;
            this.TbLaptopName.Size = new System.Drawing.Size(334, 30);
            this.TbLaptopName.TabIndex = 5;
            this.TbLaptopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbLaptopID
            // 
            this.TbLaptopID.Location = new System.Drawing.Point(203, 50);
            this.TbLaptopID.Name = "TbLaptopID";
            this.TbLaptopID.ReadOnly = true;
            this.TbLaptopID.Size = new System.Drawing.Size(334, 30);
            this.TbLaptopID.TabIndex = 4;
            this.TbLaptopID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá bán";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hãng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Khuyến mãi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên máy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã máy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterContainer
            // 
            this.FilterContainer.Controls.Add(this.TbLaptopIdFilter);
            this.FilterContainer.Controls.Add(this.label9);
            this.FilterContainer.Controls.Add(this.BtnCancel);
            this.FilterContainer.Controls.Add(this.label3);
            this.FilterContainer.Controls.Add(this.CbxPriceRange);
            this.FilterContainer.Controls.Add(this.CbIsSale);
            this.FilterContainer.Controls.Add(this.BtnFilter);
            this.FilterContainer.Controls.Add(this.label2);
            this.FilterContainer.Controls.Add(this.TbLaptopNameFilter);
            this.FilterContainer.Location = new System.Drawing.Point(12, 80);
            this.FilterContainer.Name = "FilterContainer";
            this.FilterContainer.Size = new System.Drawing.Size(1070, 141);
            this.FilterContainer.TabIndex = 4;
            this.FilterContainer.TabStop = false;
            this.FilterContainer.Text = "Lọc";
            this.FilterContainer.Enter += new System.EventHandler(this.FilterContainer_Enter);
            // 
            // TbLaptopIdFilter
            // 
            this.TbLaptopIdFilter.Location = new System.Drawing.Point(142, 27);
            this.TbLaptopIdFilter.Name = "TbLaptopIdFilter";
            this.TbLaptopIdFilter.Size = new System.Drawing.Size(298, 30);
            this.TbLaptopIdFilter.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã máy";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(928, 87);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(124, 39);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Huỷ";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(513, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khoảng giá";
            // 
            // CbxPriceRange
            // 
            this.CbxPriceRange.FormattingEnabled = true;
            this.CbxPriceRange.Items.AddRange(new object[] {
            "Dưới 15 triệu",
            "Từ 15 đến 20 triệu",
            "Từ 20 đến 30 triệu",
            "Trên 30 triệu"});
            this.CbxPriceRange.Location = new System.Drawing.Point(631, 30);
            this.CbxPriceRange.Name = "CbxPriceRange";
            this.CbxPriceRange.Size = new System.Drawing.Size(236, 30);
            this.CbxPriceRange.TabIndex = 6;
            // 
            // CbIsSale
            // 
            this.CbIsSale.Location = new System.Drawing.Point(517, 70);
            this.CbIsSale.Name = "CbIsSale";
            this.CbIsSale.Size = new System.Drawing.Size(186, 35);
            this.CbIsSale.TabIndex = 5;
            this.CbIsSale.Text = "Đang khuyến mãi";
            this.CbIsSale.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(928, 21);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(124, 39);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Lọc";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên máy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbLaptopNameFilter
            // 
            this.TbLaptopNameFilter.Location = new System.Drawing.Point(142, 70);
            this.TbLaptopNameFilter.Name = "TbLaptopNameFilter";
            this.TbLaptopNameFilter.Size = new System.Drawing.Size(298, 30);
            this.TbLaptopNameFilter.TabIndex = 2;
            // 
            // MenuFuntion
            // 
            this.MenuFuntion.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFuntion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuFuntion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseFunctionStrip});
            this.MenuFuntion.Location = new System.Drawing.Point(0, 0);
            this.MenuFuntion.Name = "MenuFuntion";
            this.MenuFuntion.Size = new System.Drawing.Size(1466, 30);
            this.MenuFuntion.TabIndex = 5;
            this.MenuFuntion.Text = "menuStrip1";
            // 
            // ChooseFunctionStrip
            // 
            this.ChooseFunctionStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterAction,
            this.ViewCartAction});
            this.ChooseFunctionStrip.Name = "ChooseFunctionStrip";
            this.ChooseFunctionStrip.Size = new System.Drawing.Size(108, 26);
            this.ChooseFunctionStrip.Text = "Chức năng";
            // 
            // FilterAction
            // 
            this.FilterAction.Name = "FilterAction";
            this.FilterAction.Size = new System.Drawing.Size(200, 26);
            this.FilterAction.Text = "Lọc sản phẩm";
            this.FilterAction.Click += new System.EventHandler(this.FilterAction_Click);
            // 
            // ViewCartAction
            // 
            this.ViewCartAction.Name = "ViewCartAction";
            this.ViewCartAction.Size = new System.Drawing.Size(200, 26);
            this.ViewCartAction.Text = "Xem giỏ hàng";
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(426, 664);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(172, 47);
            this.BtnAddToCart.TabIndex = 6;
            this.BtnAddToCart.Text = "Thêm vào giỏ hàng";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // BuyLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 741);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.FilterContainer);
            this.Controls.Add(this.LaptopInfoContainer);
            this.Controls.Add(this.DgvLaptops);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.MenuFuntion);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuFuntion;
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
            this.MenuFuntion.ResumeLayout(false);
            this.MenuFuntion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.DataGridView DgvLaptops;
        private System.Windows.Forms.GroupBox LaptopInfoContainer;
        private System.Windows.Forms.GroupBox FilterContainer;
        private System.Windows.Forms.CheckBox CbIsSale;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbLaptopNameFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxPriceRange;
        private System.Windows.Forms.MenuStrip MenuFuntion;
        private System.Windows.Forms.ToolStripMenuItem ChooseFunctionStrip;
        private System.Windows.Forms.ToolStripMenuItem FilterAction;
        private System.Windows.Forms.ToolStripMenuItem ViewCartAction;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbSalePercent;
        private System.Windows.Forms.TextBox TbLaptopPrice;
        private System.Windows.Forms.TextBox TbLaptopCategory;
        private System.Windows.Forms.TextBox TbLaptopName;
        private System.Windows.Forms.TextBox TbLaptopID;
        private System.Windows.Forms.TextBox TbLaptopIdFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaptopNameCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaptopIDCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPriceCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCell;
    }
}