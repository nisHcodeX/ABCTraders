namespace ABCTraders.Views.Admin
{
    partial class UpadteCarPartStatus
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
            System.Windows.Forms.Label label4;
            this.Tbl_OrderCarPartsAdmin = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FristName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_UpadtePartStatus = new System.Windows.Forms.Button();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.Btn_UpadtePartCancel = new System.Windows.Forms.Button();
            this.TxtBox_PartName = new System.Windows.Forms.TextBox();
            this.Drop_CarPartOrderStatus = new System.Windows.Forms.ComboBox();
            this.TxtBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PicBx_PartPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
            this.Lbl_UpdateStatus = new System.Windows.Forms.Label();
            this.Drop_UpdatePartOrderStatus = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_OrderCarPartsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_PartPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(273, 29);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 22);
            label4.TabIndex = 127;
            label4.Text = "Part Name";
            // 
            // Tbl_OrderCarPartsAdmin
            // 
            this.Tbl_OrderCarPartsAdmin.AllowUserToAddRows = false;
            this.Tbl_OrderCarPartsAdmin.AllowUserToDeleteRows = false;
            this.Tbl_OrderCarPartsAdmin.AllowUserToResizeColumns = false;
            this.Tbl_OrderCarPartsAdmin.AllowUserToResizeRows = false;
            this.Tbl_OrderCarPartsAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_OrderCarPartsAdmin.ColumnHeadersHeight = 29;
            this.Tbl_OrderCarPartsAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PartName,
            this.Price,
            this.Quantity,
            this.FristName,
            this.Email,
            this.Description});
            this.Tbl_OrderCarPartsAdmin.Location = new System.Drawing.Point(28, 242);
            this.Tbl_OrderCarPartsAdmin.Name = "Tbl_OrderCarPartsAdmin";
            this.Tbl_OrderCarPartsAdmin.RowHeadersWidth = 51;
            this.Tbl_OrderCarPartsAdmin.RowTemplate.Height = 24;
            this.Tbl_OrderCarPartsAdmin.Size = new System.Drawing.Size(1122, 223);
            this.Tbl_OrderCarPartsAdmin.TabIndex = 91;
            this.Tbl_OrderCarPartsAdmin.SelectionChanged += new System.EventHandler(this.Tbl_OrderCarPartsAdmin_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "PartName";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // FristName
            // 
            this.FristName.HeaderText = "FristName";
            this.FristName.MinimumWidth = 6;
            this.FristName.Name = "FristName";
            this.FristName.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Btn_UpadtePartStatus
            // 
            this.Btn_UpadtePartStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_UpadtePartStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadtePartStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartStatus.Location = new System.Drawing.Point(642, 488);
            this.Btn_UpadtePartStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartStatus.Name = "Btn_UpadtePartStatus";
            this.Btn_UpadtePartStatus.Size = new System.Drawing.Size(237, 50);
            this.Btn_UpadtePartStatus.TabIndex = 84;
            this.Btn_UpadtePartStatus.Text = "UPDATE";
            this.Btn_UpadtePartStatus.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartStatus.Click += new System.EventHandler(this.Btn_UpadtePartStatus_Click);
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(909, 29);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(112, 22);
            this.AddCarConditionLabel.TabIndex = 77;
            this.AddCarConditionLabel.Text = "Order Status";
            // 
            // Btn_UpadtePartCancel
            // 
            this.Btn_UpadtePartCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_UpadtePartCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpadtePartCancel.Location = new System.Drawing.Point(913, 488);
            this.Btn_UpadtePartCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartCancel.Name = "Btn_UpadtePartCancel";
            this.Btn_UpadtePartCancel.Size = new System.Drawing.Size(239, 50);
            this.Btn_UpadtePartCancel.TabIndex = 109;
            this.Btn_UpadtePartCancel.Text = "CANCEL";
            this.Btn_UpadtePartCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartCancel.Click += new System.EventHandler(this.Btn_UpadtePartCancel_Click);
            // 
            // TxtBox_PartName
            // 
            this.TxtBox_PartName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PartName.Location = new System.Drawing.Point(277, 55);
            this.TxtBox_PartName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_PartName.MaxLength = 10;
            this.TxtBox_PartName.Name = "TxtBox_PartName";
            this.TxtBox_PartName.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_PartName.TabIndex = 132;
            // 
            // Drop_CarPartOrderStatus
            // 
            this.Drop_CarPartOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_CarPartOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_CarPartOrderStatus.FormattingEnabled = true;
            this.Drop_CarPartOrderStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Approved",
            "Delivered"});
            this.Drop_CarPartOrderStatus.Location = new System.Drawing.Point(913, 60);
            this.Drop_CarPartOrderStatus.Name = "Drop_CarPartOrderStatus";
            this.Drop_CarPartOrderStatus.Size = new System.Drawing.Size(237, 30);
            this.Drop_CarPartOrderStatus.TabIndex = 130;
            this.Drop_CarPartOrderStatus.SelectedIndexChanged += new System.EventHandler(this.Drop_CarPartOrderStatus_SelectedIndexChanged_1);
            // 
            // TxtBox_CustomerName
            // 
            this.TxtBox_CustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_CustomerName.Location = new System.Drawing.Point(29, 188);
            this.TxtBox_CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_CustomerName.MaxLength = 10;
            this.TxtBox_CustomerName.Name = "TxtBox_CustomerName";
            this.TxtBox_CustomerName.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_CustomerName.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 128;
            this.label3.Text = "Customer Name";
            // 
            // PicBx_PartPhoto
            // 
            this.PicBx_PartPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_PartPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_PartPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_PartPhoto.Location = new System.Drawing.Point(29, 29);
            this.PicBx_PartPhoto.Name = "PicBx_PartPhoto";
            this.PicBx_PartPhoto.Size = new System.Drawing.Size(237, 112);
            this.PicBx_PartPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_PartPhoto.TabIndex = 133;
            this.PicBx_PartPhoto.TabStop = false;
            this.PicBx_PartPhoto.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 137;
            this.label1.Text = "Price";
            // 
            // TxtBox_Price
            // 
            this.TxtBox_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Price.Location = new System.Drawing.Point(625, 188);
            this.TxtBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Price.MaxLength = 10;
            this.TxtBox_Price.Name = "TxtBox_Price";
            this.TxtBox_Price.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_Price.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 135;
            this.label2.Text = "Quantity";
            // 
            // TxtBoxQuantity
            // 
            this.TxtBoxQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxQuantity.Location = new System.Drawing.Point(336, 188);
            this.TxtBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxQuantity.MaxLength = 10;
            this.TxtBoxQuantity.Name = "TxtBoxQuantity";
            this.TxtBoxQuantity.Size = new System.Drawing.Size(239, 28);
            this.TxtBoxQuantity.TabIndex = 134;
            // 
            // Lbl_UpdateStatus
            // 
            this.Lbl_UpdateStatus.AutoSize = true;
            this.Lbl_UpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UpdateStatus.Location = new System.Drawing.Point(909, 162);
            this.Lbl_UpdateStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_UpdateStatus.Name = "Lbl_UpdateStatus";
            this.Lbl_UpdateStatus.Size = new System.Drawing.Size(124, 22);
            this.Lbl_UpdateStatus.TabIndex = 139;
            this.Lbl_UpdateStatus.Text = "Update Status";
            // 
            // Drop_UpdatePartOrderStatus
            // 
            this.Drop_UpdatePartOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_UpdatePartOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_UpdatePartOrderStatus.FormattingEnabled = true;
            this.Drop_UpdatePartOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved"});
            this.Drop_UpdatePartOrderStatus.Location = new System.Drawing.Point(913, 187);
            this.Drop_UpdatePartOrderStatus.Name = "Drop_UpdatePartOrderStatus";
            this.Drop_UpdatePartOrderStatus.Size = new System.Drawing.Size(237, 30);
            this.Drop_UpdatePartOrderStatus.TabIndex = 138;
            // 
            // UpadteCarPartStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_UpadtePartStatus;
            this.ClientSize = new System.Drawing.Size(1180, 565);
            this.Controls.Add(this.Lbl_UpdateStatus);
            this.Controls.Add(this.Drop_UpdatePartOrderStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxQuantity);
            this.Controls.Add(this.PicBx_PartPhoto);
            this.Controls.Add(this.TxtBox_PartName);
            this.Controls.Add(this.Drop_CarPartOrderStatus);
            this.Controls.Add(this.TxtBox_CustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(label4);
            this.Controls.Add(this.Btn_UpadtePartCancel);
            this.Controls.Add(this.Tbl_OrderCarPartsAdmin);
            this.Controls.Add(this.Btn_UpadtePartStatus);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Name = "UpadteCarPartStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpadteCarPartStatus";
            this.Load += new System.EventHandler(this.UpadteCarPartStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_OrderCarPartsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_PartPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Tbl_OrderCarPartsAdmin;
        private System.Windows.Forms.Button Btn_UpadtePartStatus;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.Button Btn_UpadtePartCancel;
        private System.Windows.Forms.TextBox TxtBox_PartName;
        private System.Windows.Forms.ComboBox Drop_CarPartOrderStatus;
        private System.Windows.Forms.TextBox TxtBox_CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicBx_PartPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxQuantity;
        private System.Windows.Forms.Label Lbl_UpdateStatus;
        private System.Windows.Forms.ComboBox Drop_UpdatePartOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FristName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}