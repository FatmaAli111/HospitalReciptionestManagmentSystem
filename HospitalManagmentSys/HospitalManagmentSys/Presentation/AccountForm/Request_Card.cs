using Azure.Core;
using HospitalManagmentSys.BiussnessLogic;
using HospitalManagmentSys.Data;
using HospitalManagmentSys.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HospitalManagmentSys.Presentation
{
    public partial class Request_Card : UserControl

    {
        public event Action CardDeleted;
        public Request_Card()
        {
            InitializeComponent();

        }
        private UserRequest _request;
        public Request_Card(Data.Models.UserRequest req)
        {
            InitializeComponent();
            _request = req;

            LoadData();
        }


        private void LoadData()
        {
            if (_request.Role == UserRole.Doctor)
            {
                Doctor_View.Visible = true;
                Phone_textBox2.Text = _request.Phone;
                Specialit_textBox.Text = _request.Speciality;
            }
            else
            {
                Doctor_View.Visible = false;
            }
            Full_Name_textBox.Text = _request.Name;
            email_textBox1.Text = _request.Email;
            Password_textBox2.Text = _request.PasswordHash;


        }
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as FlowLayoutPanel;
            Exit_Btn.Cursor = Cursors.Hand;


            if (parent != null)
            {
                parent.Controls.Remove(this);
                this.Dispose();
                CardDeleted?.Invoke();



            }
        }
        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var newUser = new User
                        {
                            Name = _request.Name,
                            Email = _request.Email,
                            PasswordHash = _request.PasswordHash,
                            Phone = _request.Phone,
                            Role = _request.Role,
                            Speciality = _request.Speciality // if the role is doctor
                        };
                        db.Users.Add(newUser);

                        // ده الكود اللي هيظهرلك الأسماء في رسالة بدل الـ Output
                        var allUsers = db.Users.ToList();
                        string usersList = "Current Users in DB:\n";
                        foreach (var u in allUsers)
                        {
                            usersList += $"- {u.Name} ({u.Email})\n";
                        }
                        MessageBox.Show(usersList, "Database Check");

                        // 3. Delete the requset of UserRequest after approved the operation
                        var requestInDb = db.UserRequests.Find(_request.ID);
                        if (requestInDb != null)
                        {
                            db.UserRequests.Remove(requestInDb);
                        }
                        db.SaveChanges();

                        // confirming operation of adding user
                        transaction.Commit();

                        // update btn view
                        DenyBtn.Enabled = false;
                        ApproveBtn.Enabled = false;
                        ApproveBtn.Text = "Approved";

                        MessageBox.Show("User Approved and Registered Successfully!");
                    }
                    catch (Exception ex)
                    {
                        // apply (Rollback) if it has any error
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void Exit_Btn_MouseEnter(object sender, EventArgs e)
        {
            Exit_Btn.BackColor = Color.Red;
        }

        private void Exit_Btn_MouseLeave(object sender, EventArgs e)
        {
            Exit_Btn.BackColor = Color.Transparent;
        }

        private void DenyBtn_Click(object sender, EventArgs e)
        {
            var service = new UserRequestService();
            service.DenyRequest(_request.ID);  

    
            var parent = this.Parent;
            parent.Controls.Remove(this);
            this.Dispose();

            CardDeleted?.Invoke();
        }
        private void Password_Click(object sender, EventArgs e)
        {

        }
    }
}
