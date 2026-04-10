using HospitalManagmentSys.Data.Models;
using Microsoft.Identity.Client;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalManagmentSys.Presentation
{
    public partial class AccountCreationTicket : Form
    {
        public AccountCreationTicket()
        {
            InitializeComponent();
            doctor_view_panel.Visible = false;
        }

        ///////////////
        #region All Functions
        private void clearfilds()
        {

            FullName_textBox1.Clear();
            EmailAddress_textBox.Clear();
            Password_textBox.Clear();
            Speciality_textBox.Clear();
            Phone_textBox.Clear();
            Doctor_radioButton2.Checked = false;
            Receptionist_radioButton1.Checked = false;
            doctor_view_panel.Visible = false;
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public void validation()
        {
            if (string.IsNullOrWhiteSpace(FullName_textBox1.Text) ||
        string.IsNullOrWhiteSpace(EmailAddress_textBox.Text) ||
        string.IsNullOrWhiteSpace(Password_textBox.Text))

            {
                MessageBox.Show("Please fill all required fields ⚠️");
                return;
            }

            if (!Doctor_radioButton2.Checked && !Receptionist_radioButton1.Checked)
            {
                MessageBox.Show("Please select a role ⚠️");
                return;
            }

            if (Doctor_radioButton2.Checked)
            {

                if (string.IsNullOrWhiteSpace(Phone_textBox.Text) || string.IsNullOrWhiteSpace(Speciality_textBox.Text))
                {
                    MessageBox.Show("Please fill all required fields ⚠️");
                    return;
                }
            }
            if (FullName_textBox1.Text.Length < 8)
            {
                MessageBox.Show("Full Name shouldn't be less than 8 Characters⚠️");
                return;
            }
            if (Password_textBox.Text.Length < 8)
            {
                MessageBox.Show("Password shouldn't be less than 8 Characters⚠️");
                return;
            }
            if (!IsValidEmail(EmailAddress_textBox.Text))
            {
                MessageBox.Show("Enter a Valid Email⚠️");
                return;

            }
            if(Phone_textBox.Text.Length != 11)
            {
                MessageBox.Show("Phone number should be 11 digits⚠️");
                return;
            }
            else
            {
                MessageBox.Show("Your account creation request has been sent successfully!\n Please wait for the admin to review your request.");
                clearfilds();
            }
        }

        #endregion
        //////////////


        private void Doctor_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Doctor_radioButton2.Checked)
            {
                doctor_view_panel.Visible = true;
            }
            else
            {
                Speciality_textBox.Clear();
                Phone_textBox.Clear();
                doctor_view_panel.Visible = false;
            }
        }

        private void Send_guna2CircleButton1_Click(object sender, EventArgs e)
        {
            validation();
        }
       

        private void Reset_guna2CircleButton1_Click(object sender, EventArgs e)
        {
            clearfilds();
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = '*';
        }
        

        private void Phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void EmailAddress_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void doctor_view_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AccountCreationTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
