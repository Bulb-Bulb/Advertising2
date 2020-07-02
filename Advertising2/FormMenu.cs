using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advertising2
{
    public partial class FormMenu : Form
    {
        private FormAuthorization authorization;
        public FormMenu(FormAuthorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
            if (FormAuthorization.users.type == "employee")
            {
                buttonOpenOrg.Enabled = false;
            }
        }
        private void buttonOpenOrg_Click(object sender, EventArgs e)
        {
            Form formOrganization = new FormOrganizations();
            formOrganizations.Show();
        }
        private void buttonOpenNP_Click(object sender, EventArgs e)
        {
            Form formNewspapers = new FormNewspapers();
            formNewspapers.Show();
        }
        private void buttonOpenAdv_Click(object sender, EventArgs e)
        {
            Form formAdvertising = new FormAdvertising();
            formAdvertising.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
