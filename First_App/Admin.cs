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
    public partial class Admin : Form
    {
        private string loggedInName;
        private SqlConnection cn;
        public Admin(string loggedInName)
        {
            InitializeComponent();
            this.loggedInName = loggedInName;
            this.label2.Text = $"Logged in as: {loggedInName}";
            this.label2.Location = new Point(10, 10);
            LoadUsers(); 
        }

        private void LoadUsers()
        {
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True";

            try
            {
                using (cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    
                    string query = "SELECT Id, name, balance FROM Users"; // Modify as needed

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listBox1.Items.Clear(); 

                            while (reader.Read())
                            {
                                
                                string userInfo = $"{reader["Id"]} - {reader["name"]} ({reader["balance"]:C})";
                                listBox1.Items.Add(userInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Logging out as {loggedInName}, have a good day.");
            this.Close();
        }
    }
}
