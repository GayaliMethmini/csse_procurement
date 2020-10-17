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
    public partial class OrdersView : Form
    {
        public OrdersView()
        {
            InitializeComponent();
            displayDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardS d = new DashboardS();
            d.Show();
        }

        public void displayDetails()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "OR001";
            dataGridView1.Rows[0].Cells[1].Value = "Shehan";
            dataGridView1.Rows[0].Cells[2].Value = "Skyline";
            dataGridView1.Rows[0].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[0].Cells[4].Value = "20/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "OR002";
            dataGridView1.Rows[1].Cells[1].Value = "Gayan";
            dataGridView1.Rows[1].Cells[2].Value = "Mountain";
            dataGridView1.Rows[1].Cells[3].Value = "111A Bankshall Street, Colombo 11";
            dataGridView1.Rows[1].Cells[4].Value = "23/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "OR003";
            dataGridView1.Rows[2].Cells[1].Value = "Harsha";
            dataGridView1.Rows[2].Cells[2].Value = "Torfy";
            dataGridView1.Rows[2].Cells[3].Value = "63/2, Stace Road, Grandpass";
            dataGridView1.Rows[2].Cells[4].Value = "24/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[0].Value = "OR004";
            dataGridView1.Rows[3].Cells[1].Value = "Sharanjan ";
            dataGridView1.Rows[3].Cells[2].Value = "Mangot";
            dataGridView1.Rows[3].Cells[3].Value = "1st Flr DFCC Bldg 73/5 Galle Road, Colombo 03";
            dataGridView1.Rows[3].Cells[4].Value = "30/05/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[0].Value = "OR005";
            dataGridView1.Rows[4].Cells[1].Value = "Shehan";
            dataGridView1.Rows[4].Cells[2].Value = "Skyline";
            dataGridView1.Rows[4].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[4].Cells[4].Value = "02/06/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[5].Cells[0].Value = "OR006";
            dataGridView1.Rows[5].Cells[1].Value = "Ashan";
            dataGridView1.Rows[5].Cells[2].Value = "Storage";
            dataGridView1.Rows[5].Cells[3].Value = "348/6 Baseline Road, Nugegoda";
            dataGridView1.Rows[5].Cells[4].Value = "03/06/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[6].Cells[0].Value = "OR007";
            dataGridView1.Rows[6].Cells[1].Value = "Gayan";
            dataGridView1.Rows[6].Cells[2].Value = "Mountain";
            dataGridView1.Rows[6].Cells[3].Value = "111A Bankshall Street, Colombo 11";
            dataGridView1.Rows[6].Cells[4].Value = "05/06/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[7].Cells[0].Value = "OR008";
            dataGridView1.Rows[7].Cells[1].Value = "Shehan";
            dataGridView1.Rows[7].Cells[2].Value = "Skyline";
            dataGridView1.Rows[7].Cells[3].Value = "15A Alfred Place, Colombo 03";
            dataGridView1.Rows[7].Cells[4].Value = "10/06/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[8].Cells[0].Value = "OR009";
            dataGridView1.Rows[8].Cells[1].Value = "Harsha";
            dataGridView1.Rows[8].Cells[2].Value = "Torfy";
            dataGridView1.Rows[8].Cells[3].Value = "63/2, Stace Road, Grandpass";
            dataGridView1.Rows[8].Cells[4].Value = "12/06/2019";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[9].Cells[0].Value = "OR010";
            dataGridView1.Rows[9].Cells[1].Value = "Kusal";
            dataGridView1.Rows[9].Cells[2].Value = "Express";
            dataGridView1.Rows[9].Cells[3].Value = "220, Rathmaldeniya Road, Ragama";
            dataGridView1.Rows[9].Cells[4].Value = "13/06/2019";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            //products column
            if (e.ColumnIndex == senderGrid.Columns["Products"].Index && e.RowIndex == 0)
            {
                this.Hide();
                OrderDetails2 d = new OrderDetails2();
                d.Show();
            }
            else if (e.ColumnIndex == senderGrid.Columns["Products"].Index && e.RowIndex == 1)
            {
                this.Hide();
                OrderDetails7 d = new OrderDetails7();
                d.Show();
            }
            else if (e.ColumnIndex == senderGrid.Columns["Products"].Index && e.RowIndex == 2)
            {
                this.Hide();
                OrderDetails8 d = new OrderDetails8();
                d.Show();
            }
        }
    }
}
