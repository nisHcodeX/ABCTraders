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

namespace ABCTraders.Views.Admin
{
    public partial class AdminOrderList : Form
    {
        public AdminOrderList()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void LBL_Approved_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Btn_updateCarOrder_Click(object sender, EventArgs e)
        {
            UpadteCarStatus updateCarOrder = new UpadteCarStatus();
            updateCarOrder.Show();
        }

        private void Btn_updateCarPartOrder_Click(object sender, EventArgs e)
        {
            UpadteCarPartStatus updatePartOrder = new UpadteCarPartStatus();
            updatePartOrder.Show();
        }

        private void Lbl_CustomerCount_Click(object sender, EventArgs e)
        {
         
        }

        private void AdminOrderList_Load(object sender, EventArgs e)
        {
            Lbl_CustomerCount.Text = GetCustomerCout();
        }
        private string GetCustomerCout()
        {
            var userController = new UserController();
            var customerList = userController.GetAllCustomers();
            var customer = customerList.Count;

            return customer.ToString();
        } 
    }
}
