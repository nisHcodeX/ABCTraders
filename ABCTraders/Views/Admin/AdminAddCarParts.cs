using ABCTraders.Common;
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
using static ABCTraders.Common.AbcEnums;

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
                var addCarPartController = new AdminController();

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

                if (AddCarPartsTbl.SelectedRows.Count > 0)
                {
                    var selectedIdx = AddCarPartsTbl.CurrentCell.RowIndex;
                    var selectedCarPart = AddCarPartsTbl.Rows[selectedIdx];
                    var carPartId = (int)selectedCarPart.Cells[0].Value;

                    var carPartUpdateSuccess = addCarPartController.UpdateCarPart(carPartId, addCarPartDto);
                    if (carPartUpdateSuccess)
                    {
                        MessageBox.Show("Succesfully Updated the car part details");
                        PopulateCarPartTable();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update the car part, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var carPartAddingSuccess = addCarPartController.AddCarPart(addCarPartDto);

                    if (carPartAddingSuccess)
                    {
                        MessageBox.Show(validation.Message);
                        PopulateCarPartTable();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add the car part, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var controller = new AdminController();
            var isPartAvailable = controller.IsPartExist(partCode.Trim());
            if (isPartAvailable)
            {
                return new Validation { IsValid = false, Message = "Part Code You entered is available" };
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
            var partActiveStatus = (int)StockStatus.Available;
            if (status == (int)StockStatus.Available)
            {
                partActiveStatus = 1;
            }
            var cars = getAllCarPartsController.GetAllCarPartsByStatus(partActiveStatus);
            if(status == (int)StockStatus.OutOfStock)
            {
                cars = getAllCarPartsController.GetAllCarPartsByStatus((int)StockStatus.Available).FindAll(part => part.StockQuantity == 0);
            }
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
            if (AddCarPartsTbl.Rows.Count > 0)
            {
                var status = Drop_PartStatus.SelectedIndex;
                var selectedIdx = AddCarPartsTbl.CurrentCell.RowIndex;
                var selectedCar = AddCarPartsTbl.Rows[selectedIdx];
                var carPartId = (int)selectedCar.Cells[0].Value;

                var controller = new AdminController();
                var part = controller.GetAllCarParts().Find(x => x.Id == carPartId);

                if (part != null)
                {
                    AddCarPartNameText.Text = part.PartName;
                    AddCarPartDescriptionTxt.Text = part.Description;


                    for (int i = 0; i < AddCarPartManufCombBx.Items.Count; i++)
                    {
                        var item = (ComboBoxFields)AddCarPartManufCombBx.Items[i];

                        if (item.Value == part.ManufacturerId)
                        {
                            AddCarPartManufCombBx.SelectedIndex = i;
                            break;
                        }
                    }

                    AddCarPartCodeTxt.Text = part.PartCode;
                    AddCarPartCategoryDrop.SelectedIndex = Convert.ToInt32(part.Category);
                    AddCarPartPicutureBox.Image = System.Drawing.Image.FromStream(new MemoryStream(part.ImagePath));
                    AddCarPartQuantityNumeric.Value = (int)part.StockQuantity;
                    AddCarPartPriceNumeric.Value = (int)part.Price;
                    AddCarPartConditionDrop.SelectedIndex = Convert.ToInt32(part.Condition);
                    AddCarPartDescriptionTxt.Text = part.Description.ToString();
                }
            }
        }

        private void ResetForm()
        {
            AddCarPartPicutureBox.Image=null;
            AddCarPartCodeTxt.Text = string.Empty;
            AddCarPartNameText.Text = string.Empty;
            AddCarPartConditionDrop.SelectedIndex = 0;
            //AddCarPartManufCombBx.SelectedIndex = 0;
            AddCarPartDescriptionTxt.Text = string.Empty;
            AddCarPartPriceNumeric.Value = 0;
            AddCarPartQuantityNumeric.Value = 1;
        }

        private void AddCarPartsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drop_PartStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Drop_PartStatus.SelectedIndex == (int)StockStatus.Deleted)
            {
                AddCarPartDeleteBtn.Visible = false;
                AddCarPartSaveBtn.Visible = false;  
                AddCarPartPhotoBtn.Visible = false;
            }
            ResetForm();
            PopulateCarPartTable();
        }

        private void AddCarPartDeleteBtn_Click(object sender, EventArgs e)
        {
            if (AddCarPartsTbl.SelectedRows.Count > 0)
            {
                var confirmDelete = MessageBox.Show("Are you want to remove this car part", "WRANING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (confirmDelete == DialogResult.OK)
                {
                var selectedIdx = AddCarPartsTbl.CurrentCell.RowIndex;
                var selectedCar = AddCarPartsTbl.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;

                var controller = new AdminController();
                var isDeleted = controller.DeleteCarPart(carId);

                if (isDeleted > 0)
                {
                    MessageBox.Show("Succesfully car part deleted");
                    AddCarPartsTbl.Rows.Clear();
                    PopulateCarPartTable();
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

        private void AddCarPartsTbl_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
