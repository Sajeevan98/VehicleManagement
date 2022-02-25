using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VehicleManagement
{
    public partial class UpdateDetails : Form
    {
        string selected;
        MySqlConnection connectUpdate;
        public UpdateDetails(string selectedItem)
        {
            selected = selectedItem;
            InitializeComponent();
        }

        private void buttonUpdateCancel_Click(object sender, EventArgs e) // cancel of Update
        {
            formMain main = new formMain();
            if (main == null)
            {
                main.Parent = this;
            }
            main.Show();
            this.Hide();
        }

        private void buttonVehicleImage_Click_1(object sender, EventArgs e)
        {
             OpenFileDialog dialog = new OpenFileDialog();
             dialog.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.png; *.gif";
             if (dialog.ShowDialog() == DialogResult.OK)
             {
                pictureBoxVehicleImageUpdate.Image = Image.FromFile(dialog.FileName);

                
            }
        }

        public void UpdateDetails_Load(object sender, EventArgs e) // database connection of update...
        {
            connectUpdate = new MySqlConnection("server=localhost;user id=root;database=gain_tours_and_travels;password=;");
            MySqlCommand cmd = new MySqlCommand("select * from db_vehicle where Veh_number='" + selected+"'", connectUpdate);
            cmd.Connection.Open();
            MySqlDataReader queryReader = cmd.ExecuteReader();
            queryReader.Read();
            textBoxUpdateVehicleNumber.Text = queryReader.GetString(1);
            textBoxUpdateVehicleType.Text = queryReader.GetString(2);
            textBoxUpdateVehicleCompany.Text = queryReader.GetString(3);
            textBoxUpdateVehicleColour.Text = queryReader.GetString(4);
            connectUpdate.Close();

        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
           
           string updateQuery = "update db_vehicle set Veh_number='" + textBoxUpdateVehicleNumber.Text + "', Veh_type='" + textBoxUpdateVehicleType.Text + "', Veh_company='" + textBoxUpdateVehicleCompany.Text + "', Veh_colour='" + textBoxUpdateVehicleColour.Text + "' where Veh_number='"+selected+"'";
           MySqlCommand Command = new MySqlCommand(updateQuery, connectUpdate);
           
          Command.Connection.Open();
            if (MessageBox.Show("Are you sure you want to Update the vehicle details? ", "Update Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Data Updated Sucessfull...");
            }
            else
            {
                MessageBox.Show(" your item is not Updated!!! ");
            }
          connectUpdate.Close();

        }

        private void pictureBoxVehicleImageUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
