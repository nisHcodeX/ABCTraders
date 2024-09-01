namespace ABCTraders
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerBtnContainerPnl = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CustomerSearchCarBtn = new System.Windows.Forms.Button();
            this.CustomerLogoutBtn = new System.Windows.Forms.Button();
            this.CustomerCarPartsBtn = new System.Windows.Forms.Button();
            this.CustomerProfileBtn = new System.Windows.Forms.Button();
            this.CustomerHomeBtn = new System.Windows.Forms.Button();
            this.customerHeaderPnl = new System.Windows.Forms.Panel();
            this.CustomerHeaderLbl = new System.Windows.Forms.Label();
            this.customerFormContainerPnl = new System.Windows.Forms.Panel();
            this.customerBtnContainerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customerHeaderPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerBtnContainerPnl
            // 
            this.customerBtnContainerPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerBtnContainerPnl.Controls.Add(this.pictureBox2);
            this.customerBtnContainerPnl.Controls.Add(this.CustomerSearchCarBtn);
            this.customerBtnContainerPnl.Controls.Add(this.CustomerLogoutBtn);
            this.customerBtnContainerPnl.Controls.Add(this.CustomerCarPartsBtn);
            this.customerBtnContainerPnl.Controls.Add(this.CustomerProfileBtn);
            this.customerBtnContainerPnl.Controls.Add(this.CustomerHomeBtn);
            this.customerBtnContainerPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.customerBtnContainerPnl.Location = new System.Drawing.Point(0, 0);
            this.customerBtnContainerPnl.Name = "customerBtnContainerPnl";
            this.customerBtnContainerPnl.Size = new System.Drawing.Size(292, 777);
            this.customerBtnContainerPnl.TabIndex = 3;
            this.customerBtnContainerPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::ABCTraders.Properties.Resources.abc_car_logo;
            this.pictureBox2.Location = new System.Drawing.Point(29, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerSearchCarBtn
            // 
            this.CustomerSearchCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchCarBtn.Image = global::ABCTraders.Properties.Resources.icons8_car_sale_48;
            this.CustomerSearchCarBtn.Location = new System.Drawing.Point(29, 329);
            this.CustomerSearchCarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerSearchCarBtn.Name = "CustomerSearchCarBtn";
            this.CustomerSearchCarBtn.Padding = new System.Windows.Forms.Padding(12);
            this.CustomerSearchCarBtn.Size = new System.Drawing.Size(220, 83);
            this.CustomerSearchCarBtn.TabIndex = 9;
            this.CustomerSearchCarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerSearchCarBtn.UseVisualStyleBackColor = true;
            this.CustomerSearchCarBtn.Click += new System.EventHandler(this.CustomerSearchCarBtn_Click);
            // 
            // CustomerLogoutBtn
            // 
            this.CustomerLogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLogoutBtn.Image = global::ABCTraders.Properties.Resources.icons8_logout_48;
            this.CustomerLogoutBtn.Location = new System.Drawing.Point(29, 654);
            this.CustomerLogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerLogoutBtn.Name = "CustomerLogoutBtn";
            this.CustomerLogoutBtn.Padding = new System.Windows.Forms.Padding(12);
            this.CustomerLogoutBtn.Size = new System.Drawing.Size(220, 76);
            this.CustomerLogoutBtn.TabIndex = 3;
            this.CustomerLogoutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerLogoutBtn.UseVisualStyleBackColor = true;
            this.CustomerLogoutBtn.Click += new System.EventHandler(this.customerLogoutBtn_Click);
            // 
            // CustomerCarPartsBtn
            // 
            this.CustomerCarPartsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCarPartsBtn.Image = global::ABCTraders.Properties.Resources.icons8_car_service_48;
            this.CustomerCarPartsBtn.Location = new System.Drawing.Point(29, 248);
            this.CustomerCarPartsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerCarPartsBtn.Name = "CustomerCarPartsBtn";
            this.CustomerCarPartsBtn.Padding = new System.Windows.Forms.Padding(8);
            this.CustomerCarPartsBtn.Size = new System.Drawing.Size(220, 81);
            this.CustomerCarPartsBtn.TabIndex = 10;
            this.CustomerCarPartsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerCarPartsBtn.UseVisualStyleBackColor = true;
            this.CustomerCarPartsBtn.Click += new System.EventHandler(this.CustomerCarPartsBtn_Click);
            // 
            // CustomerProfileBtn
            // 
            this.CustomerProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerProfileBtn.Image = global::ABCTraders.Properties.Resources.icons8_users_settings_48;
            this.CustomerProfileBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CustomerProfileBtn.Location = new System.Drawing.Point(29, 414);
            this.CustomerProfileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerProfileBtn.Name = "CustomerProfileBtn";
            this.CustomerProfileBtn.Padding = new System.Windows.Forms.Padding(12);
            this.CustomerProfileBtn.Size = new System.Drawing.Size(220, 84);
            this.CustomerProfileBtn.TabIndex = 4;
            this.CustomerProfileBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerProfileBtn.UseVisualStyleBackColor = true;
            this.CustomerProfileBtn.Click += new System.EventHandler(this.CustomerProfileBtn_Click);
            // 
            // CustomerHomeBtn
            // 
            this.CustomerHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerHomeBtn.Image = global::ABCTraders.Properties.Resources.icons8_car_insurance_48;
            this.CustomerHomeBtn.Location = new System.Drawing.Point(29, 165);
            this.CustomerHomeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerHomeBtn.Name = "CustomerHomeBtn";
            this.CustomerHomeBtn.Padding = new System.Windows.Forms.Padding(12);
            this.CustomerHomeBtn.Size = new System.Drawing.Size(220, 83);
            this.CustomerHomeBtn.TabIndex = 2;
            this.CustomerHomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerHomeBtn.UseVisualStyleBackColor = true;
            this.CustomerHomeBtn.Click += new System.EventHandler(this.CustomerHomeBtn_Click);
            // 
            // customerHeaderPnl
            // 
            this.customerHeaderPnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerHeaderPnl.Controls.Add(this.CustomerHeaderLbl);
            this.customerHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerHeaderPnl.Location = new System.Drawing.Point(292, 0);
            this.customerHeaderPnl.Name = "customerHeaderPnl";
            this.customerHeaderPnl.Size = new System.Drawing.Size(1175, 78);
            this.customerHeaderPnl.TabIndex = 4;
            this.customerHeaderPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.customerHeaderPnl_Paint);
            // 
            // CustomerHeaderLbl
            // 
            this.CustomerHeaderLbl.AutoSize = true;
            this.CustomerHeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerHeaderLbl.Location = new System.Drawing.Point(383, 27);
            this.CustomerHeaderLbl.Name = "CustomerHeaderLbl";
            this.CustomerHeaderLbl.Size = new System.Drawing.Size(210, 29);
            this.CustomerHeaderLbl.TabIndex = 3;
            this.CustomerHeaderLbl.Text = "Search Car Parts";
            // 
            // customerFormContainerPnl
            // 
            this.customerFormContainerPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerFormContainerPnl.Location = new System.Drawing.Point(292, 64);
            this.customerFormContainerPnl.Name = "customerFormContainerPnl";
            this.customerFormContainerPnl.Size = new System.Drawing.Size(1175, 713);
            this.customerFormContainerPnl.TabIndex = 5;
            this.customerFormContainerPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.customerFormContainerPnl_Paint);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 777);
            this.Controls.Add(this.customerFormContainerPnl);
            this.Controls.Add(this.customerHeaderPnl);
            this.Controls.Add(this.customerBtnContainerPnl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Traders Customer View";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.customerBtnContainerPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customerHeaderPnl.ResumeLayout(false);
            this.customerHeaderPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CustomerHomeBtn;
        private System.Windows.Forms.Panel customerBtnContainerPnl;
        private System.Windows.Forms.Button CustomerProfileBtn;
        private System.Windows.Forms.Button CustomerLogoutBtn;
        private System.Windows.Forms.Panel customerHeaderPnl;
        private System.Windows.Forms.Panel customerFormContainerPnl;
        private System.Windows.Forms.Label CustomerHeaderLbl;
        private System.Windows.Forms.Button CustomerSearchCarBtn;
        private System.Windows.Forms.Button CustomerCarPartsBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}