namespace Final {
    partial class AccessoryCategoryManagementForm {
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
                  this.DgvCategories = new System.Windows.Forms.DataGridView();
                  this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.BtnReload = new System.Windows.Forms.Button();
                  this.BtnDelete = new System.Windows.Forms.Button();
                  this.BtnSearch = new System.Windows.Forms.Button();
                  this.BtnEdit = new System.Windows.Forms.Button();
                  this.label2 = new System.Windows.Forms.Label();
                  this.label1 = new System.Windows.Forms.Label();
                  this.TbName = new System.Windows.Forms.TextBox();
                  this.TbId = new System.Windows.Forms.TextBox();
                  ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
                  this.groupBox1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // DgvCategories
                  // 
                  this.DgvCategories.AllowUserToAddRows = false;
                  this.DgvCategories.AllowUserToDeleteRows = false;
                  this.DgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.DgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                  this.DgvCategories.BackgroundColor = System.Drawing.Color.White;
                  this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.DgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
                  dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                  dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
                  dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
                  dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
                  dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                  dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                  this.DgvCategories.DefaultCellStyle = dataGridViewCellStyle1;
                  this.DgvCategories.Location = new System.Drawing.Point(444, 12);
                  this.DgvCategories.Name = "DgvCategories";
                  this.DgvCategories.ReadOnly = true;
                  this.DgvCategories.RowHeadersWidth = 51;
                  this.DgvCategories.RowTemplate.Height = 24;
                  this.DgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  this.DgvCategories.Size = new System.Drawing.Size(544, 273);
                  this.DgvCategories.TabIndex = 0;
                  this.DgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategories_CellClick);
                  // 
                  // Column1
                  // 
                  this.Column1.HeaderText = "Mã loại";
                  this.Column1.MinimumWidth = 6;
                  this.Column1.Name = "Column1";
                  this.Column1.ReadOnly = true;
                  // 
                  // Column2
                  // 
                  this.Column2.HeaderText = "Tên loại";
                  this.Column2.MinimumWidth = 6;
                  this.Column2.Name = "Column2";
                  this.Column2.ReadOnly = true;
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Controls.Add(this.BtnReload);
                  this.groupBox1.Controls.Add(this.BtnDelete);
                  this.groupBox1.Controls.Add(this.BtnSearch);
                  this.groupBox1.Controls.Add(this.BtnEdit);
                  this.groupBox1.Controls.Add(this.label2);
                  this.groupBox1.Controls.Add(this.label1);
                  this.groupBox1.Controls.Add(this.TbName);
                  this.groupBox1.Controls.Add(this.TbId);
                  this.groupBox1.Location = new System.Drawing.Point(13, 13);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Size = new System.Drawing.Size(425, 272);
                  this.groupBox1.TabIndex = 1;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "Thông tin";
                  // 
                  // BtnReload
                  // 
                  this.BtnReload.Image = global::Final.Properties.Resources.icons8_refresh_32;
                  this.BtnReload.Location = new System.Drawing.Point(38, 196);
                  this.BtnReload.Name = "BtnReload";
                  this.BtnReload.Size = new System.Drawing.Size(51, 44);
                  this.BtnReload.TabIndex = 8;
                  this.BtnReload.UseVisualStyleBackColor = true;
                  this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
                  // 
                  // BtnDelete
                  // 
                  this.BtnDelete.Image = global::Final.Properties.Resources.icons8_delete_32;
                  this.BtnDelete.Location = new System.Drawing.Point(317, 196);
                  this.BtnDelete.Name = "BtnDelete";
                  this.BtnDelete.Size = new System.Drawing.Size(51, 44);
                  this.BtnDelete.TabIndex = 11;
                  this.BtnDelete.UseVisualStyleBackColor = true;
                  this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
                  // 
                  // BtnSearch
                  // 
                  this.BtnSearch.BackColor = System.Drawing.Color.White;
                  this.BtnSearch.Image = global::Final.Properties.Resources.icons8_search_32;
                  this.BtnSearch.Location = new System.Drawing.Point(185, 196);
                  this.BtnSearch.Name = "BtnSearch";
                  this.BtnSearch.Size = new System.Drawing.Size(51, 44);
                  this.BtnSearch.TabIndex = 10;
                  this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.BtnSearch.UseVisualStyleBackColor = false;
                  this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
                  // 
                  // BtnEdit
                  // 
                  this.BtnEdit.Image = global::Final.Properties.Resources.icons8_update_32;
                  this.BtnEdit.Location = new System.Drawing.Point(251, 196);
                  this.BtnEdit.Name = "BtnEdit";
                  this.BtnEdit.Size = new System.Drawing.Size(51, 44);
                  this.BtnEdit.TabIndex = 9;
                  this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.BtnEdit.UseVisualStyleBackColor = true;
                  this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
                  // 
                  // label2
                  // 
                  this.label2.Location = new System.Drawing.Point(34, 133);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(117, 30);
                  this.label2.TabIndex = 3;
                  this.label2.Text = "Loại phụ kiện";
                  this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // label1
                  // 
                  this.label1.Location = new System.Drawing.Point(34, 49);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(108, 30);
                  this.label1.TabIndex = 2;
                  this.label1.Text = "Mã";
                  this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // TbName
                  // 
                  this.TbName.Location = new System.Drawing.Point(185, 133);
                  this.TbName.Name = "TbName";
                  this.TbName.Size = new System.Drawing.Size(183, 30);
                  this.TbName.TabIndex = 1;
                  // 
                  // TbId
                  // 
                  this.TbId.Location = new System.Drawing.Point(185, 49);
                  this.TbId.Name = "TbId";
                  this.TbId.Size = new System.Drawing.Size(183, 30);
                  this.TbId.TabIndex = 0;
                  // 
                  // AccessoryCategoryManagementForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.BackColor = System.Drawing.Color.SkyBlue;
                  this.ClientSize = new System.Drawing.Size(1000, 304);
                  this.Controls.Add(this.groupBox1);
                  this.Controls.Add(this.DgvCategories);
                  this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "AccessoryCategoryManagementForm";
                  this.Text = "Quản lý danh sách các loại phụ kiện";
                  this.Load += new System.EventHandler(this.AccessoryCategoryManagementForm_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
                  this.groupBox1.ResumeLayout(false);
                  this.groupBox1.PerformLayout();
                  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnEdit;
    }
}