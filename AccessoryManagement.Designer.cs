namespace Final {
    partial class AccessoryManagement {
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
                  System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
                  this.DgvAccessories = new System.Windows.Forms.DataGridView();
                  this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.AccessoryInfoContainer = new System.Windows.Forms.GroupBox();
                  this.button1 = new System.Windows.Forms.Button();
                  this.BtnDelete = new System.Windows.Forms.Button();
                  this.TbQuantity = new System.Windows.Forms.TextBox();
                  this.BtnEdit = new System.Windows.Forms.Button();
                  this.TbSale = new System.Windows.Forms.TextBox();
                  this.CbxAccessoryBrand = new System.Windows.Forms.ComboBox();
                  this.TbPrice = new System.Windows.Forms.TextBox();
                  this.label7 = new System.Windows.Forms.Label();
                  this.CbxAccessoryCategory = new System.Windows.Forms.ComboBox();
                  this.TbAccessoryName = new System.Windows.Forms.TextBox();
                  this.TbAccessoryID = new System.Windows.Forms.TextBox();
                  this.label6 = new System.Windows.Forms.Label();
                  this.label5 = new System.Windows.Forms.Label();
                  this.label4 = new System.Windows.Forms.Label();
                  this.label3 = new System.Windows.Forms.Label();
                  this.label2 = new System.Windows.Forms.Label();
                  this.label1 = new System.Windows.Forms.Label();
                  this.BtnSearch = new System.Windows.Forms.Button();
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.ChkIsSale = new System.Windows.Forms.CheckBox();
                  this.ChkIsInStock = new System.Windows.Forms.CheckBox();
                  this.BtnCancel = new System.Windows.Forms.Button();
                  this.CbxCategoryFilter = new System.Windows.Forms.ComboBox();
                  this.label8 = new System.Windows.Forms.Label();
                  this.CbxBrandFilter = new System.Windows.Forms.ComboBox();
                  this.TbNameFilter = new System.Windows.Forms.TextBox();
                  this.TbIdFilter = new System.Windows.Forms.TextBox();
                  this.label11 = new System.Windows.Forms.Label();
                  this.label12 = new System.Windows.Forms.Label();
                  this.label14 = new System.Windows.Forms.Label();
                  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
                  this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                  this.AccessoryBrandManagement = new System.Windows.Forms.ToolStripMenuItem();
                  this.AccessoryCategoryManagement = new System.Windows.Forms.ToolStripMenuItem();
                  ((System.ComponentModel.ISupportInitialize)(this.DgvAccessories)).BeginInit();
                  this.AccessoryInfoContainer.SuspendLayout();
                  this.groupBox1.SuspendLayout();
                  this.menuStrip1.SuspendLayout();
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
                  this.DgvAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.DgvAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
                  dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                  dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
                  dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                  dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
                  dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                  dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                  this.DgvAccessories.DefaultCellStyle = dataGridViewCellStyle3;
                  this.DgvAccessories.Location = new System.Drawing.Point(457, 254);
                  this.DgvAccessories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.DgvAccessories.Name = "DgvAccessories";
                  this.DgvAccessories.ReadOnly = true;
                  this.DgvAccessories.RowHeadersWidth = 51;
                  this.DgvAccessories.RowTemplate.Height = 24;
                  this.DgvAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  this.DgvAccessories.Size = new System.Drawing.Size(834, 523);
                  this.DgvAccessories.TabIndex = 1;
                  this.DgvAccessories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccessories_CellContentClick);
                  // 
                  // Column1
                  // 
                  this.Column1.HeaderText = "Mã phụ kiện";
                  this.Column1.MinimumWidth = 6;
                  this.Column1.Name = "Column1";
                  this.Column1.ReadOnly = true;
                  // 
                  // Column2
                  // 
                  this.Column2.HeaderText = "Tên phụ kiện";
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
                  // Column5
                  // 
                  this.Column5.HeaderText = "Loại phụ kiện";
                  this.Column5.MinimumWidth = 6;
                  this.Column5.Name = "Column5";
                  this.Column5.ReadOnly = true;
                  // 
                  // Column6
                  // 
                  this.Column6.HeaderText = "Giá bán";
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
                  // Column8
                  // 
                  this.Column8.HeaderText = "Số lượng";
                  this.Column8.MinimumWidth = 6;
                  this.Column8.Name = "Column8";
                  this.Column8.ReadOnly = true;
                  // 
                  // AccessoryInfoContainer
                  // 
                  this.AccessoryInfoContainer.Controls.Add(this.button1);
                  this.AccessoryInfoContainer.Controls.Add(this.BtnDelete);
                  this.AccessoryInfoContainer.Controls.Add(this.TbQuantity);
                  this.AccessoryInfoContainer.Controls.Add(this.BtnEdit);
                  this.AccessoryInfoContainer.Controls.Add(this.TbSale);
                  this.AccessoryInfoContainer.Controls.Add(this.CbxAccessoryBrand);
                  this.AccessoryInfoContainer.Controls.Add(this.TbPrice);
                  this.AccessoryInfoContainer.Controls.Add(this.label7);
                  this.AccessoryInfoContainer.Controls.Add(this.CbxAccessoryCategory);
                  this.AccessoryInfoContainer.Controls.Add(this.TbAccessoryName);
                  this.AccessoryInfoContainer.Controls.Add(this.TbAccessoryID);
                  this.AccessoryInfoContainer.Controls.Add(this.label6);
                  this.AccessoryInfoContainer.Controls.Add(this.label5);
                  this.AccessoryInfoContainer.Controls.Add(this.label4);
                  this.AccessoryInfoContainer.Controls.Add(this.label3);
                  this.AccessoryInfoContainer.Controls.Add(this.label2);
                  this.AccessoryInfoContainer.Controls.Add(this.label1);
                  this.AccessoryInfoContainer.Location = new System.Drawing.Point(11, 254);
                  this.AccessoryInfoContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.AccessoryInfoContainer.Name = "AccessoryInfoContainer";
                  this.AccessoryInfoContainer.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.AccessoryInfoContainer.Size = new System.Drawing.Size(442, 523);
                  this.AccessoryInfoContainer.TabIndex = 2;
                  this.AccessoryInfoContainer.TabStop = false;
                  this.AccessoryInfoContainer.Text = "Thông tin phụ kiện";
                  // 
                  // button1
                  // 
                  this.button1.Image = global::Final.Properties.Resources.icons8_refresh_32;
                  this.button1.Location = new System.Drawing.Point(18, 464);
                  this.button1.Name = "button1";
                  this.button1.Size = new System.Drawing.Size(41, 42);
                  this.button1.TabIndex = 14;
                  this.button1.UseVisualStyleBackColor = true;
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // BtnDelete
                  // 
                  this.BtnDelete.Image = global::Final.Properties.Resources.icons8_delete_32;
                  this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                  this.BtnDelete.Location = new System.Drawing.Point(340, 464);
                  this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.BtnDelete.Name = "BtnDelete";
                  this.BtnDelete.Size = new System.Drawing.Size(83, 42);
                  this.BtnDelete.TabIndex = 6;
                  this.BtnDelete.Text = "Xoá";
                  this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.BtnDelete.UseVisualStyleBackColor = true;
                  this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
                  // 
                  // TbQuantity
                  // 
                  this.TbQuantity.Location = new System.Drawing.Point(159, 414);
                  this.TbQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbQuantity.Name = "TbQuantity";
                  this.TbQuantity.Size = new System.Drawing.Size(264, 30);
                  this.TbQuantity.TabIndex = 13;
                  this.TbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // BtnEdit
                  // 
                  this.BtnEdit.Image = global::Final.Properties.Resources.icons8_update_32;
                  this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                  this.BtnEdit.Location = new System.Drawing.Point(159, 464);
                  this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.BtnEdit.Name = "BtnEdit";
                  this.BtnEdit.Size = new System.Drawing.Size(119, 42);
                  this.BtnEdit.TabIndex = 5;
                  this.BtnEdit.Text = "Cập nhật";
                  this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.BtnEdit.UseVisualStyleBackColor = true;
                  this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
                  // 
                  // TbSale
                  // 
                  this.TbSale.Location = new System.Drawing.Point(159, 354);
                  this.TbSale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbSale.Name = "TbSale";
                  this.TbSale.Size = new System.Drawing.Size(264, 30);
                  this.TbSale.TabIndex = 12;
                  this.TbSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // CbxAccessoryBrand
                  // 
                  this.CbxAccessoryBrand.FormattingEnabled = true;
                  this.CbxAccessoryBrand.Location = new System.Drawing.Point(159, 169);
                  this.CbxAccessoryBrand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.CbxAccessoryBrand.Name = "CbxAccessoryBrand";
                  this.CbxAccessoryBrand.Size = new System.Drawing.Size(264, 30);
                  this.CbxAccessoryBrand.TabIndex = 11;
                  // 
                  // TbPrice
                  // 
                  this.TbPrice.Location = new System.Drawing.Point(159, 293);
                  this.TbPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbPrice.Name = "TbPrice";
                  this.TbPrice.Size = new System.Drawing.Size(264, 30);
                  this.TbPrice.TabIndex = 10;
                  this.TbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // label7
                  // 
                  this.label7.Location = new System.Drawing.Point(14, 50);
                  this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label7.Name = "label7";
                  this.label7.Size = new System.Drawing.Size(109, 28);
                  this.label7.TabIndex = 9;
                  this.label7.Text = "Mã linh kiện";
                  // 
                  // CbxAccessoryCategory
                  // 
                  this.CbxAccessoryCategory.FormattingEnabled = true;
                  this.CbxAccessoryCategory.Location = new System.Drawing.Point(159, 232);
                  this.CbxAccessoryCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.CbxAccessoryCategory.Name = "CbxAccessoryCategory";
                  this.CbxAccessoryCategory.Size = new System.Drawing.Size(264, 30);
                  this.CbxAccessoryCategory.TabIndex = 8;
                  // 
                  // TbAccessoryName
                  // 
                  this.TbAccessoryName.Location = new System.Drawing.Point(159, 107);
                  this.TbAccessoryName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbAccessoryName.Name = "TbAccessoryName";
                  this.TbAccessoryName.Size = new System.Drawing.Size(264, 30);
                  this.TbAccessoryName.TabIndex = 7;
                  this.TbAccessoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // TbAccessoryID
                  // 
                  this.TbAccessoryID.Location = new System.Drawing.Point(159, 47);
                  this.TbAccessoryID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbAccessoryID.Name = "TbAccessoryID";
                  this.TbAccessoryID.Size = new System.Drawing.Size(264, 30);
                  this.TbAccessoryID.TabIndex = 6;
                  this.TbAccessoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // label6
                  // 
                  this.label6.Location = new System.Drawing.Point(14, 417);
                  this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label6.Name = "label6";
                  this.label6.Size = new System.Drawing.Size(109, 28);
                  this.label6.TabIndex = 5;
                  this.label6.Text = "Số lượng";
                  // 
                  // label5
                  // 
                  this.label5.Location = new System.Drawing.Point(14, 357);
                  this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label5.Name = "label5";
                  this.label5.Size = new System.Drawing.Size(109, 28);
                  this.label5.TabIndex = 4;
                  this.label5.Text = "Khuyến mãi";
                  // 
                  // label4
                  // 
                  this.label4.Location = new System.Drawing.Point(14, 232);
                  this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label4.Name = "label4";
                  this.label4.Size = new System.Drawing.Size(109, 28);
                  this.label4.TabIndex = 3;
                  this.label4.Text = "Loại linh kiện";
                  // 
                  // label3
                  // 
                  this.label3.Location = new System.Drawing.Point(14, 169);
                  this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label3.Name = "label3";
                  this.label3.Size = new System.Drawing.Size(109, 28);
                  this.label3.TabIndex = 2;
                  this.label3.Text = "Hãng";
                  // 
                  // label2
                  // 
                  this.label2.Location = new System.Drawing.Point(14, 296);
                  this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(109, 28);
                  this.label2.TabIndex = 1;
                  this.label2.Text = "Giá bán";
                  // 
                  // label1
                  // 
                  this.label1.Location = new System.Drawing.Point(13, 107);
                  this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(109, 28);
                  this.label1.TabIndex = 0;
                  this.label1.Text = "Tên linh kiện";
                  // 
                  // BtnSearch
                  // 
                  this.BtnSearch.Location = new System.Drawing.Point(1138, 50);
                  this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.BtnSearch.Name = "BtnSearch";
                  this.BtnSearch.Size = new System.Drawing.Size(120, 35);
                  this.BtnSearch.TabIndex = 4;
                  this.BtnSearch.Text = "Tìm kiếm";
                  this.BtnSearch.UseVisualStyleBackColor = true;
                  this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Controls.Add(this.ChkIsSale);
                  this.groupBox1.Controls.Add(this.ChkIsInStock);
                  this.groupBox1.Controls.Add(this.BtnCancel);
                  this.groupBox1.Controls.Add(this.CbxCategoryFilter);
                  this.groupBox1.Controls.Add(this.BtnSearch);
                  this.groupBox1.Controls.Add(this.label8);
                  this.groupBox1.Controls.Add(this.CbxBrandFilter);
                  this.groupBox1.Controls.Add(this.TbNameFilter);
                  this.groupBox1.Controls.Add(this.TbIdFilter);
                  this.groupBox1.Controls.Add(this.label11);
                  this.groupBox1.Controls.Add(this.label12);
                  this.groupBox1.Controls.Add(this.label14);
                  this.groupBox1.Location = new System.Drawing.Point(11, 48);
                  this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.groupBox1.Size = new System.Drawing.Size(1280, 180);
                  this.groupBox1.TabIndex = 14;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "Tìm kiếm phụ kiện";
                  // 
                  // ChkIsSale
                  // 
                  this.ChkIsSale.AutoSize = true;
                  this.ChkIsSale.Location = new System.Drawing.Point(946, 112);
                  this.ChkIsSale.Name = "ChkIsSale";
                  this.ChkIsSale.Size = new System.Drawing.Size(170, 26);
                  this.ChkIsSale.TabIndex = 14;
                  this.ChkIsSale.Text = "Đang khuyến mãi";
                  this.ChkIsSale.UseVisualStyleBackColor = true;
                  // 
                  // ChkIsInStock
                  // 
                  this.ChkIsInStock.AutoSize = true;
                  this.ChkIsInStock.Location = new System.Drawing.Point(946, 49);
                  this.ChkIsInStock.Name = "ChkIsInStock";
                  this.ChkIsInStock.Size = new System.Drawing.Size(111, 26);
                  this.ChkIsInStock.TabIndex = 13;
                  this.ChkIsInStock.Text = "Còn hàng";
                  this.ChkIsInStock.UseVisualStyleBackColor = true;
                  // 
                  // BtnCancel
                  // 
                  this.BtnCancel.Location = new System.Drawing.Point(1138, 105);
                  this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.BtnCancel.Name = "BtnCancel";
                  this.BtnCancel.Size = new System.Drawing.Size(120, 38);
                  this.BtnCancel.TabIndex = 12;
                  this.BtnCancel.Text = "Huỷ";
                  this.BtnCancel.UseVisualStyleBackColor = true;
                  this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
                  // 
                  // CbxCategoryFilter
                  // 
                  this.CbxCategoryFilter.FormattingEnabled = true;
                  this.CbxCategoryFilter.Location = new System.Drawing.Point(636, 110);
                  this.CbxCategoryFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.CbxCategoryFilter.Name = "CbxCategoryFilter";
                  this.CbxCategoryFilter.Size = new System.Drawing.Size(264, 30);
                  this.CbxCategoryFilter.TabIndex = 11;
                  // 
                  // label8
                  // 
                  this.label8.Location = new System.Drawing.Point(14, 50);
                  this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label8.Name = "label8";
                  this.label8.Size = new System.Drawing.Size(109, 28);
                  this.label8.TabIndex = 9;
                  this.label8.Text = "Mã phụ kiện";
                  // 
                  // CbxBrandFilter
                  // 
                  this.CbxBrandFilter.FormattingEnabled = true;
                  this.CbxBrandFilter.Location = new System.Drawing.Point(636, 47);
                  this.CbxBrandFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.CbxBrandFilter.Name = "CbxBrandFilter";
                  this.CbxBrandFilter.Size = new System.Drawing.Size(264, 30);
                  this.CbxBrandFilter.TabIndex = 8;
                  // 
                  // TbNameFilter
                  // 
                  this.TbNameFilter.Location = new System.Drawing.Point(159, 107);
                  this.TbNameFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbNameFilter.Name = "TbNameFilter";
                  this.TbNameFilter.Size = new System.Drawing.Size(264, 30);
                  this.TbNameFilter.TabIndex = 7;
                  this.TbNameFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // TbIdFilter
                  // 
                  this.TbIdFilter.Location = new System.Drawing.Point(159, 47);
                  this.TbIdFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                  this.TbIdFilter.Name = "TbIdFilter";
                  this.TbIdFilter.Size = new System.Drawing.Size(264, 30);
                  this.TbIdFilter.TabIndex = 6;
                  this.TbIdFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // label11
                  // 
                  this.label11.Location = new System.Drawing.Point(514, 112);
                  this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label11.Name = "label11";
                  this.label11.Size = new System.Drawing.Size(118, 28);
                  this.label11.TabIndex = 3;
                  this.label11.Text = "Loại phụ kiện kiện";
                  // 
                  // label12
                  // 
                  this.label12.Location = new System.Drawing.Point(514, 47);
                  this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label12.Name = "label12";
                  this.label12.Size = new System.Drawing.Size(109, 31);
                  this.label12.TabIndex = 2;
                  this.label12.Text = "Hãng";
                  // 
                  // label14
                  // 
                  this.label14.Location = new System.Drawing.Point(13, 107);
                  this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                  this.label14.Name = "label14";
                  this.label14.Size = new System.Drawing.Size(109, 28);
                  this.label14.TabIndex = 0;
                  this.label14.Text = "Tên phụ kiện";
                  // 
                  // menuStrip1
                  // 
                  this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
                  this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
                  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
                  this.menuStrip1.Name = "menuStrip1";
                  this.menuStrip1.Size = new System.Drawing.Size(1302, 30);
                  this.menuStrip1.TabIndex = 15;
                  this.menuStrip1.Text = "menuStrip1";
                  // 
                  // chứcNăngToolStripMenuItem
                  // 
                  this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccessoryBrandManagement,
            this.AccessoryCategoryManagement});
                  this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
                  this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
                  this.chứcNăngToolStripMenuItem.Text = "Chức năng";
                  // 
                  // AccessoryBrandManagement
                  // 
                  this.AccessoryBrandManagement.Name = "AccessoryBrandManagement";
                  this.AccessoryBrandManagement.Size = new System.Drawing.Size(254, 26);
                  this.AccessoryBrandManagement.Text = "Quản lý hãng";
                  this.AccessoryBrandManagement.Click += new System.EventHandler(this.AccessoryBrandManagement_Click);
                  // 
                  // AccessoryCategoryManagement
                  // 
                  this.AccessoryCategoryManagement.Name = "AccessoryCategoryManagement";
                  this.AccessoryCategoryManagement.Size = new System.Drawing.Size(254, 26);
                  this.AccessoryCategoryManagement.Text = "Quản lý loại phụ kiện";
                  this.AccessoryCategoryManagement.Click += new System.EventHandler(this.AccessoryCategoryManagement_Click);
                  // 
                  // AccessoryManagement
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.BackColor = System.Drawing.Color.SkyBlue;
                  this.ClientSize = new System.Drawing.Size(1302, 781);
                  this.Controls.Add(this.groupBox1);
                  this.Controls.Add(this.AccessoryInfoContainer);
                  this.Controls.Add(this.DgvAccessories);
                  this.Controls.Add(this.menuStrip1);
                  this.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                  this.MainMenuStrip = this.menuStrip1;
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "AccessoryManagement";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "Quản lý kho phụ kiện";
                  this.Load += new System.EventHandler(this.AccessoryManagement_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.DgvAccessories)).EndInit();
                  this.AccessoryInfoContainer.ResumeLayout(false);
                  this.AccessoryInfoContainer.PerformLayout();
                  this.groupBox1.ResumeLayout(false);
                  this.groupBox1.PerformLayout();
                  this.menuStrip1.ResumeLayout(false);
                  this.menuStrip1.PerformLayout();
                  this.ResumeLayout(false);
                  this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAccessories;
        private System.Windows.Forms.GroupBox AccessoryInfoContainer;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.TextBox TbSale;
        private System.Windows.Forms.ComboBox CbxAccessoryBrand;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxAccessoryCategory;
        private System.Windows.Forms.TextBox TbAccessoryName;
        private System.Windows.Forms.TextBox TbAccessoryID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbxCategoryFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxBrandFilter;
        private System.Windows.Forms.TextBox TbNameFilter;
        private System.Windows.Forms.TextBox TbIdFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ChkIsSale;
        private System.Windows.Forms.CheckBox ChkIsInStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccessoryBrandManagement;
        private System.Windows.Forms.ToolStripMenuItem AccessoryCategoryManagement;
        private System.Windows.Forms.Button button1;
    }
}