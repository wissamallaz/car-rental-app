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
    public partial class SearchClient : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public SearchClient()
        {
            InitializeComponent();
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientPage load = new ClientPage();
            load.Show();
            Hide();
        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = ClientList.Text;
            string[] strlist = s.Split('-');
            txt_s_ssn.Text = strlist[0];
            txt_s_cname.Text = strlist[1];
            txt_s_age.Text = strlist[2];
            txt_s_address.Text = strlist[3];
            txt_s_phone.Text = strlist[4];
            txt_s_email.Text = strlist[5];
        }

        private void txt_s_ssn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * FROM Client WHERE SSN like '%" + txt_s_ssn.Text + "%'";
                DataTable td = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(td);
                string s;

                ClientList.Items.Clear();

                foreach (DataRow row in td.Rows)
                {
                    s = row["SSN"].ToString() + "-" + row["CName"] + "-" + row["Age"] + "-" + row["Adress"] + "-" + row["Phone"] + "-" + row["Email"].ToString() ;
                    ClientList.Items.Add(s);

                }


            }
            catch (Exception Msj)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {

        }
    }
    }

