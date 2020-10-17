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
    public partial class DeliveryStatus1 : Form
    {
        public DeliveryStatus1()
        {
            InitializeComponent();
            displayDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardPm d = new DashboardPm();
            d.Show();
        }

        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "OR001";
            dataGridView1.Rows[0].Cells[1].Value = "Bricks";
            dataGridView1.Rows[0].Cells[2].Value = "20/05/2019";
            dataGridView1.Rows[0].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[0].Cells[4].Value = "Delivered";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "OR002";
            dataGridView1.Rows[1].Cells[1].Value = "Paint";
            dataGridView1.Rows[1].Cells[2].Value = "23/05/2019";
            dataGridView1.Rows[1].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[1].Cells[4].Value = "Pending";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "OR003";
            dataGridView1.Rows[2].Cells[1].Value = "Amano Sheets";
            dataGridView1.Rows[2].Cells[2].Value = "24/05/2019";
            dataGridView1.Rows[2].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[2].Cells[4].Value = "Delivered";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[0].Value = "OR004";
            dataGridView1.Rows[3].Cells[1].Value = "PVC Pipe";
            dataGridView1.Rows[3].Cells[2].Value = "30/05/2019";
            dataGridView1.Rows[3].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[3].Cells[4].Value = "Not Delivered";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[0].Value = "OR005";
            dataGridView1.Rows[4].Cells[1].Value = "Tiles";
            dataGridView1.Rows[4].Cells[2].Value = "02/06/2019";
            dataGridView1.Rows[4].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[4].Cells[4].Value = "Pending";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[5].Cells[0].Value = "OR006";
            dataGridView1.Rows[5].Cells[1].Value = "Bricks";
            dataGridView1.Rows[5].Cells[2].Value = "03/06/2019";
            dataGridView1.Rows[5].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[5].Cells[4].Value = "Pending";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[6].Cells[0].Value = "OR007";
            dataGridView1.Rows[6].Cells[1].Value = "Nails";
            dataGridView1.Rows[6].Cells[2].Value = "05/06/2019";
            dataGridView1.Rows[6].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";
            dataGridView1.Rows[6].Cells[4].Value = "Delivered";
        }
    }
}
