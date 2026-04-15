using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HospitalManagmentSys.Presentation
{
    public partial class AccountCreationTicket : Form
    {
        private readonly UserRequestService _requestService;

        public AccountCreationTicket()
        {
            InitializeComponent();
            doctor_view_panel.Visible = false;
            _requestService = new UserRequestService();
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

        public bool validation()
        {
            if (string.IsNullOrWhiteSpace(FullName_textBox1.Text) ||
                string.IsNullOrWhiteSpace(EmailAddress_textBox.Text) ||
                string.IsNullOrWhiteSpace(Password_textBox.Text))

            {
                MessageBox.Show("Please fill all required fields ⚠️");
                return false;
            }

            if (!Doctor_radioButton2.Checked && !Receptionist_radioButton1.Checked)
            {
                MessageBox.Show("Please select a role ⚠️");
                return false;
            }

            if (Doctor_radioButton2.Checked)
            {
                if (Phone_textBox.Text.Length != 11)
                {
                    MessageBox.Show("Phone number should be 11 digits⚠️");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(Phone_textBox.Text) || string.IsNullOrWhiteSpace(Speciality_textBox.Text))
                {
                    MessageBox.Show("Please fill all required fields ⚠️");
                    return false;
                }

            }
            if (FullName_textBox1.Text.Length < 8)
            {
                MessageBox.Show("Full Name shouldn't be less than 8 Characters⚠️");
                return false;
            }
            if (Password_textBox.Text.Length < 8)
            {
                MessageBox.Show("Password shouldn't be less than 8 Characters⚠️");
                return false;
            }
            if (!IsValidEmail(EmailAddress_textBox.Text))
            {
                MessageBox.Show("Enter a Valid Email⚠️");
                return false;

            }

            return true;


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
            if (!validation())
                return;

            var email = EmailAddress_textBox.Text.Trim();

            if (_requestService.EmailExists(email))
            {
                MessageBox.Show("Email already exists ⚠️");
                return;
            }

            var request = new UserRequest
            {
                Role = doctor_view_panel.Visible ? UserRole.Doctor : UserRole.Receptionist,
                Name = FullName_textBox1.Text.Trim(),
                Email = email,
                PasswordHash = Password_textBox.Text,
                Phone = Phone_textBox.Text.Trim(),
                IsAccountCreated = false,
                RequestDate = DateTime.Now,
                Speciality = Speciality_textBox.Text
            };

            _requestService.AddRequest(request);

            MessageBox.Show("Your account creation request has been sent successfully!\nPlease wait for the admin to review your request.");
            clearfilds();
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

        private void Phone_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
