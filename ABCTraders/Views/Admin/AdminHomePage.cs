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

namespace ABCTraders.Views.Admin
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }
        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            SetCustomerChildForm(new AdminOrderList(), AdminHomeBtn, "Orders List");
        }
        private void AdminFormContainerPnl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AdminHomeBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new AdminOrderList(), AdminHomeBtn, "Orders List");
        }

        private void AdminAddCarBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new AdminAddCar(), AdminAddCarBtn, "Add Car to the System");
        }

        private void AdminAddCarPartsBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new AdminAddCarParts(), AdminAddCarPartsBtn, "Add Car Parts to the System");
        }

        private void AdminCustomerBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new AddminCustomersList(), AdminCustomerBtn, "Customers List");
        }
        private void AdminProfileBtn_Click(object sender, EventArgs e)
        {
            SetCustomerChildForm(new AdminProfile(), AdminProfileBtn, "Admin Profile");
        }
        private void SetCustomerChildForm(Form form, Button button, string header)
        {
            SetActivateButton(button);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            AdminHeaderLbl.Text = header;
            form.Dock = DockStyle.Fill;
            this.AdminFormContainerPnl.Controls.Add(form);
            this.AdminFormContainerPnl.Tag = form;
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
            if (AdminHomeBtn != currentBtn)
            {
                AdminHomeBtn.BackColor = color;
            }
            if (AdminAddCarBtn != currentBtn)
            {
                AdminAddCarBtn.BackColor = color;
            }
            if (AdminAddCarPartsBtn != currentBtn)
            {
                AdminAddCarPartsBtn.BackColor = color;
            }
            if (AdminCustomerBtn != currentBtn)
            {
                AdminCustomerBtn.BackColor = color;
            }
            if (AdminProfileBtn != currentBtn)
            {
                AdminProfileBtn.BackColor = color;
            }
        }

        private void AdminHeaderLbl_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogoutBtn_Click(object sender, EventArgs e)
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
    }
}
