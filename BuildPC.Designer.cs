namespace Final {
    partial class BuildPC {
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
            this.DgvAccessory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbAccessoryPrice = new System.Windows.Forms.TextBox();
            this.TbAccessoryBrand = new System.Windows.Forms.TextBox();
            this.TbAccessoryCategory = new System.Windows.Forms.TextBox();
            this.TbAccessoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTitle = new System.Windows.Forms.Label();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CartActions = new System.Windows.Forms.ToolStripMenuItem();
            this.CbxBrand = new System.Windows.Forms.ComboBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnAddToCart = new System.Windows.Forms.Button();
            this.TbNameFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAccessory
            // 
            this.DgvAccessory.AllowUserToAddRows = false;
            this.DgvAccessory.AllowUserToDeleteRows = false;
            this.DgvAccessory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccessory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvAccessory.Location = new System.Drawing.Point(506, 200);
            this.DgvAccessory.Name = "DgvAccessory";
            this.DgvAccessory.ReadOnly = true;
            this.DgvAccessory.RowHeadersWidth = 51;
            this.DgvAccessory.RowTemplate.Height = 24;
            this.DgvAccessory.Size = new System.Drawing.Size(1010, 523);
            this.DgvAccessory.TabIndex = 0;
            this.DgvAccessory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccessory_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã linh kiện";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên linh kiện";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại linh kiện";
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
            // Column6
            // 
            this.Column6.HeaderText = "Số lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Khuyến mãi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbAccessoryPrice);
            this.groupBox1.Controls.Add(this.TbAccessoryBrand);
            this.groupBox1.Controls.Add(this.TbAccessoryCategory);
            this.groupBox1.Controls.Add(this.TbAccessoryName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbSale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin linh kiện";
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(181, 364);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.ReadOnly = true;
            this.TbQuantity.Size = new System.Drawing.Size(271, 30);
            this.TbQuantity.TabIndex = 11;
            this.TbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng";
            // 
            // TbAccessoryPrice
            // 
            this.TbAccessoryPrice.Location = new System.Drawing.Point(181, 289);
            this.TbAccessoryPrice.Name = "TbAccessoryPrice";
            this.TbAccessoryPrice.ReadOnly = true;
            this.TbAccessoryPrice.Size = new System.Drawing.Size(271, 30);
            this.TbAccessoryPrice.TabIndex = 9;
            this.TbAccessoryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbAccessoryBrand
            // 
            this.TbAccessoryBrand.Location = new System.Drawing.Point(181, 211);
            this.TbAccessoryBrand.Name = "TbAccessoryBrand";
            this.TbAccessoryBrand.ReadOnly = true;
            this.TbAccessoryBrand.Size = new System.Drawing.Size(271, 30);
            this.TbAccessoryBrand.TabIndex = 8;
            this.TbAccessoryBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbAccessoryCategory
            // 
            this.TbAccessoryCategory.Location = new System.Drawing.Point(181, 132);
            this.TbAccessoryCategory.Name = "TbAccessoryCategory";
            this.TbAccessoryCategory.ReadOnly = true;
            this.TbAccessoryCategory.Size = new System.Drawing.Size(271, 30);
            this.TbAccessoryCategory.TabIndex = 7;
            this.TbAccessoryCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbAccessoryName
            // 
            this.TbAccessoryName.Location = new System.Drawing.Point(181, 60);
            this.TbAccessoryName.Name = "TbAccessoryName";
            this.TbAccessoryName.ReadOnly = true;
            this.TbAccessoryName.Size = new System.Drawing.Size(271, 30);
            this.TbAccessoryName.TabIndex = 6;
            this.TbAccessoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hãng";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại linh kiện";
            // 
            // TbSale
            // 
            this.TbSale.Location = new System.Drawing.Point(181, 429);
            this.TbSale.Name = "TbSale";
            this.TbSale.ReadOnly = true;
            this.TbSale.Size = new System.Drawing.Size(271, 30);
            this.TbSale.TabIndex = 0;
            this.TbSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khuyến mãi";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên linh kiện";
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LbTitle.Location = new System.Drawing.Point(579, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(347, 53);
            this.LbTitle.TabIndex = 2;
            this.LbTitle.Text = "Shop Máy Tính PC88";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxCategory
            // 
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.Location = new System.Drawing.Point(1117, 152);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(257, 30);
            this.CbxCategory.TabIndex = 3;
            this.CbxCategory.Text = "Loại linh kiện";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CartActions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1526, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CartActions
            // 
            this.CartActions.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartActions.Name = "CartActions";
            this.CartActions.Size = new System.Drawing.Size(93, 26);
            this.CartActions.Text = "Giỏ hàng";
            this.CartActions.Click += new System.EventHandler(this.CartActions_Click);
            // 
            // CbxBrand
            // 
            this.CbxBrand.FormattingEnabled = true;
            this.CbxBrand.Location = new System.Drawing.Point(815, 152);
            this.CbxBrand.Name = "CbxBrand";
            this.CbxBrand.Size = new System.Drawing.Size(257, 30);
            this.CbxBrand.TabIndex = 5;
            this.CbxBrand.Text = "Hãng";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(1406, 152);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(110, 30);
            this.BtnFilter.TabIndex = 6;
            this.BtnFilter.Text = "Lọc";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.Location = new System.Drawing.Point(333, 682);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(167, 40);
            this.BtnAddToCart.TabIndex = 7;
            this.BtnAddToCart.Text = "Thêm vào giỏ hàng";
            this.BtnAddToCart.UseVisualStyleBackColor = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // TbNameFilter
            // 
            this.TbNameFilter.Location = new System.Drawing.Point(506, 152);
            this.TbNameFilter.Name = "TbNameFilter";
            this.TbNameFilter.Size = new System.Drawing.Size(257, 30);
            this.TbNameFilter.TabIndex = 8;
            this.TbNameFilter.Text = "Tên linh kiện";
            // 
            // BuildPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 735);
            this.Controls.Add(this.TbNameFilter);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.CbxBrand);
            this.Controls.Add(this.CbxCategory);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvAccessory);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuildPC";
            this.Load += new System.EventHandler(this.BuildPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAccessory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.ComboBox CbxCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CartActions;
        private System.Windows.Forms.TextBox TbSale;
        private System.Windows.Forms.ComboBox CbxBrand;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbAccessoryPrice;
        private System.Windows.Forms.TextBox TbAccessoryBrand;
        private System.Windows.Forms.TextBox TbAccessoryCategory;
        private System.Windows.Forms.TextBox TbAccessoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddToCart;
        private System.Windows.Forms.TextBox TbNameFilter;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.Label label6;
    }
}