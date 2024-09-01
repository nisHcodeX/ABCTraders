using ABCTraders.Controllers;
using ABCTraders.Mappings;
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

namespace ABCTraders.Views.Admin
{
    public partial class AddminCustomersList : Form
    {
        public AddminCustomersList()
        {
            InitializeComponent();
        }

        private void AddminCustomersList_Load(object sender, EventArgs e)
        {
            PopulateCustomerTable();
        }

        private void PopulateCustomerTable()
        {
            Tbl_Customer.Rows.Clear();
            var customerController = new UserController();
            var customers = customerController.GetAllCustomers();
            foreach (var customer in customers)
            {
                Tbl_Customer.Rows.Add(new object[]
                {
                    customer.Id,
                    customer.FirstName, 
                    customer.LastName, 
                    customer.Email, 
                    customer.Contact, 
                    customer.Contact, 
                    customer.Password 
                });
            }
        }

        private void Tbl_Customer_SelectionChanged(object sender, EventArgs e)
        {
            if (Tbl_Customer.Rows.Count > 0)
            {
                var selectedIdx = Tbl_Customer.CurrentCell.RowIndex;
                var selectedCustomer = Tbl_Customer.Rows[selectedIdx];
                var customerId = (int)selectedCustomer.Cells[0].Value;

                var customerController = new UserController();
                var customer = customerController.GetAllCustomers().Find(x => x.Id == customerId);

                if (customer != null)
                {
                    TxtBox_FirstName.Text = customer.FirstName; 
                    TxtBox_LastName.Text = customer.LastName; 
                    TxtBox_Email.Text = customer.Email;
                    TxtBox_Contact.Text = customer.Contact;
                    TxtBox_Address.Text = customer.Address; 
                    TxtBox_Password.Text = customer.Password;
                }
            }
        }
    }
}
