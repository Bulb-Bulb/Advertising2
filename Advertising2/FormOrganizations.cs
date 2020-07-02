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
    public partial class FormOrganizations : Form
    {
        public FormOrganizations()
        {
            InitializeComponent();
        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormOrganizations_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OrganizationsSet organizationsSet = new OrganizationsSet();
            organizationsSet.Name = textBoxName.Text;
            organizationsSet.Address = textBoxAddress.Text;
            organizationsSet.Phone = textBoxPhone.Text;
            Program.advDb
        }
    }
}
