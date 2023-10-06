namespace Final {
    partial class Main {
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
            this.LbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxContainer = new System.Windows.Forms.GroupBox();
            this.BtnSellHistory = new System.Windows.Forms.Button();
            this.BtnBuildPC = new System.Windows.Forms.Button();
            this.BtnChooseLaptop = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAccessoryManagement = new System.Windows.Forms.Button();
            this.BtnLaptopMangement = new System.Windows.Forms.Button();
            this.BoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LbTitle.Location = new System.Drawing.Point(114, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(347, 51);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Shop Máy Tính PC88";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(122, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shop máy tính uy tín từ Việt Nam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoxContainer
            // 
            this.BoxContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxContainer.Controls.Add(this.BtnLaptopMangement);
            this.BoxContainer.Controls.Add(this.BtnAccessoryManagement);
            this.BoxContainer.Controls.Add(this.BtnSellHistory);
            this.BoxContainer.Controls.Add(this.BtnBuildPC);
            this.BoxContainer.Controls.Add(this.BtnChooseLaptop);
            this.BoxContainer.Location = new System.Drawing.Point(12, 138);
            this.BoxContainer.Name = "BoxContainer";
            this.BoxContainer.Size = new System.Drawing.Size(568, 237);
            this.BoxContainer.TabIndex = 2;
            this.BoxContainer.TabStop = false;
            this.BoxContainer.Text = "Chọn chức năng";
            // 
            // BtnSellHistory
            // 
            this.BtnSellHistory.Location = new System.Drawing.Point(413, 62);
            this.BtnSellHistory.Name = "BtnSellHistory";
            this.BtnSellHistory.Size = new System.Drawing.Size(126, 114);
            this.BtnSellHistory.TabIndex = 2;
            this.BtnSellHistory.Text = "Xem lịch sử đơn hàng";
            this.BtnSellHistory.UseVisualStyleBackColor = true;
            this.BtnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click);
            // 
            // BtnBuildPC
            // 
            this.BtnBuildPC.Location = new System.Drawing.Point(19, 141);
            this.BtnBuildPC.Name = "BtnBuildPC";
            this.BtnBuildPC.Size = new System.Drawing.Size(126, 60);
            this.BtnBuildPC.TabIndex = 1;
            this.BtnBuildPC.Text = "Build PC";
            this.BtnBuildPC.UseVisualStyleBackColor = true;
            this.BtnBuildPC.Click += new System.EventHandler(this.BtnBuildPC_Click);
            // 
            // BtnChooseLaptop
            // 
            this.BtnChooseLaptop.Location = new System.Drawing.Point(19, 43);
            this.BtnChooseLaptop.Name = "BtnChooseLaptop";
            this.BtnChooseLaptop.Size = new System.Drawing.Size(126, 60);
            this.BtnChooseLaptop.TabIndex = 0;
            this.BtnChooseLaptop.Text = "Mua Laptop";
            this.BtnChooseLaptop.UseVisualStyleBackColor = true;
            this.BtnChooseLaptop.Click += new System.EventHandler(this.BtnChooseLaptop_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(449, 394);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(131, 48);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAccessoryManagement
            // 
            this.BtnAccessoryManagement.Location = new System.Drawing.Point(221, 141);
            this.BtnAccessoryManagement.Name = "BtnAccessoryManagement";
            this.BtnAccessoryManagement.Size = new System.Drawing.Size(126, 60);
            this.BtnAccessoryManagement.TabIndex = 3;
            this.BtnAccessoryManagement.Text = "Quản lý kho linh kiện";
            this.BtnAccessoryManagement.UseVisualStyleBackColor = true;
            this.BtnAccessoryManagement.Click += new System.EventHandler(this.BtnAccessoryManagement_Click);
            // 
            // BtnLaptopMangement
            // 
            this.BtnLaptopMangement.Location = new System.Drawing.Point(221, 43);
            this.BtnLaptopMangement.Name = "BtnLaptopMangement";
            this.BtnLaptopMangement.Size = new System.Drawing.Size(126, 60);
            this.BtnLaptopMangement.TabIndex = 4;
            this.BtnLaptopMangement.Text = "Quản lý kho laptop";
            this.BtnLaptopMangement.UseVisualStyleBackColor = true;
            this.BtnLaptopMangement.Click += new System.EventHandler(this.BtnLaptopMangement_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(592, 465);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BoxContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbTitle);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Máy Tính";
            this.Load += new System.EventHandler(this.Main_Load);
            this.BoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox BoxContainer;
        private System.Windows.Forms.Button BtnChooseLaptop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBuildPC;
        private System.Windows.Forms.Button BtnSellHistory;
        private System.Windows.Forms.Button BtnLaptopMangement;
        private System.Windows.Forms.Button BtnAccessoryManagement;
    }
}

