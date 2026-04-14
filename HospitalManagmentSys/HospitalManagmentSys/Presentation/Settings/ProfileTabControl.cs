using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.Presentation.Settings
{
    public partial class ProfileTabControl : UserControl
    {
        public ProfileTabControl()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            lblDoctorName.Text = user.Name;
            lblDoctorEmail.Text = user.Email;
            txtFullName.Text = user.Name;
            txtEmail.Text = user.Email;

            var parts = user.Name.Split(' ');
            string initials = parts.Length >= 2
                ? $"{parts[0][0]}{parts[1][0]}"
                : user.Name.Substring(0, 2).ToUpper();
            lblAvatarInitials.Text = initials;

            btnBadge.Text = user.Role.ToString();
            btnBadge.FillColor = user.Role.ToString() == "Doctor"
                ? System.Drawing.Color.FromArgb(26, 124, 62)
                : System.Drawing.Color.FromArgb(37, 99, 235);

            switch (user.Role)
            {
                case UserRole.Admin:
                    lblPatValue.Text = "View & Edit";
                    lblAppValue.Text = "View & Edit";
                    lblRepValue.Text = "Full Access + Add Staff";
                    break;

                case UserRole.Doctor:
                    lblPatValue.Text = "View only";
                    lblAppValue.Text = "View only";
                    lblRepValue.Text = "View only";
                    break;

                case UserRole.Receptionist:
                    lblPatValue.Text = "View & Edit";
                    lblAppValue.Text = "View & Edit";
                    lblRepValue.Text = "View & Edit";
                    break;
            }
        }
    }
}
