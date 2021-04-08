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
    public partial class SearchCar : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public SearchCar()
        {
            InitializeComponent();
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {

        }

        

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = CarList.Text;
            string[] strlist = s.Split('-');
            txt_search_brand.Text = strlist[0];
            txt_search_color.Text = strlist[1];
            
        }

        private void txt_s_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * FROM Car WHERE Brand like '%" + txt_search_brand.Text + "%'";
                DataTable td = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(td);
                string s;

                CarList.Items.Clear();

                foreach (DataRow row in td.Rows)
                {
                    s =  row["Brand"] + "-" + row["Color"] ;
                    CarList.Items.Add(s);

                }


            }
            catch (Exception Msj)
            {
                MessageBox.Show("Something went wrong!");
            }
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
    }
    }

