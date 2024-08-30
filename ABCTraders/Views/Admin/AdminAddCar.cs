using ABCTraders.Common;
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
using static System.Net.Mime.MediaTypeNames;

namespace ABCTraders.Views.Admin
{
    public partial class AdminAddCar : Form
    {
        public AdminAddCar()
        {
            InitializeComponent();
            AddCarFuelTypeDrop.SelectedIndex = 0;
            AddCarConditionDrop.SelectedIndex = 0;
        }

        private void AddCarModelCombBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCartVINTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarVINLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCarConditionDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPicutureBox_Click(object sender, EventArgs e)
        {

        }

        private void AddCarManufCombBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Allow only specific image file types
            fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                AddCarPicutureBox.Image = new Bitmap(fileDialog.FileName);

            }
        }

        private void AddCarTransmiCombBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarManufLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCarYearNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddCarFuelTypeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarColorCombBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPriceNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddCarDescriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarSaveBtn_Click(object sender, EventArgs e)
        {
            var  validation = ValidateAddCar();

            if (validation.IsValid)
            {
                var carImage = ABCPhotConvertor();
                var addCarController = new AdminController();
                var addCarDto = new AddCarDto
                {
                    Model = AddCarModelCombBx.Text,
                    Manufacturer = AddCarManufCombBx.Text,
                    VIN = AddCartVINTxt.Text,
                    Transmission = AddCarTransmiCombBx.Text, 
                    Year = (int)AddCarYearNumeric.Value,
                    Color = AddCarColorCombBx.Text,
                    Description = AddCarDescriptionTxt.Text,
                    FuelType = AddCarFuelTypeDrop.SelectedIndex,
                    ImagePath = carImage,
                    Price = AddCarPriceNumeric.Value,
                    Condition = AddCarConditionDrop.SelectedIndex,
                };
                var carAddingSuccess = addCarController.AddCar(addCarDto);

                if (carAddingSuccess)
                {
                    MessageBox.Show(validation.Message);
                }
                else
                {
                    MessageBox.Show("Cannot add the car, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(validation.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private byte[] ABCPhotConvertor()
        {
            MemoryStream memoryStream = new MemoryStream();
            AddCarPicutureBox.Image.Save(memoryStream, AddCarPicutureBox.Image.RawFormat);
            return memoryStream.GetBuffer();
        }

        private Validation ValidateAddCar()
        {
            var model = AddCarModelCombBx.Text;
            var manufacturer  = AddCarManufCombBx.Text;
            var vin = AddCartVINTxt.Text;
            var transmission = AddCarTransmiCombBx.Text;
            var year = AddCarYearNumeric.Value;
            var fuelType = AddCarFuelTypeDrop.SelectedIndex;
            var color = AddCarColorCombBx.Text;
            var price = AddCarPriceNumeric.Value;
            var condtion = AddCarConditionDrop.SelectedIndex;
            var description = AddCarDescriptionTxt.Text;
            var picture = AddCarPicutureBox.Image;

            if (
                string.IsNullOrEmpty(model) || string.IsNullOrEmpty(manufacturer) || string.IsNullOrEmpty(manufacturer) || 
                string.IsNullOrEmpty(vin) || string.IsNullOrEmpty(transmission) || year < 0 || fuelType < 0 || string.IsNullOrEmpty(color) || 
                price < 0 || condtion < 0 || string.IsNullOrEmpty(description) || picture == null
                )
            {
                return new Validation { IsValid = false, Message = "Invalid. Please fill all fields" };
            }
            if(vin.Length < 15)
            {
                return new Validation { IsValid = false, Message = "Invalid. Vehicle Identification Number Length must 15 or Above" };
            }
            if (year < 1990 || year > DateTime.Now.Year)
            {
                return new Validation { IsValid = false, Message = "Invalid. Year must between 1990 and " + DateTime.Now.Year };
            }
            if (price < 100000)
            {
                return new Validation { IsValid = false, Message = "Invalid. Price must be reasonable" };
            }
            if (description.Length < 20)
            {
                return new Validation { IsValid = false, Message = "Invalid. Add valide description" };
            }
            return new Validation
            {
                IsValid = true,
                Message = "Successfully New Car Added to The System"
            };
        }
        }
}
