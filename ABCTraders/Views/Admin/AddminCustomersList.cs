using ABCTraders.Controllers;
using ABCTraders.Dto;
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
            TxtBox_Email.Enabled = false;
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
                    customer.IsActive 
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
                    Drop_CustomerStatus.SelectedIndex = customer.IsActive ? 0 : 1;
                }
            }
        }

        private void CustomerUpdateBtn_Click(object sender, EventArgs e)
        {
            if (Tbl_Customer.SelectedRows.Count > 0)
            {
                var confirmUpdate = MessageBox.Show("Are you want to update this customer","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(confirmUpdate == DialogResult.OK)
                {

                    var selectedIdx = Tbl_Customer.CurrentCell.RowIndex;
                    var selectedCustomer = Tbl_Customer.Rows[selectedIdx];
                    var customerId = (int)selectedCustomer.Cells[0].Value;

                    var customer = new CustomerDto
                    {
                        Address = TxtBox_Address.Text,
                        LastName = TxtBox_LastName.Text,
                        Contact = TxtBox_Contact.Text,
                        FirstName = TxtBox_FirstName.Text,
                        IsActive = Drop_CustomerStatus.SelectedIndex == 0 ? 1 : 0,
                    };
                    var admicController = new AdminController();
                    var customerUpdated = admicController.UpdateCustomer(customerId, customer);
                    if (customerUpdated)
                    {
                        MessageBox.Show("Successfully customer updated");
                    }
                    else
                    {
                        MessageBox.Show("Oops, System error, Please try again later");
                    }
                }
            }
                else
                {
                    MessageBox.Show("Please Select a Customer to update");
                }
        }

        private void Tbl_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
