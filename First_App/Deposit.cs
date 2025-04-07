using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace First_App
{
    public partial class Deposit : Form
    {
        private SqlConnection cn;
        private string loggedInName;

        public Deposit(string loggedInName)
        {
            InitializeComponent();
            this.loggedInName = loggedInName;
            this.label1.Text = $"Logged in as: {loggedInName}";
            this.label1.Location = new Point(10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the amount
                if (!decimal.TryParse(textAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid positive amount.");
                    return;
                }

                // Update the database
                using (SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True"))
                {
                    cn.Open();

                    // First check if user exists and get current balance
                    string getBalanceQuery = "SELECT Balance FROM Users WHERE Name = @name";
                    decimal currentBalance = 0;

                    using (SqlCommand cmd = new SqlCommand(getBalanceQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@name", loggedInName);
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentBalance = Convert.ToDecimal(result);
                        }
                    }

                    // Update the balance
                    string updateQuery = "UPDATE Users SET Balance = @newBalance WHERE Name = @name";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@name", loggedInName);
                        cmd.Parameters.AddWithValue("@newBalance", currentBalance + amount);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Successfully deposited {amount:C}. New balance: {currentBalance + amount:C}");
                            
                        }
                        else
                        {
                            MessageBox.Show("Deposit failed. User not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deposit: {ex.Message}");
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home(loggedInName);
            home.ShowDialog();
        }
    }
}