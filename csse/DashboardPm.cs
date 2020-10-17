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
    public partial class DashboardPm : Form
    {
        public DashboardPm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseView1 d = new PurchaseView1();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderStatus1 d = new OrderStatus1();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryStatus1 d = new DeliveryStatus1();
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
