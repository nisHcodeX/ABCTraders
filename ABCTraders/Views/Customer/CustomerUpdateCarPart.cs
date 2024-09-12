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
    public partial class CustomerUpdateCarPart : Form
    {
        private readonly int customerId = 0;
        public CustomerUpdateCarPart(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
            
        }

        private void CustomerUpdateCarPart_Load(object sender, EventArgs e)
        {
            Drop_CustomerUpdateStatus.SelectedIndex = 0;
            PopulateCarPartOrderTable();
        }

        private void Btn_UpadtePartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCarPartsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCarPartNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopulateCarPartOrderTable()
        {
            var controller = new OrderController();
            var carPartOrderList = controller.GetAllCarPartOrdersByCustomer(customerId);
            var sortedPartList = carPartOrderList.FindAll(p => p.Status == (int)CarStatus.Approved);

            var loader = new CommonLoader();
            Tbl_CusCarPartOrderList.Rows.Clear();
    
            if (carPartOrderList != null)
            {
                foreach (var part in sortedPartList)
                {
                    Tbl_CusCarPartOrderList.Rows.Add(new object[]
                    {
                        part.Id,
                        part.PartName,
                        part.PartCode,
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

        private void Tbl_CusCarPartOrderList_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_CusCarPartOrderList.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_CusCarPartOrderList.CurrentCell.RowIndex;
                var selectedCar = Tbl_CusCarPartOrderList.Rows[selectedIdx];
                var orderId = (int)selectedCar.Cells[0].Value;
                var orderContorller = new OrderController();
                var carPartOrder = orderContorller.GetAllCarPartOrdersByCustomer(customerId).Find(order => order.Id == orderId);
                if (carPartOrder != null)
                {
                    PicBx_PartPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(carPartOrder.Picture));
                    TxtBox_PartName.Text = carPartOrder.PartName;
                    TxtBox_Price.Text = carPartOrder.PartCode;
                    TxtBox_Quantity.Text = carPartOrder.Quantity.ToString();
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                }
            }

        }

        private void Tbl_CusCarPartOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_UpadtePartStatus_Click(object sender, EventArgs e)
        {
            if (Tbl_CusCarPartOrderList.SelectedRows.Count > 0)
            {
                var selectedIdx = Tbl_CusCarPartOrderList.CurrentCell.RowIndex;
                var selectedCar = Tbl_CusCarPartOrderList.Rows[selectedIdx];
                var orderId = (int)selectedCar.Cells[0].Value;
                var selectedStatus = Drop_CustomerUpdateStatus.SelectedIndex == 1 ? 3 : 2;
                var orderController = new OrderController();
                var statusUpdated = orderController.UpdateCarPartOrder(orderId, selectedStatus);

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
    }
}
