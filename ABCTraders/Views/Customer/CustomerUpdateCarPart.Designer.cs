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
            System.Windows.Forms.Label AddCarPartNameLabel;
            this.Drop_CustomerUpdateStatus = new System.Windows.Forms.ComboBox();
            this.Btn_UpadtePartCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Btn_UpadtePartStatus = new System.Windows.Forms.Button();
            this.AddCarPartCodeTxt = new System.Windows.Forms.TextBox();
            this.AddCarPartPartCodeLabel = new System.Windows.Forms.Label();
            AddCarPartNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).BeginInit();
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
            this.Drop_CustomerUpdateStatus.Location = new System.Drawing.Point(99, 66);
            this.Drop_CustomerUpdateStatus.Name = "Drop_CustomerUpdateStatus";
            this.Drop_CustomerUpdateStatus.Size = new System.Drawing.Size(326, 30);
            this.Drop_CustomerUpdateStatus.TabIndex = 122;
            // 
            // Btn_UpadtePartCancel
            // 
            this.Btn_UpadtePartCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_UpadtePartCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadtePartCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpadtePartCancel.Location = new System.Drawing.Point(898, 409);
            this.Btn_UpadtePartCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartCancel.Name = "Btn_UpadtePartCancel";
            this.Btn_UpadtePartCancel.Size = new System.Drawing.Size(325, 50);
            this.Btn_UpadtePartCancel.TabIndex = 120;
            this.Btn_UpadtePartCancel.Text = "CANCEL";
            this.Btn_UpadtePartCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartCancel.Click += new System.EventHandler(this.Btn_UpadtePartCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 119;
            this.label1.Text = "Update Status";
            // 
            // AddCarPartNameText
            // 
            this.AddCarPartNameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartNameText.Location = new System.Drawing.Point(502, 66);
            this.AddCarPartNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartNameText.MaxLength = 10;
            this.AddCarPartNameText.Name = "AddCarPartNameText";
            this.AddCarPartNameText.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartNameText.TabIndex = 118;
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
            this.AddCarPartsTbl.Location = new System.Drawing.Point(101, 142);
            this.AddCarPartsTbl.Name = "AddCarPartsTbl";
            this.AddCarPartsTbl.RowHeadersWidth = 51;
            this.AddCarPartsTbl.RowTemplate.Height = 24;
            this.AddCarPartsTbl.Size = new System.Drawing.Size(1122, 223);
            this.AddCarPartsTbl.TabIndex = 117;
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
            // Btn_UpadtePartStatus
            // 
            this.Btn_UpadtePartStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_UpadtePartStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_UpadtePartStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartStatus.Location = new System.Drawing.Point(507, 409);
            this.Btn_UpadtePartStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartStatus.Name = "Btn_UpadtePartStatus";
            this.Btn_UpadtePartStatus.Size = new System.Drawing.Size(323, 50);
            this.Btn_UpadtePartStatus.TabIndex = 116;
            this.Btn_UpadtePartStatus.Text = "UPDATE";
            this.Btn_UpadtePartStatus.UseVisualStyleBackColor = false;
            // 
            // AddCarPartCodeTxt
            // 
            this.AddCarPartCodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartCodeTxt.Location = new System.Drawing.Point(896, 66);
            this.AddCarPartCodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartCodeTxt.MaxLength = 10;
            this.AddCarPartCodeTxt.Name = "AddCarPartCodeTxt";
            this.AddCarPartCodeTxt.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartCodeTxt.TabIndex = 115;
            // 
            // AddCarPartPartCodeLabel
            // 
            this.AddCarPartPartCodeLabel.AutoSize = true;
            this.AddCarPartPartCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPartCodeLabel.Location = new System.Drawing.Point(894, 39);
            this.AddCarPartPartCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartPartCodeLabel.Name = "AddCarPartPartCodeLabel";
            this.AddCarPartPartCodeLabel.Size = new System.Drawing.Size(91, 22);
            this.AddCarPartPartCodeLabel.TabIndex = 114;
            this.AddCarPartPartCodeLabel.Text = "Part Code";
            // 
            // AddCarPartNameLabel
            // 
            AddCarPartNameLabel.AutoSize = true;
            AddCarPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartNameLabel.Location = new System.Drawing.Point(498, 41);
            AddCarPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartNameLabel.Name = "AddCarPartNameLabel";
            AddCarPartNameLabel.Size = new System.Drawing.Size(95, 22);
            AddCarPartNameLabel.TabIndex = 112;
            AddCarPartNameLabel.Text = "Part Name";
            // 
            // CustomerUpdateCarPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.Btn_UpadtePartCancel;
            this.ClientSize = new System.Drawing.Size(1281, 506);
            this.Controls.Add(this.Drop_CustomerUpdateStatus);
            this.Controls.Add(this.Btn_UpadtePartCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCarPartNameText);
            this.Controls.Add(this.AddCarPartsTbl);
            this.Controls.Add(this.Btn_UpadtePartStatus);
            this.Controls.Add(this.AddCarPartCodeTxt);
            this.Controls.Add(this.AddCarPartPartCodeLabel);
            this.Controls.Add(AddCarPartNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerUpdateCarPart";
            this.Text = "CustomerUpdateCarPart";
            this.Load += new System.EventHandler(this.CustomerUpdateCarPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Drop_CustomerUpdateStatus;
        private System.Windows.Forms.Button Btn_UpadtePartCancel;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button Btn_UpadtePartStatus;
        private System.Windows.Forms.TextBox AddCarPartCodeTxt;
        private System.Windows.Forms.Label AddCarPartPartCodeLabel;
    }
}