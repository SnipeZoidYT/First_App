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
            if (textPassword.Text != string.Empty || textName.Text != string.Empty)
            {
                
                SqlCommand cmd = new SqlCommand("select * from [Table] name", cn);
                cmd.Parameters.AddWithValue("@name", textName.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Name Already exists please try another", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into [Table] values(@name,@password)", cn);
                    cmd.Parameters.AddWithValue("@name", textName.Text);
                    cmd.Parameters.AddWithValue("@password", textPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created. Please login now.", "Done",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
