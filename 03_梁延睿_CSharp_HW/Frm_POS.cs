using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_梁延睿_CSharp_HW
{
    public partial class Frm_POS : Form
    {
        public Frm_POS()
        {
            InitializeComponent();
        }
        String a, b, c, d;
        int ca, cb, cc, cd, bb = 120, tt = 180, wi = 320, wh = 350, total;

        private void button1_Click(object sender, EventArgs e)
        {
            ca += 1;
            a = "Beer x" + ca + ", NT$ " + ca * bb +  "\n";
            total = ca * bb + cb * tt + cc * wi + cd * wh;
            label2.Text = "NT$ " + total;
            label1.Text = a + b + c + d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb += 1;
            b = "Tequila x" + cb + ", NT$ " + cb * tt + "\n";
            total = ca * bb + cb * tt + cc * wi + cd * wh;
            label2.Text = "NT$ " + total;
            label1.Text = a + b + c + d;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cc += 1;
            c = "Wine x" + cc + ", NT$ " + cc * wi +  "\n";
            total = ca * bb + cb * tt + cc * wi + cd * wh;
            label2.Text = "NT$ " + total;
            label1.Text = a + b + c + d;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cd += 1;
            d = "Whisky x" + cd + ", NT$ " + cd * wh + "\n";
            total = ca * bb + cb * tt + cc * wi + cd * wh;
            label2.Text = "NT$ " + total;
            label1.Text = a + b + c + d;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ("No Orders Yet".Equals(label1.Text))
            {
                MessageBox.Show("No Orders Yet");
            }
            else
            {
                MessageBox.Show("Total: NT$ " + total);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ("No Orders Yet".Equals(label1.Text))
            {
                MessageBox.Show("No Orders Yet");
            }
            else
            {
                MessageBox.Show("Total: NT$ " + total + "\nAfter Discount: NT$ " + (total * 0.9));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";
            c = "";
            d = "";
            ca = 0;
            cb = 0;
            cc = 0;
            cd = 0;
            label1.Text = "No Orders Yet";
            label2.Text = "NT$ 0";
        }

        
        
    }
}
