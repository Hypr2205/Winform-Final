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
            this.DgvLaptops = new System.Windows.Forms.DataGridView();
            this.LaptopInfoContainer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TblaptopID = new System.Windows.Forms.TextBox();
            this.TbLaptopName = new System.Windows.Forms.TextBox();
            this.CbxLaptopCategory = new System.Windows.Forms.ComboBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.TbSale = new System.Windows.Forms.TextBox();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLaptops)).BeginInit();
            this.LaptopInfoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvLaptops
            // 
            this.DgvLaptops.AllowUserToAddRows = false;
            this.DgvLaptops.AllowUserToDeleteRows = false;
            this.DgvLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLaptops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvLaptops.Location = new System.Drawing.Point(486, 35);
            this.DgvLaptops.Name = "DgvLaptops";
            this.DgvLaptops.ReadOnly = true;
            this.DgvLaptops.RowHeadersWidth = 51;
            this.DgvLaptops.RowTemplate.Height = 24;
            this.DgvLaptops.Size = new System.Drawing.Size(792, 457);
            this.DgvLaptops.TabIndex = 0;
            this.DgvLaptops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLaptops_CellContentClick);
            // 
            // LaptopInfoContainer
            // 
            this.LaptopInfoContainer.Controls.Add(this.TbQuantity);
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
            this.LaptopInfoContainer.Location = new System.Drawing.Point(12, 35);
            this.LaptopInfoContainer.Name = "LaptopInfoContainer";
            this.LaptopInfoContainer.Size = new System.Drawing.Size(467, 401);
            this.LaptopInfoContainer.TabIndex = 1;
            this.LaptopInfoContainer.TabStop = false;
            this.LaptopInfoContainer.Text = "Thông tin Laptop";
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
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(376, 451);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 41);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Xoá";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(253, 451);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 41);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hãng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khuyến mãi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TblaptopID
            // 
            this.TblaptopID.Location = new System.Drawing.Point(190, 45);
            this.TblaptopID.Name = "TblaptopID";
            this.TblaptopID.Size = new System.Drawing.Size(235, 30);
            this.TblaptopID.TabIndex = 6;
            this.TblaptopID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbLaptopName
            // 
            this.TbLaptopName.Location = new System.Drawing.Point(190, 118);
            this.TbLaptopName.Name = "TbLaptopName";
            this.TbLaptopName.Size = new System.Drawing.Size(235, 30);
            this.TbLaptopName.TabIndex = 7;
            this.TbLaptopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbxLaptopCategory
            // 
            this.CbxLaptopCategory.FormattingEnabled = true;
            this.CbxLaptopCategory.Location = new System.Drawing.Point(190, 184);
            this.CbxLaptopCategory.Name = "CbxLaptopCategory";
            this.CbxLaptopCategory.Size = new System.Drawing.Size(235, 30);
            this.CbxLaptopCategory.TabIndex = 8;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(190, 244);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(235, 30);
            this.TbPrice.TabIndex = 9;
            // 
            // TbSale
            // 
            this.TbSale.Location = new System.Drawing.Point(190, 305);
            this.TbSale.Name = "TbSale";
            this.TbSale.Size = new System.Drawing.Size(235, 30);
            this.TbSale.TabIndex = 10;
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(190, 362);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(235, 30);
            this.TbQuantity.TabIndex = 11;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(115, 451);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(109, 41);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Tìm kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã máy";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên máy";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hãng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khuyến mãi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // LaptopManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 511);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDelete);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLaptops;
        private System.Windows.Forms.GroupBox LaptopInfoContainer;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
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
    }
}