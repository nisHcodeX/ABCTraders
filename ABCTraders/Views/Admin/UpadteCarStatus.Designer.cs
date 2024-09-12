namespace ABCTraders.Views.Admin
{
    partial class UpadteCarStatus
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
            System.Windows.Forms.Label AddCarManufLabel;
            System.Windows.Forms.Label Lbl_CarName;
            System.Windows.Forms.Label label2;
            this.Lbl_UpdateStatus = new System.Windows.Forms.Label();
            this.Drop_UpdateCarOrderStatus = new System.Windows.Forms.ComboBox();
            this.TxtBox_CarName = new System.Windows.Forms.TextBox();
            this.Btn_UpadteCarStatus = new System.Windows.Forms.Button();
            this.TxtBox_CustomerName = new System.Windows.Forms.TextBox();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.Drop_CarOrderStatus = new System.Windows.Forms.ComboBox();
            this.Tbl_OrderCarAdmin = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_UpadteCarCancel = new System.Windows.Forms.Button();
            this.TxtBox_Price = new System.Windows.Forms.TextBox();
            this.PicBx_CarPhoto = new System.Windows.Forms.PictureBox();
            AddCarManufLabel = new System.Windows.Forms.Label();
            Lbl_CarName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_OrderCarAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarManufLabel
            // 
            AddCarManufLabel.AutoSize = true;
            AddCarManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarManufLabel.Location = new System.Drawing.Point(68, 165);
            AddCarManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarManufLabel.Name = "AddCarManufLabel";
            AddCarManufLabel.Size = new System.Drawing.Size(139, 22);
            AddCarManufLabel.TabIndex = 107;
            AddCarManufLabel.Text = "Customer Name";
            // 
            // Lbl_CarName
            // 
            Lbl_CarName.AutoSize = true;
            Lbl_CarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_CarName.Location = new System.Drawing.Point(359, 165);
            Lbl_CarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_CarName.Name = "Lbl_CarName";
            Lbl_CarName.Size = new System.Drawing.Size(91, 22);
            Lbl_CarName.TabIndex = 106;
            Lbl_CarName.Text = "Car Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(655, 167);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 22);
            label2.TabIndex = 110;
            label2.Text = "Price";
            // 
            // Lbl_UpdateStatus
            // 
            this.Lbl_UpdateStatus.AutoSize = true;
            this.Lbl_UpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UpdateStatus.Location = new System.Drawing.Point(953, 165);
            this.Lbl_UpdateStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_UpdateStatus.Name = "Lbl_UpdateStatus";
            this.Lbl_UpdateStatus.Size = new System.Drawing.Size(124, 22);
            this.Lbl_UpdateStatus.TabIndex = 104;
            this.Lbl_UpdateStatus.Text = "Update Status";
            // 
            // Drop_UpdateCarOrderStatus
            // 
            this.Drop_UpdateCarOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_UpdateCarOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_UpdateCarOrderStatus.FormattingEnabled = true;
            this.Drop_UpdateCarOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved"});
            this.Drop_UpdateCarOrderStatus.Location = new System.Drawing.Point(957, 190);
            this.Drop_UpdateCarOrderStatus.Name = "Drop_UpdateCarOrderStatus";
            this.Drop_UpdateCarOrderStatus.Size = new System.Drawing.Size(237, 30);
            this.Drop_UpdateCarOrderStatus.TabIndex = 103;
            // 
            // TxtBox_CarName
            // 
            this.TxtBox_CarName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_CarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_CarName.Location = new System.Drawing.Point(363, 189);
            this.TxtBox_CarName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_CarName.MaxLength = 10;
            this.TxtBox_CarName.Name = "TxtBox_CarName";
            this.TxtBox_CarName.Size = new System.Drawing.Size(237, 28);
            this.TxtBox_CarName.TabIndex = 102;
            // 
            // Btn_UpadteCarStatus
            // 
            this.Btn_UpadteCarStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_UpadteCarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadteCarStatus.Location = new System.Drawing.Point(684, 477);
            this.Btn_UpadteCarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadteCarStatus.Name = "Btn_UpadteCarStatus";
            this.Btn_UpadteCarStatus.Size = new System.Drawing.Size(239, 50);
            this.Btn_UpadteCarStatus.TabIndex = 100;
            this.Btn_UpadteCarStatus.Text = "UPDATE";
            this.Btn_UpadteCarStatus.UseVisualStyleBackColor = false;
            this.Btn_UpadteCarStatus.Click += new System.EventHandler(this.Btn_UpadteCarStatus_Click);
            // 
            // TxtBox_CustomerName
            // 
            this.TxtBox_CustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_CustomerName.Location = new System.Drawing.Point(72, 191);
            this.TxtBox_CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_CustomerName.MaxLength = 10;
            this.TxtBox_CustomerName.Name = "TxtBox_CustomerName";
            this.TxtBox_CustomerName.Size = new System.Drawing.Size(237, 28);
            this.TxtBox_CustomerName.TabIndex = 99;
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(953, 30);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(112, 22);
            this.AddCarConditionLabel.TabIndex = 97;
            this.AddCarConditionLabel.Text = "Order Status";
            // 
            // Drop_CarOrderStatus
            // 
            this.Drop_CarOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_CarOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_CarOrderStatus.FormattingEnabled = true;
            this.Drop_CarOrderStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Approved",
            "Delivered"});
            this.Drop_CarOrderStatus.Location = new System.Drawing.Point(957, 55);
            this.Drop_CarOrderStatus.Name = "Drop_CarOrderStatus";
            this.Drop_CarOrderStatus.Size = new System.Drawing.Size(237, 30);
            this.Drop_CarOrderStatus.TabIndex = 96;
            this.Drop_CarOrderStatus.SelectedIndexChanged += new System.EventHandler(this.Drop_CarOrderStatus_SelectedIndexChanged);
            // 
            // Tbl_OrderCarAdmin
            // 
            this.Tbl_OrderCarAdmin.AllowUserToAddRows = false;
            this.Tbl_OrderCarAdmin.AllowUserToDeleteRows = false;
            this.Tbl_OrderCarAdmin.AllowUserToResizeColumns = false;
            this.Tbl_OrderCarAdmin.AllowUserToResizeRows = false;
            this.Tbl_OrderCarAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_OrderCarAdmin.ColumnHeadersHeight = 29;
            this.Tbl_OrderCarAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CarId,
            this.ModelName,
            this.ManufacturerName,
            this.CustomerName,
            this.VIN,
            this.Price,
            this.Email,
            this.Description});
            this.Tbl_OrderCarAdmin.Location = new System.Drawing.Point(72, 238);
            this.Tbl_OrderCarAdmin.Name = "Tbl_OrderCarAdmin";
            this.Tbl_OrderCarAdmin.RowHeadersWidth = 51;
            this.Tbl_OrderCarAdmin.RowTemplate.Height = 24;
            this.Tbl_OrderCarAdmin.Size = new System.Drawing.Size(1122, 218);
            this.Tbl_OrderCarAdmin.TabIndex = 105;
            this.Tbl_OrderCarAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_OrderCarAdmin_CellContentClick);
            this.Tbl_OrderCarAdmin.SelectionChanged += new System.EventHandler(this.Tbl_OrderCarAdmin_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // CarId
            // 
            this.CarId.HeaderText = "CarId";
            this.CarId.MinimumWidth = 6;
            this.CarId.Name = "CarId";
            this.CarId.Width = 125;
            // 
            // ModelName
            // 
            this.ModelName.HeaderText = "Model";
            this.ModelName.MinimumWidth = 6;
            this.ModelName.Name = "ModelName";
            this.ModelName.Width = 125;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.HeaderText = "Manufacturer";
            this.ManufacturerName.MinimumWidth = 6;
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.MinimumWidth = 6;
            this.VIN.Name = "VIN";
            this.VIN.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
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
            // Btn_UpadteCarCancel
            // 
            this.Btn_UpadteCarCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_UpadteCarCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadteCarCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadteCarCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpadteCarCancel.Location = new System.Drawing.Point(957, 477);
            this.Btn_UpadteCarCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadteCarCancel.Name = "Btn_UpadteCarCancel";
            this.Btn_UpadteCarCancel.Size = new System.Drawing.Size(237, 50);
            this.Btn_UpadteCarCancel.TabIndex = 108;
            this.Btn_UpadteCarCancel.Text = "CANCEL";
            this.Btn_UpadteCarCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadteCarCancel.Click += new System.EventHandler(this.Btn_UpadteCarCancel_Click);
            // 
            // TxtBox_Price
            // 
            this.TxtBox_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Price.Location = new System.Drawing.Point(659, 190);
            this.TxtBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Price.MaxLength = 10;
            this.TxtBox_Price.Name = "TxtBox_Price";
            this.TxtBox_Price.Size = new System.Drawing.Size(237, 28);
            this.TxtBox_Price.TabIndex = 109;
            // 
            // PicBx_CarPhoto
            // 
            this.PicBx_CarPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_CarPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_CarPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_CarPhoto.Location = new System.Drawing.Point(72, 30);
            this.PicBx_CarPhoto.Name = "PicBx_CarPhoto";
            this.PicBx_CarPhoto.Size = new System.Drawing.Size(237, 112);
            this.PicBx_CarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_CarPhoto.TabIndex = 111;
            this.PicBx_CarPhoto.TabStop = false;
            this.PicBx_CarPhoto.WaitOnLoad = true;
            // 
            // UpadteCarStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_UpadteCarCancel;
            this.ClientSize = new System.Drawing.Size(1233, 552);
            this.Controls.Add(this.PicBx_CarPhoto);
            this.Controls.Add(label2);
            this.Controls.Add(this.TxtBox_Price);
            this.Controls.Add(this.Btn_UpadteCarCancel);
            this.Controls.Add(AddCarManufLabel);
            this.Controls.Add(Lbl_CarName);
            this.Controls.Add(this.Tbl_OrderCarAdmin);
            this.Controls.Add(this.Lbl_UpdateStatus);
            this.Controls.Add(this.Drop_UpdateCarOrderStatus);
            this.Controls.Add(this.TxtBox_CarName);
            this.Controls.Add(this.Btn_UpadteCarStatus);
            this.Controls.Add(this.TxtBox_CustomerName);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.Drop_CarOrderStatus);
            this.Name = "UpadteCarStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpadteCarStatus";
            this.Load += new System.EventHandler(this.UpadteCarStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_OrderCarAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_UpdateStatus;
        private System.Windows.Forms.ComboBox Drop_UpdateCarOrderStatus;
        private System.Windows.Forms.TextBox TxtBox_CarName;
        private System.Windows.Forms.Button Btn_UpadteCarStatus;
        private System.Windows.Forms.TextBox TxtBox_CustomerName;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.ComboBox Drop_CarOrderStatus;
        private System.Windows.Forms.DataGridView Tbl_OrderCarAdmin;
        private System.Windows.Forms.Button Btn_UpadteCarCancel;
        private System.Windows.Forms.TextBox TxtBox_Price;
        private System.Windows.Forms.PictureBox PicBx_CarPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}