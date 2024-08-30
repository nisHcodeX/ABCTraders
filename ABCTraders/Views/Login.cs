using ABCTraders.Common;
using ABCTraders.Controllers;
using ABCTraders.Model;
using ABCTraders.Repository;
using ABCTraders.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABCTraders.Common.AbcEnums;

namespace ABCTraders
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginFormCombo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginFormLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            var email = LoginFormEmail.Text.Trim();
            var password = LoginFormPassword.Text;
            var userType = LoginFormCombo.SelectedItem.ToString();
            var userController = new UserController();
            var validate = ValidateSignIn(email, password);

            //if (validate.IsValid)
            //{
            //    if(userType == UserTypes.Customer.ToString())
            //    {
            //        this.Hide();
            //        HomePage customerPage = new HomePage();
            //        customerPage.Show();
            //    }
            //    else
            //    {
            //        AdminModel admin = userController.AdminSignIn(email.ToLower(), password);
            //        if (admin != null)
            //        {
            //            this.Hide();
            //            AdminHomePage adminHomePage = new AdminHomePage();
            //            adminHomePage.Show();
            //        }
            //        else
            //        {
            //            // Handle the case where the admin is not found
            //            MessageBox.Show("Admin not found or invalid credentials", "Error");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(validate.Message);
            //}



            //HomePage homePage = new HomePage();
            //homePage.Show();
            //this.Hide();
            //LoginRepository repository = new LoginRepository();
            //RegisterPage registerPage = new RegisterPage();
            //registerPage.Show();
            //if (loginFormUsername.Text == "nish@gmail.com" && loginFormPassword.Text == "1234"){

            //    HomePage homePage = new HomePage();
            //    homePage.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Username Or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private Validation ValidateSignIn(string email, string password)
        {

            if (string.IsNullOrEmpty(email))
            {
                return new Validation { IsValid = false, Message = "Email cannot be empty" };
            }
            else if (string.IsNullOrEmpty(password))
            {
                return new Validation { IsValid = false, Message = "Password cannot be empty" };
            }

            return new Validation { IsValid = true, Message = "Sign In Successfull" };
        }

        private void LoginFormRegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginFormCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LoginFormCombo.SelectedIndex == (int)UserTypes.Admin)
            {
                LoginFormRegisterLabel.Visible = false;
            }
            else
            {
                LoginFormRegisterLabel.Visible = true;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginFormEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginFormPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
