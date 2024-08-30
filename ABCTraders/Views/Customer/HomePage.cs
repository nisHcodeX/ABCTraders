using ABCTraders.Views;
using ABCTraders.Views.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTraders
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            SetCustomerChildForm(new CustomerOrder(), CustomerHomeBtn, "My Order List");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerLogoutBtn_Click(object sender, EventArgs e)
        {
            var message = "Are you sure you want to logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            var dialogResult = MessageBox.Show(message, title, buttons);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void CustomerSearchCarBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new SearchCar(), CustomerSearchCarBtn, "Search Car");
        }
        private void CustomerCarPartsBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new SearchCarParts(), CustomerCarPartsBtn, "Search Car Parts");
        }
        private void CustomerHomeBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new CustomerOrder(), CustomerHomeBtn, "My Orders List");
        }

        private void CustomerProfileBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new CustomerProfile(), CustomerProfileBtn, "My Profile");
        }

        private void SetCustomerChildForm(Form form, Button button, string header)
        {
            SetActivateButton(button);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            CustomerHeaderLbl.Text = header;    
            form.Dock = DockStyle.Fill;
            this.customerFormContainerPnl.Controls.Add(form);
            this.customerFormContainerPnl.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void SetActivateButton(Button currentBtn)
        {
            var color = Color.FromArgb(153, 204, 255);
            currentBtn.BackColor = Color.FromArgb(0, 128, 255);
            DisableButton(currentBtn, color);
        }

        private void DisableButton(Button currentBtn, Color color)
        {
            if (CustomerHomeBtn != currentBtn)
            {
                CustomerHomeBtn.BackColor = color;
            }
            if (CustomerSearchCarBtn != currentBtn)
            {
                CustomerSearchCarBtn.BackColor = color;
            }
            if (CustomerCarPartsBtn != currentBtn)
            {
                CustomerCarPartsBtn.BackColor = color;
            }
            if (CustomerProfileBtn != currentBtn)
            {
                CustomerProfileBtn.BackColor = color;
            }
        }

        private void customerFormContainerPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerHeaderPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
