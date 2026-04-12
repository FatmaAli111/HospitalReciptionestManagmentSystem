using HospitalManagmentSys.BiussnessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSys.Presentation
{
    public partial class AdminPanel : Form
    {
        private readonly UserRequestService _requestService;

        public AdminPanel()
        {
            InitializeComponent();
            _requestService = new UserRequestService();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LoadRequests()
        {
            var requests = _requestService.GetAllRequests();
            requestsPanel.Controls.Clear();

            foreach (var req in requests)
            {
                var card = new Request_Card(req);
                card.CardDeleted += OnCardDeleted;

                requestsPanel.Controls.Add(card);
            }
            if (requests.Count == 0)
            {
                No_Pending_Requests_label.Visible = true;
            }
            else
            {
                No_Pending_Requests_label.Visible = false;
            }
        }

        public void No_Pending_Requests_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void requestsPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void OnCardDeleted()
        {
            if (requestsPanel.Controls.Count == 0)
                No_Pending_Requests_label.Visible = true;
        }
    }
}
