using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace projekt_2021_Olle
{
    public partial class Filmer : Form
    {

        public string connection = "SERVER=localhost;DATABASE=bio;UID=Admin;PASSWORD=admin";
        public string NyRad = Environment.NewLine;
        public Filmer()
        {
            InitializeComponent();
            
            loadfromdd();

        }

        private void Filmer_Load(object sender, EventArgs e)
        {

        }

        private void lstbox_filmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            





            
            
        }

        private void loadfromdd()
        {
            lstbox_filmer.Items.Clear();


            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();

            string sqlsats = "select Namn from filmer";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            lstbox_filmer.Items.Clear();
            while (dataReader.Read())
            {
                lstbox_filmer.Items.Add(dataReader.GetString("Namn"));

            }

            conn.Close();
        }
    }
}
