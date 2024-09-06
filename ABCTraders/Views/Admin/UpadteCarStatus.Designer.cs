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
            System.Windows.Forms.Label AddCarModelLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.Drop_UpdatePartOrderStatus = new System.Windows.Forms.ComboBox();
            this.AddCarPartNameText = new System.Windows.Forms.TextBox();
            this.Btn_UpadteCarStatus = new System.Windows.Forms.Button();
            this.AddCarPartCodeTxt = new System.Windows.Forms.TextBox();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.Drop_CarOrderStatus = new System.Windows.Forms.ComboBox();
            this.Tbl_CarAdmin = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_UpadteCarCancel = new System.Windows.Forms.Button();
            AddCarManufLabel = new System.Windows.Forms.Label();
            AddCarModelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarManufLabel
            // 
            AddCarManufLabel.AutoSize = true;
            AddCarManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarManufLabel.Location = new System.Drawing.Point(461, 115);
            AddCarManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarManufLabel.Name = "AddCarManufLabel";
            AddCarManufLabel.Size = new System.Drawing.Size(120, 22);
            AddCarManufLabel.TabIndex = 107;
            AddCarManufLabel.Text = "Manufacturer ";
            // 
            // AddCarModelLabel
            // 
            AddCarModelLabel.AutoSize = true;
            AddCarModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarModelLabel.Location = new System.Drawing.Point(857, 115);
            AddCarModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarModelLabel.Name = "AddCarModelLabel";
            AddCarModelLabel.Size = new System.Drawing.Size(58, 22);
            AddCarModelLabel.TabIndex = 106;
            AddCarModelLabel.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 104;
            this.label1.Text = "Update Status";
            // 
            // Drop_UpdatePartOrderStatus
            // 
            this.Drop_UpdatePartOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_UpdatePartOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_UpdatePartOrderStatus.FormattingEnabled = true;
            this.Drop_UpdatePartOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved"});
            this.Drop_UpdatePartOrderStatus.Location = new System.Drawing.Point(61, 141);
            this.Drop_UpdatePartOrderStatus.Name = "Drop_UpdatePartOrderStatus";
            this.Drop_UpdatePartOrderStatus.Size = new System.Drawing.Size(326, 30);
            this.Drop_UpdatePartOrderStatus.TabIndex = 103;
            // 
            // AddCarPartNameText
            // 
            this.AddCarPartNameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartNameText.Location = new System.Drawing.Point(465, 141);
            this.AddCarPartNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartNameText.MaxLength = 10;
            this.AddCarPartNameText.Name = "AddCarPartNameText";
            this.AddCarPartNameText.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartNameText.TabIndex = 102;
            // 
            // Btn_UpadteCarStatus
            // 
            this.Btn_UpadteCarStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_UpadteCarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadteCarStatus.Location = new System.Drawing.Point(465, 452);
            this.Btn_UpadteCarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadteCarStatus.Name = "Btn_UpadteCarStatus";
            this.Btn_UpadteCarStatus.Size = new System.Drawing.Size(323, 50);
            this.Btn_UpadteCarStatus.TabIndex = 100;
            this.Btn_UpadteCarStatus.Text = "UPDATE";
            this.Btn_UpadteCarStatus.UseVisualStyleBackColor = false;
            // 
            // AddCarPartCodeTxt
            // 
            this.AddCarPartCodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartCodeTxt.Location = new System.Drawing.Point(859, 141);
            this.AddCarPartCodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartCodeTxt.MaxLength = 10;
            this.AddCarPartCodeTxt.Name = "AddCarPartCodeTxt";
            this.AddCarPartCodeTxt.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartCodeTxt.TabIndex = 99;
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(855, 30);
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
            this.Drop_CarOrderStatus.Location = new System.Drawing.Point(858, 56);
            this.Drop_CarOrderStatus.Name = "Drop_CarOrderStatus";
            this.Drop_CarOrderStatus.Size = new System.Drawing.Size(326, 30);
            this.Drop_CarOrderStatus.TabIndex = 96;
            this.Drop_CarOrderStatus.SelectedIndexChanged += new System.EventHandler(this.Drop_CarOrderStatus_SelectedIndexChanged);
            // 
            // Tbl_CarAdmin
            // 
            this.Tbl_CarAdmin.AllowUserToAddRows = false;
            this.Tbl_CarAdmin.AllowUserToDeleteRows = false;
            this.Tbl_CarAdmin.AllowUserToResizeColumns = false;
            this.Tbl_CarAdmin.AllowUserToResizeRows = false;
            this.Tbl_CarAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CarAdmin.ColumnHeadersHeight = 29;
            this.Tbl_CarAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ModelName,
            this.ManufacturerName,
            this.VIN,
            this.Transmission,
            this.Year,
            this.FuelType,
            this.Color,
            this.Price,
            this.Condition,
            this.Description});
            this.Tbl_CarAdmin.Location = new System.Drawing.Point(62, 203);
            this.Tbl_CarAdmin.Name = "Tbl_CarAdmin";
            this.Tbl_CarAdmin.RowHeadersWidth = 51;
            this.Tbl_CarAdmin.RowTemplate.Height = 24;
            this.Tbl_CarAdmin.Size = new System.Drawing.Size(1122, 218);
            this.Tbl_CarAdmin.TabIndex = 105;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
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
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.MinimumWidth = 6;
            this.VIN.Name = "VIN";
            this.VIN.Width = 125;
            // 
            // Transmission
            // 
            this.Transmission.HeaderText = "Transmission";
            this.Transmission.MinimumWidth = 6;
            this.Transmission.Name = "Transmission";
            this.Transmission.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // FuelType
            // 
            this.FuelType.HeaderText = "FuelType";
            this.FuelType.MinimumWidth = 6;
            this.FuelType.Name = "FuelType";
            this.FuelType.Width = 125;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 125;
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
            this.Btn_UpadteCarCancel.Location = new System.Drawing.Point(858, 452);
            this.Btn_UpadteCarCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadteCarCancel.Name = "Btn_UpadteCarCancel";
            this.Btn_UpadteCarCancel.Size = new System.Drawing.Size(325, 50);
            this.Btn_UpadteCarCancel.TabIndex = 108;
            this.Btn_UpadteCarCancel.Text = "CANCEL";
            this.Btn_UpadteCarCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadteCarCancel.Click += new System.EventHandler(this.Btn_UpadteCarCancel_Click);
            // 
            // UpadteCarStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_UpadteCarCancel;
            this.ClientSize = new System.Drawing.Size(1233, 552);
            this.Controls.Add(this.Btn_UpadteCarCancel);
            this.Controls.Add(AddCarManufLabel);
            this.Controls.Add(AddCarModelLabel);
            this.Controls.Add(this.Tbl_CarAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Drop_UpdatePartOrderStatus);
            this.Controls.Add(this.AddCarPartNameText);
            this.Controls.Add(this.Btn_UpadteCarStatus);
            this.Controls.Add(this.AddCarPartCodeTxt);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.Drop_CarOrderStatus);
            this.Name = "UpadteCarStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpadteCarStatus";
            this.Load += new System.EventHandler(this.UpadteCarStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Drop_UpdatePartOrderStatus;
        private System.Windows.Forms.TextBox AddCarPartNameText;
        private System.Windows.Forms.Button Btn_UpadteCarStatus;
        private System.Windows.Forms.TextBox AddCarPartCodeTxt;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.ComboBox Drop_CarOrderStatus;
        private System.Windows.Forms.DataGridView Tbl_CarAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button Btn_UpadteCarCancel;
    }
}