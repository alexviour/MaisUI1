using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo.DB.Helpers;
using MySql.Data.MySqlClient;
using static MaisUI.Form1;

namespace MaisUI
{
    public partial class Form6 : Form
    {
        private string connectionString = "Server=localhost;Database=mais;Uid=root;Pwd=";
        private Manager loggedInUser;

        public Form6(Manager manager)
        {
            InitializeComponent();
            loggedInUser = manager;
            //  LoadData();
            LoadUserName();
            this.Load += new EventHandler(YourForm_Load);
        }

        private void YourForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=mais;Uid=root;Pwd=";

            string query = @"
                SELECT * FROM orders";

            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            dataGridView1.DataSource = dataTable;
        }

        private void LoadUserName()
        {
            if (loggedInUser != null)
            {
                UserName.Text = $"{loggedInUser.FirstName} {loggedInUser.LastName}";
                Email.Text = loggedInUser.Email;
            }
        }

        private void DashBoardbtn_Click(object sender, EventArgs e)
        {
            // Pass the same manager instance to Form5
            Form5 form5 = new Form5(loggedInUser);
            form5.Show();
            this.Hide();
        }
    }
}