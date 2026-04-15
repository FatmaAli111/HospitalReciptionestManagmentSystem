using Dashboard;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Presentation;
using HospitalManagmentSys.Presentation.Controls.Sidebar;
using HospitalManagmentSys.Presentation.Dashbord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static HospitalManagmentSys.BiussnessLogic.LoginService;

namespace WinFormsApp
{
    public partial class Login_page : Form
    {
        private readonly LoginService _loginService;

        public Login_page()
        {
            InitializeComponent();
            _loginService = new LoginService();
        }
        //**************//
        #region All Functions

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public bool Validation()
        {
            if (string.IsNullOrWhiteSpace(Emal_Address_textBox.Text) || string.IsNullOrWhiteSpace(Password_textBox1.Text))
            {
                MessageBox.Show("Please Fill All Fields⚠️");
                return false;

            }
            if (!IsValidEmail(Emal_Address_textBox.Text))
            {
                MessageBox.Show("Enter a Valid Email⚠️");
                return false;
            }

            return true;
        }
        //convert hash passowrd
        //string HashPassword(string pwd)
        //{
        //    using var sha1 = SHA1.Create();
        //    var bytes = Encoding.UTF8.GetBytes(pwd ?? string.Empty);
        //    var hash = sha1.ComputeHash(bytes);
        //    return Convert.ToBase64String(hash);
        //}
        #endregion
        //**************//

        private void Signup_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountCreationTicket accountCreationTicket = new AccountCreationTicket();
            accountCreationTicket.Show();
        }

        private void Password_textBox1_TextChanged(object sender, EventArgs e)
        {
            Password_textBox1.PasswordChar = '*';
        }
        private void Signin_button_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            string email = Emal_Address_textBox.Text.Trim();
            string password = Password_textBox1.Text;

            var user = _loginService.GetUserByEmail(email);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password⚠️\n Please try again.");
                return;
            }

<<<<<<< HEAD
            if (user.PasswordHash != /*HashPassword*/(password))
            {
                MessageBox.Show("Incorrect password ⚠️");
                return;
            }
=======
            //if (user.PasswordHash != HashPassword(password))
            //{
            //    MessageBox.Show("Incorrect password ⚠️");
            //    return;
            //}

            // Set user session
            UserSession.SetUser(user);
>>>>>>> 746362347f8f206ed1cb94d736f8c457183d0bc9

            MessageBox.Show("Login successful!🎉");
            SessionManager.CurrentUser = user;
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }


        private void Emal_Address_textBox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
