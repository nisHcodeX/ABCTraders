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
    public partial class CustomerUpdateCarPart : Form
    {
        public CustomerUpdateCarPart()
        {
            InitializeComponent();
        }

        private void CustomerUpdateCarPart_Load(object sender, EventArgs e)
        {
            Drop_CustomerUpdateStatus.SelectedIndex = 0;
        }

        private void Btn_UpadtePartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
