using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CustomerUpdateCarPart customerUpdateStatus = new CustomerUpdateCarPart();
            customerUpdateStatus.Show();
        }

        private void Btn_updateCarPartOrder_Click(object sender, EventArgs e)
        {

        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            Drop_OrderType.SelectedIndex = 0;
            MessageBox.Show("customer Id "+ customerId);
        }
    }
}
