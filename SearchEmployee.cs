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
    public partial class SearchEmployee : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeePage load = new EmployeePage();
            load.Show();
            Hide();
        }

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = EmployeeList.Text;
            string[] strlist = s.Split('-');
            txt_s_id.Text = strlist[0];
            txt_s_name.Text = strlist[1];
            txt_s_age.Text = strlist[2];
            txt_s_address.Text = strlist[3];
            txt_s_phone.Text = strlist[4];
            txt_s_email.Text = strlist[5];
        }

        private void txt_s_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * FROM Employee WHERE Employee_ID like '%" + txt_s_id.Text + "%'";
                DataTable td = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(td);
                string s;

                EmployeeList.Items.Clear();

                foreach (DataRow row in td.Rows)
                {
                    s = row["Employee_ID"].ToString() + "-" + row["Name"] + "-" + row["Age"] + "-" + row["Adress"] + "-" + row["Mobile_Number"] + row["Email"].ToString() ;
                    EmployeeList.Items.Add(s);

                }


            }
            catch (Exception Msj)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

       
    }
    }

