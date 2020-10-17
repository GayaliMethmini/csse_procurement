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
    public partial class editPurchaseViewDetails1 : Form
    {
        public editPurchaseViewDetails1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edited Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseView d = new PurchaseView();
            d.Show();
        }
    }
}
