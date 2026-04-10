using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Guna.UI2.WinForms;

namespace HospitalManagmentSys.Presentation.UserControls
{
    public partial class PatientTableHeader : UserControl
    {
        private readonly Dictionary<string, int> columns = new Dictionary<string, int>
        {
            { "PATIENT",         62  },
            { "CONTACT",        280  },
            { "BLOOD TYPE",     530  },
            { "APPOINTMENTS",   640  },
            { "NO-SHOW STATUS", 750  },
        };

        public PatientTableHeader()
        {
            InitializeComponent();
            BuildHeader();
        }

        private void BuildHeader()
        {
            Height = 36;
            Dock = DockStyle.Top;
            BackColor = Color.FromArgb(249, 250, 251);

            foreach (var col in columns)
            {
                Controls.Add(CreateHeaderLabel(col.Key, col.Value));
            }
        }

        
        private Guna2HtmlLabel CreateHeaderLabel(string text, int x)
        {
            return new Guna2HtmlLabel
            {
                Text = text,
                Font = new Font("Segoe UI", 8f, FontStyle.Bold),
                ForeColor = Color.FromArgb(107, 114, 128),
                AutoSize = true,
                Location = new Point(x, 10)
            };
        }
    }
}