namespace ABCTraders.Views.Customer
{
    partial class OrderCarPart
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
            System.Windows.Forms.Label OrderManufLabel;
            System.Windows.Forms.Label OrderModelLabel;
            this.Btn_CancelOrderPart = new System.Windows.Forms.Button();
            this.Btn_OrderCarPartNow = new System.Windows.Forms.Button();
            this.PicBx_CarPartPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_PartName = new System.Windows.Forms.TextBox();
            this.TxtBox_Qunttity = new System.Windows.Forms.TextBox();
            this.OrderPriceLabel = new System.Windows.Forms.Label();
            this.Numeric_Price = new System.Windows.Forms.NumericUpDown();
            OrderManufLabel = new System.Windows.Forms.Label();
            OrderModelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CancelOrderPart
            // 
            this.Btn_CancelOrderPart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_CancelOrderPart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CancelOrderPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CancelOrderPart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CancelOrderPart.Location = new System.Drawing.Point(428, 373);
            this.Btn_CancelOrderPart.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CancelOrderPart.Name = "Btn_CancelOrderPart";
            this.Btn_CancelOrderPart.Size = new System.Drawing.Size(243, 50);
            this.Btn_CancelOrderPart.TabIndex = 125;
            this.Btn_CancelOrderPart.Text = "CANCEL";
            this.Btn_CancelOrderPart.UseVisualStyleBackColor = false;
            this.Btn_CancelOrderPart.Click += new System.EventHandler(this.Btn_CancelOrderPart_Click);
            // 
            // Btn_OrderCarPartNow
            // 
            this.Btn_OrderCarPartNow.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_OrderCarPartNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderCarPartNow.Location = new System.Drawing.Point(64, 373);
            this.Btn_OrderCarPartNow.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OrderCarPartNow.Name = "Btn_OrderCarPartNow";
            this.Btn_OrderCarPartNow.Size = new System.Drawing.Size(243, 50);
            this.Btn_OrderCarPartNow.TabIndex = 124;
            this.Btn_OrderCarPartNow.Text = "ORDER NOW";
            this.Btn_OrderCarPartNow.UseVisualStyleBackColor = false;
            this.Btn_OrderCarPartNow.Click += new System.EventHandler(this.Btn_OrderCarPartNow_Click);
            // 
            // PicBx_CarPartPhoto
            // 
            this.PicBx_CarPartPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_CarPartPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_CarPartPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_CarPartPhoto.Location = new System.Drawing.Point(54, 102);
            this.PicBx_CarPartPhoto.Name = "PicBx_CarPartPhoto";
            this.PicBx_CarPartPhoto.Size = new System.Drawing.Size(288, 162);
            this.PicBx_CarPartPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_CarPartPhoto.TabIndex = 123;
            this.PicBx_CarPartPhoto.TabStop = false;
            this.PicBx_CarPartPhoto.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 122;
            this.label1.Text = "Your About To Order This Car Part";
            // 
            // TxtBox_PartName
            // 
            this.TxtBox_PartName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PartName.Location = new System.Drawing.Point(386, 122);
            this.TxtBox_PartName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_PartName.MaxLength = 10;
            this.TxtBox_PartName.Name = "TxtBox_PartName";
            this.TxtBox_PartName.Size = new System.Drawing.Size(286, 28);
            this.TxtBox_PartName.TabIndex = 142;
            // 
            // TxtBox_Qunttity
            // 
            this.TxtBox_Qunttity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Qunttity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Qunttity.Location = new System.Drawing.Point(386, 199);
            this.TxtBox_Qunttity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Qunttity.MaxLength = 10;
            this.TxtBox_Qunttity.Name = "TxtBox_Qunttity";
            this.TxtBox_Qunttity.Size = new System.Drawing.Size(285, 28);
            this.TxtBox_Qunttity.TabIndex = 141;
            // 
            // OrderPriceLabel
            // 
            this.OrderPriceLabel.AutoSize = true;
            this.OrderPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPriceLabel.Location = new System.Drawing.Point(384, 247);
            this.OrderPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderPriceLabel.Name = "OrderPriceLabel";
            this.OrderPriceLabel.Size = new System.Drawing.Size(66, 22);
            this.OrderPriceLabel.TabIndex = 140;
            this.OrderPriceLabel.Text = "Price : ";
            // 
            // OrderManufLabel
            // 
            OrderManufLabel.AutoSize = true;
            OrderManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrderManufLabel.Location = new System.Drawing.Point(382, 170);
            OrderManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrderManufLabel.Name = "OrderManufLabel";
            OrderManufLabel.Size = new System.Drawing.Size(87, 22);
            OrderManufLabel.TabIndex = 138;
            OrderManufLabel.Text = "Quantity :";
            // 
            // OrderModelLabel
            // 
            OrderModelLabel.AutoSize = true;
            OrderModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrderModelLabel.Location = new System.Drawing.Point(382, 96);
            OrderModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrderModelLabel.Name = "OrderModelLabel";
            OrderModelLabel.Size = new System.Drawing.Size(105, 22);
            OrderModelLabel.TabIndex = 137;
            OrderModelLabel.Text = "Part Name :";
            // 
            // Numeric_Price
            // 
            this.Numeric_Price.DecimalPlaces = 2;
            this.Numeric_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Price.Location = new System.Drawing.Point(383, 282);
            this.Numeric_Price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numeric_Price.Name = "Numeric_Price";
            this.Numeric_Price.Size = new System.Drawing.Size(288, 28);
            this.Numeric_Price.TabIndex = 143;
            // 
            // OrderCarPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 478);
            this.ControlBox = false;
            this.Controls.Add(this.Numeric_Price);
            this.Controls.Add(this.TxtBox_PartName);
            this.Controls.Add(this.TxtBox_Qunttity);
            this.Controls.Add(this.OrderPriceLabel);
            this.Controls.Add(OrderManufLabel);
            this.Controls.Add(OrderModelLabel);
            this.Controls.Add(this.Btn_CancelOrderPart);
            this.Controls.Add(this.Btn_OrderCarPartNow);
            this.Controls.Add(this.PicBx_CarPartPhoto);
            this.Controls.Add(this.label1);
            this.Name = "OrderCarPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderCarPart";
            this.Load += new System.EventHandler(this.OrderCarPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CancelOrderPart;
        private System.Windows.Forms.Button Btn_OrderCarPartNow;
        private System.Windows.Forms.PictureBox PicBx_CarPartPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_PartName;
        private System.Windows.Forms.TextBox TxtBox_Qunttity;
        private System.Windows.Forms.Label OrderPriceLabel;
        private System.Windows.Forms.NumericUpDown Numeric_Price;
    }
}