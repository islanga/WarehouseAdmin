using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using WarehouseAdmin.Models;
using System.Collections.Generic;
using Nancy.Json;

namespace WarehouseAdmin.AdminControls
{
    public partial class Admin_Categories : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        HttpClient client = new HttpClient();

        public Admin_Categories()
        {
            InitializeComponent();
        }

        private async void btninsert_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("CategoryName="+txtcategoryname.Text+"&Description="+txtdescription.Text);

            await client.PostAsync("https://localhost:7037/api/Category", content);

            MessageBox.Show("Category was created successfully");

            displaydata();
        }

        private void Admin_Categories_Load(object sender, EventArgs e)
        {
        }

        private async void displaydata()
        {
            client.BaseAddress = new Uri("https://localhost:7037/");
            HttpResponseMessage response = client.GetAsync("api/Category").Result;
            string data = await response.Content.ReadAsStringAsync();
            JavaScriptSerializer JSserializer = new JavaScriptSerializer();
            var categories = JSserializer.Deserialize<List<Categories>>(data);
            resultGrid.DataSource = categories;
        }

        private void cleardata()
        {
            txtcategoryname.Clear();
            txtdescription.Clear();
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Update_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("CategoryID=" + txtCategoryId.Text.ToString() + "&CategoryName=" + txtcategoryname.Text + "&Description=" + txtdescription.Text);

            await client.PostAsync("https://localhost:7037/api/Category", content);

            MessageBox.Show("Category was successfully updated");

            displaydata();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("CategoryID=" + txtCategoryId.Text.ToString());

            await client.PostAsync("https://localhost:7037/api/Category", content);

            MessageBox.Show("Category was successfully deleted");

            displaydata();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
