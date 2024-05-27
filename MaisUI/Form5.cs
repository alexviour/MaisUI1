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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace MaisUI
{
    public partial class Form5 : Form
    {
        private string connectionString = "Server=localhost;Database=mais;Uid=root;Pwd=";

        public Form5(Form1.getManager loggedInUser)
        {
            InitializeComponent();
            ColorHoverEffect(DashBoardbtn); ColorHoverEffect(Ordersbtn); ColorHoverEffect(Productsbtn); ColorHoverEffect(Settingsbtn);
            LoadChartData();
            LoadMostBoughtProductImage();
            LoadUserName();
        }
        private void LoadChartData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT DATE_FORMAT(o.OrderDate, '%Y-%m') AS Month, SUM(od.TotalAmount) AS TotalSales
                    FROM orders o
                    JOIN orderdetails od ON o.OrderID = od.OrderID
                    GROUP BY DATE_FORMAT(o.OrderDate, '%Y-%m')
                    ORDER BY DATE_FORMAT(o.OrderDate, '%Y-%m');";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chart1.Series.Clear();
                    chart1.Series.Add("TotalSales");
                    chart1.Series["TotalSales"].XValueMember = "Month";
                    chart1.Series["TotalSales"].YValueMembers = "TotalSales";
                    chart1.DataSource = dataTable;
                    chart1.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadUserName()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName, Email FROM managers";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string first = reader["FirstName"].ToString();
                                string last = reader["LastName"].ToString();
                                string displayText = $"{first} ({last})";
                                string email = reader["Email"].ToString();

                                UserName.Text = displayText;
                                Email.Text = email;
                            }
                        }
                    }
                }
            }
        }



        /*private void LoadUserName()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName, Email FROM customers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string first = reader["FirstName"].ToString();
                            string last = reader["LastName"].ToString();
                            string displayText = $"{first} ({last})";
                            string email = reader["Email"].ToString();

                            UserName.Text = displayText;
                            Email.Text = email;
                        }
                    }

                    reader.Close();
                }
            }
        }*/
        private void LoadMostBoughtProductImage()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT pv.ProductVariationImage
                        FROM productvariations pv
                        JOIN orderdetails od ON pv.VariationID = od.VariationID
                        GROUP BY pv.VariationID
                        ORDER BY SUM(od.Quantity) DESC
                        LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] imageBytes = (byte[])reader["ProductVariationImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                MostBoughtProductImage.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No image found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        private void ColorHoverEffect (Control control)
        {

            control.MouseEnter += (sender, e) =>
            {
                control.BackColor = ColorTranslator.FromHtml("#E1C053");
            };

            control.MouseLeave += (sender, e) =>
            {
                control.BackColor = SystemColors.ButtonFace;
            };

            control.Click += (sender, e) =>
            {
                control.BackColor = ColorTranslator.FromHtml("#E1C053");
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
