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
    public partial class Lägg_Till_Filmer : Form
    {
        public string connection = "SERVER=localhost;DATABASE=bio;UID=Admin;PASSWORD=admin";
        public Lägg_Till_Filmer()
        {
            InitializeComponent();
        }

        private void Lägg_Till_Filmer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            Txtb_Poster.Text = openFileDialog.FileName.ToString();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Btn_SaveFilm_Click(object sender, EventArgs e)
        {
            string Namn = Txtb_Namn.Text;
            string gener = Txtb_Genrer.Text;
            string popularitet = Txtb_pop.Text;
            string sal = Txtb_Sal.Text;
            string poster = Txtb_Poster.Text;


            MySqlConnection conn1 = new MySqlConnection(connection);
            conn1.Open();

            MySqlCommand comm = conn1.CreateCommand();
            comm.CommandText = $"insert into filmer ('Namn', 'Genrer','Sal','Popularitet' ) values ((@namn), (@genre),(@sal),(@pipularitet)) ";
            comm.Parameters.AddWithValue("@namn",$"{Namn}" );
            comm.Parameters.AddWithValue("@genre", $"{gener}");
            comm.Parameters.AddWithValue("@sal", $"{sal}");
            comm.Parameters.AddWithValue("@popularitet", $"{popularitet}");

            comm.ExecuteNonQuery();




        }
    }
}
