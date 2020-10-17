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
    public partial class OrderDetails6 : Form
    {
        public OrderDetails6()
        {
            InitializeComponent();
            displayDetails();
        }

        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Amano Sheets";
            dataGridView1.Rows[0].Cells[1].Value = "10";
            dataGridView1.Rows[0].Cells[2].Value = "3500";
            dataGridView1.Rows[0].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseView1 d = new PurchaseView1();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Approved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Partially Approved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Referred2 d = new Referred2();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rejected");
        }
    }
}
