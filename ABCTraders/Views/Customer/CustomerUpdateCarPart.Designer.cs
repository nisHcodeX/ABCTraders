namespace ABCTraders.Views.Customer
{
    partial class CustomerUpdateCarPart
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
            this.Drop_CustomerUpdateStatus = new System.Windows.Forms.ComboBox();
            this.Btn_UpadtePartCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Quantity = new System.Windows.Forms.TextBox();
            this.Btn_UpadtePartStatus = new System.Windows.Forms.Button();
            this.PicBx_PartPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_PartName = new System.Windows.Forms.TextBox();
            this.Tbl_CusCarPartOrderList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_PartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CusCarPartOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // Drop_CustomerUpdateStatus
            // 
            this.Drop_CustomerUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_CustomerUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_CustomerUpdateStatus.FormattingEnabled = true;
            this.Drop_CustomerUpdateStatus.Items.AddRange(new object[] {
            "Approved",
            "Delivered"});
            this.Drop_CustomerUpdateStatus.Location = new System.Drawing.Point(987, 181);
            this.Drop_CustomerUpdateStatus.Name = "Drop_CustomerUpdateStatus";
            this.Drop_CustomerUpdateStatus.Size = new System.Drawing.Size(237, 30);
            this.Drop_CustomerUpdateStatus.TabIndex = 122;
            // 
            // Btn_UpadtePartCancel
            // 
            this.Btn_UpadtePartCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_UpadtePartCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadtePartCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpadtePartCancel.Location = new System.Drawing.Point(987, 498);
            this.Btn_UpadtePartCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartCancel.Name = "Btn_UpadtePartCancel";
            this.Btn_UpadtePartCancel.Size = new System.Drawing.Size(239, 50);
            this.Btn_UpadtePartCancel.TabIndex = 120;
            this.Btn_UpadtePartCancel.Text = "CANCEL";
            this.Btn_UpadtePartCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartCancel.Click += new System.EventHandler(this.Btn_UpadtePartCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(992, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 119;
            this.label1.Text = "Update Status";
            // 
            // TxtBox_Quantity
            // 
            this.TxtBox_Quantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Quantity.Location = new System.Drawing.Point(356, 181);
            this.TxtBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Quantity.MaxLength = 10;
            this.TxtBox_Quantity.Name = "TxtBox_Quantity";
            this.TxtBox_Quantity.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_Quantity.TabIndex = 118;
            this.TxtBox_Quantity.TextChanged += new System.EventHandler(this.AddCarPartNameText_TextChanged);
            // 
            // Btn_UpadtePartStatus
            // 
            this.Btn_UpadtePartStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_UpadtePartStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadtePartStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartStatus.Location = new System.Drawing.Point(701, 498);
            this.Btn_UpadtePartStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartStatus.Name = "Btn_UpadtePartStatus";
            this.Btn_UpadtePartStatus.Size = new System.Drawing.Size(239, 50);
            this.Btn_UpadtePartStatus.TabIndex = 116;
            this.Btn_UpadtePartStatus.Text = "UPDATE";
            this.Btn_UpadtePartStatus.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartStatus.Click += new System.EventHandler(this.Btn_UpadtePartStatus_Click);
            // 
            // PicBx_PartPhoto
            // 
            this.PicBx_PartPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_PartPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_PartPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_PartPhoto.Location = new System.Drawing.Point(61, 26);
            this.PicBx_PartPhoto.Name = "PicBx_PartPhoto";
            this.PicBx_PartPhoto.Size = new System.Drawing.Size(237, 112);
            this.PicBx_PartPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_PartPhoto.TabIndex = 123;
            this.PicBx_PartPhoto.TabStop = false;
            this.PicBx_PartPhoto.WaitOnLoad = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 127;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 129;
            this.label3.Text = "Price";
            // 
            // TxtBox_Price
            // 
            this.TxtBox_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Price.Location = new System.Drawing.Point(672, 181);
            this.TxtBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Price.MaxLength = 10;
            this.TxtBox_Price.Name = "TxtBox_Price";
            this.TxtBox_Price.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_Price.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 131;
            this.label4.Text = "Part Name";
            // 
            // TxtBox_PartName
            // 
            this.TxtBox_PartName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PartName.Location = new System.Drawing.Point(61, 181);
            this.TxtBox_PartName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_PartName.MaxLength = 10;
            this.TxtBox_PartName.Name = "TxtBox_PartName";
            this.TxtBox_PartName.Size = new System.Drawing.Size(239, 28);
            this.TxtBox_PartName.TabIndex = 130;
            // 
            // Tbl_CusCarPartOrderList
            // 
            this.Tbl_CusCarPartOrderList.AllowUserToAddRows = false;
            this.Tbl_CusCarPartOrderList.AllowUserToDeleteRows = false;
            this.Tbl_CusCarPartOrderList.AllowUserToResizeColumns = false;
            this.Tbl_CusCarPartOrderList.AllowUserToResizeRows = false;
            this.Tbl_CusCarPartOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CusCarPartOrderList.ColumnHeadersHeight = 29;
            this.Tbl_CusCarPartOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PartName,
            this.PartCode,
            this.Description,
            this.Price,
            this.Condition,
            this.Quantity,
            this.OrderDate,
            this.ApproveDate,
            this.DeliverdDate});
            this.Tbl_CusCarPartOrderList.Location = new System.Drawing.Point(61, 234);
            this.Tbl_CusCarPartOrderList.Name = "Tbl_CusCarPartOrderList";
            this.Tbl_CusCarPartOrderList.RowHeadersWidth = 51;
            this.Tbl_CusCarPartOrderList.RowTemplate.Height = 24;
            this.Tbl_CusCarPartOrderList.Size = new System.Drawing.Size(1163, 242);
            this.Tbl_CusCarPartOrderList.TabIndex = 132;
            this.Tbl_CusCarPartOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_CusCarPartOrderList_CellContentClick);
            this.Tbl_CusCarPartOrderList.SelectionChanged += new System.EventHandler(this.Tbl_CusCarPartOrderList_SelectionChanged);
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
            // PartCode
            // 
            this.PartCode.HeaderText = "PartCode";
            this.PartCode.MinimumWidth = 6;
            this.PartCode.Name = "PartCode";
            this.PartCode.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 125;
            // 
            // ApproveDate
            // 
            this.ApproveDate.HeaderText = "ApproveDate";
            this.ApproveDate.MinimumWidth = 6;
            this.ApproveDate.Name = "ApproveDate";
            this.ApproveDate.Width = 125;
            // 
            // DeliverdDate
            // 
            this.DeliverdDate.HeaderText = "DeliveredDate";
            this.DeliverdDate.MinimumWidth = 6;
            this.DeliverdDate.Name = "DeliverdDate";
            this.DeliverdDate.Width = 125;
            // 
            // CustomerUpdateCarPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Btn_UpadtePartCancel;
            this.ClientSize = new System.Drawing.Size(1281, 574);
            this.Controls.Add(this.Tbl_CusCarPartOrderList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBox_PartName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBox_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicBx_PartPhoto);
            this.Controls.Add(this.Drop_CustomerUpdateStatus);
            this.Controls.Add(this.Btn_UpadtePartCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Quantity);
            this.Controls.Add(this.Btn_UpadtePartStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerUpdateCarPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerUpdateCarPart";
            this.Load += new System.EventHandler(this.CustomerUpdateCarPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_PartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CusCarPartOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Drop_CustomerUpdateStatus;
        private System.Windows.Forms.Button Btn_UpadtePartCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Quantity;
        private System.Windows.Forms.Button Btn_UpadtePartStatus;
        private System.Windows.Forms.PictureBox PicBx_PartPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBox_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_PartName;
        private System.Windows.Forms.DataGridView Tbl_CusCarPartOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverdDate;
    }
}