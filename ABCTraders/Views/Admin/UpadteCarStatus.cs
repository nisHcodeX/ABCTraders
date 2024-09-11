using ABCTraders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Btn_UpadteCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCarTable()
        {
            var orderContorller = new OrderController();
            var carList = orderContorller.GetAllCarOrdersByStatus(Drop_CarOrderStatus.SelectedIndex);
            Tbl_OrderCarAdmin.Rows.Clear();
            foreach (var car in carList)
            {
                Tbl_OrderCarAdmin.Rows.Add(new object[]
                {
                    car.Id,
                    car.ModelName,
                    car.ManufacturerName,
                    car.FristName,
                    car.VIN,
                    car.Price,
                    car.Email,
                    car.Description
                });
            }
        }

        private void Drop_CarOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarTable();
        }

        private void Btn_UpadteCarStatus_Click(object sender, EventArgs e)
        {
            if (Tbl_OrderCarAdmin.Rows.Count > 0)
            {
                var selectedIdx = Tbl_OrderCarAdmin.CurrentCell.RowIndex;
                var selectedCar = Tbl_OrderCarAdmin.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;
                var selectedStatus = Drop_UpdateCarOrderStatus.SelectedIndex;
                var adminController = new AdminController();
                var updateStatus = adminController.UpdateCarStatus(carId, selectedStatus);
            }
            else
            {
                MessageBox.Show("Please select a car first to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
