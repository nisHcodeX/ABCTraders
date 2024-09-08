using ABCTraders.Controllers;
using ABCTraders.Mappings;
using ABCTraders.Model;
using ABCTraders.Views.Customer;
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

namespace ABCTraders.Views
{
    public partial class SearchCar : Form
    {
        private readonly int customerId = 0;
        public SearchCar(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchCar_Load(object sender, EventArgs e)
        {
            PopulateCarTable();
            ResetForm();
        }

        private void PopulateCarTable()
        {
            Tbl_CarList.Rows.Clear();
            var getAllCarsController = new AdminController();
            var cars = getAllCarsController.GetAllCars();

            foreach (var car in cars)
            {
                Tbl_CarList.Rows.Add(new object[]
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
        private void Tbl_CarList_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_CarList.Rows.Count > 0 )
            {
                var selectedIdx = Tbl_CarList.CurrentCell.RowIndex;
                var selectedCar = Tbl_CarList.Rows[selectedIdx];
                var carId = (int)selectedCar.Cells[0].Value;

                var controller = new AdminController();
                var car = controller.GetAllCars().Find(x => x.Id == carId);

                if (car != null)
                {
                    TxtBox_Manufacture.Text = car.ManufacturerName;
                    TxtBox_Manufacture.Enabled = false;
                    TxtBox_Model.Text = car.ModelName;
                    TxtBox_Model.Enabled = false;
                    Drop_Condition.SelectedIndex = (int)car.Condition;
                    Drop_Condition.Enabled = false;
                    TxtBox_VIN.Text = car.VIN;
                    TxtBox_VIN.Enabled = false;
                    Drop_Color.SelectedIndex = (int)car.Color;  
                    Drop_Color.Enabled = false;
                    Drop_Transmission.SelectedIndex = (int)car.Transmission;
                    Drop_Transmission.Enabled = false;
                    Drop_FuelType.SelectedIndex = (int)car.FuelType;
                    Drop_FuelType.Enabled = false;
                    Numeric_CarYear.Value = (int)car.Year;
                    Numeric_CarYear.Enabled = false;
                    Numeric_Price.Value = (int)car.Price;
                    Numeric_Price.Enabled = false;
                    PicBx_CarPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(car.Picture));
                    TxtBox_Description.Text = car.Description;  
                    TxtBox_Description.Enabled = false;
                }
            }
        }

        private void AddCarPartQuantityNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Tbl_CarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbl_Manufacture_Click(object sender, EventArgs e)
        {

        }

        private void AddCarTransmissionLabel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SearchCar_Click(object sender, EventArgs e)
        {
            var searchCarText = TxtBox_SearchCar.Text;
            var controller = new UserController();
            var result =controller.SearchCar(0, searchCarText);

            if (result.Count > 0) {
                Tbl_CarList.Rows.Clear();
                foreach (var car in result)
                {
                    Tbl_CarList.Rows.Add(new object[]
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

            } else
            {
                MessageBox.Show("The car you search is not Availble !");
            }
        }

        private void Btn_OrderCar_Click(object sender, EventArgs e)
        {
            var selectedIdx = Tbl_CarList.CurrentCell.RowIndex;
            var selectedCar = Tbl_CarList.Rows[selectedIdx];
            var carId = (int)selectedCar.Cells[0].Value;

            if (Tbl_CarList.SelectedRows.Count > 0 && carId> 0) {
                OrderCar orderCar = new OrderCar( customerId, carId);
                orderCar.Show();
            } else
            {
                MessageBox.Show("Please Select a car before order");
            }
        }

        private void Tbl_CarList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetForm()
        {
            PicBx_CarPhoto.Image = null;
            TxtBox_Description.Text = string.Empty;
            TxtBox_Manufacture.Text = string.Empty;
            TxtBox_Model.Text = string.Empty;
            TxtBox_VIN.Text = string.Empty;
            Numeric_Price.Value = 0;
        }
    }
}
