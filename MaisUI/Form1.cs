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
using static MaisUI.ClassMethods;

namespace MaisUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string mySqlCon = "server=127.0.0.1;user=root;database=mais;password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        public string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=mais;";

        public void Login(Form1 form1)
        {
            string query = "SELECT * FROM Users WHERE username=@username AND password=@password";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.Parameters.AddWithValue("@username", textBox3.Text);
                commandDatabase.Parameters.AddWithValue("@password", textBox2.Text);

                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("Login successfully. \n Opening POS.");
                                Form2 frm2 = new Form2();
                                frm2.Show();
                                form1.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are not authorized to access this system.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ToggleMinimize(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}