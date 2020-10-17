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
    public partial class OrderTracking : Form
    {
        public OrderTracking()
        {
            InitializeComponent();
            displayDetails();

        }

        //display details
        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Cement";
            dataGridView1.Rows[0].Cells[1].Value = "100";
            dataGridView1.Rows[0].Cells[2].Value = "1000";
            dataGridView1.Rows[0].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "Sand";
            dataGridView1.Rows[1].Cells[1].Value = "1";
            dataGridView1.Rows[1].Cells[2].Value = "12000";
            dataGridView1.Rows[1].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "Bricks";
            dataGridView1.Rows[2].Cells[1].Value = "5000";
            dataGridView1.Rows[2].Cells[2].Value = "50000";
            dataGridView1.Rows[2].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[0].Value = "Nails";
            dataGridView1.Rows[3].Cells[1].Value = "500";
            dataGridView1.Rows[3].Cells[2].Value = "1500";
            dataGridView1.Rows[3].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[0].Value = "PVC Pipe";
            dataGridView1.Rows[4].Cells[1].Value = "10";
            dataGridView1.Rows[4].Cells[2].Value = "3000";
            dataGridView1.Rows[4].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[5].Cells[0].Value = "Concrete";
            dataGridView1.Rows[5].Cells[1].Value = "100";
            dataGridView1.Rows[5].Cells[2].Value = "55000";
            dataGridView1.Rows[5].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[6].Cells[0].Value = "Amano Sheets";
            dataGridView1.Rows[6].Cells[1].Value = "10";
            dataGridView1.Rows[6].Cells[2].Value = "3500";
            dataGridView1.Rows[6].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[7].Cells[0].Value = "Tiles";
            dataGridView1.Rows[7].Cells[1].Value = "200";
            dataGridView1.Rows[7].Cells[2].Value = "130000";
            dataGridView1.Rows[7].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[8].Cells[0].Value = "Glass";
            dataGridView1.Rows[8].Cells[1].Value = "20";
            dataGridView1.Rows[8].Cells[2].Value = "8000";
            dataGridView1.Rows[8].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[9].Cells[0].Value = "Paint";
            dataGridView1.Rows[9].Cells[1].Value = "10";
            dataGridView1.Rows[9].Cells[2].Value = "8000";
            dataGridView1.Rows[9].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[10].Cells[0].Value = "Binding wire";
            dataGridView1.Rows[10].Cells[1].Value = "50";
            dataGridView1.Rows[10].Cells[2].Value = "40000";
            dataGridView1.Rows[10].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[11].Cells[0].Value = "Stones";
            dataGridView1.Rows[11].Cells[1].Value = "100";
            dataGridView1.Rows[11].Cells[2].Value = "12000";
            dataGridView1.Rows[11].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[12].Cells[0].Value = "Switches";
            dataGridView1.Rows[12].Cells[1].Value = "50";
            dataGridView1.Rows[12].Cells[2].Value = "15000";
            dataGridView1.Rows[12].Cells[3].Value = "abcdefghigklmnopqrstuvwxyz";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardSm d = new DashboardSm();
            d.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("Successfully Delivered");
            }
        }
    }
}
