namespace ABCTraders.Views
{
    partial class SearchCar
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
            System.Windows.Forms.Label AddCarColorLabel;
            System.Windows.Forms.Label AddCarTransmissionLabel;
            System.Windows.Forms.Label AddCarManufLabel;
            System.Windows.Forms.Label AddCarModelLabel;
            this.Tbl_CarList = new System.Windows.Forms.DataGridView();
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
            this.AddCarYearLabel = new System.Windows.Forms.Label();
            this.AddCarDescriptionLabel = new System.Windows.Forms.Label();
            this.AddCarPriceLabel = new System.Windows.Forms.Label();
            this.AddCarVINLabel = new System.Windows.Forms.Label();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.AddCarFuelTypeLabel = new System.Windows.Forms.Label();
            this.TxtBox_SearchCar = new System.Windows.Forms.TextBox();
            this.Btn_SearchCar = new System.Windows.Forms.Button();
            this.Btn_OrderCar = new System.Windows.Forms.Button();
            this.TxtBox_Manufacture = new System.Windows.Forms.TextBox();
            this.TxtBox_Model = new System.Windows.Forms.TextBox();
            this.TxtBox_VIN = new System.Windows.Forms.TextBox();
            this.TxtBox_Description = new System.Windows.Forms.TextBox();
            this.Drop_Condition = new System.Windows.Forms.ComboBox();
            this.Numeric_Price = new System.Windows.Forms.NumericUpDown();
            this.Drop_Color = new System.Windows.Forms.ComboBox();
            this.Numeric_CarYear = new System.Windows.Forms.NumericUpDown();
            this.Drop_Transmission = new System.Windows.Forms.ComboBox();
            this.Drop_FuelType = new System.Windows.Forms.ComboBox();
            this.PicBx_CarPhoto = new System.Windows.Forms.PictureBox();
            AddCarColorLabel = new System.Windows.Forms.Label();
            AddCarTransmissionLabel = new System.Windows.Forms.Label();
            AddCarManufLabel = new System.Windows.Forms.Label();
            AddCarModelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CarYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarColorLabel
            // 
            AddCarColorLabel.AutoSize = true;
            AddCarColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarColorLabel.Location = new System.Drawing.Point(792, 24);
            AddCarColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarColorLabel.Name = "AddCarColorLabel";
            AddCarColorLabel.Size = new System.Drawing.Size(68, 22);
            AddCarColorLabel.TabIndex = 51;
            AddCarColorLabel.Text = "Color : ";
            // 
            // AddCarTransmissionLabel
            // 
            AddCarTransmissionLabel.AutoSize = true;
            AddCarTransmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarTransmissionLabel.Location = new System.Drawing.Point(416, 236);
            AddCarTransmissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarTransmissionLabel.Name = "AddCarTransmissionLabel";
            AddCarTransmissionLabel.Size = new System.Drawing.Size(127, 22);
            AddCarTransmissionLabel.TabIndex = 50;
            AddCarTransmissionLabel.Text = "Transmission :";
            AddCarTransmissionLabel.Click += new System.EventHandler(this.AddCarTransmissionLabel_Click);
            // 
            // AddCarManufLabel
            // 
            AddCarManufLabel.AutoSize = true;
            AddCarManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarManufLabel.Location = new System.Drawing.Point(415, 26);
            AddCarManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarManufLabel.Name = "AddCarManufLabel";
            AddCarManufLabel.Size = new System.Drawing.Size(125, 22);
            AddCarManufLabel.TabIndex = 48;
            AddCarManufLabel.Text = "Manufacturer :";
            // 
            // AddCarModelLabel
            // 
            AddCarModelLabel.AutoSize = true;
            AddCarModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarModelLabel.Location = new System.Drawing.Point(413, 91);
            AddCarModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarModelLabel.Name = "AddCarModelLabel";
            AddCarModelLabel.Size = new System.Drawing.Size(68, 22);
            AddCarModelLabel.TabIndex = 46;
            AddCarModelLabel.Text = "Model :";
            // 
            // Tbl_CarList
            // 
            this.Tbl_CarList.AllowUserToAddRows = false;
            this.Tbl_CarList.AllowUserToDeleteRows = false;
            this.Tbl_CarList.AllowUserToResizeColumns = false;
            this.Tbl_CarList.AllowUserToResizeRows = false;
            this.Tbl_CarList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CarList.ColumnHeadersHeight = 29;
            this.Tbl_CarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Tbl_CarList.Location = new System.Drawing.Point(75, 467);
            this.Tbl_CarList.Name = "Tbl_CarList";
            this.Tbl_CarList.RowHeadersWidth = 51;
            this.Tbl_CarList.RowTemplate.Height = 24;
            this.Tbl_CarList.Size = new System.Drawing.Size(1009, 206);
            this.Tbl_CarList.TabIndex = 68;
            this.Tbl_CarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_CarList_CellContentClick_1);
            this.Tbl_CarList.SelectionChanged += new System.EventHandler(this.Tbl_CarList_SelectionChanged);
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
            // AddCarYearLabel
            // 
            this.AddCarYearLabel.AutoSize = true;
            this.AddCarYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarYearLabel.Location = new System.Drawing.Point(793, 244);
            this.AddCarYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarYearLabel.Name = "AddCarYearLabel";
            this.AddCarYearLabel.Size = new System.Drawing.Size(58, 22);
            this.AddCarYearLabel.TabIndex = 66;
            this.AddCarYearLabel.Text = "Year :";
            // 
            // AddCarDescriptionLabel
            // 
            this.AddCarDescriptionLabel.AutoSize = true;
            this.AddCarDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDescriptionLabel.Location = new System.Drawing.Point(790, 314);
            this.AddCarDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarDescriptionLabel.Name = "AddCarDescriptionLabel";
            this.AddCarDescriptionLabel.Size = new System.Drawing.Size(110, 22);
            this.AddCarDescriptionLabel.TabIndex = 64;
            this.AddCarDescriptionLabel.Text = "Description :";
            // 
            // AddCarPriceLabel
            // 
            this.AddCarPriceLabel.AutoSize = true;
            this.AddCarPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPriceLabel.Location = new System.Drawing.Point(791, 99);
            this.AddCarPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPriceLabel.Name = "AddCarPriceLabel";
            this.AddCarPriceLabel.Size = new System.Drawing.Size(66, 22);
            this.AddCarPriceLabel.TabIndex = 58;
            this.AddCarPriceLabel.Text = "Price : ";
            // 
            // AddCarVINLabel
            // 
            this.AddCarVINLabel.AutoSize = true;
            this.AddCarVINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarVINLabel.Location = new System.Drawing.Point(416, 163);
            this.AddCarVINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarVINLabel.Name = "AddCarVINLabel";
            this.AddCarVINLabel.Size = new System.Drawing.Size(303, 22);
            this.AddCarVINLabel.TabIndex = 56;
            this.AddCarVINLabel.Text = "VIN (Vehicle Identification Number) : ";
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(793, 175);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(101, 22);
            this.AddCarConditionLabel.TabIndex = 55;
            this.AddCarConditionLabel.Text = "Condition : ";
            // 
            // AddCarFuelTypeLabel
            // 
            this.AddCarFuelTypeLabel.AutoSize = true;
            this.AddCarFuelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarFuelTypeLabel.Location = new System.Drawing.Point(416, 303);
            this.AddCarFuelTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarFuelTypeLabel.Name = "AddCarFuelTypeLabel";
            this.AddCarFuelTypeLabel.Size = new System.Drawing.Size(101, 22);
            this.AddCarFuelTypeLabel.TabIndex = 53;
            this.AddCarFuelTypeLabel.Text = "Fuel Type :";
            // 
            // TxtBox_SearchCar
            // 
            this.TxtBox_SearchCar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_SearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_SearchCar.Location = new System.Drawing.Point(73, 48);
            this.TxtBox_SearchCar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_SearchCar.MaxLength = 10;
            this.TxtBox_SearchCar.Name = "TxtBox_SearchCar";
            this.TxtBox_SearchCar.Size = new System.Drawing.Size(288, 27);
            this.TxtBox_SearchCar.TabIndex = 117;
            // 
            // Btn_SearchCar
            // 
            this.Btn_SearchCar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_SearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchCar.Location = new System.Drawing.Point(73, 100);
            this.Btn_SearchCar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SearchCar.Name = "Btn_SearchCar";
            this.Btn_SearchCar.Size = new System.Drawing.Size(288, 50);
            this.Btn_SearchCar.TabIndex = 116;
            this.Btn_SearchCar.Text = "SEARCH CAR";
            this.Btn_SearchCar.UseVisualStyleBackColor = false;
            this.Btn_SearchCar.Click += new System.EventHandler(this.Btn_SearchCar_Click);
            // 
            // Btn_OrderCar
            // 
            this.Btn_OrderCar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_OrderCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderCar.Location = new System.Drawing.Point(73, 364);
            this.Btn_OrderCar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OrderCar.Name = "Btn_OrderCar";
            this.Btn_OrderCar.Size = new System.Drawing.Size(288, 50);
            this.Btn_OrderCar.TabIndex = 115;
            this.Btn_OrderCar.Text = "ORDER";
            this.Btn_OrderCar.UseVisualStyleBackColor = false;
            this.Btn_OrderCar.Click += new System.EventHandler(this.Btn_OrderCar_Click);
            // 
            // TxtBox_Manufacture
            // 
            this.TxtBox_Manufacture.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Manufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Manufacture.Location = new System.Drawing.Point(417, 52);
            this.TxtBox_Manufacture.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Manufacture.MaxLength = 10;
            this.TxtBox_Manufacture.Name = "TxtBox_Manufacture";
            this.TxtBox_Manufacture.Size = new System.Drawing.Size(288, 27);
            this.TxtBox_Manufacture.TabIndex = 128;
            // 
            // TxtBox_Model
            // 
            this.TxtBox_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Model.Location = new System.Drawing.Point(417, 117);
            this.TxtBox_Model.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Model.MaxLength = 10;
            this.TxtBox_Model.Name = "TxtBox_Model";
            this.TxtBox_Model.Size = new System.Drawing.Size(288, 27);
            this.TxtBox_Model.TabIndex = 129;
            // 
            // TxtBox_VIN
            // 
            this.TxtBox_VIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_VIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_VIN.Location = new System.Drawing.Point(420, 192);
            this.TxtBox_VIN.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_VIN.MaxLength = 10;
            this.TxtBox_VIN.Name = "TxtBox_VIN";
            this.TxtBox_VIN.Size = new System.Drawing.Size(285, 27);
            this.TxtBox_VIN.TabIndex = 130;
            // 
            // TxtBox_Description
            // 
            this.TxtBox_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Description.Location = new System.Drawing.Point(796, 340);
            this.TxtBox_Description.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Description.MaxLength = 10;
            this.TxtBox_Description.Multiline = true;
            this.TxtBox_Description.Name = "TxtBox_Description";
            this.TxtBox_Description.Size = new System.Drawing.Size(288, 84);
            this.TxtBox_Description.TabIndex = 132;
            // 
            // Drop_Condition
            // 
            this.Drop_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_Condition.FormattingEnabled = true;
            this.Drop_Condition.Items.AddRange(new object[] {
            "Brand New",
            "Used"});
            this.Drop_Condition.Location = new System.Drawing.Point(796, 200);
            this.Drop_Condition.Name = "Drop_Condition";
            this.Drop_Condition.Size = new System.Drawing.Size(288, 28);
            this.Drop_Condition.TabIndex = 138;
            // 
            // Numeric_Price
            // 
            this.Numeric_Price.DecimalPlaces = 2;
            this.Numeric_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Price.Location = new System.Drawing.Point(796, 135);
            this.Numeric_Price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numeric_Price.Name = "Numeric_Price";
            this.Numeric_Price.Size = new System.Drawing.Size(288, 28);
            this.Numeric_Price.TabIndex = 139;
            // 
            // Drop_Color
            // 
            this.Drop_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_Color.FormattingEnabled = true;
            this.Drop_Color.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "White",
            "Black",
            "Silver ",
            "Grey ",
            "Green",
            "Yellow ",
            "Orange",
            "Brown",
            "Other"});
            this.Drop_Color.Location = new System.Drawing.Point(794, 53);
            this.Drop_Color.Name = "Drop_Color";
            this.Drop_Color.Size = new System.Drawing.Size(288, 28);
            this.Drop_Color.TabIndex = 140;
            // 
            // Numeric_CarYear
            // 
            this.Numeric_CarYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_CarYear.Location = new System.Drawing.Point(794, 269);
            this.Numeric_CarYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Numeric_CarYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.Numeric_CarYear.Name = "Numeric_CarYear";
            this.Numeric_CarYear.Size = new System.Drawing.Size(290, 28);
            this.Numeric_CarYear.TabIndex = 141;
            this.Numeric_CarYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // Drop_Transmission
            // 
            this.Drop_Transmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_Transmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_Transmission.FormattingEnabled = true;
            this.Drop_Transmission.Items.AddRange(new object[] {
            "Automatic ",
            "Manual ",
            "Automated & Manual",
            "CVT"});
            this.Drop_Transmission.Location = new System.Drawing.Point(420, 261);
            this.Drop_Transmission.Name = "Drop_Transmission";
            this.Drop_Transmission.Size = new System.Drawing.Size(285, 28);
            this.Drop_Transmission.TabIndex = 143;
            // 
            // Drop_FuelType
            // 
            this.Drop_FuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_FuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_FuelType.FormattingEnabled = true;
            this.Drop_FuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.Drop_FuelType.Location = new System.Drawing.Point(420, 328);
            this.Drop_FuelType.Name = "Drop_FuelType";
            this.Drop_FuelType.Size = new System.Drawing.Size(285, 28);
            this.Drop_FuelType.TabIndex = 142;
            // 
            // PicBx_CarPhoto
            // 
            this.PicBx_CarPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_CarPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_CarPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_CarPhoto.Location = new System.Drawing.Point(73, 169);
            this.PicBx_CarPhoto.Name = "PicBx_CarPhoto";
            this.PicBx_CarPhoto.Size = new System.Drawing.Size(288, 164);
            this.PicBx_CarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_CarPhoto.TabIndex = 60;
            this.PicBx_CarPhoto.TabStop = false;
            this.PicBx_CarPhoto.WaitOnLoad = true;
            // 
            // SearchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 704);
            this.Controls.Add(this.Drop_Transmission);
            this.Controls.Add(this.Drop_FuelType);
            this.Controls.Add(this.Numeric_CarYear);
            this.Controls.Add(this.Drop_Color);
            this.Controls.Add(this.Numeric_Price);
            this.Controls.Add(this.Drop_Condition);
            this.Controls.Add(this.TxtBox_Description);
            this.Controls.Add(this.TxtBox_VIN);
            this.Controls.Add(this.TxtBox_Model);
            this.Controls.Add(this.TxtBox_Manufacture);
            this.Controls.Add(this.TxtBox_SearchCar);
            this.Controls.Add(this.Btn_SearchCar);
            this.Controls.Add(this.Btn_OrderCar);
            this.Controls.Add(this.Tbl_CarList);
            this.Controls.Add(this.AddCarYearLabel);
            this.Controls.Add(this.AddCarDescriptionLabel);
            this.Controls.Add(this.PicBx_CarPhoto);
            this.Controls.Add(this.AddCarPriceLabel);
            this.Controls.Add(this.AddCarVINLabel);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.AddCarFuelTypeLabel);
            this.Controls.Add(AddCarColorLabel);
            this.Controls.Add(AddCarTransmissionLabel);
            this.Controls.Add(AddCarManufLabel);
            this.Controls.Add(AddCarModelLabel);
            this.Name = "SearchCar";
            this.Text = "SearchCar";
            this.Load += new System.EventHandler(this.SearchCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CarYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Tbl_CarList;
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
        private System.Windows.Forms.Label AddCarYearLabel;
        private System.Windows.Forms.Label AddCarDescriptionLabel;
        private System.Windows.Forms.PictureBox PicBx_CarPhoto;
        private System.Windows.Forms.Label AddCarPriceLabel;
        private System.Windows.Forms.Label AddCarVINLabel;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.Label AddCarFuelTypeLabel;
        private System.Windows.Forms.TextBox TxtBox_SearchCar;
        private System.Windows.Forms.Button Btn_SearchCar;
        private System.Windows.Forms.Button Btn_OrderCar;
        private System.Windows.Forms.TextBox TxtBox_Manufacture;
        private System.Windows.Forms.TextBox TxtBox_Model;
        private System.Windows.Forms.TextBox TxtBox_VIN;
        private System.Windows.Forms.TextBox TxtBox_Description;
        private System.Windows.Forms.ComboBox Drop_Condition;
        private System.Windows.Forms.NumericUpDown Numeric_Price;
        private System.Windows.Forms.ComboBox Drop_Color;
        private System.Windows.Forms.NumericUpDown Numeric_CarYear;
        private System.Windows.Forms.ComboBox Drop_Transmission;
        private System.Windows.Forms.ComboBox Drop_FuelType;
    }
}