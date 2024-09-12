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
            this.Lbl_PendingPart = new System.Windows.Forms.Label();
            this.Lbl_PendingCar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_PendingOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_DeliveredPart = new System.Windows.Forms.Label();
            this.Lbl_DeliveredCar = new System.Windows.Forms.Label();
            this.Lbl_DeliveredOrders = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.Lbl_ApprovedPart = new System.Windows.Forms.Label();
            this.Lbl_ApprovedCar = new System.Windows.Forms.Label();
            this.Lbl_ApproveOrders = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_updateCarOrder = new System.Windows.Forms.Button();
            this.Btn_updateCarPartOrder = new System.Windows.Forms.Button();
            this.Drop_OrderType = new System.Windows.Forms.ComboBox();
            this.AddCarConditionLabel = new System.Windows.Forms.Label();
            this.Tbl_CarPartOrderList = new System.Windows.Forms.DataGridView();
            this.Tbl_CarOrderList = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_CancelledPart = new System.Windows.Forms.Label();
            this.Lbl_CancelledCar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_CancelledOrders = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarPartOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarOrderList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.Lbl_PendingPart);
            this.panel1.Controls.Add(this.Lbl_PendingCar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Lbl_PendingOrders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 140);
            this.panel1.TabIndex = 34;
            // 
            // Lbl_PendingPart
            // 
            this.Lbl_PendingPart.AutoSize = true;
            this.Lbl_PendingPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PendingPart.Location = new System.Drawing.Point(224, 95);
            this.Lbl_PendingPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PendingPart.Name = "Lbl_PendingPart";
            this.Lbl_PendingPart.Size = new System.Drawing.Size(19, 23);
            this.Lbl_PendingPart.TabIndex = 21;
            this.Lbl_PendingPart.Text = "0";
            // 
            // Lbl_PendingCar
            // 
            this.Lbl_PendingCar.AutoSize = true;
            this.Lbl_PendingCar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PendingCar.Location = new System.Drawing.Point(225, 60);
            this.Lbl_PendingCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PendingCar.Name = "Lbl_PendingCar";
            this.Lbl_PendingCar.Size = new System.Drawing.Size(19, 23);
            this.Lbl_PendingCar.TabIndex = 20;
            this.Lbl_PendingCar.Text = "0";
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
            // Lbl_PendingOrders
            // 
            this.Lbl_PendingOrders.AutoSize = true;
            this.Lbl_PendingOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PendingOrders.Location = new System.Drawing.Point(204, 3);
            this.Lbl_PendingOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PendingOrders.Name = "Lbl_PendingOrders";
            this.Lbl_PendingOrders.Size = new System.Drawing.Size(52, 41);
            this.Lbl_PendingOrders.TabIndex = 17;
            this.Lbl_PendingOrders.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
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
            this.panel3.Controls.Add(this.Lbl_DeliveredPart);
            this.panel3.Controls.Add(this.Lbl_DeliveredCar);
            this.panel3.Controls.Add(this.Lbl_DeliveredOrders);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(591, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 140);
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
            // Lbl_DeliveredPart
            // 
            this.Lbl_DeliveredPart.AutoSize = true;
            this.Lbl_DeliveredPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DeliveredPart.Location = new System.Drawing.Point(228, 95);
            this.Lbl_DeliveredPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DeliveredPart.Name = "Lbl_DeliveredPart";
            this.Lbl_DeliveredPart.Size = new System.Drawing.Size(19, 23);
            this.Lbl_DeliveredPart.TabIndex = 21;
            this.Lbl_DeliveredPart.Text = "0";
            // 
            // Lbl_DeliveredCar
            // 
            this.Lbl_DeliveredCar.AutoSize = true;
            this.Lbl_DeliveredCar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DeliveredCar.Location = new System.Drawing.Point(229, 62);
            this.Lbl_DeliveredCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DeliveredCar.Name = "Lbl_DeliveredCar";
            this.Lbl_DeliveredCar.Size = new System.Drawing.Size(19, 23);
            this.Lbl_DeliveredCar.TabIndex = 20;
            this.Lbl_DeliveredCar.Text = "0";
            // 
            // Lbl_DeliveredOrders
            // 
            this.Lbl_DeliveredOrders.AutoSize = true;
            this.Lbl_DeliveredOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DeliveredOrders.Location = new System.Drawing.Point(206, 5);
            this.Lbl_DeliveredOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DeliveredOrders.Name = "Lbl_DeliveredOrders";
            this.Lbl_DeliveredOrders.Size = new System.Drawing.Size(52, 41);
            this.Lbl_DeliveredOrders.TabIndex = 17;
            this.Lbl_DeliveredOrders.Text = "00";
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
            this.panel2.Controls.Add(this.Lbl_ApprovedPart);
            this.panel2.Controls.Add(this.Lbl_ApprovedCar);
            this.panel2.Controls.Add(this.Lbl_ApproveOrders);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(308, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 140);
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
            // Lbl_ApprovedPart
            // 
            this.Lbl_ApprovedPart.AutoSize = true;
            this.Lbl_ApprovedPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApprovedPart.Location = new System.Drawing.Point(228, 97);
            this.Lbl_ApprovedPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApprovedPart.Name = "Lbl_ApprovedPart";
            this.Lbl_ApprovedPart.Size = new System.Drawing.Size(19, 23);
            this.Lbl_ApprovedPart.TabIndex = 21;
            this.Lbl_ApprovedPart.Text = "0";
            // 
            // Lbl_ApprovedCar
            // 
            this.Lbl_ApprovedCar.AutoSize = true;
            this.Lbl_ApprovedCar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApprovedCar.Location = new System.Drawing.Point(228, 63);
            this.Lbl_ApprovedCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApprovedCar.Name = "Lbl_ApprovedCar";
            this.Lbl_ApprovedCar.Size = new System.Drawing.Size(19, 23);
            this.Lbl_ApprovedCar.TabIndex = 20;
            this.Lbl_ApprovedCar.Text = "0";
            // 
            // Lbl_ApproveOrders
            // 
            this.Lbl_ApproveOrders.AutoSize = true;
            this.Lbl_ApproveOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApproveOrders.Location = new System.Drawing.Point(207, 1);
            this.Lbl_ApproveOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApproveOrders.Name = "Lbl_ApproveOrders";
            this.Lbl_ApproveOrders.Size = new System.Drawing.Size(52, 41);
            this.Lbl_ApproveOrders.TabIndex = 17;
            this.Lbl_ApproveOrders.Text = "00";
            this.Lbl_ApproveOrders.Click += new System.EventHandler(this.label6_Click);
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
            this.Btn_updateCarOrder.Location = new System.Drawing.Point(548, 241);
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
            this.Btn_updateCarPartOrder.Location = new System.Drawing.Point(867, 239);
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
            this.Drop_OrderType.Location = new System.Drawing.Point(31, 277);
            this.Drop_OrderType.Name = "Drop_OrderType";
            this.Drop_OrderType.Size = new System.Drawing.Size(284, 30);
            this.Drop_OrderType.TabIndex = 112;
            this.Drop_OrderType.SelectedIndexChanged += new System.EventHandler(this.Drop_OrderType_SelectedIndexChanged);
            // 
            // AddCarConditionLabel
            // 
            this.AddCarConditionLabel.AutoSize = true;
            this.AddCarConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarConditionLabel.Location = new System.Drawing.Point(28, 246);
            this.AddCarConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddCarConditionLabel.Name = "AddCarConditionLabel";
            this.AddCarConditionLabel.Size = new System.Drawing.Size(217, 22);
            this.AddCarConditionLabel.TabIndex = 111;
            this.AddCarConditionLabel.Text = "Select car / car part Order";
            // 
            // Tbl_CarPartOrderList
            // 
            this.Tbl_CarPartOrderList.AllowUserToAddRows = false;
            this.Tbl_CarPartOrderList.AllowUserToDeleteRows = false;
            this.Tbl_CarPartOrderList.AllowUserToResizeColumns = false;
            this.Tbl_CarPartOrderList.AllowUserToResizeRows = false;
            this.Tbl_CarPartOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CarPartOrderList.ColumnHeadersHeight = 29;
            this.Tbl_CarPartOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.PartName,
            this.PartCode,
            this.Category,
            this.Description,
            this.Price,
            this.Condition,
            this.Quantity,
            this.OrderDate,
            this.ApproveDate,
            this.DeliverdDate});
            this.Tbl_CarPartOrderList.Location = new System.Drawing.Point(31, 360);
            this.Tbl_CarPartOrderList.Name = "Tbl_CarPartOrderList";
            this.Tbl_CarPartOrderList.RowHeadersWidth = 51;
            this.Tbl_CarPartOrderList.RowTemplate.Height = 24;
            this.Tbl_CarPartOrderList.Size = new System.Drawing.Size(1118, 314);
            this.Tbl_CarPartOrderList.TabIndex = 113;
            // 
            // Tbl_CarOrderList
            // 
            this.Tbl_CarOrderList.AllowUserToAddRows = false;
            this.Tbl_CarOrderList.AllowUserToDeleteRows = false;
            this.Tbl_CarOrderList.AllowUserToResizeColumns = false;
            this.Tbl_CarOrderList.AllowUserToResizeRows = false;
            this.Tbl_CarOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tbl_CarOrderList.ColumnHeadersHeight = 29;
            this.Tbl_CarOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn3,
            this.Model,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.OrderedDate,
            this.ApprovedDate,
            this.DeliveredDate});
            this.Tbl_CarOrderList.Location = new System.Drawing.Point(32, 363);
            this.Tbl_CarOrderList.Name = "Tbl_CarOrderList";
            this.Tbl_CarOrderList.RowHeadersWidth = 51;
            this.Tbl_CarOrderList.RowTemplate.Height = 24;
            this.Tbl_CarOrderList.Size = new System.Drawing.Size(1118, 314);
            this.Tbl_CarOrderList.TabIndex = 114;
            this.Tbl_CarOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_CarOrderList_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel4.Controls.Add(this.Lbl_CancelledPart);
            this.panel4.Controls.Add(this.Lbl_CancelledCar);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.Lbl_CancelledOrders);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(873, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 140);
            this.panel4.TabIndex = 35;
            // 
            // Lbl_CancelledPart
            // 
            this.Lbl_CancelledPart.AutoSize = true;
            this.Lbl_CancelledPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CancelledPart.Location = new System.Drawing.Point(242, 95);
            this.Lbl_CancelledPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CancelledPart.Name = "Lbl_CancelledPart";
            this.Lbl_CancelledPart.Size = new System.Drawing.Size(19, 23);
            this.Lbl_CancelledPart.TabIndex = 21;
            this.Lbl_CancelledPart.Text = "0";
            // 
            // Lbl_CancelledCar
            // 
            this.Lbl_CancelledCar.AutoSize = true;
            this.Lbl_CancelledCar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CancelledCar.Location = new System.Drawing.Point(240, 58);
            this.Lbl_CancelledCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CancelledCar.Name = "Lbl_CancelledCar";
            this.Lbl_CancelledCar.Size = new System.Drawing.Size(19, 23);
            this.Lbl_CancelledCar.TabIndex = 20;
            this.Lbl_CancelledCar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "CAR PART ORDERS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "CARS ORDERS";
            // 
            // Lbl_CancelledOrders
            // 
            this.Lbl_CancelledOrders.AutoSize = true;
            this.Lbl_CancelledOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CancelledOrders.Location = new System.Drawing.Point(217, 4);
            this.Lbl_CancelledOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CancelledOrders.Name = "Lbl_CancelledOrders";
            this.Lbl_CancelledOrders.Size = new System.Drawing.Size(52, 41);
            this.Lbl_CancelledOrders.TabIndex = 17;
            this.Lbl_CancelledOrders.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 28);
            this.label13.TabIndex = 16;
            this.label13.Text = "CANCELLED ORDERS";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Condition";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // OrderedDate
            // 
            this.OrderedDate.HeaderText = "OrderedDate";
            this.OrderedDate.MinimumWidth = 6;
            this.OrderedDate.Name = "OrderedDate";
            this.OrderedDate.Width = 125;
            // 
            // ApprovedDate
            // 
            this.ApprovedDate.HeaderText = "ApprovedDate";
            this.ApprovedDate.MinimumWidth = 6;
            this.ApprovedDate.Name = "ApprovedDate";
            this.ApprovedDate.Width = 125;
            // 
            // DeliveredDate
            // 
            this.DeliveredDate.HeaderText = "DeliveredDate";
            this.DeliveredDate.MinimumWidth = 6;
            this.DeliveredDate.Name = "DeliveredDate";
            this.DeliveredDate.Width = 125;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Id";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.Width = 125;
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
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 750);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Tbl_CarOrderList);
            this.Controls.Add(this.Tbl_CarPartOrderList);
            this.Controls.Add(this.Drop_OrderType);
            this.Controls.Add(this.AddCarConditionLabel);
            this.Controls.Add(this.Btn_updateCarPartOrder);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Btn_updateCarOrder);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarPartOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CarOrderList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_PendingPart;
        private System.Windows.Forms.Label Lbl_PendingCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_PendingOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_DeliveredPart;
        private System.Windows.Forms.Label Lbl_DeliveredCar;
        private System.Windows.Forms.Label Lbl_DeliveredOrders;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label Lbl_ApprovedPart;
        private System.Windows.Forms.Label Lbl_ApprovedCar;
        private System.Windows.Forms.Label Lbl_ApproveOrders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_updateCarOrder;
        private System.Windows.Forms.Button Btn_updateCarPartOrder;
        private System.Windows.Forms.ComboBox Drop_OrderType;
        private System.Windows.Forms.Label AddCarConditionLabel;
        private System.Windows.Forms.DataGridView Tbl_CarPartOrderList;
        private System.Windows.Forms.DataGridView Tbl_CarOrderList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_CancelledPart;
        private System.Windows.Forms.Label Lbl_CancelledCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_CancelledOrders;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveredDate;
    }
}