using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WinFormsApp
{
    public partial class Sign_up_page : Form
    {
        private readonly SignupService _signupService;

        public Sign_up_page()
        {
            InitializeComponent();
            _signupService = new SignupService();   // Composition
        }


        //////////////
        #region All Functions

        public bool Validation()
        {
            if (string.IsNullOrWhiteSpace(Full_Name_textBox.Text) ||
       string.IsNullOrWhiteSpace(Email_Address_textBox.Text) ||
       string.IsNullOrWhiteSpace(Password_textBox.Text) || string.IsNullOrWhiteSpace(Confirm_Password_textBox.Text))
            {
                MessageBox.Show("Please fill all required fields ⚠️");
                return false;
            }

            if (Full_Name_textBox.Text.Length < 8)
            {
                MessageBox.Show("Full Name shouldn't be less than 8 Characters⚠️");
                return false;
            }
            if (Password_textBox.Text.Length < 8)
            {
                MessageBox.Show("Password shouldn't be less than 8 Characters⚠️");
                return false;
            }
            if (!IsValidEmail(Email_Address_textBox.Text))
            {
                MessageBox.Show("Enter a Valid Email⚠️");
                return false;

            }
            if (Confirm_Password_textBox.Text != Password_textBox.Text)
            {
                MessageBox.Show("Passwords doesn't not match ⚠️");
                return false;
            }

            if (Doctor_View.Visible == true)
            {
                if (Phone_textBox2.Text.Length != 11)
                {
                    MessageBox.Show("Phone number should be 11 digits⚠️");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(Phone_textBox2.Text) || string.IsNullOrWhiteSpace(Specialit_textBox.Text))
                {
                    MessageBox.Show("Please fill all required fields ⚠️");
                    return false;
                }
            }
            return true;

        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public void clearfilds()
        {

            Full_Name_textBox.Clear();
            Email_Address_textBox.Clear();
            Password_textBox.Clear();
            Confirm_Password_textBox.Clear();
            Specialit_textBox.Clear();
            Phone_textBox2.Clear();
            Doctor_View.Visible = true;
        }

        // simple hash to fit existing column length; replace with BCrypt in production
        string HashPassword(string pwd)
        {
            using var sha1 = SHA1.Create();
            var bytes = Encoding.UTF8.GetBytes(pwd ?? string.Empty);
            var hash = sha1.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        #endregion
        //////////////



        private void Receptionist_button_Click(object sender, EventArgs e)
        {
            Doctor_View.Visible = false;

        }

        private void Doctor_button_Click(object sender, EventArgs e)
        {
            Doctor_View.Visible = true;

        }

        private void Sign_in_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
        }
        private void Phone_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void SignupBtn_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            var email = Email_Address_textBox.Text.Trim();

            if (_signupService.EmailExists(email))
            {
                MessageBox.Show("Email already exists ⚠️");
                return;
            }

            var user = new HospitalManagmentSys.Data.Models.User
            {
                Role = Doctor_View.Visible ? UserRole.Doctor : UserRole.Receptionist,
                Name = Full_Name_textBox.Text.Trim(),
                Email = email,
                PasswordHash = HashPassword(Password_textBox.Text),
                Phone = Phone_textBox2.Text.Trim(),
                IsActive = true,
                CreatedAt = DateTime.Now,
                Speciality = Specialit_textBox.Text
            };

            _signupService.AddUser(user);

            MessageBox.Show($"User Created Successfully✅ \n Email: {email} \n Password: {Password_textBox.Text}");
            clearfilds();
        }

        private void Phone_textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void Sign_up_page_Load(object sender, EventArgs e)
        {

        }

    }


}
