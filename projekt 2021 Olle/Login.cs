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
    public partial class Login : Form
    {

        public string connection = "SERVER=localhost;DATABASE=Login;UID=Admin;PASSWORD=admin";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {



        }

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            string användarnamn = Txtbx_Username.Text.ToString();
            
            MySqlConnection conn1 = new MySqlConnection(connection);
            conn1.Open();

            bool loginsucces = false;

            MySqlCommand comm = conn1.CreateCommand();
            comm.CommandText = $"select (@namn) from användare  ";
            comm.Parameters.AddWithValue("@namn", $"{användarnamn}");
         
            MySqlDataReader dataReader = comm.ExecuteReader();


            if (dataReader.HasRows)
            {
                string lössenord = Txtbx_Password.Text.ToString();
                
                MySqlConnection conn2 = new MySqlConnection(connection);
                conn2.Open();



                MySqlCommand comm2 = conn2.CreateCommand();
                comm.CommandText = $"select (@lössen) from användare  ";
                comm.Parameters.AddWithValue("@lössen", $"{lössenord}");

                MySqlDataReader dataReader2 = comm2.ExecuteReader();
             
                if (dataReader2.HasRows)
                {

                    MessageBox.Show("login succes");

                    Lägg_Till_Filmer fönster = new Lägg_Till_Filmer();

                        fönster.Show();

                    Environment.Exit(0);

                }


            }
            else
            {
                MessageBox.Show("wrong username");
            }




        }
    }
}
