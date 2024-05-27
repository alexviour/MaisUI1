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
using static MaisUI.Form1;

namespace MaisUI
{
    public partial class Form6 : Form
    {
        private string connectionString = "Server=localhost;Database=mais;Uid=root;Pwd=";
        private Manager _loggedInManager;

        public Form6(Manager manager)
        {
            InitializeComponent();
            _loggedInManager = manager;
            LoadData();
            LoadUserName();
        }

        private void LoadData()
        {
            string connectionString = "server=localhost;database=mais;uid=root;pwd=;";
            string query = "SELECT * FROM orderdetails";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadUserName()
        {
            if (_loggedInManager != null)
            {
                UserName.Text = $"{_loggedInManager.FirstName} {_loggedInManager.LastName}";
                Email.Text = _loggedInManager.Email;
            }
        }

        private void DashBoardbtn_Click(object sender, EventArgs e)
        {
            // Pass the same manager instance to Form5
            Form5 form5 = new Form5(_loggedInManager);
            form5.Show();
            this.Hide();
        }
    }
}