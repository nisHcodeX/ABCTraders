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
    public partial class CustomerUpdateCar : Form
    {
        private readonly int customerId = 0;
        public CustomerUpdateCar(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void CustomerUpdatePartOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
