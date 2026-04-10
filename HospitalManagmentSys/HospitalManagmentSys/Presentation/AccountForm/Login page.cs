using HospitalManagmentSys.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void Emal_Address_textBox_TextChanged(object sender, EventArgs e)
        {


        }

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
            if (string.IsNullOrWhiteSpace(Emal_Address_textBox.Text ) || string.IsNullOrWhiteSpace(Password_textBox1.Text ))
            {
                MessageBox.Show("Please Fill All Fields⚠️");
                return;

            }
             if (!IsValidEmail(Emal_Address_textBox.Text))
            {
                MessageBox.Show("Enter a Valid Email⚠️");
                return;

            }
             if (Password_textBox1.Text.Length < 8)
            {
                MessageBox.Show("Password shouldn't be less than 8 Characters⚠️");
                return;
            }

            MessageBox.Show("Logged In Successfully✅");
            Emal_Address_textBox.Clear();
            Password_textBox1.Clear();


        }
    }
}
