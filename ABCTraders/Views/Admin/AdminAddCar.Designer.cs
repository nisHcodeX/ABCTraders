namespace ABCTraders.Views.Admin
{
    partial class AdminAddCar
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
            System.Windows.Forms.Label AddCarModelLabel;
            System.Windows.Forms.Label AddCarManufLabel;
            System.Windows.Forms.Label AddCarTransmissionLabel;
            System.Windows.Forms.Label AddCarColorLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_CarModel = new System.Windows.Forms.ComboBox();
            this.Combo_Manufac = new System.Windows.Forms.ComboBox();
            this.AddCarFuelTypeLabel = new System.Windows.Forms.Label();
            this.AddCarFuelTypeDrop = new System.Windows.Forms.ComboBox();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.AddCarConditionDrop = new System.Windows.Forms.ComboBox();
            this.AddCartVINTxt = new System.Windows.Forms.TextBox();
            this.AddCarVINLabel = new System.Windows.Forms.Label();
            this.AddCarPriceLabel = new System.Windows.Forms.Label();
            this.AddCarPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCarPhotoBtn = new System.Windows.Forms.Button();
            this.AddCarPicutureBox = new System.Windows.Forms.PictureBox();
            this.AddCarSaveBtn = new System.Windows.Forms.Button();
            this.AddCarDeleteBtn = new System.Windows.Forms.Button();
            this.AddCarDescriptionTxt = new System.Windows.Forms.TextBox();
            this.AddCarDescriptionLabel = new System.Windows.Forms.Label();
            this.AddCarYearNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCarYearLabel = new System.Windows.Forms.Label();
            this.AddCarTbl = new System.Windows.Forms.DataGridView();
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
            this.AddCarTransmissionDrop = new System.Windows.Forms.ComboBox();
            this.AddCarColorDrop = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Drop_CarStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            AddCarModelLabel = new System.Windows.Forms.Label();
            AddCarManufLabel = new System.Windows.Forms.Label();
            AddCarTransmissionLabel = new System.Windows.Forms.Label();
            AddCarColorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPicutureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarYearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarTbl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCarModelLabel
            // 
            AddCarModelLabel.AutoSize = true;
            AddCarModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarModelLabel.Location = new System.Drawing.Point(382, 115);
            AddCarModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarModelLabel.Name = "AddCarModelLabel";
            AddCarModelLabel.Size = new System.Drawing.Size(58, 22);
            AddCarModelLabel.TabIndex = 12;
            AddCarModelLabel.Text = "Model";
            // 
            // AddCarManufLabel
            // 
            AddCarManufLabel.AutoSize = true;
            AddCarManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarManufLabel.Location = new System.Drawing.Point(381, 56);
            AddCarManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarManufLabel.Name = "AddCarManufLabel";
            AddCarManufLabel.Size = new System.Drawing.Size(120, 22);
            AddCarManufLabel.TabIndex = 15;
            AddCarManufLabel.Text = "Manufacturer ";
            AddCarManufLabel.Click += new System.EventHandler(this.AddCarManufLabel_Click);
            // 
            // AddCarTransmissionLabel
            // 
            AddCarTransmissionLabel.AutoSize = true;
            AddCarTransmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarTransmissionLabel.Location = new System.Drawing.Point(382, 234);
            AddCarTransmissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarTransmissionLabel.Name = "AddCarTransmissionLabel";
            AddCarTransmissionLabel.Size = new System.Drawing.Size(117, 22);
            AddCarTransmissionLabel.TabIndex = 21;
            AddCarTransmissionLabel.Text = "Transmission";
            AddCarTransmissionLabel.Click += new System.EventHandler(this.AddCarTransmissionLabel_Click);
            // 
            // AddCarColorLabel
            // 
            AddCarColorLabel.AutoSize = true;
            AddCarColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarColorLabel.Location = new System.Drawing.Point(781, 172);
            AddCarColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarColorLabel.Name = "AddCarColorLabel";
            AddCarColorLabel.Size = new System.Drawing.Size(53, 22);
            AddCarColorLabel.TabIndex = 24;
            AddCarColorLabel.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1298, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 3;
            // 
            // Combo_CarModel
            // 
            this.Combo_CarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_CarModel.FormattingEnabled = true;
            this.Combo_CarModel.Location = new System.Drawing.Point(383, 141);
            this.Combo_CarModel.Name = "Combo_CarModel";
            this.Combo_CarModel.Size = new System.Drawing.Size(320, 30);
            this.Combo_CarModel.TabIndex = 14;
            this.Combo_CarModel.SelectedIndexChanged += new System.EventHandler(this.AddCarModelCombBx_SelectedIndexChanged);
            // 
            // Combo_Manufac
            // 
            this.Combo_Manufac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Manufac.FormattingEnabled = true;
            this.Combo_Manufac.Location = new System.Drawing.Point(383, 81);
            this.Combo_Manufac.Name = "Combo_Manufac";
            this.Combo_Manufac.Size = new System.Drawing.Size(320, 30);
            this.Combo_Manufac.TabIndex = 16;
            this.Combo_Manufac.SelectedIndexChanged += new System.EventHandler(this.AddCarManufCombBx_SelectedIndexChanged);
            // 
            // AddCarFuelTypeLabel
            // 
            this.AddCarFuelTypeLabel.AutoSize = true;
            this.AddCarFuelTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarFuelTypeLabel.Location = new System.Drawing.Point(385, 402);
            this.AddCarFuelTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarFuelTypeLabel.Name = "AddCarFuelTypeLabel";
            this.AddCarFuelTypeLabel.Size = new System.Drawing.Size(91, 22);
            this.AddCarFuelTypeLabel.TabIndex = 26;
            this.AddCarFuelTypeLabel.Text = "Fuel Type";
            // 
            // AddCarFuelTypeDrop
            // 
            this.AddCarFuelTypeDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarFuelTypeDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarFuelTypeDrop.FormattingEnabled = true;
            this.AddCarFuelTypeDrop.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Electric",
            "Hybrid"});
            this.AddCarFuelTypeDrop.Location = new System.Drawing.Point(387, 427);
            this.AddCarFuelTypeDrop.Name = "AddCarFuelTypeDrop";
            this.AddCarFuelTypeDrop.Size = new System.Drawing.Size(320, 30);
            this.AddCarFuelTypeDrop.TabIndex = 25;
            this.AddCarFuelTypeDrop.SelectedIndexChanged += new System.EventHandler(this.AddCarFuelTypeDrop_SelectedIndexChanged);
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(785, 290);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(86, 22);
            this.AddCarConditionLabel.TabIndex = 28;
            this.AddCarConditionLabel.Text = "Condition";
            // 
            // AddCarConditionDrop
            // 
            this.AddCarConditionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarConditionDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionDrop.FormattingEnabled = true;
            this.AddCarConditionDrop.Items.AddRange(new object[] {
            "Brand New",
            "Used"});
            this.AddCarConditionDrop.Location = new System.Drawing.Point(788, 316);
            this.AddCarConditionDrop.Name = "AddCarConditionDrop";
            this.AddCarConditionDrop.Size = new System.Drawing.Size(320, 30);
            this.AddCarConditionDrop.TabIndex = 27;
            this.AddCarConditionDrop.SelectedIndexChanged += new System.EventHandler(this.AddCarConditionDrop_SelectedIndexChanged);
            // 
            // AddCartVINTxt
            // 
            this.AddCartVINTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCartVINTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCartVINTxt.Location = new System.Drawing.Point(384, 201);
            this.AddCartVINTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCartVINTxt.MaxLength = 17;
            this.AddCartVINTxt.Name = "AddCartVINTxt";
            this.AddCartVINTxt.Size = new System.Drawing.Size(320, 28);
            this.AddCartVINTxt.TabIndex = 30;
            this.AddCartVINTxt.TextChanged += new System.EventHandler(this.AddCartVINTxt_TextChanged);
            // 
            // AddCarVINLabel
            // 
            this.AddCarVINLabel.AutoSize = true;
            this.AddCarVINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarVINLabel.Location = new System.Drawing.Point(385, 176);
            this.AddCarVINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarVINLabel.Name = "AddCarVINLabel";
            this.AddCarVINLabel.Size = new System.Drawing.Size(288, 22);
            this.AddCarVINLabel.TabIndex = 29;
            this.AddCarVINLabel.Text = "VIN (Vehicle Identification Number)";
            this.AddCarVINLabel.Click += new System.EventHandler(this.AddCarVINLabel_Click);
            // 
            // AddCarPriceLabel
            // 
            this.AddCarPriceLabel.AutoSize = true;
            this.AddCarPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPriceLabel.Location = new System.Drawing.Point(784, 232);
            this.AddCarPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPriceLabel.Name = "AddCarPriceLabel";
            this.AddCarPriceLabel.Size = new System.Drawing.Size(51, 22);
            this.AddCarPriceLabel.TabIndex = 31;
            this.AddCarPriceLabel.Text = "Price";
            // 
            // AddCarPriceNumeric
            // 
            this.AddCarPriceNumeric.DecimalPlaces = 2;
            this.AddCarPriceNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPriceNumeric.Location = new System.Drawing.Point(788, 257);
            this.AddCarPriceNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AddCarPriceNumeric.Name = "AddCarPriceNumeric";
            this.AddCarPriceNumeric.Size = new System.Drawing.Size(320, 28);
            this.AddCarPriceNumeric.TabIndex = 32;
            this.AddCarPriceNumeric.ValueChanged += new System.EventHandler(this.AddCarPriceNumeric_ValueChanged);
            // 
            // AddCarPhotoBtn
            // 
            this.AddCarPhotoBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCarPhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPhotoBtn.Location = new System.Drawing.Point(63, 245);
            this.AddCarPhotoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPhotoBtn.Name = "AddCarPhotoBtn";
            this.AddCarPhotoBtn.Size = new System.Drawing.Size(267, 50);
            this.AddCarPhotoBtn.TabIndex = 35;
            this.AddCarPhotoBtn.Text = "Add Car Photo";
            this.AddCarPhotoBtn.UseVisualStyleBackColor = false;
            this.AddCarPhotoBtn.Click += new System.EventHandler(this.AddCarPhotoBtn_Click);
            // 
            // AddCarPicutureBox
            // 
            this.AddCarPicutureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddCarPicutureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddCarPicutureBox.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.AddCarPicutureBox.Location = new System.Drawing.Point(63, 59);
            this.AddCarPicutureBox.Name = "AddCarPicutureBox";
            this.AddCarPicutureBox.Size = new System.Drawing.Size(267, 164);
            this.AddCarPicutureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddCarPicutureBox.TabIndex = 34;
            this.AddCarPicutureBox.TabStop = false;
            this.AddCarPicutureBox.WaitOnLoad = true;
            this.AddCarPicutureBox.Click += new System.EventHandler(this.AddCarPicutureBox_Click);
            // 
            // AddCarSaveBtn
            // 
            this.AddCarSaveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddCarSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarSaveBtn.Location = new System.Drawing.Point(63, 348);
            this.AddCarSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarSaveBtn.Name = "AddCarSaveBtn";
            this.AddCarSaveBtn.Size = new System.Drawing.Size(267, 50);
            this.AddCarSaveBtn.TabIndex = 36;
            this.AddCarSaveBtn.Text = "Save";
            this.AddCarSaveBtn.UseVisualStyleBackColor = false;
            this.AddCarSaveBtn.Click += new System.EventHandler(this.AddCarSaveBtn_Click);
            // 
            // AddCarDeleteBtn
            // 
            this.AddCarDeleteBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddCarDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCarDeleteBtn.Location = new System.Drawing.Point(63, 405);
            this.AddCarDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarDeleteBtn.Name = "AddCarDeleteBtn";
            this.AddCarDeleteBtn.Size = new System.Drawing.Size(267, 50);
            this.AddCarDeleteBtn.TabIndex = 37;
            this.AddCarDeleteBtn.Text = "Delete";
            this.AddCarDeleteBtn.UseVisualStyleBackColor = false;
            this.AddCarDeleteBtn.Click += new System.EventHandler(this.AddCarDeleteBtn_Click);
            // 
            // AddCarDescriptionTxt
            // 
            this.AddCarDescriptionTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDescriptionTxt.Location = new System.Drawing.Point(389, 318);
            this.AddCarDescriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarDescriptionTxt.MaxLength = 100000;
            this.AddCarDescriptionTxt.Multiline = true;
            this.AddCarDescriptionTxt.Name = "AddCarDescriptionTxt";
            this.AddCarDescriptionTxt.Size = new System.Drawing.Size(320, 80);
            this.AddCarDescriptionTxt.TabIndex = 39;
            this.AddCarDescriptionTxt.TextChanged += new System.EventHandler(this.AddCarDescriptionTxt_TextChanged);
            // 
            // AddCarDescriptionLabel
            // 
            this.AddCarDescriptionLabel.AutoSize = true;
            this.AddCarDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDescriptionLabel.Location = new System.Drawing.Point(385, 291);
            this.AddCarDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarDescriptionLabel.Name = "AddCarDescriptionLabel";
            this.AddCarDescriptionLabel.Size = new System.Drawing.Size(100, 22);
            this.AddCarDescriptionLabel.TabIndex = 38;
            this.AddCarDescriptionLabel.Text = "Description";
            // 
            // AddCarYearNumeric
            // 
            this.AddCarYearNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarYearNumeric.Location = new System.Drawing.Point(784, 375);
            this.AddCarYearNumeric.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.AddCarYearNumeric.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.AddCarYearNumeric.Name = "AddCarYearNumeric";
            this.AddCarYearNumeric.Size = new System.Drawing.Size(320, 28);
            this.AddCarYearNumeric.TabIndex = 42;
            this.AddCarYearNumeric.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.AddCarYearNumeric.ValueChanged += new System.EventHandler(this.AddCarYearNumeric_ValueChanged);
            // 
            // AddCarYearLabel
            // 
            this.AddCarYearLabel.AutoSize = true;
            this.AddCarYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarYearLabel.Location = new System.Drawing.Point(781, 349);
            this.AddCarYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarYearLabel.Name = "AddCarYearLabel";
            this.AddCarYearLabel.Size = new System.Drawing.Size(48, 22);
            this.AddCarYearLabel.TabIndex = 41;
            this.AddCarYearLabel.Text = "Year";
            // 
            // AddCarTbl
            // 
            this.AddCarTbl.AllowUserToAddRows = false;
            this.AddCarTbl.AllowUserToDeleteRows = false;
            this.AddCarTbl.AllowUserToResizeColumns = false;
            this.AddCarTbl.AllowUserToResizeRows = false;
            this.AddCarTbl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCarTbl.ColumnHeadersHeight = 29;
            this.AddCarTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.AddCarTbl.Location = new System.Drawing.Point(63, 484);
            this.AddCarTbl.Name = "AddCarTbl";
            this.AddCarTbl.RowHeadersWidth = 51;
            this.AddCarTbl.RowTemplate.Height = 24;
            this.AddCarTbl.Size = new System.Drawing.Size(1045, 137);
            this.AddCarTbl.TabIndex = 43;
            this.AddCarTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddCarTbl_CellContentClick);
            this.AddCarTbl.SelectionChanged += new System.EventHandler(this.AddCarTbl_SelectionChanged);
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
            // AddCarTransmissionDrop
            // 
            this.AddCarTransmissionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarTransmissionDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarTransmissionDrop.FormattingEnabled = true;
            this.AddCarTransmissionDrop.Items.AddRange(new object[] {
            "Automatic ",
            "Manual ",
            "Automated & Manual",
            "CVT"});
            this.AddCarTransmissionDrop.Location = new System.Drawing.Point(384, 257);
            this.AddCarTransmissionDrop.Name = "AddCarTransmissionDrop";
            this.AddCarTransmissionDrop.Size = new System.Drawing.Size(320, 30);
            this.AddCarTransmissionDrop.TabIndex = 44;
            this.AddCarTransmissionDrop.SelectedIndexChanged += new System.EventHandler(this.AddCarTransmissionDrop_SelectedIndexChanged);
            // 
            // AddCarColorDrop
            // 
            this.AddCarColorDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarColorDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarColorDrop.FormattingEnabled = true;
            this.AddCarColorDrop.Items.AddRange(new object[] {
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
            this.AddCarColorDrop.Location = new System.Drawing.Point(784, 197);
            this.AddCarColorDrop.Name = "AddCarColorDrop";
            this.AddCarColorDrop.Size = new System.Drawing.Size(320, 30);
            this.AddCarColorDrop.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Drop_CarStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(789, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 99);
            this.panel1.TabIndex = 74;
            // 
            // Drop_CarStatus
            // 
            this.Drop_CarStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_CarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_CarStatus.FormattingEnabled = true;
            this.Drop_CarStatus.Items.AddRange(new object[] {
            "Available",
            "Deleted"});
            this.Drop_CarStatus.Location = new System.Drawing.Point(24, 47);
            this.Drop_CarStatus.Name = "Drop_CarStatus";
            this.Drop_CarStatus.Size = new System.Drawing.Size(279, 30);
            this.Drop_CarStatus.TabIndex = 111;
            this.Drop_CarStatus.SelectedIndexChanged += new System.EventHandler(this.Drop_CarStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 75;
            this.label2.Text = "Status";
            // 
            // AdminAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 708);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddCarColorDrop);
            this.Controls.Add(this.AddCarTransmissionDrop);
            this.Controls.Add(this.AddCarTbl);
            this.Controls.Add(this.AddCarYearNumeric);
            this.Controls.Add(this.AddCarYearLabel);
            this.Controls.Add(this.AddCarDescriptionTxt);
            this.Controls.Add(this.AddCarDescriptionLabel);
            this.Controls.Add(this.AddCarDeleteBtn);
            this.Controls.Add(this.AddCarSaveBtn);
            this.Controls.Add(this.AddCarPhotoBtn);
            this.Controls.Add(this.AddCarPicutureBox);
            this.Controls.Add(this.AddCarPriceNumeric);
            this.Controls.Add(this.AddCarPriceLabel);
            this.Controls.Add(this.AddCartVINTxt);
            this.Controls.Add(this.AddCarVINLabel);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.AddCarConditionDrop);
            this.Controls.Add(this.AddCarFuelTypeLabel);
            this.Controls.Add(this.AddCarFuelTypeDrop);
            this.Controls.Add(AddCarColorLabel);
            this.Controls.Add(AddCarTransmissionLabel);
            this.Controls.Add(this.Combo_Manufac);
            this.Controls.Add(AddCarManufLabel);
            this.Controls.Add(this.Combo_CarModel);
            this.Controls.Add(AddCarModelLabel);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddCar";
            this.Text = "AdminAddCar";
            this.Load += new System.EventHandler(this.AdminAddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPicutureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarYearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarTbl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_CarModel;
        private System.Windows.Forms.ComboBox Combo_Manufac;
        private System.Windows.Forms.Label AddCarFuelTypeLabel;
        private System.Windows.Forms.ComboBox AddCarFuelTypeDrop;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.ComboBox AddCarConditionDrop;
        private System.Windows.Forms.TextBox AddCartVINTxt;
        private System.Windows.Forms.Label AddCarVINLabel;
        private System.Windows.Forms.Label AddCarPriceLabel;
        private System.Windows.Forms.NumericUpDown AddCarPriceNumeric;
        private System.Windows.Forms.Button AddCarPhotoBtn;
        private System.Windows.Forms.Button AddCarSaveBtn;
        private System.Windows.Forms.Button AddCarDeleteBtn;
        private System.Windows.Forms.TextBox AddCarDescriptionTxt;
        private System.Windows.Forms.Label AddCarDescriptionLabel;
        private System.Windows.Forms.NumericUpDown AddCarYearNumeric;
        private System.Windows.Forms.Label AddCarYearLabel;
        private System.Windows.Forms.DataGridView AddCarTbl;
        private System.Windows.Forms.ComboBox AddCarTransmissionDrop;
        private System.Windows.Forms.ComboBox AddCarColorDrop;
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
        private System.Windows.Forms.PictureBox AddCarPicutureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Drop_CarStatus;
        private System.Windows.Forms.Label label2;
    }
}