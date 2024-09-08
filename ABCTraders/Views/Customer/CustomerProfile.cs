using ABCTraders.Common;
using ABCTraders.Controllers;
using ABCTraders.Dto;
using ABCTraders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            EmailTxtBox.ReadOnly = true;
            GetCustomerById(customerId);
        }

        private void GetCustomerById(int customerId)
        {
            var controller = new UserController();
            var customer = controller.GetAllCustomers().Find(x => x.Id == customerId);

            EmailTxtBox.Text = customer.Email;
            FirstNameTxtBox.Text = customer.FirstName;
            LastNameTxtBox.Text = customer.LastName;
            ContactTxtBox.Text = customer.Contact;
            AddressTxtBox.Text = customer.Address;
        }

        private void Btn_ProfileUpdate_Click(object sender, EventArgs e)
        {
            var validation = ValidateRegister();
            var customerController = new UserController();

            if (validation.IsValid) {
                var customerDto = new CustomerModel
                {
                    FirstName = FirstNameTxtBox.Text,
                    LastName = LastNameTxtBox.Text,
                    Email = EmailTxtBox.Text,
                    Address = AddressTxtBox.Text,
                    Contact = ContactTxtBox.Text,
                    Password = PasswordTxtBox.Text,
                };

                var customerUpdated = customerController.UpdateCustomer(customerId ,customerDto);
                if (customerUpdated) {
                    MessageBox.Show(validation.Message);
                } else
                {
                    MessageBox.Show("Oops! Something went wrong. Please try again later");
                }
            } else
            {
                MessageBox.Show(validation.Message);
            }
        }

        private Validation ValidateRegister()
        {
            var firstName = FirstNameTxtBox.Text;
            var lastName = LastNameTxtBox.Text;
            var email = EmailTxtBox.Text.Trim();
            var contact = ContactTxtBox.Text;
            var address = AddressTxtBox.Text;

            //check null fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address))
            {
                return new Validation { IsValid = false, Message = "Invalid. Please fill all fields" };
            }

            //validate phone number
            if (contact.Length != 10)
            {
                return new Validation { IsValid = false, Message = "Invalid Contact. Contact need 10 numbers" };
            }
            var contactCharacters = contact.ToCharArray();
            foreach (var c in contactCharacters)
            {
                if (!int.TryParse(c.ToString(), out int number))
                {
                    return new Validation { IsValid = false, Message = "Invalid Contact. suuport only numbers" };
                }
            }

            return new Validation
            {
                IsValid = true,
                Message = "Successfully Update the Customer"
            };
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage(customerId);
            homepage.Refresh();
        }

        private void Btn_UpdatePassword_Click(object sender, EventArgs e)
        {

            var currentPassowd = PasswordTxtBox.Text;
            var newPassword = NewPasswordTxtBox.Text;
            var confirmPassword = ConfimNewPasswordTxtBox.Text;
            var userController = new UserController();

            if (!string.IsNullOrEmpty(currentPassowd) && !string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(confirmPassword))
            {
            var customer = userController.GetAllCustomers().Find(x => x.Id == customerId);

            var isMathced = userController.ComparePasswords(currentPassowd,customer.Password);

            if (isMathced)
            {
                    var newPasswordValid = ValidatePassword(currentPassowd);
                    if (newPasswordValid.IsValid)
                    {
                        var comparePasswords = ComparePasswords(newPassword, confirmPassword);
                        if (comparePasswords.IsValid)
                        {
                            var passwordUpdated = userController.UpdatePassword(customerId, confirmPassword);
                            if(passwordUpdated> 0)
                            {
                                MessageBox.Show("Password Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("Oops! Something went wrong. Please try again later");
                            }
                        }
                        else
                        {
                            MessageBox.Show(comparePasswords.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(newPasswordValid.Message);
                    }
            }
            else
            {
                MessageBox.Show("Current Password is invalid");
            }
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty");
            }
        }

        private Validation ValidatePassword(string password)
        {
            var passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$");
            var matchPassword = passwordRegex.Match(password);
            if (!matchPassword.Success)
            {
                return new Validation
                {
                    IsValid = false,
                    Message = "Invalid Password\n\n" +
                 "• Password must be at least 8 characters long and include:\n" +
                 "• At least one uppercase letter (A-Z)\n" +
                 "• At least one lowercase letter (a-z)\n" +
                 "• At least one digit (0-9)\n" +
                 "• At least one special character (@$!%*?&)"
                };
            }
            else
            {
                return new Validation { IsValid = true, Message=  "Password validated" };
            }
        }

        private Validation ComparePasswords(string newPass, string comPass)
        {
            if (!string.Equals(newPass, comPass))
            {
                return new Validation { IsValid = false, Message = "The password confirmation does not match" };
            }
            return new Validation { IsValid = true, Message = "The passwords matched" };
        }
    }
}
