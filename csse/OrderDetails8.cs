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
    public partial class OrderDetails8 : Form
    {
        public OrderDetails8()
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
            dataGridView1.Rows[0].Cells[0].Value = "Amano Sheets";
            dataGridView1.Rows[0].Cells[1].Value = "10";
            dataGridView1.Rows[0].Cells[2].Value = "3500";
            dataGridView1.Rows[0].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
        }
    }
}
