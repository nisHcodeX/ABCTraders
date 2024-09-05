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
    public partial class CustomerProfile : Form
    {
        private readonly int customerId = 0;
        public CustomerProfile(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;   
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
