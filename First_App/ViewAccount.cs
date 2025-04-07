using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_App
{
    public partial class ViewAccount : Form
    {
        private string loggedInName;
        private SqlConnection cn;
        public ViewAccount(string loggedInName)
        {
            InitializeComponent();
            this.loggedInName = loggedInName; // Store the parameter
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    string query = "SELECT * FROM Users WHERE name = @name";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        // Now loggedInName has the actual username
                        cmd.Parameters.AddWithValue("@name", loggedInName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Added null checks for each field
                                label6.Text = reader["name"]?.ToString() ?? "N/A";
                                label7.Text = reader["age"]?.ToString() ?? "N/A";
                                label8.Text = reader["email"]?.ToString() ?? "N/A";
                                label9.Text = reader["balance"] != DBNull.Value
                                    ? $"{Convert.ToDecimal(reader["balance"]):C}"
                                    : "£0.00";
                            }
                            else
                            {
                                MessageBox.Show("User not found in database.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user details: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(loggedInName);
            home.ShowDialog();
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
