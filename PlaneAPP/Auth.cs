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

namespace PlaneAPP
{
    public partial class Auth : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=lukman122002;database=plane_app;");
        MySqlCommand command;
        MySqlDataReader reader;
        public Auth()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var email = emailLogin.Text;
            var password = passwordLogin.Text;
            if (email.Length > 10 && password.Length > 7){
                conn.Open();
                String query = "SELECT * FROM user WHERE email='" + email + "' AND password='" + password + "';";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("login berhasil");
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Tidak boleh kosong dan Lebih dari 7 characters");
            }
            
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            var named = nameDaftar.Text;
            var emaild = emailDaftar.Text;
            var paswordd = passwordDaftar.Text;
            if (named.Length > 7 && emaild.Contains("@gmail") && paswordd.Length > 7)
            {
                conn.Open();
                String query = "INSERT INTO user (name,email,password)" +
                "VALUES (" +
                "'" + named + "'," +
                "'" + emaild + "'," +
                "'" + paswordd + "');";
                command = new MySqlCommand(query, conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Akun anda berhasil didaftarkan, silahkan login kembali");
                }
                else
                {
                    MessageBox.Show("Akun gagal di buat");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Tidak boleh kosong dan Lebih dari 7 characters");
            }
        }
    }
}
