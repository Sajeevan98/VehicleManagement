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
    public partial class DeleteDetails : Form
    {
        string forDelete;        
        MySqlConnection connectDel;

        public DeleteDetails(string selectedItem)
        {
            forDelete = selectedItem;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // cancel of delete
        {
            formMain main = new formMain();
            if (main == null)
            {
                main.Parent = this;
            }
            main.Show();
            this.Hide();
        }

        private void buttonDetete_Click(object sender, EventArgs e)
        {

        }
        public void selectVehicle()
        {

        }
        private void DeleteDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void Delete_Load( )
        {
            connectDel = new MySqlConnection("server=localhost;user id=root;database=gain_tours_and_travels;password=;");
            MySqlCommand cmd = new MySqlCommand("select * from db_vehicle where Veh_number='" + forDelete + "'", connectDel);
            cmd.Connection.Open();
            MySqlDataReader queryReader = cmd.ExecuteReader();
            queryReader.Read();
            textBoxDeleteVehicleNumber.Text = queryReader.GetString(1);
            textBoxDeleteVehicleType.Text = queryReader.GetString(2);
            textBoxDeleteCompanyVehicleCompany.Text = queryReader.GetString(3);
            textBoxDeleteVehicleColour.Text = queryReader.GetString(4);

         
           
            connectDel.Close();
        }


        private void buttonUpdate_Click(object sender, EventArgs e) //delete Button.....
        {
            Delete_Load();

            string updateQuery = "update db_vehicle set Veh_number='" + textBoxDeleteVehicleNumber.Text + "', Veh_type='" + textBoxDeleteVehicleType.Text + "', Veh_company='" + textBoxDeleteCompanyVehicleCompany.Text + "', Veh_colour='" + textBoxDeleteVehicleColour.Text + "' where Veh_number='" + forDelete + "'";
            MySqlCommand noCom = new MySqlCommand(updateQuery, connectDel);

            string deleteQuery = "delete from db_vehicle where Veh_number= '" + textBoxDeleteVehicleNumber.Text + "'";
            MySqlCommand Command = new MySqlCommand(deleteQuery, connectDel);

            Command.Connection.Open();
            if (MessageBox.Show("Are you sure you want to delete the vehicle details? ","Deleted Item",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfull...");
            }
            else
            {
                MessageBox.Show(" your item is not deleted!!! ");
            }
            connectDel.Close();
            
        }

       
        private void buttonDeleteCancel_Click(object sender, EventArgs e)
            {
                formMain main = new formMain();
                if (main == null)
                {
                    main.Parent = this;
                }
                main.Show();
                this.Hide();
            }

        private void buttonVehicleImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxVehicleImageUpdate.Image = Image.FromFile(dialog.FileName);


            }
        }
    }
}
