using ABCTraders.Controllers;
using ABCTraders.Mappings;
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

namespace ABCTraders.Views.Customer
{
    public partial class SearchCarParts : Form
    {
        private readonly int customerId = 0;
        public SearchCarParts(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPartNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPartCodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarPartQuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchCarParts_Load(object sender, EventArgs e)
        {
            PopulateCarPartTable();

        }

        private void PopulateCarPartTable()
        {
            Tbl_CarPartsList.Rows.Clear();
            var getAllCarPartsController = new AdminController();
            var partList = getAllCarPartsController.GetAllCarParts(0);
            foreach (var part in partList)
            {
                Tbl_CarPartsList.Rows.Add(new object[]
                {
                    part.Id,
                    part.PartName,
                    part.ManufacturerId,
                    part.PartCode,
                    part.Category,
                    part.Description,
                    part.Price,
                    part.Condition,
                    part.StockQuantity,
                });
            }
        }
        private void Tbl_CarPartsList_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_CarPartsList.Rows.Count > 0)
            {
                var selectedIdx = Tbl_CarPartsList.CurrentCell.RowIndex;
                var selectedCar = Tbl_CarPartsList.Rows[selectedIdx];
                var carPartId = (int)selectedCar.Cells[0].Value;

                var controller = new AdminController();
                var part = controller.GetAllCarParts(0).Find(x => x.Id == carPartId);

                if (part != null)
                {
                    TxtBox_Description.Text = part.Description;
                    TxtBox_Description.Enabled = false;
                    TxtBox_Manufacturer.Text = part.ManufacturerName;
                    TxtBox_Manufacturer.Enabled = false;
                    TxtBox_PartCode.Text = part.PartCode;
                    TxtBox_PartCode.Enabled = false;
                    Drop_Category.SelectedIndex = Convert.ToInt32(part.Category);
                    Drop_Category.Enabled = false;
                    Drop_Condition.SelectedIndex = (int)part.Condition;
                    Drop_Condition.Enabled = false;
                    TxtBox_PartName.Text = part.PartName;
                    TxtBox_PartName.Enabled = false;
                    Numeric_Price.Value = part.Price;
                    Numeric_Price.Enabled = false;
                    Numeric_Stock.Value = part.StockQuantity;
                    Numeric_Stock.Enabled = false;
                    PicBx_CarPartPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(part.ImagePath));
                    Numeric_QuantityPrice.Value = part.Price;
                }
            }
        }

        private void Tbl_CarPartsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Drop_Manufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_SearchCarPart_Click(object sender, EventArgs e)
        {
            var searchText = TxtBox_SearchPart.Text;
            var controller = new UserController();
            var searechResult =  controller.SearchCarPart(0, searchText);
            if (searechResult.Count > 0)
            {
                Tbl_CarPartsList.Rows.Clear();
                foreach (var part in searechResult)
                {
                    if(part.StockQuantity> 0)
                    {
                    Tbl_CarPartsList.Rows.Add(new object[]
                    {
                    part.Id,
                    part.PartName,
                    part.ManufacturerId,
                    part.PartCode,
                    part.Category,
                    part.Description,
                    part.Price,
                    part.Condition,
                    part.StockQuantity,
                    });
                    }
                }

            }
            else
            {
                MessageBox.Show("The part you searhc not Available in the System");
            }
        }

        private void Btn_OrderPart_Click(object sender, EventArgs e)
        {
            var selectedIdx = Tbl_CarPartsList.CurrentCell.RowIndex;
            var selectedCar = Tbl_CarPartsList.Rows[selectedIdx];
            var partId = (int)selectedCar.Cells[0].Value;
            var qauntity = Numeric_Quantity.Value;
            var price = Numeric_QuantityPrice.Value;
            var stock = Numeric_Stock.Value;
            var updateQuantity = stock - qauntity;
            if (Tbl_CarPartsList.SelectedRows.Count > 0 && partId > 0)
            {
                OrderCarPart orderCarPart = new OrderCarPart(customerId, partId, qauntity, updateQuantity, price);
                orderCarPart.Show();
            }
            else
            {
                MessageBox.Show("Please Select a car before order");
            }
        }

        private void Numeric_QuantityPrice_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Numeric_Quantity_ValueChanged(object sender, EventArgs e)
        {
            var stock = Numeric_Stock.Value;
            var partPrice = Numeric_Price.Value;
            var quantity = Numeric_Quantity.Value;
            if (stock < Numeric_Quantity.Value) {
                MessageBox.Show("Selected Quantity is Invalid");
                Numeric_Quantity.Value = 1;
                Btn_OrderPart.Enabled = false;
            }
            else
            {
                Btn_OrderPart.Enabled = true;
                var calPrice = partPrice * quantity;
                if(calPrice > 0)
                {
                    Numeric_QuantityPrice.Value = calPrice;
                }
                else
                {
                    MessageBox.Show("Ooops! System Error. Please try again later");
                }
            }
        }
    }
}
