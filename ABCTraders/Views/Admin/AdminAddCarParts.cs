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
            AddCarPartCategoryDrop.SelectedIndex = 0;
        }

        private void AddCarPartSaveBtn_Click(object sender, EventArgs e)
        {
            var validation = ValidateAddCar();
            if (validation.IsValid)
            {
                var carImage = ABCPhotConvertor();
                var addCarController = new AdminController();

                var manufacturerIdx = AddCarPartManufCombBx.SelectedIndex;
                var manufac = (ComboBoxFields)AddCarPartManufCombBx.Items[manufacturerIdx];
                var addCarPartDto = new AddCarPartDto
                {
                    PartName = AddCarPartNameText.Text,
                    ManufacturerId = manufac.Value,
                    Category = AddCarPartCategoryDrop.SelectedIndex,
                    PartCode = AddCarPartCodeTxt.Text,
                    StockQuantity = (int)AddCarPartQuantityNumeric.Value,
                    Price = AddCarPartPriceNumeric.Value,
                    Condition = AddCarPartConditionDrop.SelectedIndex,
                    Description = AddCarPartDescriptionTxt.Text,
                    ImagePath = carImage,

                };

                bool carPartAddingSuccess = false;

                if (AddCarPartsTbl.SelectedRows.Count > 0)
                {
                    var selectedIdx = AddCarPartsTbl.CurrentCell.RowIndex;
                    var selectedCarPart = AddCarPartsTbl.Rows[selectedIdx];
                    var carPartId = (int)selectedCarPart.Cells[0].Value;

                    //carAddingSuccess = addCarController.UpdateCarPart(carId, addCarDto);
                }
                else
                {
                    carPartAddingSuccess = addCarController.AddCarPart(addCarPartDto); ;
                }

                if (carPartAddingSuccess)
                {
                    MessageBox.Show(validation.Message);
                    AddCarPartsTbl.Rows.Clear();
                    PopulateCarPartTable();
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
            AddCarPartPicutureBox.Image.Save(memoryStream, AddCarPartPicutureBox.Image.RawFormat);
            return memoryStream.GetBuffer();
        }
        private Validation ValidateAddCar() 
        {
            var partName = AddCarPartNameText.Text;
            var maufacturerId = AddCarPartManufCombBx.SelectedIndex;
            var category = AddCarPartCategoryDrop.SelectedIndex;
            var partCode = AddCarPartCodeTxt.Text;
            var quantity = AddCarPartQuantityNumeric.Value;
            var condition = AddCarPartConditionDrop.SelectedIndex;
            var price = AddCarPartPriceNumeric.Value;
            var description = AddCarPartDescriptionTxt.Text;
            var pic = AddCarPartPicutureBox.Image;

            if (string.IsNullOrEmpty(partName) || maufacturerId < 0 || category < 0 || string.IsNullOrEmpty(partCode) || quantity  < 0 || condition < 0 || price < 0 || string.IsNullOrEmpty(description) || pic == null)
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

        private void AdminAddCarParts_Load(object sender, EventArgs e)
        {
            Drop_PartStatus.SelectedIndex = 0;
            PopulateModels();
            AddCarPartsTbl.ClearSelection();
            ResetForm();
        }

        private void PopulateModels()
        {

            var controller = new AdminController();
            var models = controller.GetAllManufacturers();

            var list = new List<ComboBoxFields>();

            AddCarPartManufCombBx.DisplayMember = "Name";
            AddCarPartManufCombBx.ValueMember = "Value";

            foreach (var model in models)
            {
                list.Add(new ComboBoxFields { Value = model.Id, Name = model.Name });
            }

            AddCarPartManufCombBx.DataSource = list;
        }

        private void PopulateCarPartTable()
        {
            AddCarPartsTbl.Rows.Clear();
            var status = Drop_PartStatus.SelectedIndex;
            var getAllCarPartsController = new AdminController();
            var cars = getAllCarPartsController.GetAllCarParts(status);
            foreach (var car in cars)
            {
                AddCarPartsTbl.Rows.Add(new object[]
                {
                    car.Id,
                    car.PartName,
                    car.ManufacturerId,
                    car.PartCode,
                    car.Category,
                    car.Description,
                    car.Price,
                    car.Condition,
                    car.StockQuantity,
                });
            }
        }

        private void AddCarPartManufCombBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPartNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCarPartsTbl_SelectionChanged(object sender, EventArgs e)
        {
            if (AddCarPartsTbl.Rows.Count > 0 && AddCarPartsTbl.CurrentCell != null)
            {
                var selectedIdx = AddCarPartsTbl.CurrentCell.RowIndex;
                var selectedCar = AddCarPartsTbl.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;
                var status = Drop_PartStatus.SelectedIndex;

                var controller = new AdminController();
                var carPart = controller.GetAllCarParts(status).Find(x => x.Id == carId);
                if(carPart != null)
                {
                AddCarPartNameText.Text = carPart.PartName;
                AddCarPartCodeTxt.Text = carPart.PartCode;
                AddCarPartDescriptionTxt.Text = carPart.Description;


                for (int i = 0; i < AddCarPartManufCombBx.Items.Count; i++)
                {
                    var item = (ComboBoxFields)AddCarPartManufCombBx.Items[i];

                    if (item.Value == carPart.ManufacturerId)
                    {
                        AddCarPartManufCombBx.SelectedIndex = i;
                        break;
                    }
                }

                AddCarPartPicutureBox.Image = System.Drawing.Image.FromStream(new MemoryStream(carPart.ImagePath));
                AddCarPartPriceNumeric.Value = carPart.Price;
                }
            }
        }

        private void ResetForm()
        {
            AddCarPartPicutureBox.Image=null;
            AddCarPartCodeTxt.Text = string.Empty;
            AddCarPartNameText.Text = string.Empty;
            AddCarPartConditionDrop.SelectedIndex = 0;
            AddCarPartManufCombBx.SelectedIndex = 0;
            AddCarPartDescriptionTxt.Text = string.Empty;
            AddCarPartPriceNumeric.Value = 0;
            AddCarPartQuantityNumeric.Value = 1;
        }

        private void AddCarPartsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drop_PartStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarPartTable();
        }
    }
}
