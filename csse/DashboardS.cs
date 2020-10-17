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
    public partial class DashboardS : Form
    {
        public DashboardS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersView d = new OrdersView();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login d = new Login();
            d.Show();
        }
    }
}
