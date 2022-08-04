using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAdmin.AdminControls;

namespace WarehouseAdmin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Admin_Categories cat = new Admin_Categories();
            addUserControl(cat);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
 
        private void categories_Click(object sender, EventArgs e)
        {
            Admin_Categories cat = new Admin_Categories();
            addUserControl(cat);
        }

        private void products_Click(object sender, EventArgs e)
        {
            Admin_Products prod = new Admin_Products();
            addUserControl(prod);
        }

        private void suppliers_Click(object sender, EventArgs e)
        {
            Admin_Suppliers sup = new Admin_Suppliers();
            addUserControl(sup);
        }
    }
}
