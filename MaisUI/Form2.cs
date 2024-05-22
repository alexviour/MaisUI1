using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaisUI.ClassMethods;
using MySql.Data.MySqlClient;

namespace MaisUI
{
    public partial class Form2 : Form
    {
        private int currentPage = 0;
        private const int itemsPerPage = 3;
        private MySqlConnection connection;

        public Form2()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            LoadRecentTransactions(currentPage);
        }

        public string connectionString = "server=127.0.0.1;port=3306;username=root;password=;database=mais;";

        private void LoadRecentTransactions(int page)
        {
            string query = @"SELECT
                            o.order_id,
                            u.username,
                            p.name AS product_name,
                            c.color_name,
                            l.logo_name,
                            oi.quantity,
                            oi.price * oi.quantity AS total_cost,
                            os.status_name,
                            o.order_date
                         FROM
                            Orders o
                         JOIN
                            OrderItems oi ON o.order_id = oi.order_id
                         JOIN
                            ProductVariants pv ON oi.variant_id = pv.variant_id
                         JOIN
                            Products p ON pv.product_id = p.product_id
                         JOIN
                            Colors c ON pv.color_id = c.color_id
                         JOIN
                            Logos l ON pv.logo_id = l.logo_id
                         JOIN
                            Users u ON o.customer_id = u.user_id
                         JOIN
                            OrderStatus os ON o.status_id = os.status_id
                         ORDER BY
                            o.order_date DESC
                         LIMIT @limit OFFSET @offset";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@limit", itemsPerPage);
                cmd.Parameters.AddWithValue("@offset", page * itemsPerPage);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        panelTransactions.Controls.Clear();
                        int yOffset = 0;

                        while (reader.Read())
                        {
                            Panel panel = new Panel
                            {
                                Size = new Size(500, 100),
                                BorderStyle = BorderStyle.FixedSingle,
                                BackgroundImage = Properties.Resources.horizontal_box,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                Location = new Point(0, yOffset) // Positioning the panel
                            };

                            Label lblUsername = new Label
                            {
                                Text = $"Username: {reader["username"]}",
                                Location = new Point(10, 10), // Position relative to the panel
                                AutoSize = true,
                                BackColor = Color.Transparent // Make the label background transparent to see the panel background
                            };

                            Label lblProduct = new Label
                            {
                                Text = $"Product: {reader["product_name"]}, Color: {reader["color_name"]}, Logo: {reader["logo_name"]}",
                                Location = new Point(10, 30), // Position relative to the panel
                                AutoSize = true,
                                BackColor = Color.Transparent
                            };

                            Label lblQuantity = new Label
                            {
                                Text = $"Quantity: {reader["quantity"]}",
                                Location = new Point(10, 50), // Position relative to the panel
                                AutoSize = true,
                                BackColor = Color.Transparent
                            };

                            Label lblTotalCost = new Label
                            {
                                Text = $"Total Cost: ${reader["total_cost"]}",
                                Location = new Point(10, 70), // Position relative to the panel
                                AutoSize = true,
                                BackColor = Color.Transparent
                            };

                            Label lblStatus = new Label
                            {
                                Text = $"Status: {reader["status_name"]}",
                                Location = new Point(250, 10), // Position relative to the panel
                                AutoSize = true,
                                BackColor = Color.Transparent
                            };

                            Label lblOrderDate = new Label
                            {
                                Text = $"Order Date: {reader["order_date"]}",
                                Location = new Point(250, 30), // Position relative to the panel
                                AutoSize = true,
                                BackColor = Color.Transparent
                            };

                            panel.Controls.Add(lblUsername);
                            panel.Controls.Add(lblProduct);
                            panel.Controls.Add(lblQuantity);
                            panel.Controls.Add(lblTotalCost);
                            panel.Controls.Add(lblStatus);
                            panel.Controls.Add(lblOrderDate);

                            panelTransactions.Controls.Add(panel);
                            yOffset += 110; // Adjust yOffset for the next panel
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleMinimize(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LogOutFunction();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void UserName_Click(object sender, EventArgs e)
        {
        }

        private void ProductQuantity_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadRecentTransactions(currentPage);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadRecentTransactions(currentPage);
            }
        }
    }
}