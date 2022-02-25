using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VehicleManagement
{
    public partial class AddDetails : Form
    {
        public AddDetails()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) // Vehicle Details Add in the Database...
        {
              MySqlConnection connection = new MySqlConnection("datasource=localhost; user id=root; database=gain_tours_and_travels; password=;");


                string insertQuery= "insert into db_vehicle(Veh_number, Veh_type, Veh_company, Veh_colour) values('" + textBoxVehicleNumber.Text+ "','" + textBoxVehicleType.Text + "','" + textBoxVehicleCompany.Text + "','" + textBoxVehicleColour.Text + "')";
                MySqlCommand Command = new MySqlCommand(insertQuery, connection);
                Command.Connection.Open();
                if (MessageBox.Show("Are you sure you want to Add the vehicle details? ", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Command.ExecuteNonQuery();
                    MessageBox.Show(" your data added successful... ");
                }
                else
                {               
                    MessageBox.Show(" your item is not added!!! ");
                }

                Command.Connection.Close();          
                   
        }

        private void buttonVehicleImage_Click(object sender, EventArgs e) // Select Image
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxVehicleImageAdd.Image = Image.FromFile(dialog.FileName);

               // imgLocation = dialog.FileName.ToString();
               // pictureBoxVehicleImage.ImageLocation = imgLocation;
            }

        }

        private void button1_Click_1(object sender, EventArgs e) // cancel of Add
        {
            formMain main = new formMain();
            if (main == null)
            {
                main.Parent = this;
            }
            main.Show();
            this.Hide();

        }

        private void AddDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxVehicleNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
