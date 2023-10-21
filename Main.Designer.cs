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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxContainer = new System.Windows.Forms.GroupBox();
            this.BtnLaptopMangement = new System.Windows.Forms.Button();
            this.BtnAccessoryManagement = new System.Windows.Forms.Button();
            this.BtnSellHistory = new System.Windows.Forms.Button();
            this.BtnBuyAccessory = new System.Windows.Forms.Button();
            this.BtnChooseLaptop = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.BackColor = System.Drawing.Color.Transparent;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LbTitle.Location = new System.Drawing.Point(271, 31);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(961, 67);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "PC88 - CỬA HÀNG LAPTOP - PHỤ KIỆN";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(468, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG LAPTOP - PHỤ KIỆN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoxContainer
            // 
            this.BoxContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxContainer.BackColor = System.Drawing.Color.Transparent;
            this.BoxContainer.Controls.Add(this.BtnLaptopMangement);
            this.BoxContainer.Controls.Add(this.BtnAccessoryManagement);
            this.BoxContainer.Controls.Add(this.BtnSellHistory);
            this.BoxContainer.Controls.Add(this.BtnBuyAccessory);
            this.BoxContainer.Controls.Add(this.BtnChooseLaptop);
            this.BoxContainer.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxContainer.Location = new System.Drawing.Point(12, 153);
            this.BoxContainer.Name = "BoxContainer";
            this.BoxContainer.Size = new System.Drawing.Size(1385, 610);
            this.BoxContainer.TabIndex = 2;
            this.BoxContainer.TabStop = false;
            this.BoxContainer.Text = "CHỌN CHỨC NĂNG";
            // 
            // BtnLaptopMangement
            // 
            this.BtnLaptopMangement.BackColor = System.Drawing.Color.Coral;
            this.BtnLaptopMangement.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLaptopMangement.Image = global::Final.Properties.Resources.warehouse;
            this.BtnLaptopMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLaptopMangement.Location = new System.Drawing.Point(239, 336);
            this.BtnLaptopMangement.Name = "BtnLaptopMangement";
            this.BtnLaptopMangement.Size = new System.Drawing.Size(442, 107);
            this.BtnLaptopMangement.TabIndex = 4;
            this.BtnLaptopMangement.Text = "QUẢN LÝ KHO LAPTOP";
            this.BtnLaptopMangement.UseVisualStyleBackColor = false;
            this.BtnLaptopMangement.Click += new System.EventHandler(this.BtnLaptopMangement_Click);
            // 
            // BtnAccessoryManagement
            // 
            this.BtnAccessoryManagement.BackColor = System.Drawing.Color.Tomato;
            this.BtnAccessoryManagement.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccessoryManagement.Image = global::Final.Properties.Resources.warehouse;
            this.BtnAccessoryManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccessoryManagement.Location = new System.Drawing.Point(239, 475);
            this.BtnAccessoryManagement.Name = "BtnAccessoryManagement";
            this.BtnAccessoryManagement.Size = new System.Drawing.Size(442, 107);
            this.BtnAccessoryManagement.TabIndex = 3;
            this.BtnAccessoryManagement.Text = "QUẢN LÝ KHO PHỤ KIỆN";
            this.BtnAccessoryManagement.UseVisualStyleBackColor = false;
            this.BtnAccessoryManagement.Click += new System.EventHandler(this.BtnAccessoryManagement_Click);
            // 
            // BtnSellHistory
            // 
            this.BtnSellHistory.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnSellHistory.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSellHistory.Image = global::Final.Properties.Resources.trolley;
            this.BtnSellHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSellHistory.Location = new System.Drawing.Point(856, 226);
            this.BtnSellHistory.Name = "BtnSellHistory";
            this.BtnSellHistory.Size = new System.Drawing.Size(329, 176);
            this.BtnSellHistory.TabIndex = 2;
            this.BtnSellHistory.Text = "XEM LỊCH SỬ ĐƠN HÀNG";
            this.BtnSellHistory.UseVisualStyleBackColor = false;
            this.BtnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click);
            // 
            // BtnBuyAccessory
            // 
            this.BtnBuyAccessory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBuyAccessory.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuyAccessory.Image = global::Final.Properties.Resources.Accessory;
            this.BtnBuyAccessory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuyAccessory.Location = new System.Drawing.Point(239, 199);
            this.BtnBuyAccessory.Name = "BtnBuyAccessory";
            this.BtnBuyAccessory.Size = new System.Drawing.Size(442, 107);
            this.BtnBuyAccessory.TabIndex = 1;
            this.BtnBuyAccessory.Text = "MUA PHỤ KIỆN";
            this.BtnBuyAccessory.UseVisualStyleBackColor = false;
            this.BtnBuyAccessory.Click += new System.EventHandler(this.BtnBuyAccessory_Click);
            // 
            // BtnChooseLaptop
            // 
            this.BtnChooseLaptop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnChooseLaptop.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChooseLaptop.Image = global::Final.Properties.Resources.BuyLaptop;
            this.BtnChooseLaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChooseLaptop.Location = new System.Drawing.Point(239, 64);
            this.BtnChooseLaptop.Name = "BtnChooseLaptop";
            this.BtnChooseLaptop.Size = new System.Drawing.Size(442, 107);
            this.BtnChooseLaptop.TabIndex = 0;
            this.BtnChooseLaptop.Text = "MUA LAPTOP";
            this.BtnChooseLaptop.UseVisualStyleBackColor = false;
            this.BtnChooseLaptop.Click += new System.EventHandler(this.BtnChooseLaptop_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = global::Final.Properties.Resources.Exit;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(1248, 781);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(149, 41);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "THOÁT";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1409, 834);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BoxContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbTitle);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button BtnChooseLaptop;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBuyAccessory;
        private System.Windows.Forms.Button BtnSellHistory;
        private System.Windows.Forms.Button BtnLaptopMangement;
        private System.Windows.Forms.Button BtnAccessoryManagement;
        private System.Windows.Forms.GroupBox BoxContainer;
    }
}

