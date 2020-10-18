using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String title = comboBoxselect.SelectedItem.ToString();

            if(title == "Site Manager")
            {
                this.Hide();
                DashboardSm d = new DashboardSm();
                d.Show();
            }
            else if(title == "Procurement Manager")
            {
                this.Hide();
                DashboardPm d = new DashboardPm();
                d.Show();
            }
            else
            {
                this.Hide();
                DashboardS d = new DashboardS();
                d.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '*')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
    }
}
