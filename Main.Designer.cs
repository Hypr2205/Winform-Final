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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLaptopMangement = new System.Windows.Forms.Button();
            this.BtnAccessoryManagement = new System.Windows.Forms.Button();
            this.BtnSellHistory = new System.Windows.Forms.Button();
            this.BtnBuyAccessory = new System.Windows.Forms.Button();
            this.BtnChooseLaptop = new System.Windows.Forms.Button();
            this.BoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.BackColor = System.Drawing.Color.Transparent;
            this.LbTitle.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LbTitle.Location = new System.Drawing.Point(133, 9);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(347, 51);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "Shop Máy Tính PC88";
            this.LbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(141, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shop máy tính uy tín từ Việt Nam";
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
            this.BoxContainer.Location = new System.Drawing.Point(12, 153);
            this.BoxContainer.Name = "BoxContainer";
            this.BoxContainer.Size = new System.Drawing.Size(598, 237);
            this.BoxContainer.TabIndex = 2;
            this.BoxContainer.TabStop = false;
            this.BoxContainer.Text = "Chọn chức năng";
            // 
            // BtnExit
            // 
            this.BtnExit.Image = global::Final.Properties.Resources.Exit;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(518, 405);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 48);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLaptopMangement
            // 
            this.BtnLaptopMangement.Image = global::Final.Properties.Resources.warehouse;
            this.BtnLaptopMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLaptopMangement.Location = new System.Drawing.Point(227, 43);
            this.BtnLaptopMangement.Name = "BtnLaptopMangement";
            this.BtnLaptopMangement.Size = new System.Drawing.Size(206, 60);
            this.BtnLaptopMangement.TabIndex = 4;
            this.BtnLaptopMangement.Text = "Quản lý kho laptop";
            this.BtnLaptopMangement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLaptopMangement.UseVisualStyleBackColor = true;
            this.BtnLaptopMangement.Click += new System.EventHandler(this.BtnLaptopMangement_Click);
            // 
            // BtnAccessoryManagement
            // 
            this.BtnAccessoryManagement.Image = global::Final.Properties.Resources.warehouse;
            this.BtnAccessoryManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccessoryManagement.Location = new System.Drawing.Point(227, 141);
            this.BtnAccessoryManagement.Name = "BtnAccessoryManagement";
            this.BtnAccessoryManagement.Size = new System.Drawing.Size(206, 60);
            this.BtnAccessoryManagement.TabIndex = 3;
            this.BtnAccessoryManagement.Text = "Quản lý kho phụ kiện";
            this.BtnAccessoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccessoryManagement.UseVisualStyleBackColor = true;
            this.BtnAccessoryManagement.Click += new System.EventHandler(this.BtnAccessoryManagement_Click);
            // 
            // BtnSellHistory
            // 
            this.BtnSellHistory.Image = global::Final.Properties.Resources.trolley;
            this.BtnSellHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSellHistory.Location = new System.Drawing.Point(466, 58);
            this.BtnSellHistory.Name = "BtnSellHistory";
            this.BtnSellHistory.Size = new System.Drawing.Size(126, 128);
            this.BtnSellHistory.TabIndex = 2;
            this.BtnSellHistory.Text = "Xem lịch sử đơn hàng";
            this.BtnSellHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSellHistory.UseVisualStyleBackColor = true;
            this.BtnSellHistory.Click += new System.EventHandler(this.BtnSellHistory_Click);
            // 
            // BtnBuyAccessory
            // 
            this.BtnBuyAccessory.Image = global::Final.Properties.Resources.Accessory;
            this.BtnBuyAccessory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuyAccessory.Location = new System.Drawing.Point(19, 141);
            this.BtnBuyAccessory.Name = "BtnBuyAccessory";
            this.BtnBuyAccessory.Size = new System.Drawing.Size(169, 60);
            this.BtnBuyAccessory.TabIndex = 1;
            this.BtnBuyAccessory.Text = "Mua phụ kiện";
            this.BtnBuyAccessory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuyAccessory.UseVisualStyleBackColor = true;
            this.BtnBuyAccessory.Click += new System.EventHandler(this.BtnBuyAccessory_Click);
            // 
            // BtnChooseLaptop
            // 
            this.BtnChooseLaptop.Image = global::Final.Properties.Resources.BuyLaptop;
            this.BtnChooseLaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChooseLaptop.Location = new System.Drawing.Point(19, 43);
            this.BtnChooseLaptop.Name = "BtnChooseLaptop";
            this.BtnChooseLaptop.Size = new System.Drawing.Size(169, 60);
            this.BtnChooseLaptop.TabIndex = 0;
            this.BtnChooseLaptop.Text = "Mua Laptop";
            this.BtnChooseLaptop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnChooseLaptop.UseVisualStyleBackColor = true;
            this.BtnChooseLaptop.Click += new System.EventHandler(this.BtnChooseLaptop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(618, 465);
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

