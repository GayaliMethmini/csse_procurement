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
    public partial class OrderDetails2 : Form
    {
        public OrderDetails2()
        {
            InitializeComponent();
            displayDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersView d = new OrdersView();
            d.Show();
        }

        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Bricks";
            dataGridView1.Rows[0].Cells[1].Value = "5000";
            dataGridView1.Rows[0].Cells[2].Value = "50000";
            dataGridView1.Rows[0].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
        }
    }
}
