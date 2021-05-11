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
using System.Security.Cryptography;

namespace projekt_2021_Olle
{
    public partial class Login : Form
    {
        public string connection = "SERVER=localhost;DATABASE=bio;UID=Admin;PASSWORD=admin";


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

       

            MySqlCommand comm = conn1.CreateCommand();
            comm.CommandText = $"select count(1) from användare where Användarnamn = (@namn) ";
            comm.Parameters.AddWithValue("@namn", $"{användarnamn}");
         
            
            int count = Convert.ToInt32(comm.ExecuteScalar());
            if ( count == 1)
            {
                
                     string lössenord = Txtbx_Password.Text.ToString();
                 
                     MySqlConnection conn2 = new MySqlConnection(connection);
                     conn2.Open();



                     MySqlCommand comm2 = conn2.CreateCommand();
                     comm2.CommandText = $"select count(1) from användare where Lösenord = (@lössen)  ";
                     comm2.Parameters.AddWithValue("@lössen", $"{lössenord}");

                int count2 = Convert.ToInt32(comm2.ExecuteScalar());
                

                       if (count2 == 1)
                       {

                           MessageBox.Show("login succes");

                           Lägg_Till_Filmer fönster = new Lägg_Till_Filmer();

                              fönster.Show();

                         
                           conn1.Close();
                           conn2.Close();


                          

                       }
                       else
                       {
                          MessageBox.Show("wrong password");
                       }

                 
               





            } 
            else
            {
                MessageBox.Show("wrong username");
            }

            




        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            string usrn = Txtbx_Username.ToString(); 

        }
    }
}
