using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp
{
    public partial class Sign_up_page : Form
    {
        public Sign_up_page()
        {
            InitializeComponent();
        }

        //////////////
        #region All Functions

        public void Validation()
        {
            if (string.IsNullOrWhiteSpace(Full_Name_textBox.Text) ||
       string.IsNullOrWhiteSpace(Email_Address_textBox.Text) ||
       string.IsNullOrWhiteSpace(Password_textBox.Text) || string.IsNullOrWhiteSpace(Confirm_Password_textBox.Text))
            {
                MessageBox.Show("Please fill all required fields ⚠️");
                return;
            }

            if (Full_Name_textBox.Text.Length < 8)
            {
                MessageBox.Show("Full Name shouldn't be less than 8 Characters⚠️");
                return;
            }
            if (Password_textBox.Text.Length < 8)
            {
                MessageBox.Show("Password shouldn't be less than 8 Characters⚠️");
                return;
            }
            if (!IsValidEmail(Email_Address_textBox.Text))
            {
                MessageBox.Show("Enter a Valid Email⚠️");
                return;

            }
            if (Confirm_Password_textBox.Text != Password_textBox.Text)
            {
                MessageBox.Show("Passwords doesn't not match ⚠️");
                return;
            }
            if (Phone_textBox2.Text.Length != 11)
            {
                MessageBox.Show("Phone number should be 11 digits⚠️");
                return;
            }
            if (Doctor_View.Visible == true)
            {
                if (string.IsNullOrWhiteSpace(Phone_textBox2.Text) || string.IsNullOrWhiteSpace(Specialit_textBox.Text))
                {
                    MessageBox.Show("Please fill all required fields ⚠️");
                    return;
                }
            }
            MessageBox.Show($"User Created Successfully✅ \n Email: {Email_Address_textBox.Text}\n Password: {Password_textBox.Text}");
            clearfilds();

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
            Validation();
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
