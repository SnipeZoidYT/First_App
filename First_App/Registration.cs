using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace First_App
{
    public partial class Registration : Form
    {
        private SqlConnection cn;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textPassword.Text) && !string.IsNullOrEmpty(textName.Text))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE name=@name", cn);
                    cmd.Parameters.AddWithValue("@name", textName.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            MessageBox.Show("Name already exists. Please try another.", "Error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Users (name, password) VALUES (@name, @password)", cn))
                    {
                        insertCmd.Parameters.AddWithValue("@name", textName.Text);
                        insertCmd.Parameters.AddWithValue("@password", textPassword.Text);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Your account has been created. Please login now.", "Success",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
