namespace ABCTraders.Views.Customer
{
    partial class CustomerOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Rejected = new System.Windows.Forms.Label();
            this.LBL_Pending = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_Approved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_updateCarOrder = new System.Windows.Forms.Button();
            this.Btn_updateCarPartOrder = new System.Windows.Forms.Button();
            this.Drop_OrderType = new System.Windows.Forms.ComboBox();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.LBL_Rejected);
            this.panel1.Controls.Add(this.LBL_Pending);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LBL_Approved);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(111, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 140);
            this.panel1.TabIndex = 34;
            // 
            // LBL_Rejected
            // 
            this.LBL_Rejected.AutoSize = true;
            this.LBL_Rejected.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Rejected.Location = new System.Drawing.Point(239, 97);
            this.LBL_Rejected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Rejected.Name = "LBL_Rejected";
            this.LBL_Rejected.Size = new System.Drawing.Size(19, 23);
            this.LBL_Rejected.TabIndex = 21;
            this.LBL_Rejected.Text = "2";
            // 
            // LBL_Pending
            // 
            this.LBL_Pending.AutoSize = true;
            this.LBL_Pending.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Pending.Location = new System.Drawing.Point(239, 60);
            this.LBL_Pending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Pending.Name = "LBL_Pending";
            this.LBL_Pending.Size = new System.Drawing.Size(19, 23);
            this.LBL_Pending.TabIndex = 20;
            this.LBL_Pending.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "CAR PART ORDERS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "CARS ORDERS";
            // 
            // LBL_Approved
            // 
            this.LBL_Approved.AutoSize = true;
            this.LBL_Approved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Approved.Location = new System.Drawing.Point(228, 1);
            this.LBL_Approved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Approved.Name = "LBL_Approved";
            this.LBL_Approved.Size = new System.Drawing.Size(52, 41);
            this.LBL_Approved.TabIndex = 17;
            this.LBL_Approved.Text = "03";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "PENDING ORDERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "CARS ORDERS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(784, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 140);
            this.panel3.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "CAR PART ORDERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "CARS ORDERS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(228, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 41);
            this.label14.TabIndex = 17;
            this.label14.Text = "04";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 28);
            this.label15.TabIndex = 16;
            this.label15.Text = "DELIVERED ORDERS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(449, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 140);
            this.panel2.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(5, 101);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 19);
            this.label22.TabIndex = 22;
            this.label22.Text = "CAR PART ORDERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "02";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "APPROVED ORDERS";
            // 
            // Btn_updateCarOrder
            // 
            this.Btn_updateCarOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_updateCarOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateCarOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_updateCarOrder.Location = new System.Drawing.Point(446, 228);
            this.Btn_updateCarOrder.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_updateCarOrder.Name = "Btn_updateCarOrder";
            this.Btn_updateCarOrder.Size = new System.Drawing.Size(284, 68);
            this.Btn_updateCarOrder.TabIndex = 38;
            this.Btn_updateCarOrder.Text = "UPDATE CAR ORDER STATUS";
            this.Btn_updateCarOrder.UseVisualStyleBackColor = false;
            this.Btn_updateCarOrder.Click += new System.EventHandler(this.Btn_updateCarOrder_Click);
            // 
            // Btn_updateCarPartOrder
            // 
            this.Btn_updateCarPartOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_updateCarPartOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateCarPartOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_updateCarPartOrder.Location = new System.Drawing.Point(783, 228);
            this.Btn_updateCarPartOrder.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_updateCarPartOrder.Name = "Btn_updateCarPartOrder";
            this.Btn_updateCarPartOrder.Size = new System.Drawing.Size(285, 68);
            this.Btn_updateCarPartOrder.TabIndex = 39;
            this.Btn_updateCarPartOrder.Text = "UPDATE CAR PARTS ORDER STATUS";
            this.Btn_updateCarPartOrder.UseVisualStyleBackColor = false;
            this.Btn_updateCarPartOrder.Click += new System.EventHandler(this.Btn_updateCarPartOrder_Click);
            // 
            // Drop_OrderType
            // 
            this.Drop_OrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Drop_OrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_OrderType.FormattingEnabled = true;
            this.Drop_OrderType.Items.AddRange(new object[] {
            "Car Orders",
            "Car Part Orders"});
            this.Drop_OrderType.Location = new System.Drawing.Point(111, 330);
            this.Drop_OrderType.Name = "Drop_OrderType";
            this.Drop_OrderType.Size = new System.Drawing.Size(284, 30);
            this.Drop_OrderType.TabIndex = 112;
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(108, 299);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(217, 22);
            this.AddCarConditionLabel.TabIndex = 111;
            this.AddCarConditionLabel.Text = "Select car / car part Order";
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
            this.AddCarPartsTbl.Location = new System.Drawing.Point(111, 400);
            this.AddCarPartsTbl.Name = "AddCarPartsTbl";
            this.AddCarPartsTbl.RowHeadersWidth = 51;
            this.AddCarPartsTbl.RowTemplate.Height = 24;
            this.AddCarPartsTbl.Size = new System.Drawing.Size(957, 223);
            this.AddCarPartsTbl.TabIndex = 113;
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
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 667);
            this.Controls.Add(this.AddCarPartsTbl);
            this.Controls.Add(this.Drop_OrderType);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.Btn_updateCarPartOrder);
            this.Controls.Add(this.Btn_updateCarOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerOrder";
            this.Text = "CustomerOrder";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCarPartsTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Rejected;
        private System.Windows.Forms.Label LBL_Pending;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_Approved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_updateCarOrder;
        private System.Windows.Forms.Button Btn_updateCarPartOrder;
        private System.Windows.Forms.ComboBox Drop_OrderType;
        private System.Windows.Forms.Label AddCarConditionLabel;
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
    }
}