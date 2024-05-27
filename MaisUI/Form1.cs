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

        public class Manager
        {
            public int ManagerId { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        private string connectionString = "Server=localhost;Database=mais;Uid=root;Pwd=";

        public void Login(Form1 form1)
        {
            string query = "SELECT * FROM managers WHERE email=@Email AND password=@Password";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.Parameters.AddWithValue("@Email", textBox3.Text);
                commandDatabase.Parameters.AddWithValue("@Password", textBox2.Text);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            Manager loggedInUser = new Manager
                            {
                                Email = reader["Email"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString()
                            };

                            MessageBox.Show("Login successful. \nOpening POS.");
                            Form5 form5 = new Form5(loggedInUser);
                            form5.Show();
                            form1.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You are not authorized to access this system.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}