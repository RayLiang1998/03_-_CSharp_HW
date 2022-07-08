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
    public partial class Frm_Calculator : Form
    {
        public Frm_Calculator()
        {
            InitializeComponent();
        }
        double a;
        double b;

        private void btn_addition_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (a + b).ToString();

        }

        private void btn_deduction_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (a - b).ToString();
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {

            txt_ans.Text = (a * b).ToString();
        }

        private void btn_devition_Click(object sender, EventArgs e)
        {
            txt_ans.Text = (a / b).ToString();
        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txt_1.Text, out a))
            {
                double a = double.Parse(txt_1.Text);
            }
            else if (txt_1.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Please enter numbers in Number 1 !");
                txt_1.Clear();
                txt_1.Focus();
            }
        }

        private void txt_2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txt_2.Text, out b))
            {
                double b = double.Parse(txt_2.Text);
            }
            else if(txt_2.Text == "")
            {

            }
            else
            {
                txt_2.Clear();
                txt_2.Focus();
                MessageBox.Show("Please enter numbers in Number 2 !");
            }
        }
    }
}
