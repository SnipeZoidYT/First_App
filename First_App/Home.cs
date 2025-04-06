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
        public string loggedInName { get; set; }
        public Home(string loggedInName)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Logged out, Have a good day!");

            this.Hide();
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

        private void toolStripLabel1_Load(object  sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loggedInName))
            {
                toolStripLabel1.Text = $"Logged in as: {loggedInName}";
            }
        }
    }
}
