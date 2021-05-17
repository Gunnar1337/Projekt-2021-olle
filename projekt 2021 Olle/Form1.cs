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
        
       
        public MainWindow()
        {
            InitializeComponent();

            MySqlConnection conn1 = new MySqlConnection(connection);
            conn1.Open();

            MySqlCommand comm = conn1.CreateCommand();
            comm.CommandText = $"select ID, Namn, Popularitet, Poster from Filmer where ID > 0 order by Popularitet desc";







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

        private void rank ()
        {



        }

    }
}
