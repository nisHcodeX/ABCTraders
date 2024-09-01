﻿namespace ABCTraders.Views.Admin
{
    partial class UpadteCarPartStatus
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
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_UpadtePartCancel = new System.Windows.Forms.Button();
            this.Drop_PartOrderStatus = new System.Windows.Forms.ComboBox();
            this.Drop_UpdatePartOrderStatus = new System.Windows.Forms.ComboBox();
            AddCarPartNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCarPartNameLabel
            // 
            AddCarPartNameLabel.AutoSize = true;
            AddCarPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddCarPartNameLabel.Location = new System.Drawing.Point(428, 121);
            AddCarPartNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddCarPartNameLabel.Name = "AddCarPartNameLabel";
            AddCarPartNameLabel.Size = new System.Drawing.Size(95, 22);
            AddCarPartNameLabel.TabIndex = 73;
            AddCarPartNameLabel.Text = "Part Name";
            // 
            // AddCarPartNameText
            // 
            this.AddCarPartNameText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartNameText.Location = new System.Drawing.Point(432, 146);
            this.AddCarPartNameText.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartNameText.MaxLength = 10;
            this.AddCarPartNameText.Name = "AddCarPartNameText";
            this.AddCarPartNameText.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartNameText.TabIndex = 92;
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
            this.AddCarPartsTbl.Location = new System.Drawing.Point(29, 201);
            this.AddCarPartsTbl.Name = "AddCarPartsTbl";
            this.AddCarPartsTbl.RowHeadersWidth = 51;
            this.AddCarPartsTbl.RowTemplate.Height = 24;
            this.AddCarPartsTbl.Size = new System.Drawing.Size(1122, 223);
            this.AddCarPartsTbl.TabIndex = 91;
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
            this.Btn_UpadtePartStatus.Location = new System.Drawing.Point(434, 448);
            this.Btn_UpadtePartStatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartStatus.Name = "Btn_UpadtePartStatus";
            this.Btn_UpadtePartStatus.Size = new System.Drawing.Size(323, 50);
            this.Btn_UpadtePartStatus.TabIndex = 84;
            this.Btn_UpadtePartStatus.Text = "UPDATE";
            this.Btn_UpadtePartStatus.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartStatus.Click += new System.EventHandler(this.Btn_UpadtePartStatus_Click);
            // 
            // AddCarPartCodeTxt
            // 
            this.AddCarPartCodeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AddCarPartCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartCodeTxt.Location = new System.Drawing.Point(826, 146);
            this.AddCarPartCodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.AddCarPartCodeTxt.MaxLength = 10;
            this.AddCarPartCodeTxt.Name = "AddCarPartCodeTxt";
            this.AddCarPartCodeTxt.Size = new System.Drawing.Size(325, 28);
            this.AddCarPartCodeTxt.TabIndex = 79;
            // 
            // AddCarPartPartCodeLabel
            // 
            this.AddCarPartPartCodeLabel.AutoSize = true;
            this.AddCarPartPartCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarPartPartCodeLabel.Location = new System.Drawing.Point(824, 119);
            this.AddCarPartPartCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarPartPartCodeLabel.Name = "AddCarPartPartCodeLabel";
            this.AddCarPartPartCodeLabel.Size = new System.Drawing.Size(91, 22);
            this.AddCarPartPartCodeLabel.TabIndex = 78;
            this.AddCarPartPartCodeLabel.Text = "Part Code";
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(822, 35);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(112, 22);
            this.AddCarConditionLabel.TabIndex = 77;
            this.AddCarConditionLabel.Text = "Order Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 94;
            this.label1.Text = "Update Status";
            // 
            // Btn_UpadtePartCancel
            // 
            this.Btn_UpadtePartCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_UpadtePartCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadtePartCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_UpadtePartCancel.Location = new System.Drawing.Point(825, 448);
            this.Btn_UpadtePartCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpadtePartCancel.Name = "Btn_UpadtePartCancel";
            this.Btn_UpadtePartCancel.Size = new System.Drawing.Size(325, 50);
            this.Btn_UpadtePartCancel.TabIndex = 109;
            this.Btn_UpadtePartCancel.Text = "CANCEL";
            this.Btn_UpadtePartCancel.UseVisualStyleBackColor = false;
            this.Btn_UpadtePartCancel.Click += new System.EventHandler(this.Btn_UpadtePartCancel_Click);
            // 
            // Drop_PartOrderStatus
            // 
            this.Drop_PartOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_PartOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_PartOrderStatus.FormattingEnabled = true;
            this.Drop_PartOrderStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Approved",
            "Delivered"});
            this.Drop_PartOrderStatus.Location = new System.Drawing.Point(824, 60);
            this.Drop_PartOrderStatus.Name = "Drop_PartOrderStatus";
            this.Drop_PartOrderStatus.Size = new System.Drawing.Size(326, 30);
            this.Drop_PartOrderStatus.TabIndex = 110;
            // 
            // Drop_UpdatePartOrderStatus
            // 
            this.Drop_UpdatePartOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_UpdatePartOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_UpdatePartOrderStatus.FormattingEnabled = true;
            this.Drop_UpdatePartOrderStatus.Items.AddRange(new object[] {
            "Available",
            "Pending",
            "Approved",
            "Delivered"});
            this.Drop_UpdatePartOrderStatus.Location = new System.Drawing.Point(29, 146);
            this.Drop_UpdatePartOrderStatus.Name = "Drop_UpdatePartOrderStatus";
            this.Drop_UpdatePartOrderStatus.Size = new System.Drawing.Size(326, 30);
            this.Drop_UpdatePartOrderStatus.TabIndex = 111;
            // 
            // UpadteCarPartStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_UpadtePartStatus;
            this.ClientSize = new System.Drawing.Size(1180, 539);
            this.Controls.Add(this.Drop_UpdatePartOrderStatus);
            this.Controls.Add(this.Drop_PartOrderStatus);
            this.Controls.Add(this.Btn_UpadtePartCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCarPartNameText);
            this.Controls.Add(this.AddCarPartsTbl);
            this.Controls.Add(this.Btn_UpadtePartStatus);
            this.Controls.Add(this.AddCarPartCodeTxt);
            this.Controls.Add(this.AddCarPartPartCodeLabel);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(AddCarPartNameLabel);
            this.Name = "UpadteCarPartStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpadteCarPartStatus";
            this.Load += new System.EventHandler(this.UpadteCarPartStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_UpadtePartCancel;
        private System.Windows.Forms.ComboBox Drop_PartOrderStatus;
        private System.Windows.Forms.ComboBox Drop_UpdatePartOrderStatus;
    }
}