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
    public partial class EmployeePage : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public EmployeePage()
        {
            InitializeComponent();
        }


        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;

            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage load = new HomePage();
            load.Show();
            Hide();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_addemployee_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Employee VALUES (@Employee_ID, @Name, @Age, @Adress, @Mobile_Number, @Email)";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@Employee_ID", Int32.Parse(txt_id.Text));
                com.Parameters.AddWithValue("@Name", txt_name.Text);
                com.Parameters.AddWithValue("@Age", Int32.Parse(txt_age.Text));
                com.Parameters.AddWithValue("@Adress", txt_address.Text);
                com.Parameters.AddWithValue("@Mobile_Number", Int32.Parse(txt_phone.Text));
                com.Parameters.AddWithValue("@Email", txt_email.Text);




                if (con.State != ConnectionState.Open)
                    con.Open();
                com.ExecuteNonQuery();

                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show("Employee added successfully!");


            }
            catch (Exception Msg)
            {
                MessageBox.Show(Msg.Message);
            }
        }

        private void txt_ssn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_showemployees_Click(object sender, EventArgs e)
        {
            string query = "Select * from Employee";
            DataTable td = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(td);
            dataGridView1.DataSource = td;
        }

        private void btn_searchemployees_Click(object sender, EventArgs e)
        {
            SearchEmployee load = new SearchEmployee();
            load.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientPage load = new ClientPage();
            load.Show();
            Hide();
        }
    }
}
        
