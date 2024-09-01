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
            this.AddCarPartCategoryDrop = new System.Windows.Forms.ComboBox();
            this.AddCarPartNameText = new System.Windows.Forms.TextBox();
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
            this.AddCarPartPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCarPartPriceLabel = new System.Windows.Forms.Label();
            this.AddCarPartDescriptionTxt = new System.Windows.Forms.TextBox();
            this.AddCarDescriptionLabel = new System.Windows.Forms.Label();
            this.AddCarPartSaveBtn = new System.Windows.Forms.Button();
            this.AddCarPartPicutureBox = new System.Windows.Forms.PictureBox();
            this.AddCarPartQuantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCarPartQuantityLabel = new System.Windows.Forms.Label();
            this.AddCarPartCodeTxt = new System.Windows.Forms.TextBox();
            this.AddCarPartPartCodeLabel = new System.Windows.Forms.Label();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.AddCarPartConditionDrop = new System.Windows.Forms.ComboBox();
            this.AddCarPartManufCombBx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            AddCarPartCategoryLabel = new System.Windows.Forms.Label();
            AddCarPartManufLabel = new System.Windows.Forms.Label();
            AddCarPartNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPicutureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartQuantityNumeric)).BeginInit();
            this.SuspendLayout();
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
            this.AddCarPartCategoryDrop.Location = new System.Drawing.Point(422, 237);
            this.AddCarPartCategoryDrop.Name = "AddCarPartCategoryDrop";
            this.AddCarPartCategoryDrop.Size = new System.Drawing.Size(325, 30);
            this.AddCarPartCategoryDrop.TabIndex = 112;
            // 
            // AddCarPartNameText
            // 
            this.AddCarPartNameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartNameText.Location = new System.Drawing.Point(422, 57);
            this.AddCarPartNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartNameText.MaxLength = 10;
            this.AddCarPartNameText.Name = "AddCarPartNameText";
            this.AddCarPartNameText.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartNameText.TabIndex = 111;
            // 
            // AddCarPartsTbl
            // 
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
            this.AddCarPartsTbl.Location = new System.Drawing.Point(80, 427);
            this.AddCarPartsTbl.Name = "AddCarPartsTbl";
            this.AddCarPartsTbl.RowHeadersWidth = 51;
            this.AddCarPartsTbl.RowTemplate.Height = 24;
            this.AddCarPartsTbl.Size = new System.Drawing.Size(1041, 199);
            this.AddCarPartsTbl.TabIndex = 110;
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
            // AddCarPartPriceNumeric
            // 
            this.AddCarPartPriceNumeric.DecimalPlaces = 2;
            this.AddCarPartPriceNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPriceNumeric.Location = new System.Drawing.Point(804, 116);
            this.AddCarPartPriceNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AddCarPartPriceNumeric.Name = "AddCarPartPriceNumeric";
            this.AddCarPartPriceNumeric.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartPriceNumeric.TabIndex = 109;
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
            // AddCarPartCategoryLabel
            // 
            AddCarPartCategoryLabel.AutoSize = true;
            AddCarPartCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartCategoryLabel.Location = new System.Drawing.Point(420, 212);
            AddCarPartCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartCategoryLabel.Name = "AddCarPartCategoryLabel";
            AddCarPartCategoryLabel.Size = new System.Drawing.Size(83, 22);
            AddCarPartCategoryLabel.TabIndex = 107;
            AddCarPartCategoryLabel.Text = "Category";
            // 
            // AddCarPartDescriptionTxt
            // 
            this.AddCarPartDescriptionTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartDescriptionTxt.Location = new System.Drawing.Point(801, 173);
            this.AddCarPartDescriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartDescriptionTxt.MaxLength = 500;
            this.AddCarPartDescriptionTxt.Multiline = true;
            this.AddCarPartDescriptionTxt.Name = "AddCarPartDescriptionTxt";
            this.AddCarPartDescriptionTxt.Size = new System.Drawing.Size(326, 85);
            this.AddCarPartDescriptionTxt.TabIndex = 106;
            // 
            // AddCarDescriptionLabel
            // 
            this.AddCarDescriptionLabel.AutoSize = true;
            this.AddCarDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarDescriptionLabel.Location = new System.Drawing.Point(800, 147);
            this.AddCarDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarDescriptionLabel.Name = "AddCarDescriptionLabel";
            this.AddCarDescriptionLabel.Size = new System.Drawing.Size(100, 22);
            this.AddCarDescriptionLabel.TabIndex = 105;
            this.AddCarDescriptionLabel.Text = "Description";
            // 
            // AddCarPartSaveBtn
            // 
            this.AddCarPartSaveBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddCarPartSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartSaveBtn.Location = new System.Drawing.Point(810, 324);
            this.AddCarPartSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartSaveBtn.Name = "AddCarPartSaveBtn";
            this.AddCarPartSaveBtn.Size = new System.Drawing.Size(317, 50);
            this.AddCarPartSaveBtn.TabIndex = 104;
            this.AddCarPartSaveBtn.Text = "ORDER";
            this.AddCarPartSaveBtn.UseVisualStyleBackColor = false;
            // 
            // AddCarPartPicutureBox
            // 
            this.AddCarPartPicutureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddCarPartPicutureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddCarPartPicutureBox.InitialImage = global::ABCTraders.Properties.Resources.icons8_add_car_48;
            this.AddCarPartPicutureBox.Location = new System.Drawing.Point(80, 192);
            this.AddCarPartPicutureBox.Name = "AddCarPartPicutureBox";
            this.AddCarPartPicutureBox.Size = new System.Drawing.Size(288, 176);
            this.AddCarPartPicutureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddCarPartPicutureBox.TabIndex = 103;
            this.AddCarPartPicutureBox.TabStop = false;
            this.AddCarPartPicutureBox.WaitOnLoad = true;
            // 
            // AddCarPartQuantityNumeric
            // 
            this.AddCarPartQuantityNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartQuantityNumeric.Location = new System.Drawing.Point(421, 340);
            this.AddCarPartQuantityNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.AddCarPartQuantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddCarPartQuantityNumeric.Name = "AddCarPartQuantityNumeric";
            this.AddCarPartQuantityNumeric.Size = new System.Drawing.Size(326, 28);
            this.AddCarPartQuantityNumeric.TabIndex = 102;
            this.AddCarPartQuantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddCarPartQuantityLabel
            // 
            this.AddCarPartQuantityLabel.AutoSize = true;
            this.AddCarPartQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartQuantityLabel.Location = new System.Drawing.Point(420, 315);
            this.AddCarPartQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartQuantityLabel.Name = "AddCarPartQuantityLabel";
            this.AddCarPartQuantityLabel.Size = new System.Drawing.Size(77, 22);
            this.AddCarPartQuantityLabel.TabIndex = 101;
            this.AddCarPartQuantityLabel.Text = "Quantity";
            // 
            // AddCarPartCodeTxt
            // 
            this.AddCarPartCodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartCodeTxt.Location = new System.Drawing.Point(421, 179);
            this.AddCarPartCodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartCodeTxt.MaxLength = 10;
            this.AddCarPartCodeTxt.Name = "AddCarPartCodeTxt";
            this.AddCarPartCodeTxt.Size = new System.Drawing.Size(326, 28);
            this.AddCarPartCodeTxt.TabIndex = 100;
            // 
            // AddCarPartPartCodeLabel
            // 
            this.AddCarPartPartCodeLabel.AutoSize = true;
            this.AddCarPartPartCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPartCodeLabel.Location = new System.Drawing.Point(419, 152);
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
            // AddCarPartConditionDrop
            // 
            this.AddCarPartConditionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCarPartConditionDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartConditionDrop.FormattingEnabled = true;
            this.AddCarPartConditionDrop.Items.AddRange(new object[] {
            "Brand New",
            "Used"});
            this.AddCarPartConditionDrop.Location = new System.Drawing.Point(803, 58);
            this.AddCarPartConditionDrop.Name = "AddCarPartConditionDrop";
            this.AddCarPartConditionDrop.Size = new System.Drawing.Size(326, 30);
            this.AddCarPartConditionDrop.TabIndex = 97;
            // 
            // AddCarPartManufCombBx
            // 
            this.AddCarPartManufCombBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartManufCombBx.FormattingEnabled = true;
            this.AddCarPartManufCombBx.Location = new System.Drawing.Point(421, 116);
            this.AddCarPartManufCombBx.Name = "AddCarPartManufCombBx";
            this.AddCarPartManufCombBx.Size = new System.Drawing.Size(326, 30);
            this.AddCarPartManufCombBx.TabIndex = 96;
            // 
            // AddCarPartManufLabel
            // 
            AddCarPartManufLabel.AutoSize = true;
            AddCarPartManufLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartManufLabel.Location = new System.Drawing.Point(418, 90);
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
            AddCarPartNameLabel.Location = new System.Drawing.Point(418, 32);
            AddCarPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartNameLabel.Name = "AddCarPartNameLabel";
            AddCarPartNameLabel.Size = new System.Drawing.Size(95, 22);
            AddCarPartNameLabel.TabIndex = 94;
            AddCarPartNameLabel.Text = "Part Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 50);
            this.button1.TabIndex = 113;
            this.button1.Text = "SEARCH CAR PART";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 34);
            this.textBox1.TabIndex = 114;
            // 
            // SearchCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 652);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddCarPartCategoryDrop);
            this.Controls.Add(this.AddCarPartNameText);
            this.Controls.Add(this.AddCarPartsTbl);
            this.Controls.Add(this.AddCarPartPriceNumeric);
            this.Controls.Add(this.AddCarPartPriceLabel);
            this.Controls.Add(AddCarPartCategoryLabel);
            this.Controls.Add(this.AddCarPartDescriptionTxt);
            this.Controls.Add(this.AddCarDescriptionLabel);
            this.Controls.Add(this.AddCarPartSaveBtn);
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
            this.Name = "SearchCarParts";
            this.Text = "SearchCarParts";
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartPicutureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartQuantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AddCarPartCategoryDrop;
        private System.Windows.Forms.TextBox AddCarPartNameText;
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
        private System.Windows.Forms.NumericUpDown AddCarPartPriceNumeric;
        private System.Windows.Forms.Label AddCarPartPriceLabel;
        private System.Windows.Forms.TextBox AddCarPartDescriptionTxt;
        private System.Windows.Forms.Label AddCarDescriptionLabel;
        private System.Windows.Forms.Button AddCarPartSaveBtn;
        private System.Windows.Forms.PictureBox AddCarPartPicutureBox;
        private System.Windows.Forms.NumericUpDown AddCarPartQuantityNumeric;
        private System.Windows.Forms.Label AddCarPartQuantityLabel;
        private System.Windows.Forms.TextBox AddCarPartCodeTxt;
        private System.Windows.Forms.Label AddCarPartPartCodeLabel;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.ComboBox AddCarPartConditionDrop;
        private System.Windows.Forms.ComboBox AddCarPartManufCombBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}