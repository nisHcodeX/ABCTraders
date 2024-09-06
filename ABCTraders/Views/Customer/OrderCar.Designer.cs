namespace ABCTraders.Views.Customer
{
    partial class OrderCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.PicBx_CarPhoto = new System.Windows.Forms.PictureBox();
            this.Btn_OrderCarNow = new System.Windows.Forms.Button();
            this.Btn_CancelOrder = new System.Windows.Forms.Button();
            this.OrderPriceLabel = new System.Windows.Forms.Label();
            this.OrderVINLabel = new System.Windows.Forms.Label();
            this.TxtBox_Manu = new System.Windows.Forms.TextBox();
            this.TxtBox_Model = new System.Windows.Forms.TextBox();
            this.TxtBox_Price = new System.Windows.Forms.TextBox();
            this.TxtBox_VIN = new System.Windows.Forms.TextBox();
            OrderManufLabel = new System.Windows.Forms.Label();
            OrderModelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderManufLabel
            // 
            OrderManufLabel.AutoSize = true;
            OrderManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrderManufLabel.Location = new System.Drawing.Point(360, 229);
            OrderManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrderManufLabel.Name = "OrderManufLabel";
            OrderManufLabel.Size = new System.Drawing.Size(125, 22);
            OrderManufLabel.TabIndex = 124;
            OrderManufLabel.Text = "Manufacturer :";
            // 
            // OrderModelLabel
            // 
            OrderModelLabel.AutoSize = true;
            OrderModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OrderModelLabel.Location = new System.Drawing.Point(360, 109);
            OrderModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrderModelLabel.Name = "OrderModelLabel";
            OrderModelLabel.Size = new System.Drawing.Size(68, 22);
            OrderModelLabel.TabIndex = 123;
            OrderModelLabel.Text = "Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your About To Order This Car";
            // 
            // PicBx_CarPhoto
            // 
            this.PicBx_CarPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_CarPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_CarPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_CarPhoto.Location = new System.Drawing.Point(31, 135);
            this.PicBx_CarPhoto.Name = "PicBx_CarPhoto";
            this.PicBx_CarPhoto.Size = new System.Drawing.Size(288, 162);
            this.PicBx_CarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_CarPhoto.TabIndex = 104;
            this.PicBx_CarPhoto.TabStop = false;
            this.PicBx_CarPhoto.WaitOnLoad = true;
            // 
            // Btn_OrderCarNow
            // 
            this.Btn_OrderCarNow.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_OrderCarNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderCarNow.Location = new System.Drawing.Point(41, 416);
            this.Btn_OrderCarNow.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OrderCarNow.Name = "Btn_OrderCarNow";
            this.Btn_OrderCarNow.Size = new System.Drawing.Size(243, 50);
            this.Btn_OrderCarNow.TabIndex = 105;
            this.Btn_OrderCarNow.Text = "ORDER NOW";
            this.Btn_OrderCarNow.UseVisualStyleBackColor = false;
            this.Btn_OrderCarNow.Click += new System.EventHandler(this.Btn_OrderCarNow_Click);
            // 
            // Btn_CancelOrder
            // 
            this.Btn_CancelOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_CancelOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CancelOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CancelOrder.Location = new System.Drawing.Point(406, 416);
            this.Btn_CancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CancelOrder.Name = "Btn_CancelOrder";
            this.Btn_CancelOrder.Size = new System.Drawing.Size(243, 50);
            this.Btn_CancelOrder.TabIndex = 121;
            this.Btn_CancelOrder.Text = "CANCEL";
            this.Btn_CancelOrder.UseVisualStyleBackColor = false;
            this.Btn_CancelOrder.Click += new System.EventHandler(this.Btn_CancelOrder_Click);
            // 
            // OrderPriceLabel
            // 
            this.OrderPriceLabel.AutoSize = true;
            this.OrderPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPriceLabel.Location = new System.Drawing.Point(361, 170);
            this.OrderPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderPriceLabel.Name = "OrderPriceLabel";
            this.OrderPriceLabel.Size = new System.Drawing.Size(66, 22);
            this.OrderPriceLabel.TabIndex = 130;
            this.OrderPriceLabel.Text = "Price : ";
            // 
            // OrderVINLabel
            // 
            this.OrderVINLabel.AutoSize = true;
            this.OrderVINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderVINLabel.Location = new System.Drawing.Point(361, 294);
            this.OrderVINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderVINLabel.Name = "OrderVINLabel";
            this.OrderVINLabel.Size = new System.Drawing.Size(303, 22);
            this.OrderVINLabel.TabIndex = 129;
            this.OrderVINLabel.Text = "VIN (Vehicle Identification Number) : ";
            this.OrderVINLabel.Click += new System.EventHandler(this.OrderVINLabel_Click);
            // 
            // TxtBox_Manu
            // 
            this.TxtBox_Manu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Manu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Manu.Location = new System.Drawing.Point(364, 258);
            this.TxtBox_Manu.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Manu.MaxLength = 10;
            this.TxtBox_Manu.Name = "TxtBox_Manu";
            this.TxtBox_Manu.Size = new System.Drawing.Size(285, 28);
            this.TxtBox_Manu.TabIndex = 133;
            this.TxtBox_Manu.TextChanged += new System.EventHandler(this.AddCarPartNameText_TextChanged);
            // 
            // TxtBox_Model
            // 
            this.TxtBox_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Model.Location = new System.Drawing.Point(364, 135);
            this.TxtBox_Model.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Model.MaxLength = 10;
            this.TxtBox_Model.Name = "TxtBox_Model";
            this.TxtBox_Model.Size = new System.Drawing.Size(286, 28);
            this.TxtBox_Model.TabIndex = 134;
            // 
            // TxtBox_Price
            // 
            this.TxtBox_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Price.Enabled = false;
            this.TxtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Price.Location = new System.Drawing.Point(365, 196);
            this.TxtBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Price.MaxLength = 10;
            this.TxtBox_Price.Name = "TxtBox_Price";
            this.TxtBox_Price.Size = new System.Drawing.Size(284, 28);
            this.TxtBox_Price.TabIndex = 135;
            // 
            // TxtBox_VIN
            // 
            this.TxtBox_VIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_VIN.Location = new System.Drawing.Point(365, 329);
            this.TxtBox_VIN.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_VIN.MaxLength = 10;
            this.TxtBox_VIN.Name = "TxtBox_VIN";
            this.TxtBox_VIN.Size = new System.Drawing.Size(284, 28);
            this.TxtBox_VIN.TabIndex = 136;
            // 
            // OrderCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 530);
            this.ControlBox = false;
            this.Controls.Add(this.TxtBox_VIN);
            this.Controls.Add(this.TxtBox_Price);
            this.Controls.Add(this.TxtBox_Model);
            this.Controls.Add(this.TxtBox_Manu);
            this.Controls.Add(this.OrderPriceLabel);
            this.Controls.Add(this.OrderVINLabel);
            this.Controls.Add(OrderManufLabel);
            this.Controls.Add(OrderModelLabel);
            this.Controls.Add(this.Btn_CancelOrder);
            this.Controls.Add(this.Btn_OrderCarNow);
            this.Controls.Add(this.PicBx_CarPhoto);
            this.Controls.Add(this.label1);
            this.Name = "OrderCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderCar";
            this.Load += new System.EventHandler(this.OrderCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBx_CarPhoto;
        private System.Windows.Forms.Button Btn_OrderCarNow;
        private System.Windows.Forms.Button Btn_CancelOrder;
        private System.Windows.Forms.Label OrderPriceLabel;
        private System.Windows.Forms.Label OrderVINLabel;
        private System.Windows.Forms.TextBox TxtBox_Manu;
        private System.Windows.Forms.TextBox TxtBox_Model;
        private System.Windows.Forms.TextBox TxtBox_Price;
        private System.Windows.Forms.TextBox TxtBox_VIN;
    }
}