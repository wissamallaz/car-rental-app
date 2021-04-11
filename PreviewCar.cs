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
    public partial class PreviewCar : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public PreviewCar()
        {
            InitializeComponent();
        }

        



        private void btn_back_car_Click(object sender, EventArgs e)
        {
            CarPage load = new CarPage();
            load.Show();
            Hide();
        }

        private void txt_search_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_show_cars_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * from Car";
                DataTable td = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(td);
                dataGridView1.DataSource = td;

            }
           
        }
    }
    }

