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
    public partial class OrderDetails3 : Form
    {
        public OrderDetails3()
        {
            InitializeComponent();
            displayDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseView d = new PurchaseView();
            d.Show();
        }

        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Paint";
            dataGridView1.Rows[0].Cells[1].Value = "10";
            dataGridView1.Rows[0].Cells[2].Value = "8000";
            dataGridView1.Rows[0].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
        }
    }
}
