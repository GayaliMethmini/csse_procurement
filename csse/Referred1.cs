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
    public partial class Referred1 : Form
    {
        public Referred1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails5 d = new OrderDetails5();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Sent");
        }
    }
}
