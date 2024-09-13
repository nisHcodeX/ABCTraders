namespace ABCTraders.Views.Admin
{
    partial class AdminOrderList
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Btn_ExportCarOrders = new System.Windows.Forms.Button();
            this.Chart_Admin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_PendingPart = new System.Windows.Forms.Label();
            this.Lbl_PendingCar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_Pending = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ExportPartOrders = new System.Windows.Forms.Button();
            this.Btn_ExportCustomers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Lbl_ApprovedPart = new System.Windows.Forms.Label();
            this.Lbl_ApprovedCar = new System.Windows.Forms.Label();
            this.Lbl_Approved = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_DeliveredPart = new System.Windows.Forms.Label();
            this.Lbl_DeliveredCar = new System.Windows.Forms.Label();
            this.Lbl_Delivered = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Lbl_CustomerCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_ExportCars = new System.Windows.Forms.Button();
            this.Btn_ExportCarParts = new System.Windows.Forms.Button();
            this.Btn_updateCarOrder = new System.Windows.Forms.Button();
            this.Btn_updateCarPartOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Admin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ExportCarOrders
            // 
            this.Btn_ExportCarOrders.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ExportCarOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportCarOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportCarOrders.Location = new System.Drawing.Point(47, 342);
            this.Btn_ExportCarOrders.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExportCarOrders.Name = "Btn_ExportCarOrders";
            this.Btn_ExportCarOrders.Size = new System.Drawing.Size(259, 68);
            this.Btn_ExportCarOrders.TabIndex = 28;
            this.Btn_ExportCarOrders.Text = "EXPORT CAR ORDER DATA";
            this.Btn_ExportCarOrders.UseVisualStyleBackColor = false;
            this.Btn_ExportCarOrders.Click += new System.EventHandler(this.Btn_ExportCarOrders_Click);
            // 
            // Chart_Admin
            // 
            chartArea5.Name = "ChartArea1";
            this.Chart_Admin.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Chart_Admin.Legends.Add(legend5);
            this.Chart_Admin.Location = new System.Drawing.Point(621, 249);
            this.Chart_Admin.Name = "Chart_Admin";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "category";
            this.Chart_Admin.Series.Add(series5);
            this.Chart_Admin.Size = new System.Drawing.Size(536, 372);
            this.Chart_Admin.TabIndex = 30;
            this.Chart_Admin.Text = "ABC Trader Chart View";
            this.Chart_Admin.Click += new System.EventHandler(this.chart2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.Lbl_PendingPart);
            this.panel1.Controls.Add(this.Lbl_PendingCar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Lbl_Pending);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 140);
            this.panel1.TabIndex = 31;
            // 
            // Lbl_PendingPart
            // 
            this.Lbl_PendingPart.AutoSize = true;
            this.Lbl_PendingPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PendingPart.Location = new System.Drawing.Point(219, 95);
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
            this.Lbl_PendingCar.Location = new System.Drawing.Point(219, 60);
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
            // Lbl_Pending
            // 
            this.Lbl_Pending.AutoSize = true;
            this.Lbl_Pending.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pending.Location = new System.Drawing.Point(207, 2);
            this.Lbl_Pending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Pending.Name = "Lbl_Pending";
            this.Lbl_Pending.Size = new System.Drawing.Size(52, 41);
            this.Lbl_Pending.TabIndex = 17;
            this.Lbl_Pending.Text = "00";
            this.Lbl_Pending.Click += new System.EventHandler(this.LBL_Approved_Click);
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
            // Btn_ExportPartOrders
            // 
            this.Btn_ExportPartOrders.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ExportPartOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportPartOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportPartOrders.Location = new System.Drawing.Point(332, 342);
            this.Btn_ExportPartOrders.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExportPartOrders.Name = "Btn_ExportPartOrders";
            this.Btn_ExportPartOrders.Size = new System.Drawing.Size(259, 68);
            this.Btn_ExportPartOrders.TabIndex = 32;
            this.Btn_ExportPartOrders.Text = "EXPORT CAR PARTS ORDER DATA";
            this.Btn_ExportPartOrders.UseVisualStyleBackColor = false;
            this.Btn_ExportPartOrders.Click += new System.EventHandler(this.Btn_ExportPartOrders_Click);
            // 
            // Btn_ExportCustomers
            // 
            this.Btn_ExportCustomers.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ExportCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportCustomers.Location = new System.Drawing.Point(47, 545);
            this.Btn_ExportCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExportCustomers.Name = "Btn_ExportCustomers";
            this.Btn_ExportCustomers.Size = new System.Drawing.Size(259, 68);
            this.Btn_ExportCustomers.TabIndex = 33;
            this.Btn_ExportCustomers.Text = "EXPORT CUSTOMER DATA";
            this.Btn_ExportCustomers.UseVisualStyleBackColor = false;
            this.Btn_ExportCustomers.Click += new System.EventHandler(this.Btn_ExportCustomers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.Lbl_ApprovedPart);
            this.panel2.Controls.Add(this.Lbl_ApprovedCar);
            this.panel2.Controls.Add(this.Lbl_Approved);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(332, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 140);
            this.panel2.TabIndex = 32;
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
            this.Lbl_ApprovedPart.Location = new System.Drawing.Point(224, 95);
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
            this.Lbl_ApprovedCar.Location = new System.Drawing.Point(224, 63);
            this.Lbl_ApprovedCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ApprovedCar.Name = "Lbl_ApprovedCar";
            this.Lbl_ApprovedCar.Size = new System.Drawing.Size(19, 23);
            this.Lbl_ApprovedCar.TabIndex = 20;
            this.Lbl_ApprovedCar.Text = "0";
            // 
            // Lbl_Approved
            // 
            this.Lbl_Approved.AutoSize = true;
            this.Lbl_Approved.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Approved.Location = new System.Drawing.Point(207, 2);
            this.Lbl_Approved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Approved.Name = "Lbl_Approved";
            this.Lbl_Approved.Size = new System.Drawing.Size(52, 41);
            this.Lbl_Approved.TabIndex = 17;
            this.Lbl_Approved.Text = "00";
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Lbl_DeliveredPart);
            this.panel3.Controls.Add(this.Lbl_DeliveredCar);
            this.panel3.Controls.Add(this.Lbl_Delivered);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(621, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 140);
            this.panel3.TabIndex = 33;
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
            this.Lbl_DeliveredPart.Location = new System.Drawing.Point(222, 95);
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
            this.Lbl_DeliveredCar.Location = new System.Drawing.Point(222, 60);
            this.Lbl_DeliveredCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DeliveredCar.Name = "Lbl_DeliveredCar";
            this.Lbl_DeliveredCar.Size = new System.Drawing.Size(19, 23);
            this.Lbl_DeliveredCar.TabIndex = 20;
            this.Lbl_DeliveredCar.Text = "0";
            // 
            // Lbl_Delivered
            // 
            this.Lbl_Delivered.AutoSize = true;
            this.Lbl_Delivered.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Delivered.Location = new System.Drawing.Point(207, 1);
            this.Lbl_Delivered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Delivered.Name = "Lbl_Delivered";
            this.Lbl_Delivered.Size = new System.Drawing.Size(52, 41);
            this.Lbl_Delivered.TabIndex = 17;
            this.Lbl_Delivered.Text = "00";
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
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(4, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 28);
            this.label21.TabIndex = 16;
            this.label21.Text = "CUSTOMERS";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // Lbl_CustomerCount
            // 
            this.Lbl_CustomerCount.AutoSize = true;
            this.Lbl_CustomerCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CustomerCount.Location = new System.Drawing.Point(194, 1);
            this.Lbl_CustomerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CustomerCount.Name = "Lbl_CustomerCount";
            this.Lbl_CustomerCount.Size = new System.Drawing.Size(52, 41);
            this.Lbl_CustomerCount.TabIndex = 17;
            this.Lbl_CustomerCount.Text = "00";
            this.Lbl_CustomerCount.Click += new System.EventHandler(this.Lbl_CustomerCount_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Controls.Add(this.Lbl_CustomerCount);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Location = new System.Drawing.Point(898, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 140);
            this.panel4.TabIndex = 34;
            // 
            // Btn_ExportCars
            // 
            this.Btn_ExportCars.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ExportCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportCars.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportCars.Location = new System.Drawing.Point(47, 448);
            this.Btn_ExportCars.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExportCars.Name = "Btn_ExportCars";
            this.Btn_ExportCars.Size = new System.Drawing.Size(259, 68);
            this.Btn_ExportCars.TabIndex = 35;
            this.Btn_ExportCars.Text = "EXPORT CAR DATA";
            this.Btn_ExportCars.UseVisualStyleBackColor = false;
            this.Btn_ExportCars.Click += new System.EventHandler(this.Btn_ExportCars_Click);
            // 
            // Btn_ExportCarParts
            // 
            this.Btn_ExportCarParts.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ExportCarParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportCarParts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportCarParts.Location = new System.Drawing.Point(332, 448);
            this.Btn_ExportCarParts.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExportCarParts.Name = "Btn_ExportCarParts";
            this.Btn_ExportCarParts.Size = new System.Drawing.Size(259, 68);
            this.Btn_ExportCarParts.TabIndex = 36;
            this.Btn_ExportCarParts.Text = "EXPORT CAR PART DATA";
            this.Btn_ExportCarParts.UseVisualStyleBackColor = false;
            this.Btn_ExportCarParts.Click += new System.EventHandler(this.Btn_ExportCarParts_Click);
            // 
            // Btn_updateCarOrder
            // 
            this.Btn_updateCarOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_updateCarOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateCarOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_updateCarOrder.Location = new System.Drawing.Point(47, 249);
            this.Btn_updateCarOrder.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_updateCarOrder.Name = "Btn_updateCarOrder";
            this.Btn_updateCarOrder.Size = new System.Drawing.Size(259, 68);
            this.Btn_updateCarOrder.TabIndex = 37;
            this.Btn_updateCarOrder.Text = "UPDATE CAR ORDER STATUS";
            this.Btn_updateCarOrder.UseVisualStyleBackColor = false;
            this.Btn_updateCarOrder.Click += new System.EventHandler(this.Btn_updateCarOrder_Click);
            // 
            // Btn_updateCarPartOrder
            // 
            this.Btn_updateCarPartOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_updateCarPartOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateCarPartOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_updateCarPartOrder.Location = new System.Drawing.Point(332, 249);
            this.Btn_updateCarPartOrder.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_updateCarPartOrder.Name = "Btn_updateCarPartOrder";
            this.Btn_updateCarPartOrder.Size = new System.Drawing.Size(259, 68);
            this.Btn_updateCarPartOrder.TabIndex = 38;
            this.Btn_updateCarPartOrder.Text = "UPDATE CAR PARTS ORDER STATUS";
            this.Btn_updateCarPartOrder.UseVisualStyleBackColor = false;
            this.Btn_updateCarPartOrder.Click += new System.EventHandler(this.Btn_updateCarPartOrder_Click);
            // 
            // AdminOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 724);
            this.Controls.Add(this.Btn_updateCarPartOrder);
            this.Controls.Add(this.Btn_updateCarOrder);
            this.Controls.Add(this.Btn_ExportCarParts);
            this.Controls.Add(this.Btn_ExportCars);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_ExportCustomers);
            this.Controls.Add(this.Btn_ExportPartOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chart_Admin);
            this.Controls.Add(this.Btn_ExportCarOrders);
            this.Name = "AdminOrderList";
            this.Text = "AdminOrderList";
            this.Load += new System.EventHandler(this.AdminOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Admin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ExportCarOrders;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_PendingPart;
        private System.Windows.Forms.Label Lbl_PendingCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_Pending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ExportPartOrders;
        private System.Windows.Forms.Button Btn_ExportCustomers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_ApprovedPart;
        private System.Windows.Forms.Label Lbl_ApprovedCar;
        private System.Windows.Forms.Label Lbl_Approved;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_DeliveredPart;
        private System.Windows.Forms.Label Lbl_DeliveredCar;
        private System.Windows.Forms.Label Lbl_Delivered;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label Lbl_CustomerCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_ExportCars;
        private System.Windows.Forms.Button Btn_ExportCarParts;
        private System.Windows.Forms.Button Btn_updateCarOrder;
        private System.Windows.Forms.Button Btn_updateCarPartOrder;
    }
}