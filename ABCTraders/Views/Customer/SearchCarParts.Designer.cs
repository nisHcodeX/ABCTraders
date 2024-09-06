namespace ABCTraders.Views.Customer
{
    partial class SearchCarParts
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
            System.Windows.Forms.Label AddCarPartCategoryLabel;
            System.Windows.Forms.Label AddCarPartManufLabel;
            System.Windows.Forms.Label AddCarPartNameLabel;
            this.Drop_Category = new System.Windows.Forms.ComboBox();
            this.TxtBox_PartName = new System.Windows.Forms.TextBox();
            this.Tbl_CarPartsList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeric_Price = new System.Windows.Forms.NumericUpDown();
            this.AddCarPartPriceLabel = new System.Windows.Forms.Label();
            this.TxtBox_Description = new System.Windows.Forms.TextBox();
            this.AddCarDescriptionLabel = new System.Windows.Forms.Label();
            this.Btn_OrderPart = new System.Windows.Forms.Button();
            this.PicBx_CarPartPhoto = new System.Windows.Forms.PictureBox();
            this.Numeric_Quantity = new System.Windows.Forms.NumericUpDown();
            this.AddCarPartQuantityLabel = new System.Windows.Forms.Label();
            this.TxtBox_PartCode = new System.Windows.Forms.TextBox();
            this.AddCarPartPartCodeLabel = new System.Windows.Forms.Label();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.Drop_Condition = new System.Windows.Forms.ComboBox();
            this.Btn_SearchCarPart = new System.Windows.Forms.Button();
            this.TxtBox_SearchPart = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Numeric_QuantityPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Manufacturer = new System.Windows.Forms.TextBox();
            this.Numeric_Stock = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            AddCarPartCategoryLabel = new System.Windows.Forms.Label();
            AddCarPartManufLabel = new System.Windows.Forms.Label();
            AddCarPartNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarPartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPartPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Quantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_QuantityPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarPartCategoryLabel
            // 
            AddCarPartCategoryLabel.AutoSize = true;
            AddCarPartCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartCategoryLabel.Location = new System.Drawing.Point(423, 156);
            AddCarPartCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartCategoryLabel.Name = "AddCarPartCategoryLabel";
            AddCarPartCategoryLabel.Size = new System.Drawing.Size(83, 22);
            AddCarPartCategoryLabel.TabIndex = 107;
            AddCarPartCategoryLabel.Text = "Category";
            // 
            // AddCarPartManufLabel
            // 
            AddCarPartManufLabel.AutoSize = true;
            AddCarPartManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartManufLabel.Location = new System.Drawing.Point(421, 34);
            AddCarPartManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartManufLabel.Name = "AddCarPartManufLabel";
            AddCarPartManufLabel.Size = new System.Drawing.Size(120, 22);
            AddCarPartManufLabel.TabIndex = 95;
            AddCarPartManufLabel.Text = "Manufacturer ";
            // 
            // AddCarPartNameLabel
            // 
            AddCarPartNameLabel.AutoSize = true;
            AddCarPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartNameLabel.Location = new System.Drawing.Point(76, 343);
            AddCarPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartNameLabel.Name = "AddCarPartNameLabel";
            AddCarPartNameLabel.Size = new System.Drawing.Size(95, 22);
            AddCarPartNameLabel.TabIndex = 94;
            AddCarPartNameLabel.Text = "Part Name";
            // 
            // Drop_Category
            // 
            this.Drop_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_Category.FormattingEnabled = true;
            this.Drop_Category.Items.AddRange(new object[] {
            "Engine Components",
            "Transmission",
            "Suspension and Steering",
            "Braking System",
            "Electrical and Lighting",
            "Exhaust System",
            "Cooling System",
            "Fuel System",
            "Interior Components",
            "Body and Exterior Parts",
            "Other"});
            this.Drop_Category.Location = new System.Drawing.Point(425, 181);
            this.Drop_Category.Name = "Drop_Category";
            this.Drop_Category.Size = new System.Drawing.Size(325, 30);
            this.Drop_Category.TabIndex = 112;
            // 
            // TxtBox_PartName
            // 
            this.TxtBox_PartName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PartName.Location = new System.Drawing.Point(80, 368);
            this.TxtBox_PartName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_PartName.MaxLength = 10;
            this.TxtBox_PartName.Name = "TxtBox_PartName";
            this.TxtBox_PartName.Size = new System.Drawing.Size(288, 28);
            this.TxtBox_PartName.TabIndex = 111;
            this.TxtBox_PartName.TextChanged += new System.EventHandler(this.AddCarPartNameText_TextChanged);
            // 
            // Tbl_CarPartsList
            // 
            this.Tbl_CarPartsList.AllowUserToAddRows = false;
            this.Tbl_CarPartsList.AllowUserToDeleteRows = false;
            this.Tbl_CarPartsList.AllowUserToResizeColumns = false;
            this.Tbl_CarPartsList.AllowUserToResizeRows = false;
            this.Tbl_CarPartsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CarPartsList.ColumnHeadersHeight = 29;
            this.Tbl_CarPartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PartName,
            this.Manufacturer,
            this.PartCode,
            this.Category,
            this.Description,
            this.Price,
            this.Condition,
            this.StockQuantity});
            this.Tbl_CarPartsList.Location = new System.Drawing.Point(80, 427);
            this.Tbl_CarPartsList.Name = "Tbl_CarPartsList";
            this.Tbl_CarPartsList.RowHeadersWidth = 51;
            this.Tbl_CarPartsList.RowTemplate.Height = 24;
            this.Tbl_CarPartsList.Size = new System.Drawing.Size(1041, 199);
            this.Tbl_CarPartsList.TabIndex = 110;
            this.Tbl_CarPartsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_CarPartsList_CellContentClick);
            this.Tbl_CarPartsList.SelectionChanged += new System.EventHandler(this.Tbl_CarPartsList_SelectionChanged);
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
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.MinimumWidth = 6;
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Width = 125;
            // 
            // PartCode
            // 
            this.PartCode.HeaderText = "PartCode";
            this.PartCode.MinimumWidth = 6;
            this.PartCode.Name = "PartCode";
            this.PartCode.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
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
            // StockQuantity
            // 
            this.StockQuantity.HeaderText = "StockQuantity";
            this.StockQuantity.MinimumWidth = 6;
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.Width = 125;
            // 
            // Numeric_Price
            // 
            this.Numeric_Price.DecimalPlaces = 2;
            this.Numeric_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Price.Location = new System.Drawing.Point(804, 116);
            this.Numeric_Price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numeric_Price.Name = "Numeric_Price";
            this.Numeric_Price.Size = new System.Drawing.Size(325, 28);
            this.Numeric_Price.TabIndex = 109;
            // 
            // AddCarPartPriceLabel
            // 
            this.AddCarPartPriceLabel.AutoSize = true;
            this.AddCarPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPriceLabel.Location = new System.Drawing.Point(799, 92);
            this.AddCarPartPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartPriceLabel.Name = "AddCarPartPriceLabel";
            this.AddCarPartPriceLabel.Size = new System.Drawing.Size(51, 22);
            this.AddCarPartPriceLabel.TabIndex = 108;
            this.AddCarPartPriceLabel.Text = "Price";
            // 
            // TxtBox_Description
            // 
            this.TxtBox_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Description.Location = new System.Drawing.Point(801, 179);
            this.TxtBox_Description.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Description.MaxLength = 500;
            this.TxtBox_Description.Multiline = true;
            this.TxtBox_Description.Name = "TxtBox_Description";
            this.TxtBox_Description.Size = new System.Drawing.Size(326, 85);
            this.TxtBox_Description.TabIndex = 106;
            // 
            // AddCarDescriptionLabel
            // 
            this.AddCarDescriptionLabel.AutoSize = true;
            this.AddCarDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDescriptionLabel.Location = new System.Drawing.Point(800, 153);
            this.AddCarDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarDescriptionLabel.Name = "AddCarDescriptionLabel";
            this.AddCarDescriptionLabel.Size = new System.Drawing.Size(100, 22);
            this.AddCarDescriptionLabel.TabIndex = 105;
            this.AddCarDescriptionLabel.Text = "Description";
            // 
            // Btn_OrderPart
            // 
            this.Btn_OrderPart.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_OrderPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrderPart.Location = new System.Drawing.Point(451, 24);
            this.Btn_OrderPart.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OrderPart.Name = "Btn_OrderPart";
            this.Btn_OrderPart.Size = new System.Drawing.Size(243, 50);
            this.Btn_OrderPart.TabIndex = 104;
            this.Btn_OrderPart.Text = "ORDER";
            this.Btn_OrderPart.UseVisualStyleBackColor = false;
            this.Btn_OrderPart.Click += new System.EventHandler(this.Btn_OrderPart_Click);
            // 
            // PicBx_CarPartPhoto
            // 
            this.PicBx_CarPartPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBx_CarPartPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBx_CarPartPhoto.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.PicBx_CarPartPhoto.Location = new System.Drawing.Point(80, 165);
            this.PicBx_CarPartPhoto.Name = "PicBx_CarPartPhoto";
            this.PicBx_CarPartPhoto.Size = new System.Drawing.Size(288, 162);
            this.PicBx_CarPartPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx_CarPartPhoto.TabIndex = 103;
            this.PicBx_CarPartPhoto.TabStop = false;
            this.PicBx_CarPartPhoto.WaitOnLoad = true;
            // 
            // Numeric_Quantity
            // 
            this.Numeric_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Quantity.Location = new System.Drawing.Point(26, 41);
            this.Numeric_Quantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numeric_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Quantity.Name = "Numeric_Quantity";
            this.Numeric_Quantity.Size = new System.Drawing.Size(112, 28);
            this.Numeric_Quantity.TabIndex = 102;
            this.Numeric_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_Quantity.ValueChanged += new System.EventHandler(this.Numeric_Quantity_ValueChanged);
            // 
            // AddCarPartQuantityLabel
            // 
            this.AddCarPartQuantityLabel.AutoSize = true;
            this.AddCarPartQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartQuantityLabel.Location = new System.Drawing.Point(21, 16);
            this.AddCarPartQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartQuantityLabel.Name = "AddCarPartQuantityLabel";
            this.AddCarPartQuantityLabel.Size = new System.Drawing.Size(77, 22);
            this.AddCarPartQuantityLabel.TabIndex = 101;
            this.AddCarPartQuantityLabel.Text = "Quantity";
            this.AddCarPartQuantityLabel.Click += new System.EventHandler(this.AddCarPartQuantityLabel_Click);
            // 
            // TxtBox_PartCode
            // 
            this.TxtBox_PartCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_PartCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_PartCode.Location = new System.Drawing.Point(424, 123);
            this.TxtBox_PartCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_PartCode.MaxLength = 10;
            this.TxtBox_PartCode.Name = "TxtBox_PartCode";
            this.TxtBox_PartCode.Size = new System.Drawing.Size(326, 28);
            this.TxtBox_PartCode.TabIndex = 100;
            this.TxtBox_PartCode.TextChanged += new System.EventHandler(this.AddCarPartCodeTxt_TextChanged);
            // 
            // AddCarPartPartCodeLabel
            // 
            this.AddCarPartPartCodeLabel.AutoSize = true;
            this.AddCarPartPartCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPartCodeLabel.Location = new System.Drawing.Point(422, 96);
            this.AddCarPartPartCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartPartCodeLabel.Name = "AddCarPartPartCodeLabel";
            this.AddCarPartPartCodeLabel.Size = new System.Drawing.Size(91, 22);
            this.AddCarPartPartCodeLabel.TabIndex = 99;
            this.AddCarPartPartCodeLabel.Text = "Part Code";
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(800, 32);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(86, 22);
            this.AddCarConditionLabel.TabIndex = 98;
            this.AddCarConditionLabel.Text = "Condition";
            // 
            // Drop_Condition
            // 
            this.Drop_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_Condition.FormattingEnabled = true;
            this.Drop_Condition.Items.AddRange(new object[] {
            "Brand New",
            "Used"});
            this.Drop_Condition.Location = new System.Drawing.Point(803, 58);
            this.Drop_Condition.Name = "Drop_Condition";
            this.Drop_Condition.Size = new System.Drawing.Size(326, 30);
            this.Drop_Condition.TabIndex = 97;
            // 
            // Btn_SearchCarPart
            // 
            this.Btn_SearchCarPart.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_SearchCarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchCarPart.Location = new System.Drawing.Point(80, 102);
            this.Btn_SearchCarPart.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SearchCarPart.Name = "Btn_SearchCarPart";
            this.Btn_SearchCarPart.Size = new System.Drawing.Size(288, 50);
            this.Btn_SearchCarPart.TabIndex = 113;
            this.Btn_SearchCarPart.Text = "SEARCH CAR PART";
            this.Btn_SearchCarPart.UseVisualStyleBackColor = false;
            this.Btn_SearchCarPart.Click += new System.EventHandler(this.Btn_SearchCarPart_Click);
            // 
            // TxtBox_SearchPart
            // 
            this.TxtBox_SearchPart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_SearchPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_SearchPart.Location = new System.Drawing.Point(80, 51);
            this.TxtBox_SearchPart.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_SearchPart.MaxLength = 10;
            this.TxtBox_SearchPart.Name = "TxtBox_SearchPart";
            this.TxtBox_SearchPart.Size = new System.Drawing.Size(288, 34);
            this.TxtBox_SearchPart.TabIndex = 114;
            this.TxtBox_SearchPart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.Numeric_QuantityPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Numeric_Quantity);
            this.panel2.Controls.Add(this.AddCarPartQuantityLabel);
            this.panel2.Controls.Add(this.Btn_OrderPart);
            this.panel2.Location = new System.Drawing.Point(424, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 99);
            this.panel2.TabIndex = 115;
            // 
            // Numeric_QuantityPrice
            // 
            this.Numeric_QuantityPrice.DecimalPlaces = 2;
            this.Numeric_QuantityPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_QuantityPrice.Location = new System.Drawing.Point(179, 41);
            this.Numeric_QuantityPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numeric_QuantityPrice.Name = "Numeric_QuantityPrice";
            this.Numeric_QuantityPrice.Size = new System.Drawing.Size(224, 28);
            this.Numeric_QuantityPrice.TabIndex = 117;
            this.Numeric_QuantityPrice.ValueChanged += new System.EventHandler(this.Numeric_QuantityPrice_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 116;
            this.label1.Text = "Quantity Price";
            // 
            // TxtBox_Manufacturer
            // 
            this.TxtBox_Manufacturer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBox_Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Manufacturer.Location = new System.Drawing.Point(424, 60);
            this.TxtBox_Manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Manufacturer.MaxLength = 10;
            this.TxtBox_Manufacturer.Name = "TxtBox_Manufacturer";
            this.TxtBox_Manufacturer.Size = new System.Drawing.Size(325, 28);
            this.TxtBox_Manufacturer.TabIndex = 116;
            // 
            // Numeric_Stock
            // 
            this.Numeric_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Stock.Location = new System.Drawing.Point(427, 240);
            this.Numeric_Stock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Numeric_Stock.Name = "Numeric_Stock";
            this.Numeric_Stock.Size = new System.Drawing.Size(325, 28);
            this.Numeric_Stock.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 117;
            this.label2.Text = "Stock Quantity";
            // 
            // SearchCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 652);
            this.Controls.Add(this.Numeric_Stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBox_Manufacturer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtBox_SearchPart);
            this.Controls.Add(this.Btn_SearchCarPart);
            this.Controls.Add(this.Drop_Category);
            this.Controls.Add(this.TxtBox_PartName);
            this.Controls.Add(this.Tbl_CarPartsList);
            this.Controls.Add(this.Numeric_Price);
            this.Controls.Add(this.AddCarPartPriceLabel);
            this.Controls.Add(AddCarPartCategoryLabel);
            this.Controls.Add(this.TxtBox_Description);
            this.Controls.Add(this.AddCarDescriptionLabel);
            this.Controls.Add(this.PicBx_CarPartPhoto);
            this.Controls.Add(this.TxtBox_PartCode);
            this.Controls.Add(this.AddCarPartPartCodeLabel);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.Drop_Condition);
            this.Controls.Add(AddCarPartManufLabel);
            this.Controls.Add(AddCarPartNameLabel);
            this.Name = "SearchCarParts";
            this.Text = "SearchCarParts";
            this.Load += new System.EventHandler(this.SearchCarParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarPartsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_CarPartPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_QuantityPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Drop_Category;
        private System.Windows.Forms.TextBox TxtBox_PartName;
        private System.Windows.Forms.DataGridView Tbl_CarPartsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
        private System.Windows.Forms.NumericUpDown Numeric_Price;
        private System.Windows.Forms.Label AddCarPartPriceLabel;
        private System.Windows.Forms.TextBox TxtBox_Description;
        private System.Windows.Forms.Label AddCarDescriptionLabel;
        private System.Windows.Forms.Button Btn_OrderPart;
        private System.Windows.Forms.PictureBox PicBx_CarPartPhoto;
        private System.Windows.Forms.NumericUpDown Numeric_Quantity;
        private System.Windows.Forms.Label AddCarPartQuantityLabel;
        private System.Windows.Forms.TextBox TxtBox_PartCode;
        private System.Windows.Forms.Label AddCarPartPartCodeLabel;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.ComboBox Drop_Condition;
        private System.Windows.Forms.Button Btn_SearchCarPart;
        private System.Windows.Forms.TextBox TxtBox_SearchPart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown Numeric_QuantityPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Manufacturer;
        private System.Windows.Forms.NumericUpDown Numeric_Stock;
        private System.Windows.Forms.Label label2;
    }
}