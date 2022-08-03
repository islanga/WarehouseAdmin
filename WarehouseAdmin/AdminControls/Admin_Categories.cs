using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WarehouseAdmin.AdminControls
{
    public partial class Admin_Categories : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Admin_Categories()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query = $"insert into Categories values('{txtcategoryname.Text.ToString()}','{txtdescription.Text}','{txtpicture.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }

        private void Admin_Categories_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=.;Initial Catalog=Warehouse;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Categories";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            resultGrid.DataSource = dt;
            conn.Close();
        }

        private void cleardata()
        {
            txtcategoryname.Clear();
            txtdescription.Clear();
            txtpicture.Clear();
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
