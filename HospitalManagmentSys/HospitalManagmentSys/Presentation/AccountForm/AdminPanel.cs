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
                requestsPanel.Controls.Add(card);
            }
        }
    }
}
