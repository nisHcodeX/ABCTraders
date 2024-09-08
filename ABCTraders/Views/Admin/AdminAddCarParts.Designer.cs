namespace ABCTraders.Views.Admin
{
    partial class AdminAddCarParts
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
            System.Windows.Forms.Label AddCarPartNameLabel;
            System.Windows.Forms.Label AddCarPartManufLabel;
            System.Windows.Forms.Label AddCarPartCategoryLabel;
            this.AddCarPartsTbl = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCarPartManufCombBx = new System.Windows.Forms.ComboBox();
            this.AddCarPartConditionDrop = new System.Windows.Forms.ComboBox();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.AddCarPartPartCodeLabel = new System.Windows.Forms.Label();
            this.AddCarPartCodeTxt = new System.Windows.Forms.TextBox();
            this.AddCarPartQuantityLabel = new System.Windows.Forms.Label();
            this.AddCarPartQuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCarPartPhotoBtn = new System.Windows.Forms.Button();
            this.AddCarPartSaveBtn = new System.Windows.Forms.Button();
            this.AddCarPartDeleteBtn = new System.Windows.Forms.Button();
            this.AddCarDescriptionLabel = new System.Windows.Forms.Label();
            this.AddCarPartDescriptionTxt = new System.Windows.Forms.TextBox();
            this.AddCarPartPriceLabel = new System.Windows.Forms.Label();
            this.AddCarPartPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCarPartNameText = new System.Windows.Forms.TextBox();
            this.AddCarPartCategoryDrop = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Drop_PartStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCarPartPicutureBox = new System.Windows.Forms.PictureBox();
            AddCarPartNameLabel = new System.Windows.Forms.Label();
            AddCarPartManufLabel = new System.Windows.Forms.Label();
            AddCarPartCategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartQuantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPriceNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPicutureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarPartNameLabel
            // 
            AddCarPartNameLabel.AutoSize = true;
            AddCarPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartNameLabel.Location = new System.Drawing.Point(365, 30);
            AddCarPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartNameLabel.Name = "AddCarPartNameLabel";
            AddCarPartNameLabel.Size = new System.Drawing.Size(95, 22);
            AddCarPartNameLabel.TabIndex = 43;
            AddCarPartNameLabel.Text = "Part Name";
            AddCarPartNameLabel.Click += new System.EventHandler(this.AddCarPartNameLabel_Click);
            // 
            // AddCarPartManufLabel
            // 
            AddCarPartManufLabel.AutoSize = true;
            AddCarPartManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartManufLabel.Location = new System.Drawing.Point(365, 88);
            AddCarPartManufLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartManufLabel.Name = "AddCarPartManufLabel";
            AddCarPartManufLabel.Size = new System.Drawing.Size(120, 22);
            AddCarPartManufLabel.TabIndex = 45;
            AddCarPartManufLabel.Text = "Manufacturer ";
            // 
            // AddCarPartCategoryLabel
            // 
            AddCarPartCategoryLabel.AutoSize = true;
            AddCarPartCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartCategoryLabel.Location = new System.Drawing.Point(367, 210);
            AddCarPartCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartCategoryLabel.Name = "AddCarPartCategoryLabel";
            AddCarPartCategoryLabel.Size = new System.Drawing.Size(83, 22);
            AddCarPartCategoryLabel.TabIndex = 66;
            AddCarPartCategoryLabel.Text = "Category";
            // 
            // AddCarPartsTbl
            // 
            this.AddCarPartsTbl.AllowUserToAddRows = false;
            this.AddCarPartsTbl.AllowUserToDeleteRows = false;
            this.AddCarPartsTbl.AllowUserToResizeColumns = false;
            this.AddCarPartsTbl.AllowUserToResizeRows = false;
            this.AddCarPartsTbl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCarPartsTbl.ColumnHeadersHeight = 29;
            this.AddCarPartsTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PartName,
            this.Manufacturer,
            this.PartCode,
            this.Category,
            this.Description,
            this.Price,
            this.Condition,
            this.StockQuantity});
            this.AddCarPartsTbl.Location = new System.Drawing.Point(56, 413);
            this.AddCarPartsTbl.Name = "AddCarPartsTbl";
            this.AddCarPartsTbl.RowHeadersWidth = 51;
            this.AddCarPartsTbl.RowTemplate.Height = 24;
            this.AddCarPartsTbl.Size = new System.Drawing.Size(1041, 223);
            this.AddCarPartsTbl.TabIndex = 70;
            this.AddCarPartsTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddCarPartsTbl_CellContentClick_1);
            this.AddCarPartsTbl.SelectionChanged += new System.EventHandler(this.AddCarPartsTbl_SelectionChanged);
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
            // AddCarPartManufCombBx
            // 
            this.AddCarPartManufCombBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartManufCombBx.FormattingEnabled = true;
            this.AddCarPartManufCombBx.Location = new System.Drawing.Point(368, 114);
            this.AddCarPartManufCombBx.Name = "AddCarPartManufCombBx";
            this.AddCarPartManufCombBx.Size = new System.Drawing.Size(326, 30);
            this.AddCarPartManufCombBx.TabIndex = 46;
            this.AddCarPartManufCombBx.SelectedIndexChanged += new System.EventHandler(this.AddCarPartManufCombBx_SelectedIndexChanged);
            // 
            // AddCarPartConditionDrop
            // 
            this.AddCarPartConditionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarPartConditionDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartConditionDrop.FormattingEnabled = true;
            this.AddCarPartConditionDrop.Items.AddRange(new object[] {
            "Brand New",
            "Used"});
            this.AddCarPartConditionDrop.Location = new System.Drawing.Point(771, 177);
            this.AddCarPartConditionDrop.Name = "AddCarPartConditionDrop";
            this.AddCarPartConditionDrop.Size = new System.Drawing.Size(326, 30);
            this.AddCarPartConditionDrop.TabIndex = 53;
            this.AddCarPartConditionDrop.SelectedIndexChanged += new System.EventHandler(this.AddCarPartConditionDrop_SelectedIndexChanged);
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(768, 151);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(86, 22);
            this.AddCarConditionLabel.TabIndex = 54;
            this.AddCarConditionLabel.Text = "Condition";
            // 
            // AddCarPartPartCodeLabel
            // 
            this.AddCarPartPartCodeLabel.AutoSize = true;
            this.AddCarPartPartCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPartCodeLabel.Location = new System.Drawing.Point(366, 150);
            this.AddCarPartPartCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartPartCodeLabel.Name = "AddCarPartPartCodeLabel";
            this.AddCarPartPartCodeLabel.Size = new System.Drawing.Size(91, 22);
            this.AddCarPartPartCodeLabel.TabIndex = 55;
            this.AddCarPartPartCodeLabel.Text = "Part Code";
            // 
            // AddCarPartCodeTxt
            // 
            this.AddCarPartCodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartCodeTxt.Location = new System.Drawing.Point(368, 177);
            this.AddCarPartCodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartCodeTxt.MaxLength = 10;
            this.AddCarPartCodeTxt.Name = "AddCarPartCodeTxt";
            this.AddCarPartCodeTxt.Size = new System.Drawing.Size(326, 28);
            this.AddCarPartCodeTxt.TabIndex = 56;
            // 
            // AddCarPartQuantityLabel
            // 
            this.AddCarPartQuantityLabel.AutoSize = true;
            this.AddCarPartQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartQuantityLabel.Location = new System.Drawing.Point(366, 270);
            this.AddCarPartQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartQuantityLabel.Name = "AddCarPartQuantityLabel";
            this.AddCarPartQuantityLabel.Size = new System.Drawing.Size(127, 22);
            this.AddCarPartQuantityLabel.TabIndex = 57;
            this.AddCarPartQuantityLabel.Text = "Stock Quantity";
            // 
            // AddCarPartQuantityNumeric
            // 
            this.AddCarPartQuantityNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartQuantityNumeric.Location = new System.Drawing.Point(369, 295);
            this.AddCarPartQuantityNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AddCarPartQuantityNumeric.Name = "AddCarPartQuantityNumeric";
            this.AddCarPartQuantityNumeric.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartQuantityNumeric.TabIndex = 58;
            this.AddCarPartQuantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddCarPartPhotoBtn
            // 
            this.AddCarPartPhotoBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCarPartPhotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPhotoBtn.Location = new System.Drawing.Point(56, 222);
            this.AddCarPartPhotoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartPhotoBtn.Name = "AddCarPartPhotoBtn";
            this.AddCarPartPhotoBtn.Size = new System.Drawing.Size(265, 50);
            this.AddCarPartPhotoBtn.TabIndex = 61;
            this.AddCarPartPhotoBtn.Text = "Add Car Part Photo";
            this.AddCarPartPhotoBtn.UseVisualStyleBackColor = false;
            this.AddCarPartPhotoBtn.Click += new System.EventHandler(this.AddCarPartPhotoBtn_Click);
            // 
            // AddCarPartSaveBtn
            // 
            this.AddCarPartSaveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddCarPartSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartSaveBtn.Location = new System.Drawing.Point(56, 283);
            this.AddCarPartSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartSaveBtn.Name = "AddCarPartSaveBtn";
            this.AddCarPartSaveBtn.Size = new System.Drawing.Size(267, 50);
            this.AddCarPartSaveBtn.TabIndex = 62;
            this.AddCarPartSaveBtn.Text = "Save";
            this.AddCarPartSaveBtn.UseVisualStyleBackColor = false;
            this.AddCarPartSaveBtn.Click += new System.EventHandler(this.AddCarPartSaveBtn_Click);
            // 
            // AddCarPartDeleteBtn
            // 
            this.AddCarPartDeleteBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddCarPartDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCarPartDeleteBtn.Location = new System.Drawing.Point(58, 341);
            this.AddCarPartDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartDeleteBtn.Name = "AddCarPartDeleteBtn";
            this.AddCarPartDeleteBtn.Size = new System.Drawing.Size(265, 50);
            this.AddCarPartDeleteBtn.TabIndex = 63;
            this.AddCarPartDeleteBtn.Text = "Delete";
            this.AddCarPartDeleteBtn.UseVisualStyleBackColor = false;
            this.AddCarPartDeleteBtn.Click += new System.EventHandler(this.AddCarPartDeleteBtn_Click);
            // 
            // AddCarDescriptionLabel
            // 
            this.AddCarDescriptionLabel.AutoSize = true;
            this.AddCarDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDescriptionLabel.Location = new System.Drawing.Point(770, 212);
            this.AddCarDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarDescriptionLabel.Name = "AddCarDescriptionLabel";
            this.AddCarDescriptionLabel.Size = new System.Drawing.Size(100, 22);
            this.AddCarDescriptionLabel.TabIndex = 64;
            this.AddCarDescriptionLabel.Text = "Description";
            // 
            // AddCarPartDescriptionTxt
            // 
            this.AddCarPartDescriptionTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartDescriptionTxt.Location = new System.Drawing.Point(771, 238);
            this.AddCarPartDescriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartDescriptionTxt.MaxLength = 500;
            this.AddCarPartDescriptionTxt.Multiline = true;
            this.AddCarPartDescriptionTxt.Name = "AddCarPartDescriptionTxt";
            this.AddCarPartDescriptionTxt.Size = new System.Drawing.Size(326, 85);
            this.AddCarPartDescriptionTxt.TabIndex = 65;
            // 
            // AddCarPartPriceLabel
            // 
            this.AddCarPartPriceLabel.AutoSize = true;
            this.AddCarPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPriceLabel.Location = new System.Drawing.Point(366, 339);
            this.AddCarPartPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartPriceLabel.Name = "AddCarPartPriceLabel";
            this.AddCarPartPriceLabel.Size = new System.Drawing.Size(51, 22);
            this.AddCarPartPriceLabel.TabIndex = 68;
            this.AddCarPartPriceLabel.Text = "Price";
            // 
            // AddCarPartPriceNumeric
            // 
            this.AddCarPartPriceNumeric.DecimalPlaces = 2;
            this.AddCarPartPriceNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPriceNumeric.Location = new System.Drawing.Point(371, 363);
            this.AddCarPartPriceNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AddCarPartPriceNumeric.Name = "AddCarPartPriceNumeric";
            this.AddCarPartPriceNumeric.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartPriceNumeric.TabIndex = 69;
            // 
            // AddCarPartNameText
            // 
            this.AddCarPartNameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartNameText.Location = new System.Drawing.Point(369, 55);
            this.AddCarPartNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartNameText.MaxLength = 10;
            this.AddCarPartNameText.Name = "AddCarPartNameText";
            this.AddCarPartNameText.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartNameText.TabIndex = 71;
            // 
            // AddCarPartCategoryDrop
            // 
            this.AddCarPartCategoryDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarPartCategoryDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartCategoryDrop.FormattingEnabled = true;
            this.AddCarPartCategoryDrop.Items.AddRange(new object[] {
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
            this.AddCarPartCategoryDrop.Location = new System.Drawing.Point(369, 235);
            this.AddCarPartCategoryDrop.Name = "AddCarPartCategoryDrop";
            this.AddCarPartCategoryDrop.Size = new System.Drawing.Size(325, 30);
            this.AddCarPartCategoryDrop.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Drop_PartStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(771, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 99);
            this.panel1.TabIndex = 73;
            // 
            // Drop_PartStatus
            // 
            this.Drop_PartStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_PartStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_PartStatus.FormattingEnabled = true;
            this.Drop_PartStatus.Items.AddRange(new object[] {
            "Available",
            "Deleted",
            "Out of Stock"});
            this.Drop_PartStatus.Location = new System.Drawing.Point(24, 47);
            this.Drop_PartStatus.Name = "Drop_PartStatus";
            this.Drop_PartStatus.Size = new System.Drawing.Size(279, 30);
            this.Drop_PartStatus.TabIndex = 111;
            this.Drop_PartStatus.SelectedIndexChanged += new System.EventHandler(this.Drop_PartStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 75;
            this.label1.Text = "Status";
            // 
            // AddCarPartPicutureBox
            // 
            this.AddCarPartPicutureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddCarPartPicutureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddCarPartPicutureBox.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.AddCarPartPicutureBox.Location = new System.Drawing.Point(58, 34);
            this.AddCarPartPicutureBox.Name = "AddCarPartPicutureBox";
            this.AddCarPartPicutureBox.Size = new System.Drawing.Size(265, 164);
            this.AddCarPartPicutureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddCarPartPicutureBox.TabIndex = 60;
            this.AddCarPartPicutureBox.TabStop = false;
            this.AddCarPartPicutureBox.WaitOnLoad = true;
            // 
            // AdminAddCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddCarPartCategoryDrop);
            this.Controls.Add(this.AddCarPartNameText);
            this.Controls.Add(this.AddCarPartsTbl);
            this.Controls.Add(this.AddCarPartPriceNumeric);
            this.Controls.Add(this.AddCarPartPriceLabel);
            this.Controls.Add(AddCarPartCategoryLabel);
            this.Controls.Add(this.AddCarPartDescriptionTxt);
            this.Controls.Add(this.AddCarDescriptionLabel);
            this.Controls.Add(this.AddCarPartDeleteBtn);
            this.Controls.Add(this.AddCarPartSaveBtn);
            this.Controls.Add(this.AddCarPartPhotoBtn);
            this.Controls.Add(this.AddCarPartPicutureBox);
            this.Controls.Add(this.AddCarPartQuantityNumeric);
            this.Controls.Add(this.AddCarPartQuantityLabel);
            this.Controls.Add(this.AddCarPartCodeTxt);
            this.Controls.Add(this.AddCarPartPartCodeLabel);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.AddCarPartConditionDrop);
            this.Controls.Add(this.AddCarPartManufCombBx);
            this.Controls.Add(AddCarPartManufLabel);
            this.Controls.Add(AddCarPartNameLabel);
            this.Name = "AdminAddCarParts";
            this.Text = "AdminAddCarParts";
            this.Load += new System.EventHandler(this.AdminAddCarParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartQuantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPriceNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPicutureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView AddCarPartsTbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
        private System.Windows.Forms.ComboBox AddCarPartManufCombBx;
        private System.Windows.Forms.ComboBox AddCarPartConditionDrop;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.Label AddCarPartPartCodeLabel;
        private System.Windows.Forms.TextBox AddCarPartCodeTxt;
        private System.Windows.Forms.Label AddCarPartQuantityLabel;
        private System.Windows.Forms.NumericUpDown AddCarPartQuantityNumeric;
        private System.Windows.Forms.PictureBox AddCarPartPicutureBox;
        private System.Windows.Forms.Button AddCarPartPhotoBtn;
        private System.Windows.Forms.Button AddCarPartSaveBtn;
        private System.Windows.Forms.Button AddCarPartDeleteBtn;
        private System.Windows.Forms.Label AddCarDescriptionLabel;
        private System.Windows.Forms.TextBox AddCarPartDescriptionTxt;
        private System.Windows.Forms.Label AddCarPartPriceLabel;
        private System.Windows.Forms.NumericUpDown AddCarPartPriceNumeric;
        private System.Windows.Forms.TextBox AddCarPartNameText;
        private System.Windows.Forms.ComboBox AddCarPartCategoryDrop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Drop_PartStatus;
    }
}