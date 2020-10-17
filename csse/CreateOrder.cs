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
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //else if (String.IsNullOrEmpty(comboBoxSupplier.SelectedIndex.ToString()) && String.IsNullOrEmpty(comboBoxProduct.SelectedIndex.ToString()) && String.IsNullOrEmpty(textqty.Text) && String.IsNullOrEmpty(textTot.Text) && String.IsNullOrEmpty(comboBoxSupplier.SelectedIndex.ToString()) && String.IsNullOrEmpty(textLoc.Text) && String.IsNullOrEmpty(textdes.Text))
            if (comboBoxSupplier.SelectedIndex == -1 && comboBoxProduct.SelectedIndex == -1 && String.IsNullOrEmpty(txtprice.Text) && String.IsNullOrEmpty(textqty.Text) && String.IsNullOrEmpty(textLoc.Text) && String.IsNullOrEmpty(textdes.Text))
            {
                MessageBox.Show(" cannot proceed the order, Other fields must be filled");

            }

            else if (String.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show(" cannot proceed the order please enter price");
            }
            else if (String.IsNullOrEmpty(textqty.Text))
            {
                MessageBox.Show(" cannot proceed the order please enter qty");
            }
            else if (comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show(" cannot proceed the order. Please select product");
            }
            else if (comboBoxSupplier.SelectedIndex == -1)
            {
                MessageBox.Show(" cannot proceed the order please select supplier");

            }

            else if (String.IsNullOrEmpty(textLoc.Text))
            {
                MessageBox.Show(" cannot proceed the order please enter deleivery location");
            }

            else if (String.IsNullOrEmpty(textdes.Text))
            {
                MessageBox.Show(" cannot proceed the order please enter description");
            }

            else
            {
                /*if (textTot.Text != null)
                {
                    /*if (int.Parse(textTot.Text) > 100000)
                    {
                        MessageBox.Show(" Order is the exceed the price limit.t.Please get approval for order");

                    }
                }*/


                int price = int.Parse(txtprice.Text);

                int qty = int.Parse(textqty.Text);

                int tot;

                tot = price * qty;




                /*
                if (tot > 100000)
                {
                    MessageBox.Show(" Your total amount is " + tot + "/=." + " Total amount exceed the price limit. Please get approval for this order.");

                }


                else
                {}*/

                   MessageBox.Show(" create order successfully " + "total amount is " + tot + "/=");
                



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" order details are saved successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardSm d = new DashboardSm();
            d.Show();
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProduct.Text == "Cement")
            {
                txtprice.Text = "100";
            }
            else if (comboBoxProduct.Text == "Sand")
            {
                txtprice.Text = "12000";
            }
            else if (comboBoxProduct.Text == "Bricks")
            {
                txtprice.Text = "10";
            }
            else if (comboBoxProduct.Text == "Tiles")
            {
                txtprice.Text = "6000";
            }
            else if (comboBoxProduct.Text == "Pipes")
            {
                txtprice.Text = "300";
            }
        }
    }
}
