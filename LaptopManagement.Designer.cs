namespace Final {
    partial class LaptopManagement {
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
            this.DgvLaptops = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaptopInfoContainer = new System.Windows.Forms.GroupBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TbSale = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.CbxLaptopCategory = new System.Windows.Forms.ComboBox();
            this.TbLaptopName = new System.Windows.Forms.TextBox();
            this.TblaptopID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.filterContainer = new System.Windows.Forms.GroupBox();
            this.ChkIsSale = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbxCategoryFilter = new System.Windows.Forms.ComboBox();
            this.TbNameFilter = new System.Windows.Forms.TextBox();
            this.TbIdFilter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLaptops)).BeginInit();
            this.LaptopInfoContainer.SuspendLayout();
            this.filterContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.DgvLaptops.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgvLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLaptops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLaptops.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLaptops.Location = new System.Drawing.Point(486, 217);
            this.DgvLaptops.Name = "DgvLaptops";
            this.DgvLaptops.ReadOnly = true;
            this.DgvLaptops.RowHeadersWidth = 51;
            this.DgvLaptops.RowTemplate.Height = 24;
            this.DgvLaptops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLaptops.Size = new System.Drawing.Size(792, 467);
            this.DgvLaptops.TabIndex = 0;
            this.DgvLaptops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLaptops_CellContentClick);
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
            this.Column5.HeaderText = "Khuyến mãi";
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
            // LaptopInfoContainer
            // 
            this.LaptopInfoContainer.Controls.Add(this.BtnRefresh);
            this.LaptopInfoContainer.Controls.Add(this.TbQuantity);
            this.LaptopInfoContainer.Controls.Add(this.BtnDelete);
            this.LaptopInfoContainer.Controls.Add(this.BtnEdit);
            this.LaptopInfoContainer.Controls.Add(this.TbSale);
            this.LaptopInfoContainer.Controls.Add(this.TbPrice);
            this.LaptopInfoContainer.Controls.Add(this.CbxLaptopCategory);
            this.LaptopInfoContainer.Controls.Add(this.TbLaptopName);
            this.LaptopInfoContainer.Controls.Add(this.TblaptopID);
            this.LaptopInfoContainer.Controls.Add(this.label6);
            this.LaptopInfoContainer.Controls.Add(this.label5);
            this.LaptopInfoContainer.Controls.Add(this.label4);
            this.LaptopInfoContainer.Controls.Add(this.label3);
            this.LaptopInfoContainer.Controls.Add(this.label2);
            this.LaptopInfoContainer.Controls.Add(this.label1);
            this.LaptopInfoContainer.Location = new System.Drawing.Point(13, 217);
            this.LaptopInfoContainer.Name = "LaptopInfoContainer";
            this.LaptopInfoContainer.Size = new System.Drawing.Size(467, 467);
            this.LaptopInfoContainer.TabIndex = 1;
            this.LaptopInfoContainer.TabStop = false;
            this.LaptopInfoContainer.Text = "Thông tin Laptop";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::Final.Properties.Resources.icons8_refresh_32;
            this.BtnRefresh.Location = new System.Drawing.Point(17, 403);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(60, 50);
            this.BtnRefresh.TabIndex = 12;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(190, 355);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(235, 30);
            this.TbQuantity.TabIndex = 11;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Final.Properties.Resources.icons8_delete_32;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(340, 403);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 50);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Xoá";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Final.Properties.Resources.icons8_update_32;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(190, 403);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(121, 50);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Cập nhật";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TbSale
            // 
            this.TbSale.Location = new System.Drawing.Point(190, 298);
            this.TbSale.Name = "TbSale";
            this.TbSale.Size = new System.Drawing.Size(235, 30);
            this.TbSale.TabIndex = 10;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(190, 244);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(235, 30);
            this.TbPrice.TabIndex = 9;
            // 
            // CbxLaptopCategory
            // 
            this.CbxLaptopCategory.FormattingEnabled = true;
            this.CbxLaptopCategory.Location = new System.Drawing.Point(190, 184);
            this.CbxLaptopCategory.Name = "CbxLaptopCategory";
            this.CbxLaptopCategory.Size = new System.Drawing.Size(235, 30);
            this.CbxLaptopCategory.TabIndex = 8;
            // 
            // TbLaptopName
            // 
            this.TbLaptopName.Location = new System.Drawing.Point(190, 111);
            this.TbLaptopName.Name = "TbLaptopName";
            this.TbLaptopName.Size = new System.Drawing.Size(235, 30);
            this.TbLaptopName.TabIndex = 7;
            this.TbLaptopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TblaptopID
            // 
            this.TblaptopID.Location = new System.Drawing.Point(190, 45);
            this.TblaptopID.Name = "TblaptopID";
            this.TblaptopID.Size = new System.Drawing.Size(235, 30);
            this.TblaptopID.TabIndex = 6;
            this.TblaptopID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khuyến mãi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hãng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên máy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã máy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(838, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(125, 39);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Tìm kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // filterContainer
            // 
            this.filterContainer.Controls.Add(this.ChkIsSale);
            this.filterContainer.Controls.Add(this.BtnCancel);
            this.filterContainer.Controls.Add(this.CbxCategoryFilter);
            this.filterContainer.Controls.Add(this.BtnSearch);
            this.filterContainer.Controls.Add(this.TbNameFilter);
            this.filterContainer.Controls.Add(this.TbIdFilter);
            this.filterContainer.Controls.Add(this.label10);
            this.filterContainer.Controls.Add(this.label11);
            this.filterContainer.Controls.Add(this.label12);
            this.filterContainer.Location = new System.Drawing.Point(7, 12);
            this.filterContainer.Name = "filterContainer";
            this.filterContainer.Size = new System.Drawing.Size(974, 180);
            this.filterContainer.TabIndex = 12;
            this.filterContainer.TabStop = false;
            this.filterContainer.Text = "Thông tin Laptop";
            // 
            // ChkIsSale
            // 
            this.ChkIsSale.AutoSize = true;
            this.ChkIsSale.Location = new System.Drawing.Point(479, 118);
            this.ChkIsSale.Name = "ChkIsSale";
            this.ChkIsSale.Size = new System.Drawing.Size(107, 26);
            this.ChkIsSale.TabIndex = 10;
            this.ChkIsSale.Text = "Đang sale";
            this.ChkIsSale.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(838, 109);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(125, 39);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Huỷ";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbxCategoryFilter
            // 
            this.CbxCategoryFilter.FormattingEnabled = true;
            this.CbxCategoryFilter.Location = new System.Drawing.Point(555, 50);
            this.CbxCategoryFilter.Name = "CbxCategoryFilter";
            this.CbxCategoryFilter.Size = new System.Drawing.Size(235, 30);
            this.CbxCategoryFilter.TabIndex = 8;
            // 
            // TbNameFilter
            // 
            this.TbNameFilter.Location = new System.Drawing.Point(120, 109);
            this.TbNameFilter.Name = "TbNameFilter";
            this.TbNameFilter.Size = new System.Drawing.Size(235, 30);
            this.TbNameFilter.TabIndex = 7;
            this.TbNameFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbIdFilter
            // 
            this.TbIdFilter.Location = new System.Drawing.Point(120, 50);
            this.TbIdFilter.Name = "TbIdFilter";
            this.TbIdFilter.Size = new System.Drawing.Size(235, 30);
            this.TbIdFilter.TabIndex = 6;
            this.TbIdFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(454, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Hãng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên máy";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã máy";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaptopManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 696);
            this.Controls.Add(this.filterContainer);
            this.Controls.Add(this.LaptopInfoContainer);
            this.Controls.Add(this.DgvLaptops);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LaptopManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho laptop";
            this.Load += new System.EventHandler(this.LaptopManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLaptops)).EndInit();
            this.LaptopInfoContainer.ResumeLayout(false);
            this.LaptopInfoContainer.PerformLayout();
            this.filterContainer.ResumeLayout(false);
            this.filterContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLaptops;
        private System.Windows.Forms.GroupBox LaptopInfoContainer;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.ComboBox CbxLaptopCategory;
        private System.Windows.Forms.TextBox TbLaptopName;
        private System.Windows.Forms.TextBox TblaptopID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.TextBox TbSale;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox filterContainer;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbxCategoryFilter;
        private System.Windows.Forms.TextBox TbNameFilter;
        private System.Windows.Forms.TextBox TbIdFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ChkIsSale;
        private System.Windows.Forms.Button BtnRefresh;
    }
}