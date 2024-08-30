﻿using ABCTraders.Common;
using ABCTraders.Controllers;
using ABCTraders.Dto;
using ABCTraders.Mappings;
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
            AddCarTransmissionDrop.SelectedIndex = 0;
            AddCarColorDrop.SelectedIndex = 0;
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
            PopulateModels();
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

                var manufacturerIdx = Combo_Manufac.SelectedIndex;
                var manufac = (ComboBoxFields)Combo_Manufac.Items[manufacturerIdx];

                var modelIdx = Combo_CarModel.SelectedIndex;
                var model = (ComboBoxFields)Combo_CarModel.Items[modelIdx];

                var addCarDto = new AddCarDto
                {
                    VIN = AddCartVINTxt.Text,
                    Transmission = AddCarTransmissionDrop.SelectedIndex, 
                    Year = (int)AddCarYearNumeric.Value,
                    Color = AddCarColorDrop.SelectedIndex,
                    Description = AddCarDescriptionTxt.Text,
                    FuelType = AddCarFuelTypeDrop.SelectedIndex,
                    Picture = carImage,
                    Price = AddCarPriceNumeric.Value,
                    Condition = AddCarConditionDrop.SelectedIndex,
                    ModelId = model.Value,
                    ManufacturerId = manufac.Value
                };

                var carAddingSuccess = addCarController.AddCar(addCarDto);

                if (carAddingSuccess)
                {
                    MessageBox.Show(validation.Message);
                    AddCarTbl.Rows.Clear();
                    PopulateCarTable();
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
            var vin = AddCartVINTxt.Text;
            var transmission = AddCarTransmissionDrop.SelectedIndex;
            var year = AddCarYearNumeric.Value;
            var fuelType = AddCarFuelTypeDrop.SelectedIndex;
            var color = AddCarColorDrop.SelectedIndex;
            var price = AddCarPriceNumeric.Value;
            var condtion = AddCarConditionDrop.SelectedIndex;
            var description = AddCarDescriptionTxt.Text;
            var picture = AddCarPicutureBox.Image;

            if (string.IsNullOrEmpty(vin) || transmission < 0 || year < 0 || fuelType < 0 || color < 0 || 
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

        //main
        private void AdminAddCar_Load(object sender, EventArgs e)
        {
            PopulateManufacturers();
            PopulateModels();
            PopulateCarTable();
        }

        private void PopulateCarTable()
        {
            var getAllCarsController = new AdminController();
            var cars = getAllCarsController.GetAllCars();

            foreach (var car in cars)
            {
                AddCarTbl.Rows.Add(new object[] 
                { 
                    car.Id,
                    car.ModelName,
                    car.ManufacturerName,
                    car.VIN,
                    car.Transmission,
                    car.Year,
                    car.FuelType,
                    car.Color,
                    car.Price,
                    car.Condition,
                    car.Description,

                });
            }
        }

        private void PopulateManufacturers()
        {
            var controller = new AdminController();
            var manufactures = controller.GetAllManufacturers();

            var list = new List<ComboBoxFields>();

            Combo_Manufac.DisplayMember = "Name";
            Combo_Manufac.ValueMember = "Value";

            foreach (var manufacturer in manufactures)
            {
                list.Add(new ComboBoxFields { Value = manufacturer.Id, Name = manufacturer.Name });
            }

            Combo_Manufac.DataSource = list;
            if (list.Count > 0) Combo_Manufac.SelectedIndex = 0;
        }

        private void PopulateModels()
        {
            var idx = Combo_Manufac.SelectedIndex;
            var item = (ComboBoxFields)Combo_Manufac.Items[idx];

            var controller = new AdminController();
            var models = controller.GetAllModels(item.Value);

            var list = new List<ComboBoxFields>();

            Combo_CarModel.DisplayMember = "Name";
            Combo_CarModel.ValueMember = "Value";

            foreach (var model in models)
            {
                list.Add(new ComboBoxFields { Value = model.Id, Name = model.Name });
            }

            Combo_CarModel.DataSource = list;
        }

        private void AddCarTransmissionLabel_Click(object sender, EventArgs e)
        {
                
        }

        private void AddCarTransmissionDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
