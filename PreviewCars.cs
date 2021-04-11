using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_Application
{
    public partial class PreviewCars : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public PreviewCars()
        {
            InitializeComponent();
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarPage load = new CarPage();
            load.Show();
            Hide();
        }

       

       
        private void Btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_prev_cars_Click(object sender, EventArgs e)
        {
            string query = "Select * from Car";
            DataTable td = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(td);
            dataGridView1.DataSource = td;
        }
    }
    }

