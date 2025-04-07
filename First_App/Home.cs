using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace First_App
{

    public partial class Home : Form
    {
        private string loggedInName;

        public Home(string loggedInName)
        {
            InitializeComponent();
            this.loggedInName = loggedInName;
            this.label2.Text = $"Logged in as: {loggedInName}";
            this.label2.Location = new Point(10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Successfully Logged out as {loggedInName}, Have a good day!");

            this.Close();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void loggedInAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit(loggedInName);
            deposit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAccount viewAccount =  new ViewAccount(loggedInName);
            viewAccount.ShowDialog();
        }
    }
}
