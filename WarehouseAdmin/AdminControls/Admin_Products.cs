using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAdmin.Models;
using Nancy.Json;
using System.Data.SqlClient;
using System.Net.Http;

namespace WarehouseAdmin.AdminControls
{
    public partial class Admin_Products : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        HttpClient client = new HttpClient();

        public Admin_Products()
        {
            InitializeComponent();
        }

        private async void btninsert_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("ProductName=" + txtproductname.Text 
                + "&SupplierID=" + txtsupplierid.Text
                + "&CategoryID=" + txtcategoryid.Text
                + "&QuantityPerUnit=" + txtqtyperunit.Text
                + "&UnitPrice=" + txtunitprice.Text
                + "&UnitsInStock=" + txtunitsinstock.Text
                + "&UnitsOnOrder=" + txtunitsonorder.Text
                + "&ReorderLevel=" + txtreorderlevel.Text
                + "&Discontinued=" + txtdiscontinued.Text);

            await client.PostAsync("https://localhost:7037/api/Product", content);

            MessageBox.Show("Category was created successfully");

            displaydata();
        }

        private async void displaydata()
        {
            client.BaseAddress = new Uri("https://localhost:7037/");
            HttpResponseMessage response = client.GetAsync("api/Product").Result;
            string data = await response.Content.ReadAsStringAsync();
            JavaScriptSerializer JSserializer = new JavaScriptSerializer();
            var categories = JSserializer.Deserialize<List<Products>>(data);
            resultGrid.DataSource = categories;
        }

        private void cleardata()
        {
            txtproductname.Clear();
            txtqtyperunit.Clear();
            txtunitprice.Clear();
            txtunitsinstock.Clear();
            txtunitsonorder.Clear();
            txtreorderlevel.Clear();
            txtdiscontinued.Clear();
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("ProductID=" + txtproductid.Text
                + "ProductName=" + txtproductname.Text
                + "&SupplierID=" + txtsupplierid.Text
                + "&CategoryID=" + txtcategoryid.Text
                + "&QuantityPerUnit=" + txtqtyperunit.Text
                + "&UnitPrice=" + txtunitprice.Text
                + "&UnitsInStock=" + txtunitsinstock.Text
                + "&UnitsOnOrder=" + txtunitsonorder.Text
                + "&ReorderLevel=" + txtreorderlevel.Text
                + "&Discontinued=" + txtdiscontinued.Text);

            await client.PostAsync("https://localhost:7037/api/Product", content);

            MessageBox.Show("Product was successfully updated");

            displaydata();
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            StringContent content = new StringContent("ProductID=" + txtproductid.Text.ToString());

            await client.PostAsync("https://localhost:7037/api/Product", content);

            MessageBox.Show("Product was successfully deleted");

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

        private void Admin_Products_Load(object sender, EventArgs e)
        {

        }
    }
}
