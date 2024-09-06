using ABCTraders.Controllers;
using ABCTraders.Dto;
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
    public partial class OrderCarPart : Form
    {
        private readonly int customerId = 0;
        private readonly int partId = 0;
        private readonly decimal price = 0;
        private readonly int qauntity = 0;
        private readonly int updateQuantity = 0;
        public OrderCarPart(int customerId, int partId, decimal qauntity, decimal updateQuantity,decimal price)
        {
            this.customerId = customerId;
            this.partId = partId;
            this.qauntity = (int)qauntity;
            this.updateQuantity = (int)updateQuantity;
            this.price = price;

            InitializeComponent();
        }

        private void Btn_CancelOrderPart_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrderCarPart_Load(object sender, EventArgs e)
        {
            LoadCarPartOrderDetails();
        }

        private void LoadCarPartOrderDetails()
        {
            if (customerId > 0 && partId > 0)
            {
                var controller = new AdminController();
                var part = controller.GetAllCarParts(0).Find(x => x.Id == partId);
                if (part != null)
                {
                    PicBx_CarPartPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(part.ImagePath));
                    TxtBox_PartName.Text =part.PartName.ToString();
                    Numeric_Price.Value = price;
                    TxtBox_Qunttity.Text = qauntity.ToString();
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Oops, System error, Please try again later");
                this.Hide();
            }
        }

        private void Btn_OrderCarPartNow_Click(object sender, EventArgs e)
        {
            var carOrder = new OrderController();
            var addCarController = new AdminController();
            var updateStatus = (int)CarStatus.Pending;

            PartOrderDto carPartDto = new PartOrderDto
            {
                CustomerId = customerId,
                FullPrice = price,
                PartId = partId,
                Quantity = qauntity,
                Status = updateStatus
            };
            var stockUpdated = addCarController.UpdateCarPartStock(partId, updateQuantity);

            if (stockUpdated)
            {
                var partOrdered = carOrder.CarPartOrder(carPartDto);

                if (partOrdered)
                {
                    this.Hide();
                    MessageBox.Show("Your Order Has Been Placed!");
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Oops, System error, Please try again later");
                this.Hide();
            }
        }
    }
}
