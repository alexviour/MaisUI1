﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=mais;";

        public void login()
        {
            string query = "SELECT * FROM users WHERE username=@username AND password=@password";

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
                                MessageBox.Show("Login successful, opening POS");
                                Form2 frm2 = new Form2();
                                frm2.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oops! Something went wrong. Please try again later.");
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
            login();
        }
    }
}