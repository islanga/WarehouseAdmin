using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
using System.Windows.Forms;
using WarehouseAdmin.Models;

namespace WarehouseAdmin.AdminControls
{
    public partial class Admin_Suppliers : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        HttpClient client = new HttpClient();

        public Admin_Suppliers()
        {
            InitializeComponent();
        }

        private void Admin_Suppliers_Load(object sender, EventArgs e)
        {

        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("SupplierID=" + txtSupplierId.Text.ToString());

            await client.PostAsync("https://localhost:7037/api/Supplier", content);

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

        private async void Update_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("SupplierID=" + txtSupplierId.Text
            + "CompanyName=" + txtcompanyname.Text
            + "&ContactName=" + txtcontactname.Text
            + "&ContactTitle=" + txtcontactitle.Text
            + "&Address=" + txtaddress.Text
            + "&City=" + txtcity.Text
            + "&Region=" + txtregion.Text
            + "&PostalCode=" + txtpostalcode.Text
            + "&Country=" + txtcountry.Text
            + "&Phone=" + txtphone.Text
            + "&Fax=" + txtfax.Text
            + "&HomePage=" + txthomepage.Text);

            await client.PostAsync("https://localhost:7037/api/Supplier", content);

            MessageBox.Show("Supplier was successfully updated");

            displaydata();
        }

        private void cleardata()
        {
            txtcompanyname.Clear();
            txtcontactname.Clear();
            txtcontactitle.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtregion.Clear();
            txtpostalcode.Clear();
            txtcountry.Clear();
            txtphone.Clear();
            txtfax.Clear();
            txthomepage.Clear();
        }

        private async void displaydata()
        {
            client.BaseAddress = new Uri("https://localhost:7037/");
            HttpResponseMessage response = client.GetAsync("api/Supplier").Result;
            string data = await response.Content.ReadAsStringAsync();
            JavaScriptSerializer JSserializer = new JavaScriptSerializer();
            var categories = JSserializer.Deserialize<List<Suppliers>>(data);
            resultGrid.DataSource = categories;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

        }

        private async void btninsert_Click_1(object sender, EventArgs e)
        {
            StringContent content = new StringContent("CompanyName=" + txtcompanyname.Text
            + "&ContactName=" + txtcontactname.Text
            + "&ContactTitle=" + txtcontactitle.Text
            + "&Address=" + txtaddress.Text
            + "&City=" + txtcity.Text
            + "&Region=" + txtregion.Text
            + "&PostalCode=" + txtpostalcode.Text
            + "&Country=" + txtcountry.Text
            + "&Phone=" + txtphone.Text
            + "&Fax=" + txtfax.Text
            + "&HomePage=" + txthomepage.Text);

            await client.PostAsync("https://localhost:7037/api/Supplier", content);

            MessageBox.Show("Supplier was created successfully");

            displaydata();
        }
    }
}
