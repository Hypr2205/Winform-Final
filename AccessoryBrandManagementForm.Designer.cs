namespace Final {
    partial class AccessoryBrandManagementForm {
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
                  this.DgvAccessoryBrands = new System.Windows.Forms.DataGridView();
                  this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.BtnReload = new System.Windows.Forms.Button();
                  this.TbID = new System.Windows.Forms.TextBox();
                  this.BtnDelete = new System.Windows.Forms.Button();
                  this.BtnSearch = new System.Windows.Forms.Button();
                  this.BtnEdit = new System.Windows.Forms.Button();
                  this.label2 = new System.Windows.Forms.Label();
                  this.label1 = new System.Windows.Forms.Label();
                  this.TbName = new System.Windows.Forms.TextBox();
                  ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoryBrands)).BeginInit();
                  this.groupBox1.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // DgvAccessoryBrands
                  // 
                  this.DgvAccessoryBrands.AllowUserToAddRows = false;
                  this.DgvAccessoryBrands.AllowUserToDeleteRows = false;
                  this.DgvAccessoryBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
                  this.DgvAccessoryBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                  this.DgvAccessoryBrands.BackgroundColor = System.Drawing.Color.White;
                  this.DgvAccessoryBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.DgvAccessoryBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
                  this.DgvAccessoryBrands.Location = new System.Drawing.Point(350, 49);
                  this.DgvAccessoryBrands.Name = "DgvAccessoryBrands";
                  this.DgvAccessoryBrands.ReadOnly = true;
                  dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                  dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
                  dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
                  dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
                  dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                  dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                  this.DgvAccessoryBrands.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
                  this.DgvAccessoryBrands.RowHeadersWidth = 51;
                  this.DgvAccessoryBrands.RowTemplate.Height = 24;
                  this.DgvAccessoryBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                  this.DgvAccessoryBrands.Size = new System.Drawing.Size(506, 253);
                  this.DgvAccessoryBrands.TabIndex = 0;
                  this.DgvAccessoryBrands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAccessoryBrands_CellContentClick);
                  // 
                  // Column1
                  // 
                  this.Column1.HeaderText = "Mã";
                  this.Column1.MinimumWidth = 6;
                  this.Column1.Name = "Column1";
                  this.Column1.ReadOnly = true;
                  // 
                  // Column2
                  // 
                  this.Column2.HeaderText = "Tên hãng";
                  this.Column2.MinimumWidth = 6;
                  this.Column2.Name = "Column2";
                  this.Column2.ReadOnly = true;
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Controls.Add(this.BtnReload);
                  this.groupBox1.Controls.Add(this.TbID);
                  this.groupBox1.Controls.Add(this.BtnDelete);
                  this.groupBox1.Controls.Add(this.BtnSearch);
                  this.groupBox1.Controls.Add(this.BtnEdit);
                  this.groupBox1.Controls.Add(this.label2);
                  this.groupBox1.Controls.Add(this.label1);
                  this.groupBox1.Controls.Add(this.TbName);
                  this.groupBox1.Location = new System.Drawing.Point(13, 49);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Size = new System.Drawing.Size(331, 254);
                  this.groupBox1.TabIndex = 1;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "Thông tin hãng";
                  // 
                  // BtnReload
                  // 
                  this.BtnReload.Image = global::Final.Properties.Resources.icons8_refresh_32;
                  this.BtnReload.Location = new System.Drawing.Point(33, 189);
                  this.BtnReload.Name = "BtnReload";
                  this.BtnReload.Size = new System.Drawing.Size(51, 44);
                  this.BtnReload.TabIndex = 2;
                  this.BtnReload.UseVisualStyleBackColor = true;
                  this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
                  // 
                  // TbID
                  // 
                  this.TbID.Location = new System.Drawing.Point(118, 59);
                  this.TbID.Name = "TbID";
                  this.TbID.Size = new System.Drawing.Size(176, 30);
                  this.TbID.TabIndex = 8;
                  this.TbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // BtnDelete
                  // 
                  this.BtnDelete.Image = global::Final.Properties.Resources.icons8_delete_32;
                  this.BtnDelete.Location = new System.Drawing.Point(243, 189);
                  this.BtnDelete.Name = "BtnDelete";
                  this.BtnDelete.Size = new System.Drawing.Size(51, 44);
                  this.BtnDelete.TabIndex = 7;
                  this.BtnDelete.UseVisualStyleBackColor = true;
                  this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
                  // 
                  // BtnSearch
                  // 
                  this.BtnSearch.BackColor = System.Drawing.Color.White;
                  this.BtnSearch.Image = global::Final.Properties.Resources.icons8_search_32;
                  this.BtnSearch.Location = new System.Drawing.Point(118, 189);
                  this.BtnSearch.Name = "BtnSearch";
                  this.BtnSearch.Size = new System.Drawing.Size(51, 44);
                  this.BtnSearch.TabIndex = 6;
                  this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.BtnSearch.UseVisualStyleBackColor = false;
                  this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
                  // 
                  // BtnEdit
                  // 
                  this.BtnEdit.Image = global::Final.Properties.Resources.icons8_update_32;
                  this.BtnEdit.Location = new System.Drawing.Point(176, 189);
                  this.BtnEdit.Name = "BtnEdit";
                  this.BtnEdit.Size = new System.Drawing.Size(51, 44);
                  this.BtnEdit.TabIndex = 4;
                  this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                  this.BtnEdit.UseVisualStyleBackColor = true;
                  this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
                  // 
                  // label2
                  // 
                  this.label2.Location = new System.Drawing.Point(6, 133);
                  this.label2.Name = "label2";
                  this.label2.Size = new System.Drawing.Size(105, 30);
                  this.label2.TabIndex = 3;
                  this.label2.Text = "Tên hãng";
                  this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // label1
                  // 
                  this.label1.Location = new System.Drawing.Point(6, 59);
                  this.label1.Name = "label1";
                  this.label1.Size = new System.Drawing.Size(105, 30);
                  this.label1.TabIndex = 2;
                  this.label1.Text = "Mã";
                  this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                  // 
                  // TbName
                  // 
                  this.TbName.Location = new System.Drawing.Point(118, 133);
                  this.TbName.Name = "TbName";
                  this.TbName.Size = new System.Drawing.Size(176, 30);
                  this.TbName.TabIndex = 1;
                  this.TbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                  // 
                  // AccessoryBrandManagementForm
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.BackColor = System.Drawing.Color.SkyBlue;
                  this.ClientSize = new System.Drawing.Size(868, 314);
                  this.Controls.Add(this.groupBox1);
                  this.Controls.Add(this.DgvAccessoryBrands);
                  this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  this.Margin = new System.Windows.Forms.Padding(4);
                  this.Name = "AccessoryBrandManagementForm";
                  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                  this.Text = "Danh sách các hãng phụ kiện";
                  this.Load += new System.EventHandler(this.AccessoryBrandManagement_Load);
                  ((System.ComponentModel.ISupportInitialize)(this.DgvAccessoryBrands)).EndInit();
                  this.groupBox1.ResumeLayout(false);
                  this.groupBox1.PerformLayout();
                  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAccessoryBrands;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.TextBox TbID;
    }
}