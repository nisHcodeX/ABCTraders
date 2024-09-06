﻿using ABCTraders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Views.Admin
{
    public partial class AdminOrderList : Form
    {
        public AdminOrderList()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void LBL_Approved_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Btn_updateCarOrder_Click(object sender, EventArgs e)
        {
            UpadteCarStatus updateCarOrder = new UpadteCarStatus();
            updateCarOrder.Show();
        }

        private void Btn_updateCarPartOrder_Click(object sender, EventArgs e)
        {
            UpadteCarPartStatus updatePartOrder = new UpadteCarPartStatus();
            updatePartOrder.Show();
        }

        private void Lbl_CustomerCount_Click(object sender, EventArgs e)
        {
         
        }

        private void AdminOrderList_Load(object sender, EventArgs e)
        {
            Lbl_CustomerCount.Text = GetCustomerCout();
            UpdateAdminDAshBoard();
        }
        private string GetCustomerCout()
        {
            var userController = new UserController();
            var customerList = userController.GetAllCustomers();
            var customer = customerList.Count;

            return customer.ToString();
        }

        private void UpdateAdminDAshBoard()
        {
            var controller = new OrderController();
            var pendingCar = controller.GetAllCarOrders((int)CarStatus.Pending).Count;
            var approvedCar = controller.GetAllCarOrders((int)CarStatus.Approved).Count;
            var deliveredCar = controller.GetAllCarOrders((int)CarStatus.Delivered).Count;
            
            var pendingPart = controller.GetAllCarPartOrders((int) CarStatus.Pending).Count;
            var approvedPart = controller.GetAllCarPartOrders((int) CarStatus.Pending).Count;
            var deliveredPart = controller.GetAllCarPartOrders((int) CarStatus.Pending).Count;

            Lbl_PendingCar.Text = pendingCar.ToString();
            Lbl_PendingPart.Text = pendingPart.ToString();
            Lbl_Pending.Text = (pendingCar + pendingPart).ToString();

            Lbl_ApprovedCar.Text = approvedCar.ToString();  
            Lbl_ApprovedPart.Text = approvedPart.ToString();
            Lbl_Approved.Text = (approvedCar + approvedPart).ToString();

            Lbl_DeliveredCar.Text = deliveredCar.ToString();
            Lbl_DeliveredPart.Text = deliveredPart.ToString();
            Lbl_Delivered.Text = (deliveredCar + deliveredPart).ToString();

            Chart_Admin.Titles.Add("ABC Traders");
            Chart_Admin.Series.Add("pending");
            Chart_Admin.Series["pending"].Points.AddXY("Pending", (deliveredCar + deliveredPart).ToString());
            Chart_Admin.Series["pending"].ChartType = SeriesChartType.Column;
            Chart_Admin.Series.Add("approved");
            Chart_Admin.Series["approved"].Points.AddXY("approved", (deliveredCar + deliveredPart).ToString());
            Chart_Admin.Series.Add("delivered");
            Chart_Admin.Series["delivered"].Points.AddXY("delivered", (deliveredCar + deliveredPart).ToString());
            Chart_Admin.Series.Add("customers");
            Chart_Admin.Series["customers"].Points.AddXY("customers", (deliveredCar + deliveredPart).ToString());
        }

    }
}
