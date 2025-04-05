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
            string name = "Christopher";
            string password = "Secure123";

            if (textBox1.Text != name || textBox2.Text != password)
            {
                MessageBox.Show("Incorrect username or password.");
            }
            else
            {
                MessageBox.Show("Logged in!");
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
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code\C#\App\First_App\First_App\Database.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
