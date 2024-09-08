using ABCTraders.Controllers;
using ABCTraders.Dto;
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

namespace ABCTraders.Views.Customer
{
    public partial class OrderCar : Form
    {
        private readonly int customerId = 0;
        private readonly int carId = 0;
        public OrderCar(int customerId,int carId)
        {
            this.customerId = customerId;
            this.carId = carId;
            InitializeComponent();
        }

        private void OrderCar_Load(object sender, EventArgs e)
        {
            LoadCarOrderDetails();
        }

        private void LoadCarOrderDetails ()
        {
            if (customerId > 0 && carId > 0)
            {
                var controller = new AdminController();
                var car = controller.GetAllCars().Find(x => x.Id == carId);
                if (car != null)
                {
                    PicBx_CarPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(car.Picture));
                    TxtBox_Model.Text = car.ModelName.ToString();
                    TxtBox_Price.Text = car.Price.ToString();
                    TxtBox_Manu.Text = car.ManufacturerName.ToString();
                    TxtBox_VIN.Text = car.VIN.ToString();
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
 
        private string GetCarCondtion(Enum conditon)
        {
            CarCondition conditionEnum = (CarCondition)conditon;
            string conditionText = conditionEnum.ToString();
            return conditionText;
        }
        private string GetFuelType(Enum fuelType)
        {
            FuelTypes fuelTypeEnum = (FuelTypes)fuelType;
            string fuelTypeText = fuelTypeEnum.ToString();
            return fuelTypeText;
        }

        private string GetColorType(Enum colorType)
        {
            CarColors colorTypeEnum = (CarColors)colorType;
            string colorTypeText = colorTypeEnum.ToString();
            return colorTypeText;
        }

        private void Btn_CancelOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddCarTransmissionLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCarDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Model_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Manufacturer_Click(object sender, EventArgs e)
        {

        }

        private void AddCarYearLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCarPartNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderVINLabel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_OrderCarNow_Click(object sender, EventArgs e)
        {
            var carOrder = new OrderController();
            var addCarController = new AdminController();
            var carOrderDto = new CarOrderDto
            {
                CarId = carId,
                CustomerId = customerId,
                Price = decimal.Parse(TxtBox_Price.Text),
                Status = (int)CarStatus.Pending
            };

            var carOrderSuccess = carOrder.CarOrder(carOrderDto);

            if (carOrderSuccess) {
                var status = addCarController.UpdateCarStatus(carId, (int)CarStatus.Pending);
                if (status)
                {

                    this.Hide();
                    MessageBox.Show("Your Order Has Been Placed!");
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Oops, System error, Please try again later");
                }
            } else
            {
                this.Hide();
                MessageBox.Show("Oops, System error, Please try again later");
            }
        }
    }
}
