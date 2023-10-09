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
            this.DgvAccessories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessoryInfoContainer = new System.Windows.Forms.GroupBox();
            this.TbQuantity = new System.Windows.Forms.TextBox();
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessories)).BeginInit();
            this.AccessoryInfoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAccessories
            // 
            this.DgvAccessories.AllowUserToAddRows = false;
            this.DgvAccessories.AllowUserToDeleteRows = false;
            this.DgvAccessories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvAccessories.Location = new System.Drawing.Point(448, 12);
            this.DgvAccessories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DgvAccessories.Name = "DgvAccessories";
            this.DgvAccessories.ReadOnly = true;
            this.DgvAccessories.RowHeadersWidth = 51;
            this.DgvAccessories.RowTemplate.Height = 24;
            this.DgvAccessories.Size = new System.Drawing.Size(838, 610);
            this.DgvAccessories.TabIndex = 0;
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
            this.Column3.HeaderText = "Hãng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Loại linh kiện";
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
            this.AccessoryInfoContainer.Controls.Add(this.TbQuantity);
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
            this.AccessoryInfoContainer.Location = new System.Drawing.Point(-2, 12);
            this.AccessoryInfoContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AccessoryInfoContainer.Name = "AccessoryInfoContainer";
            this.AccessoryInfoContainer.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AccessoryInfoContainer.Size = new System.Drawing.Size(442, 550);
            this.AccessoryInfoContainer.TabIndex = 1;
            this.AccessoryInfoContainer.TabStop = false;
            this.AccessoryInfoContainer.Text = "Thông tin linh kiện";
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(159, 491);
            this.TbQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(264, 30);
            this.TbQuantity.TabIndex = 13;
            this.TbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbSale
            // 
            this.TbSale.Location = new System.Drawing.Point(159, 420);
            this.TbSale.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TbSale.Name = "TbSale";
            this.TbSale.Size = new System.Drawing.Size(264, 30);
            this.TbSale.TabIndex = 12;
            this.TbSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbxAccessoryBrand
            // 
            this.CbxAccessoryBrand.FormattingEnabled = true;
            this.CbxAccessoryBrand.Location = new System.Drawing.Point(159, 195);
            this.CbxAccessoryBrand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbxAccessoryBrand.Name = "CbxAccessoryBrand";
            this.CbxAccessoryBrand.Size = new System.Drawing.Size(264, 30);
            this.CbxAccessoryBrand.TabIndex = 11;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(159, 344);
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
            this.CbxAccessoryCategory.Location = new System.Drawing.Point(159, 270);
            this.CbxAccessoryCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CbxAccessoryCategory.Name = "CbxAccessoryCategory";
            this.CbxAccessoryCategory.Size = new System.Drawing.Size(264, 30);
            this.CbxAccessoryCategory.TabIndex = 8;
            // 
            // TbAccessoryName
            // 
            this.TbAccessoryName.Location = new System.Drawing.Point(159, 122);
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
            this.label6.Location = new System.Drawing.Point(13, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khuyến mãi";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại linh kiện";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hãng";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá bán";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên linh kiện";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(328, 568);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 54);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Xoá";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(58, 568);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(112, 54);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Tìm kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(192, 568);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(112, 54);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Cập nhật";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // AccessoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 645);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.AccessoryInfoContainer);
            this.Controls.Add(this.DgvAccessories);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccessoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccessories)).EndInit();
            this.AccessoryInfoContainer.ResumeLayout(false);
            this.AccessoryInfoContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAccessories;
        private System.Windows.Forms.GroupBox AccessoryInfoContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxAccessoryCategory;
        private System.Windows.Forms.TextBox TbAccessoryName;
        private System.Windows.Forms.TextBox TbAccessoryID;
        private System.Windows.Forms.ComboBox CbxAccessoryBrand;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.TextBox TbSale;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}