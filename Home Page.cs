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
    public partial class HomePage : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form_home_Load(object sender, EventArgs e)
        {

        }
 
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeePage load = new EmployeePage();
            load.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            ClientPage load = new ClientPage();
            load.Show();
            Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarPage load = new CarPage();
            load.Show();
            Hide();
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
    }
}
