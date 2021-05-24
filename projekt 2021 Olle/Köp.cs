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
   

    public partial class Köp : Form
    { 
    public string connection = "SERVER=localhost;DATABASE=bio;UID=Admin;PASSWORD=admin";
    public List<int> ID = new List<int>();
    public List<string> NYPoster = new List<string>();
    public List<string> Poster = new List<string>();
    public List<PictureBox> picboxpop = new List<PictureBox>();
        public Köp()
        {
            InitializeComponent();
            picboxpop.Add(PicBox_Pfilm1);
            picboxpop.Add(PicBox_Pfilm2);
            picboxpop.Add(PicBox_Pfilm3);
            picboxpop.Add(PicBox_Pfilm4);
            picboxpop.Add(PicBox_Pfilm5);


            loadpop();
            pop();
        }

        private void Köp_Load(object sender, EventArgs e)
        {

        }
        private void pop()
        {
            int i = 0;
            while (i < 5)
            {
                picboxpop[i].Load(Poster[0]);

                i++;
            }


        }
        private void loadpop()
        {

            MySqlConnection conn1 = new MySqlConnection(connection);
            conn1.Open();

            MySqlCommand comm = conn1.CreateCommand();
            comm.CommandText = $"select ID, Namn, Popularitet, Poster from Filmer where ID > 0 order by Popularitet desc";

            MySqlDataReader reader = comm.ExecuteReader();

            reader.Read();

            if (reader.IsDBNull(0) != true)
            {


                string tempPO = reader.GetString("Poster");
                Poster.Add(tempPO);
            }


            conn1.Close();

        }

        private void Btn_VäljFilm_Click(object sender, EventArgs e)
        {
            Filmer Fönster = new Filmer();
            Fönster.Show();
        }
    }
}
