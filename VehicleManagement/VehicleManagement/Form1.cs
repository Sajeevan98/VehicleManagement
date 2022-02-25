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
    public partial class formMain : Form
    {
        MySqlConnection connectObj;
        public formMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDetails add = new AddDetails();
            if(add == null)
            {
                add.Parent = this;
            }
            add.Show();
            this.Hide();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDetails update = new UpdateDetails(comboBoxUpdateChoose.SelectedItem.ToString());
            if (update == null)
            {
                update.Parent = this;
            }
            update.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteDetails delete = new DeleteDetails(comboBoxDeleteChoose.SelectedItem.ToString());
            if (delete == null)
            {
                delete.Parent = this;
            }
            delete.Show();
            this.Hide();

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            loadVehicles();
        }
        private void loadVehicles() // Database Conection & get Details in combobox for Update and delete...
        {
            connectObj = new MySqlConnection("server=localhost;user id=root;database=gain_tours_and_travels;password=");
            MySqlCommand cmd = new MySqlCommand("select * from db_vehicle where 1", connectObj);
            cmd.Connection.Open();
            MySqlDataReader queryReader = cmd.ExecuteReader();
            while(queryReader.Read())
            {
                comboBoxUpdateChoose.Items.Add(queryReader.GetString(1));
                comboBoxDeleteChoose.Items.Add(queryReader.GetString(1));
            }
           
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDeleteChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
