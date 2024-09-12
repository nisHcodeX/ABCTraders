using ABCTraders.Common;
using ABCTraders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders.Views.Customer
{
    public partial class CustomerUpdateCar : Form
    {
        private readonly int customerId = 0;
        public CustomerUpdateCar(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void CustomerUpdatePartOrder_Load(object sender, EventArgs e)
        {
            PopulateCarOrderTable();
            Drop_CustomerUpdateStatus.SelectedIndex = 0;
        }

        private void PopulateCarOrderTable()
        {

            var controller = new OrderController();
            var carOrderList = controller.GetAllCarOrdersByCustomer(customerId).FindAll(car => car.Id == (int)CarStatus.Approved);
            var loadder = new CommonLoader();
            Tbl_CusCarOrderList.Rows.Clear();
            if (carOrderList != null)
            {
                foreach (var car in carOrderList)
                {
                    Tbl_CusCarOrderList.Rows.Add(new object[]
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

        private void Tbl_CusCarOrderList_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_CusCarOrderList.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_CusCarOrderList.CurrentCell.RowIndex;
                var selectedCar = Tbl_CusCarOrderList.Rows[selectedIdx];
                var orderId = (int)selectedCar.Cells[0].Value;
                var orderContorller = new OrderController();
                var carPartOrder = orderContorller.GetAllCarOrdersByCustomer(customerId).Find(order => order.Id == orderId);
                if (carPartOrder != null)
                {
                    PicBx_PartPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(carPartOrder.Picture));
                    TxtBox_CarName.Text = carPartOrder.ManufacturerName + " " + carPartOrder.ModelName;
                    TxtBox_Price.Text = carPartOrder.Price.ToString();
                    TxtBox_VIN.Text = carPartOrder.VIN.ToString();
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                }
            }
        }

        private void Btn_UpadteCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_UpadteCarStatus_Click(object sender, EventArgs e)
        {
            if (Tbl_CusCarOrderList.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_CusCarOrderList.CurrentCell.RowIndex;
                var selectedCar = Tbl_CusCarOrderList.Rows[selectedIdx];
                var orderId = (int)selectedCar.Cells[0].Value;
                var selectedStatus = Drop_CustomerUpdateStatus.SelectedIndex == 1 ? 3 : 2;
                var orderController = new OrderController();
                var statusUpdated = orderController.UpdateCarOrder(orderId, selectedStatus);

                if (statusUpdated)
                {
                    this.Hide();
                    MessageBox.Show("Car Order Status Updated");
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Please select a car first to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
