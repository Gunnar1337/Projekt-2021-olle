using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql;
using MySql.Data.MySqlClient;


namespace projekt_2021_Olle
{
    public partial class MainWindow : Form
    {
        public string connection = "SERVER=localhost;DATABASE=bio;UID=Admin;PASSWORD=admin";
        public List<int> popularitet = new List<int>();
        public List<int> ID = new List<int>();
        public List<string> NYPoster = new List<string>();
        public List<string> Poster = new List<string>();
        public List<PictureBox> picboxpop = new List<PictureBox>();
        public List<PictureBox> picboxny = new List<PictureBox>();

        public MainWindow()
        {
            InitializeComponent();

            picboxpop.Add(PicBox_Pfilm1);
            picboxpop.Add(PicBox_Pfilm2);
            picboxpop.Add(PicBox_Pfilm3);
            picboxpop.Add(PicBox_Pfilm4);
            picboxpop.Add(PicBox_Pfilm5);
            picboxpop.Add(PicBox_Pfilm6);

            picboxny.Add(PicBox_Nfilm1);
            picboxny.Add(PicBox_Nfilm2);
            picboxny.Add(PicBox_Nfilm3);
            picboxny.Add(PicBox_Nfilm4);
            picboxny.Add(PicBox_Nfilm5);
            picboxny.Add(PicBox_Nfilm6);



            loadpop();
            pop();

            loadid();
            nyastefilm();


        }


        private void btn_Köpa_Click(object sender, EventArgs e)
        {
            Köp Fönster = new Köp();
            Fönster.Show();


        }

        private void btn_Filmer_Click(object sender, EventArgs e)
        {
            Filmer Fönster = new Filmer();
            Fönster.Show();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Login Fönster = new Login();
            Fönster.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pop ()
        {
            int i = 0;
            while(i < 6)
            {
                picboxpop[i].LoadAsync(Poster[i]);

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

           

           while (reader.Read())
            {
               

                string tempPO = reader.GetString("Poster");
                Poster.Add(tempPO);
            }


            conn1.Close();

        }

        private void loadid()
        {
            MySqlConnection conn2 = new MySqlConnection(connection);
            conn2.Open();

            MySqlCommand comm = conn2.CreateCommand();
            comm.CommandText = $"select ID, Namn, Popularitet, Poster from Filmer where ID > 0 order by ID Asc";

            MySqlDataReader reader2 = comm.ExecuteReader();
;

          while (reader2.Read())
            {


                string tempfilm = reader2.GetString("Poster");
                NYPoster.Add(tempfilm);
            }

            
        }

        private void nyastefilm()
        {

            int i = 0;
            while (i < 6)
            {
                picboxny[i].LoadAsync(NYPoster[i]);


                i++;
            }


        }

    }
}
