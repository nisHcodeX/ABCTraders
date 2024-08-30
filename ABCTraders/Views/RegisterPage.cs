using ABCTraders.Common;
using ABCTraders.Controllers;
using ABCTraders.Dto;
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

namespace ABCTraders
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginFormRegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void loginFormABCLabel_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerRegisterBtn_Click(object sender, EventArgs e)
        {
            var validation = ValidateRegister();
             if (validation.IsValid) {
                var customerController = new UserController();
                var customerDto = new CustomerDto
                {
                    FirstName = FirstNameTxtBox.Text,
                    LastName = LastNameTxtBox.Text,
                    Email = EmailTxtBox.Text,
                    Address = AddressTxtBox.Text,
                    Contact = ContactTxtBox.Text,
                    Password = PasswordTxtBox.Text,
                };

                var customerRegisterd = customerController.CustomerRegister(customerDto);

                if (customerRegisterd)
                {
                    MessageBox.Show(validation.Message);

                    var login = new Login();
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("System error. Please try again later");
                }

            } else{
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
            var password = PasswordTxtBox.Text;
            var confirmPassword = ConfirmPasswordTxtBox.Text;

            //check null fields
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                return new Validation { IsValid = false, Message = "Invalid. Please fill all fields" };
            }

            //validate email
            var mailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
            var mailMatch = mailRegex.Match(email);

            if (!mailMatch.Success)
            {
                return new Validation { IsValid = false, Message = "Invalid Email. Please check again" };
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

            //pasword validator
            var passwordRegex = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$");
            var matchPassword = passwordRegex.Match(password);
            if (!matchPassword.Success)
            {
                return new Validation { IsValid = false, 
                    Message = "Invalid Password\n\n" +
                 "• Password must be at least 8 characters long and include:\n" +
                 "• At least one uppercase letter (A-Z)\n" +
                 "• At least one lowercase letter (a-z)\n" +
                 "• At least one digit (0-9)\n" +
                 "• At least one special character (@$!%*?&)"
                };
            }

            //passowrd & confirm password validator
            if (!string.Equals(password, confirmPassword))
            {
                return new Validation { IsValid = false, Message = "The password confirmation does not match" };
            }

            //check email exist in the db

            var emailController = new UserController();
            var isExist = emailController.IsEmailExist(email.ToLower());
            if (isExist)
            {
                return new Validation { IsValid = false, Message = "Email is exist ase another valid email" };
            }

            return new Validation { IsValid = true,
                Message = "Successfully Registed a new Customer\\n" + 
                "Please login to Continue ...!"
            };
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
