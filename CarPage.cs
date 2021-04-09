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
using System.Configuration;
using System.IO;

namespace Car_Rental_Application
{
    public partial class CarPage : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ToString());
        public CarPage()
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
        public void Insert(byte[] image)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentalDbConString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();

                using (SqlCommand com = new SqlCommand("INSERT INTO Car VALUES (@Plate, @Branch, @Brand, @Color, @Engine, @YearModel,@Rent_per_day, @Category, @Preview, @Insurance)", cn))
                {
                    com.Parameters.AddWithValue("@Plate", txt_plate.Text);
                    com.Parameters.AddWithValue("@Branch", Int32.Parse(txt_branch.Text));
                    com.Parameters.AddWithValue("@Brand", txt_brand.Text);
                    com.Parameters.AddWithValue("@Color", txt_color.Text);
                    com.Parameters.AddWithValue("@Engine", txt_engine.Text);
                    com.Parameters.AddWithValue("@YearModel", Int32.Parse(txt_yearmodel.Text));
                    com.Parameters.AddWithValue("@Rent_per_day", txt_rent_per_day.Text);
                    com.Parameters.AddWithValue("@Category", txt_category.Text);
                    com.Parameters.AddWithValue("@Preview", image);
                    com.Parameters.AddWithValue("@Insurance", checkBox2.Checked);
                    com.ExecuteNonQuery();
                }
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
            MessageBox.Show("Car added successfully!");
            }
            catch (Exception Msg)
            {
                MessageBox.Show(Msg.Message);
            }

        }
    

    public byte[] ConvertImageToBytes(Image img)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);  // You can change the image type from jpg to png or anything else from here
            return ms.ToArray();

        }
    }
    public Image ConvertByteArrayToImage(byte[] data)
    {
        using(MemoryStream ms=new MemoryStream(data))
        {
            return Image.FromStream(ms);
        }
    }

    private void btn_addcar_Click(object sender, EventArgs e)
    {
            using (OpenFileDialog ofd = new OpenFileDialog() )
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                    Insert(ConvertImageToBytes(pictureBox.Image));
                }
    }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_showcars_Click(object sender, EventArgs e)
        {
            string query = "Select * from Car";
            DataTable td = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(td);
            dataGridView1.DataSource = td;
        }

        private void btn_back_car_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientPage load = new ClientPage();
            load.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeePage load = new EmployeePage();
            load.Show();
            Hide();
        }

        private void txt_plate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_photo_Click(object sender, EventArgs e)
        {

        }

        private void btn_searchcars_Click(object sender, EventArgs e)
        {
            SearchCar load = new SearchCar();
            load.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
        
