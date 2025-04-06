using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace First_App
{
    public partial class Login : Form
    {
        private SqlConnection cn;

        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection  cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True"))
            {
                cn.Open();

                string name =  textName.Text;
                string password =  textPassword.Text;

                string query = "SELECT * FROM Users ";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@password", password);


                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string loggedInName = textName.Text;    

                        this.Hide();
                        Home home = new Home(loggedInName);
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
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
    }
}
