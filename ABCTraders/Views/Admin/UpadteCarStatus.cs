using ABCTraders.Controllers;
using ABCTraders.Model;
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

namespace ABCTraders.Views.Admin
{
    public partial class UpadteCarStatus : Form
    {
        public UpadteCarStatus()
        {
            InitializeComponent();
        }

        private void UpadteCarStatus_Load(object sender, EventArgs e)
        {
            Drop_CarOrderStatus.SelectedIndex = 1;
            Drop_UpdateCarOrderStatus.SelectedIndex = 1;
            PopulateCarTable();

        }

        private void Tbl_OrderCarAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_OrderCarAdmin.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_OrderCarAdmin.CurrentCell.RowIndex;
                var selectedCar = Tbl_OrderCarAdmin.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;
                var orderContorller = new OrderController();
                var carList = orderContorller.GetAllCarOrdersByStatus(Drop_CarOrderStatus.SelectedIndex).Find(order => order.Id == carId);
                if(carList != null)
                {
                    PicBx_CarPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(carList.Picture));
                    TxtBox_CarName.Text = carList.ManufacturerName + " " + carList.ModelName;
                    TxtBox_CustomerName.Text = carList.FristName;
                    TxtBox_Price.Text = carList.Price.ToString();
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

        private void PopulateCarTable()
        {
            var orderContorller = new OrderController();
            var carOrderList = orderContorller.GetAllCarOrdersByStatus(Drop_CarOrderStatus.SelectedIndex);
            Tbl_OrderCarAdmin.Rows.Clear();
            foreach (var order in carOrderList)
            {
                Tbl_OrderCarAdmin.Rows.Add(new object[]
                {
                    order.Id,
                    order.CarId,
                    order.ModelName,
                    order.ManufacturerName,
                    order.FristName,
                    order.VIN,
                    order.Price,
                    order.Email,
                    order.Description,
                });
            }
        }

        private void Drop_CarOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            PopulateCarTable();
        }

        private void Btn_UpadteCarStatus_Click(object sender, EventArgs e)
        {
            if(Drop_CarOrderStatus.SelectedIndex == (int)CarStatus.Pending)
            {
                Btn_UpadteCarStatus.Enabled = true;
            }
            else
            {
                Btn_UpadteCarStatus.Enabled = false;
            }
            if (Tbl_OrderCarAdmin.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_OrderCarAdmin.CurrentCell.RowIndex;
                var selectedCar = Tbl_OrderCarAdmin.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[1].Value;
                var orderId = (int)selectedCar.Cells[0].Value;
                var selectedStatus = Drop_UpdateCarOrderStatus.SelectedIndex == 1 ? 2 : 1;
                var adminController = new AdminController();
                var updateStatus = adminController.UpdateCarStatus(carId, selectedStatus);
                if (updateStatus)
                {
                    var orderController = new OrderController();
                    var statusUpdated = orderController.UpdateCarOrderByAdmin(orderId, selectedStatus);
                    if (statusUpdated) {
                        this.Hide();
                        MessageBox.Show("Car Order Status Updated");
                    } else
                    {
                        MessageBox.Show("Oops, System error, Please try again later");
                        this.Hide();
                    }
                }
                else{
                   MessageBox.Show("Oops, System error, Please try again later");
                   this.Hide();
                }
            }
            else{
                MessageBox.Show("Please select a car first to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            PicBx_CarPhoto.Image = null;
            TxtBox_CarName.Text =string.Empty;
            TxtBox_CustomerName.Text = string.Empty;
            TxtBox_Price.Text = string.Empty;
        }

        private void Tbl_OrderCarAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
