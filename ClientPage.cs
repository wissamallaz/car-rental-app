﻿using System;
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
    public partial class ClientPage : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public ClientPage()
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

        private void ClientPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_client(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Client VALUES (@CName, @SSN, @Age, @Phone, @Adress, @Email)";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@SSN", int.Parse(txt_ssn.Text));
                com.Parameters.AddWithValue("@CName", txt_name.Text);
                com.Parameters.AddWithValue("@Age", int.Parse(txt_age.Text));
                com.Parameters.AddWithValue("@Adress", txt_address);
                com.Parameters.AddWithValue("@Phone", int.Parse(txt_phone.Text));
                com.Parameters.AddWithValue("@Email", txt_email.Text);




                if (con.State != ConnectionState.Open)
                    con.Open();
                com.ExecuteNonQuery();

                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show("Client added successfully!");


            }
            catch (Exception Msg)
            {
                MessageBox.Show(Msg.Message);
            }
        }

        private void txt_ssn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
