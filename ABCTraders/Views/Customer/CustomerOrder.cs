using ABCTraders.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABCTraders.Views.Customer
{
    public partial class CustomerOrder : Form
    {
        private readonly int customerId = 0;
        public CustomerOrder(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_updateCarOrder_Click(object sender, EventArgs e)
        {
            CustomerUpdateCar customerUpdateCar = new CustomerUpdateCar(customerId);
            customerUpdateCar.Show();
        }

        private void Btn_updateCarPartOrder_Click(object sender, EventArgs e)
        {
            CustomerUpdateCarPart customerUpdateStatus = new CustomerUpdateCarPart(customerId);
            customerUpdateStatus.Show();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            Drop_OrderType.SelectedIndex = 0;
            Tbl_CarPartOrderList.Visible = false;
            PopulateCarOrderTable();
        }

        private void PopulateCarOrderTable()
        {
  
            var controller = new OrderController();
            //var controller = controller.GetAllCarOrders(())
        }

        private void PopulateCarPartOrderTable()
        {

        }

        private void Drop_OrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Drop_OrderType.SelectedIndex == 0)
            {
                PopulateCarOrderTable();
                Tbl_CarOrderList.Visible = true;    
                Tbl_CarPartOrderList.Visible = false;

            }
            else
            {
                PopulateCarPartOrderTable();
                Tbl_CarOrderList.Visible = false;
                Tbl_CarPartOrderList.Visible = true;
            }
        }
    }
}
