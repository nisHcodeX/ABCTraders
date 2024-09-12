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
    public partial class UpadteCarPartStatus : Form
    {
        public UpadteCarPartStatus()
        {
            InitializeComponent();
        }

        private void UpadteCarPartStatus_Load(object sender, EventArgs e)
        {
            Drop_UpdatePartOrderStatus.SelectedIndex = 1;   
            Drop_CarPartOrderStatus.SelectedIndex = 1;
            Tbl_OrderCarPartsAdmin.ClearSelection();
            PopulatePartTable();
        }

        private void Btn_UpadtePartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulatePartTable()
        {
            var orderContorller = new OrderController();
            var partList = orderContorller.GetAllCarPartOrdersByStaus(Drop_CarPartOrderStatus.SelectedIndex);
            Tbl_OrderCarPartsAdmin.Rows.Clear();
            foreach (var part in partList)
            {
                Tbl_OrderCarPartsAdmin.Rows.Add(new object[]
                {
                    part.Id,
                    part.PartName,
                    part.Price,
                    part.Quantity,
                    part.FristName,
                    part.Email,
                    part.Description,
                });
            }
        }

        private void Btn_UpadtePartStatus_Click(object sender, EventArgs e)
        {
            if (Drop_CarPartOrderStatus.SelectedIndex == (int)CarStatus.Pending)
            {
                Btn_UpadtePartStatus.Enabled = true;
            }
            else
            {
                Btn_UpadtePartStatus.Enabled = false;
            }
            if (Tbl_OrderCarPartsAdmin.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_OrderCarPartsAdmin.CurrentCell.RowIndex;
                var selectedCar = Tbl_OrderCarPartsAdmin.Rows[selectedIdx];
                var orderId = (int)selectedCar.Cells[0].Value;
                var selectedStatus = Drop_UpdatePartOrderStatus.SelectedIndex == 1 ? 2 : 1;
                var orderController = new OrderController();
                var statusUpdated = orderController.UpdateCarPartOrderByAdmin(orderId, selectedStatus);

                if (statusUpdated)
                {
                    this.Hide();
                    MessageBox.Show("Car Part Order Status Updated");
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                    this.Hide();
                }
 
            }
            else
            {
                MessageBox.Show("Please select a car part first to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Drop_CarPartOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePartTable();
        }

        private void Tbl_OrderCarPartsAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tbl_OrderCarPartsAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_OrderCarPartsAdmin.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_OrderCarPartsAdmin.CurrentCell.RowIndex;
                var selectedCar = Tbl_OrderCarPartsAdmin.Rows[selectedIdx];
                var partId = (int)selectedCar.Cells[0].Value;
                var orderContorller = new OrderController();
                var partList = orderContorller.GetAllCarPartOrdersByStaus(Drop_CarPartOrderStatus.SelectedIndex).Find(order => order.Id == partId);
                if (partList != null)
                {
                    PicBx_PartPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(partList.Picture));
                    TxtBox_PartName.Text = partList.PartName;
                    TxtBox_CustomerName.Text = partList.FristName;
                    TxtBox_Price.Text = partList.Price.ToString();
                    TxtBoxQuantity.Text = partList.Quantity.ToString();
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                }
            }

        }

        private void ResetForm()
        {
            PicBx_PartPhoto.Image = null;
            TxtBox_PartName.Text = string.Empty;
            TxtBox_CustomerName.Text = string.Empty;
            TxtBox_Price.Text = string.Empty;
            TxtBoxQuantity.Text = string.Empty;
        }

        private void Drop_CarPartOrderStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ResetForm();
            PopulatePartTable();
        }
    }
}
