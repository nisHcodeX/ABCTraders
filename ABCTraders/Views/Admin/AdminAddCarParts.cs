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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTraders.Views.Admin
{
    public partial class AdminAddCarParts : Form
    {
        public AdminAddCarParts()
        {
            InitializeComponent();
            AddCarPartConditionDrop.SelectedIndex = 0;
        }

        private void AddCarPartSaveBtn_Click(object sender, EventArgs e)
        {
            var validation = ValidateAddCar();
            if (validation.IsValid)
            {
                var carImage = ABCPhotConvertor();
                var addCarController = new AdminController();
                var addCarPartDto = new AddCarPartDto
                {
                    PartName = AddCarPartCategoryCombBx.Text,
                    Manufacturer = AddCarPartManufCombBx.Text,
                    Category = AddCarPartCategoryCombBx.Text,
                    PartCode = AddCarPartCodeTxt.Text,
                    StockQuantity = (int)AddCarPartQuantityNumeric.Value,
                    Price = AddCarPartPriceNumeric.Value,
                    Condition = AddCarPartConditionDrop.SelectedIndex,
                    Description = AddCarPartDescriptionTxt.Text,
                    ImagePath = carImage,
                };
                var carAddingSuccess = addCarController.AddCarPart(addCarPartDto);

                if (carAddingSuccess)
                {
                    MessageBox.Show(validation.Message);
                }
                else
                {
                    MessageBox.Show("Cannot add the car part, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            AddCarPartPicutureBox.Image.Save(memoryStream, AddCarPartPicutureBox.Image.RawFormat);
            return memoryStream.GetBuffer();
        }
        private Validation ValidateAddCar() 
        {
            var partName = AddCarPartCategoryCombBx.Text;
            var maufacturer = AddCarPartManufCombBx.Text;
            var category = AddCarPartCategoryCombBx.Text;
            var partCode = AddCarPartCodeTxt.Text;
            var quantity = AddCarPartQuantityNumeric.Value;
            var condition = AddCarPartConditionDrop.SelectedIndex;
            var price = AddCarPartPriceNumeric.Value;
            var description = AddCarPartDescriptionTxt.Text;
            var pic = AddCarPartPicutureBox.Image;

            if (string.IsNullOrEmpty(partName) || string.IsNullOrEmpty(maufacturer) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(partCode) || quantity  < 0 || condition < 0 || price < 0 || string.IsNullOrEmpty(description) || pic == null)
            {
                return new Validation { IsValid = false, Message = "Invalid. Please fill all fields" };
            };
            if (price < 100)
            {
                return new Validation { IsValid = false, Message = "Invalid. Price must be reasonable" };
            }
            if (description.Length < 15)
            {
                return new Validation { IsValid = false, Message = "Invalid. Add valide description" };
            }
            return new Validation
            {
                IsValid = true,
                Message = "Successfully New Car Part Added to The System"
            };
        }

        private void AddCarPartConditionDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPartPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            // Allow only specific image file types
            fileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                AddCarPartPicutureBox.Image = new Bitmap(fileDialog.FileName);

            }
        }
    }
}
