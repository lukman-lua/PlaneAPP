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
        public Auth()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=lukman122002;database=orderspeech;");
            MySqlCommand command;
            MySqlDataReader reader;
            conn.Open();
            String query = "SELECT * FROM admin WHERE user='" + usernameLogin.Text + "' AND password='" + passwordLogin.Text + "';";
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
    }
}
