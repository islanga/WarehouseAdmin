using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using WarehouseAdmin.Models;

namespace WarehouseAdmin.AdminControls
{
    public partial class Admin_Categories : UserControl
    {
        HttpClient client = new HttpClient();

        public Admin_Categories()
        {
            InitializeComponent();
        }

        private async void btninsert_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories()
            {
                CategoryName = txtcategoryname.Text,
                Description = txtdescription.Text
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7037/api/Category", cat);

            MessageBox.Show("Category was created successfully");

            displaydata();
        }

        private void Admin_Categories_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            client.BaseAddress = new Uri("https://localhost:7037/");
            HttpResponseMessage response = client.GetAsync("api/Category").Result;
            if (response.IsSuccessStatusCode)
            {
                var categories = response.Content.ReadAsAsync<IEnumerable<Categories>>().Result;
                resultGrid.DataSource = categories;
            }
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
            StringContent content = new StringContent("CategoryID=1&CategoryName=" + txtcategoryname.Text + "&Description=" + txtdescription.Text);

            await client.PostAsync("https://localhost:7037/api/Category", content);

            MessageBox.Show("Category was successfully updated");

            displaydata();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("CategoryID=1");

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
