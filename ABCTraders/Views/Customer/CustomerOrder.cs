using ABCTraders.Common;
using ABCTraders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABCTraders.Common.AbcEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABCTraders.Views.Customer
{
    public partial class CustomerOrder : Form
    {
        private readonly int customerId = 0;
        public CustomerOrder(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_updateCarOrder_Click(object sender, EventArgs e)
        {
            CustomerUpdateCar customerUpdateCar = new CustomerUpdateCar(customerId);
            customerUpdateCar.Show();
        }

        private void Btn_updateCarPartOrder_Click(object sender, EventArgs e)
        {
            CustomerUpdateCarPart customerUpdateStatus = new CustomerUpdateCarPart(customerId);
            customerUpdateStatus.Show();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            Drop_OrderType.SelectedIndex = 0;
            Tbl_CarPartOrderList.Visible = false;
            PopulateCarOrderTable();
            UpdateCustomerDashBoard();
        }

        private void PopulateCarOrderTable()
        {
  
            var controller = new OrderController();
            var carOrderList = controller.GetAllCarOrdersByCustomer(customerId);
            var loadder = new CommonLoader();
            Tbl_CarOrderList.Rows.Clear();
            if(carOrderList != null)
            {
                foreach (var car in carOrderList)
                {
                    Tbl_CarOrderList.Rows.Add(new object[]
                    {
                        car.Id,
                        car.ManufacturerName,
                        car.ModelName,
                        car.Description,
                        car.Price,
                        loadder.GetConditionName(car.Conditon),
                        car.OrderedDate,
                        car.ApprovedDate,
                        car.DeliveredDate
                    });
                }
            }
        }

        private void PopulateCarPartOrderTable()
        {
            var controller = new OrderController();
            var carPartOrderList = controller.GetAllCarPartOrdersByCustomer(customerId);
            Tbl_CarPartOrderList.Rows.Clear();
            var loader = new CommonLoader();
            if (carPartOrderList != null)
            {
                foreach (var part in carPartOrderList)
                {
                    Tbl_CarPartOrderList.Rows.Add(new object[]
                    {
                        part.Id,
                        part.PartName,
                        part.PartCode,
                        loader.GetCategoryName(part.Category),
                        part.Description,
                        part.Price,
                        loader.GetConditionName(part.Conditon),
                        part.Quantity,
                        part.OrderedDate,
                        part.ApprovedDate,
                        part.DeliveredDate
                    });
                }
            }
        }

        private void Drop_OrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Drop_OrderType.SelectedIndex == 0)
            {
                PopulateCarOrderTable();
                Tbl_CarOrderList.Visible = true;    
                Tbl_CarPartOrderList.Visible = false;

            }
            else
            {
                PopulateCarPartOrderTable();
                Tbl_CarOrderList.Visible = false;
                Tbl_CarPartOrderList.Visible = true;
            }
        }

        private void UpdateCustomerDashBoard()
        {
            var controller = new OrderController();
            var pendingCar = controller.GetAllCarOrdersByCustomer(customerId).FindAll(Co => Co.Status == (int)CarStatus.Pending).Count;
            var approvedCar = controller.GetAllCarOrdersByCustomer(customerId).FindAll(Co => Co.Status == (int)CarStatus.Approved).Count;
            var deliveredCar = controller.GetAllCarOrdersByCustomer(customerId).FindAll(Co => Co.Status == (int)CarStatus.Delivered).Count;
            var cancelledCar = controller.GetAllCarOrdersByCustomer(customerId).FindAll(Co => Co.Status == (int)CarStatus.Cancelled).Count;

            var pendingPart = controller.GetAllCarPartOrdersByCustomer(customerId).FindAll(Cp => Cp.Status == (int)CarStatus.Pending).Count;
            var approvedPart = controller.GetAllCarPartOrdersByCustomer(customerId).FindAll(Cp => Cp.Status == (int)CarStatus.Approved).Count;
            var deliveredPart = controller.GetAllCarPartOrdersByCustomer(customerId).FindAll(Cp => Cp.Status == (int)CarStatus.Delivered).Count;
            var cancelledPart = controller.GetAllCarPartOrdersByCustomer(customerId).FindAll(Cp => Cp.Status == (int)CarStatus.Cancelled).Count;

            Lbl_PendingOrders.Text = (pendingCar + pendingPart).ToString();
            Lbl_PendingCar.Text = pendingCar.ToString();
            Lbl_PendingPart.Text = pendingPart.ToString();

            Lbl_ApproveOrders.Text = (approvedCar + approvedPart).ToString();
            Lbl_ApprovedCar.Text = approvedCar.ToString();
            Lbl_ApprovedPart.Text = approvedPart.ToString();

            Lbl_DeliveredOrders.Text = (deliveredCar + deliveredPart).ToString();
            Lbl_DeliveredCar.Text = deliveredPart.ToString();
            Lbl_DeliveredPart.Text = deliveredPart.ToString();

            Lbl_CancelledOrders.Text = (cancelledCar + cancelledPart).ToString();
            Lbl_CancelledCar.Text = cancelledCar.ToString();
            Lbl_CancelledPart.Text = cancelledPart.ToString();
        }

        private void Tbl_CarOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
