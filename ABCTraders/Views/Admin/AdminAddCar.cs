using ABCTraders.Common;
using ABCTraders.Controllers;
using ABCTraders.Dto;
using ABCTraders.Mappings;
using ABCTraders.Model;
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
using static ABCTraders.Common.AbcEnums;
using static System.Net.Mime.MediaTypeNames;

namespace ABCTraders.Views.Admin
{
    public partial class AdminAddCar : Form
    {
        public AdminAddCar()
        {
            InitializeComponent();
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

                if (AddCarTbl.SelectedRows.Count > 0)
                {
                    var selectedIdx = AddCarTbl.CurrentCell.RowIndex;
                    var selectedCar = AddCarTbl.Rows[selectedIdx];
                    var carId = (int)selectedCar.Cells[0].Value;

                    var carUpdateSuccess = addCarController.UpdateCar(carId, addCarDto);

                    if (carUpdateSuccess)
                    {
                        MessageBox.Show("Succesfully Updated the car details");
                        AddCarTbl.Rows.Clear();
                        PopulateCarTable();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update the car, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
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
            var controller = new AdminController();
            var isPartAvailable = controller.IsCarExist(vin.Trim());
            if (isPartAvailable)
            {
                return new Validation { IsValid = false, Message = "Vehicle available for Your entered VIN" };
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
            Drop_CarStatus.SelectedIndex = 0;
            PopulateManufacturers();
            PopulateModels();
            AddCarTbl.ClearSelection();
            PopulateCarTable();
            ResetForm();
        }

        private void PopulateCarTable()
        {
            AddCarTbl.Rows.Clear();
            var activeStatus = Drop_CarStatus.SelectedIndex;
            var getAllCarsController = new AdminController();
            var carActiveStatus = (int)StockStatus.Available;

            if(activeStatus == (int)StockStatus.Available)
            {
                carActiveStatus = 1;
            }

            var cars = getAllCarsController.GetAllCarsByStatus(carActiveStatus);
            var sortedCars = cars.FindAll(car => car.Status == (int)CarStatus.Available);

            foreach (var car in sortedCars)
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

        private void AddCarTbl_SelectionChanged(object sender, EventArgs e)
       {
            if (AddCarTbl.SelectedRows.Count > 0 )
            {
                var activeStatus = Drop_CarStatus.SelectedIndex;
                var selectedIdx = AddCarTbl.CurrentCell.RowIndex;
                var selectedCar = AddCarTbl.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;
                var carCurrentStatus = 0;

                if (activeStatus == 0)
                {
                    carCurrentStatus = 1;
                }

                var controller = new AdminController();
                var car = controller.GetAllCarsByStatus(carCurrentStatus).Find(x => x.Id == carId);

                if (car != null)
                {
                    AddCartVINTxt.Text = car.VIN;
                    AddCarDescriptionTxt.Text = car.Description;


                    for (int i = 0; i < Combo_Manufac.Items.Count; i++)
                    {
                        var item = (ComboBoxFields)Combo_Manufac.Items[i];

                        if (item.Value == car.ManufacturerId)
                        {
                            Combo_Manufac.SelectedIndex = i;
                            break;
                        }
                    }

                    for (int i = 0; i < Combo_CarModel.Items.Count; i++)
                    {
                        var item = (ComboBoxFields)Combo_CarModel.Items[i];

                        if (item.Value == car.ModelId)
                        {
                            Combo_CarModel.SelectedIndex = i;
                            break;
                        }
                    }
                    AddCarConditionDrop.SelectedIndex = (int)car.Condition;
                    AddCarTransmissionDrop.SelectedIndex = (int)car.Transmission;
                    AddCarPicutureBox.Image = System.Drawing.Image.FromStream(new MemoryStream(car.Picture));
                    AddCarColorDrop.SelectedIndex = (int)car.Color;
                    AddCarPriceNumeric.Value = car.Price;
                    AddCarYearNumeric.Value = car.Year;
                    AddCarFuelTypeDrop.SelectedIndex = (int)car.FuelType;
                }
            }
        }

        private void ResetForm()
        {
            AddCarPicutureBox.Image = null;
            AddCartVINTxt.Text = string.Empty;
            AddCarFuelTypeDrop.SelectedIndex = 0;
            AddCarConditionDrop.SelectedIndex = 0;
            AddCarTransmissionDrop.SelectedIndex = 0;
            AddCarColorDrop.SelectedIndex = 0;
            AddCarDescriptionTxt.Text = string.Empty;
            AddCarPriceNumeric.Value = 0;
        }

        private void AddCarTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drop_CarStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            PopulateCarTable();
            if(Drop_CarStatus.SelectedIndex == (int)StockStatus.Deleted)
            {
                AddCarDeleteBtn.Visible = false;
                AddCarSaveBtn.Visible = false;
                AddCarPhotoBtn.Visible = false;
            }
        }

        private void AddCarDeleteBtn_Click(object sender, EventArgs e)
        {
            if (AddCarTbl.SelectedRows.Count > 0)
            {

                var confirmDelete = MessageBox.Show("Are you want to remove this car", "WRANING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (confirmDelete == DialogResult.OK)
                {
                var selectedIdx = AddCarTbl.CurrentCell.RowIndex;
                var selectedCar = AddCarTbl.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;

                var controller = new AdminController();
                var isDeleted = controller.DeleteCar(carId);

                if (isDeleted > 0)
                {
                    MessageBox.Show("Succesfully car record deleted");
                    AddCarTbl.Rows.Clear();
                    PopulateCarTable();
                }
                else
                {
                    MessageBox.Show("Oops, System error, Please try again later");
                }
                }
            }
            else
            {
                MessageBox.Show("Please select a car first to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
