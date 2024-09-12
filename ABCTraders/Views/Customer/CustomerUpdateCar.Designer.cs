namespace ABCTraders.Views.Customer
{
    partial class CustomerUpdateCar
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
            System.Windows.Forms.Label Lbl_CarName;
            System.Windows.Forms.Label Lbl_VIN;
            this.Btn_UpadteCarCancel = new System.Windows.Forms.Button();
            this.Btn_UpadteCarStatus = new System.Windows.Forms.Button();
            this.PicBx_PartPhoto = new System.Windows.Forms.PictureBox();
            this.Tbl_CusCarOrderList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_Price = new System.Windows.Forms.TextBox();
            this.Drop_CustomerUpdateStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_CarName = new System.Windows.Forms.TextBox();
            this.TxtBox_VIN = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lbl_CarName = new System.Windows.Forms.Label();
            Lbl_VIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_PartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CusCarOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_CarName
            // 
            Lbl_CarName.AutoSize = true;
            Lbl_CarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_CarName.Location = new System.Drawing.Point(42, 155);
            Lbl_CarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_CarName.Name = "Lbl_CarName";
            Lbl_CarName.Size = new System.Drawing.Size(91, 22);
            Lbl_CarName.TabIndex = 141;
            Lbl_CarName.Text = "Car Name";
            // 
            // Lbl_VIN
            // 
            Lbl_VIN.AutoSize = true;
            Lbl_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_VIN.Location = new System.Drawing.Point(331, 153);
            Lbl_VIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Lbl_VIN.Name = "Lbl_VIN";
            Lbl_VIN.Size = new System.Drawing.Size(303, 28);
            Lbl_VIN.TabIndex = 143;
            Lbl_VIN.Text = "Vehicle Identification Number";
            // 
            // Btn_UpadteCarCancel
            // 
            this.Btn_UpadteCarCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_UpadteCarCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadteCarCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadteCarCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpadteCarCancel.Location = new System.Drawing.Point(928, 513);
            this.Btn_UpadteCarCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadteCarCancel.Name = "Btn_UpadteCarCancel";
            this.Btn_UpadteCarCancel.Size = new System.Drawing.Size(238, 50);
            this.Btn_UpadteCarCancel.TabIndex = 119;
            this.Btn_UpadteCarCancel.Text = "CANCEL";
            this.Btn_UpadteCarCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadteCarCancel.Click += new System.EventHandler(this.Btn_UpadteCarCancel_Click);
            // 
            // Btn_UpadteCarStatus
            // 
            this.Btn_UpadteCarStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_UpadteCarStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadteCarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadteCarStatus.Location = new System.Drawing.Point(655, 513);
            this.Btn_UpadteCarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadteCarStatus.Name = "Btn_UpadteCarStatus";
            this.Btn_UpadteCarStatus.Size = new System.Drawing.Size(237, 50);
            this.Btn_UpadteCarStatus.TabIndex = 115;
            this.Btn_UpadteCarStatus.Text = "UPDATE";
            this.Btn_UpadteCarStatus.UseVisualStyleBackColor = false;
            this.Btn_UpadteCarStatus.Click += new System.EventHandler(this.Btn_UpadteCarStatus_Click);
            // 
            // PicBx_PartPhoto
            // 
            this.PicBx_PartPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_PartPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_PartPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_PartPhoto.Location = new System.Drawing.Point(46, 22);
            this.PicBx_PartPhoto.Name = "PicBx_PartPhoto";
            this.PicBx_PartPhoto.Size = new System.Drawing.Size(237, 112);
            this.PicBx_PartPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_PartPhoto.TabIndex = 134;
            this.PicBx_PartPhoto.TabStop = false;
            this.PicBx_PartPhoto.WaitOnLoad = true;
            // 
            // Tbl_CusCarOrderList
            // 
            this.Tbl_CusCarOrderList.AllowUserToAddRows = false;
            this.Tbl_CusCarOrderList.AllowUserToDeleteRows = false;
            this.Tbl_CusCarOrderList.AllowUserToResizeColumns = false;
            this.Tbl_CusCarOrderList.AllowUserToResizeRows = false;
            this.Tbl_CusCarOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CusCarOrderList.ColumnHeadersHeight = 29;
            this.Tbl_CusCarOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn3,
            this.Model,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.OrderedDate,
            this.ApprovedDate,
            this.DeliveredDate});
            this.Tbl_CusCarOrderList.Location = new System.Drawing.Point(46, 248);
            this.Tbl_CusCarOrderList.Name = "Tbl_CusCarOrderList";
            this.Tbl_CusCarOrderList.RowHeadersWidth = 51;
            this.Tbl_CusCarOrderList.RowTemplate.Height = 24;
            this.Tbl_CusCarOrderList.Size = new System.Drawing.Size(1118, 238);
            this.Tbl_CusCarOrderList.TabIndex = 135;
            this.Tbl_CusCarOrderList.SelectionChanged += new System.EventHandler(this.Tbl_CusCarOrderList_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 139;
            this.label3.Text = "Price";
            // 
            // TxtBox_Price
            // 
            this.TxtBox_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Price.Location = new System.Drawing.Point(632, 179);
            this.TxtBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Price.MaxLength = 10;
            this.TxtBox_Price.Name = "TxtBox_Price";
            this.TxtBox_Price.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_Price.TabIndex = 138;
            // 
            // Drop_CustomerUpdateStatus
            // 
            this.Drop_CustomerUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_CustomerUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_CustomerUpdateStatus.FormattingEnabled = true;
            this.Drop_CustomerUpdateStatus.Items.AddRange(new object[] {
            "Approved",
            "Delivered"});
            this.Drop_CustomerUpdateStatus.Location = new System.Drawing.Point(925, 179);
            this.Drop_CustomerUpdateStatus.Name = "Drop_CustomerUpdateStatus";
            this.Drop_CustomerUpdateStatus.Size = new System.Drawing.Size(237, 30);
            this.Drop_CustomerUpdateStatus.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 136;
            this.label1.Text = "Update Status";
            // 
            // TxtBox_CarName
            // 
            this.TxtBox_CarName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_CarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_CarName.Location = new System.Drawing.Point(46, 179);
            this.TxtBox_CarName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_CarName.MaxLength = 10;
            this.TxtBox_CarName.Name = "TxtBox_CarName";
            this.TxtBox_CarName.Size = new System.Drawing.Size(237, 28);
            this.TxtBox_CarName.TabIndex = 140;
            // 
            // TxtBox_VIN
            // 
            this.TxtBox_VIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_VIN.Location = new System.Drawing.Point(335, 177);
            this.TxtBox_VIN.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_VIN.MaxLength = 10;
            this.TxtBox_VIN.Name = "TxtBox_VIN";
            this.TxtBox_VIN.Size = new System.Drawing.Size(237, 28);
            this.TxtBox_VIN.TabIndex = 142;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // OrderedDate
            // 
            this.OrderedDate.HeaderText = "OrderedDate";
            this.OrderedDate.MinimumWidth = 6;
            this.OrderedDate.Name = "OrderedDate";
            this.OrderedDate.Width = 125;
            // 
            // ApprovedDate
            // 
            this.ApprovedDate.HeaderText = "ApprovedDate";
            this.ApprovedDate.MinimumWidth = 6;
            this.ApprovedDate.Name = "ApprovedDate";
            this.ApprovedDate.Width = 125;
            // 
            // DeliveredDate
            // 
            this.DeliveredDate.HeaderText = "DeliveredDate";
            this.DeliveredDate.MinimumWidth = 6;
            this.DeliveredDate.Name = "DeliveredDate";
            this.DeliveredDate.Width = 125;
            // 
            // CustomerUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_UpadteCarCancel;
            this.ClientSize = new System.Drawing.Size(1217, 602);
            this.Controls.Add(Lbl_VIN);
            this.Controls.Add(this.TxtBox_VIN);
            this.Controls.Add(Lbl_CarName);
            this.Controls.Add(this.TxtBox_CarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBox_Price);
            this.Controls.Add(this.Drop_CustomerUpdateStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbl_CusCarOrderList);
            this.Controls.Add(this.PicBx_PartPhoto);
            this.Controls.Add(this.Btn_UpadteCarCancel);
            this.Controls.Add(this.Btn_UpadteCarStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerUpdateCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Update Car Order";
            this.Load += new System.EventHandler(this.CustomerUpdatePartOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_PartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CusCarOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_UpadteCarCancel;
        private System.Windows.Forms.Button Btn_UpadteCarStatus;
        private System.Windows.Forms.PictureBox PicBx_PartPhoto;
        private System.Windows.Forms.DataGridView Tbl_CusCarOrderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBox_Price;
        private System.Windows.Forms.ComboBox Drop_CustomerUpdateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_CarName;
        private System.Windows.Forms.TextBox TxtBox_VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveredDate;
    }
}