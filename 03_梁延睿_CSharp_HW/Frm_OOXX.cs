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
    public partial class Frm_OOXX : Form
    {
        public Frm_OOXX()
        {
            InitializeComponent();
        }
        bool OX = true;

        void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        void OWin()
        {

            if (button1.Text == button2.Text && button2.Text == button3.Text &&
               button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text &&
               button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text &&
               button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text &&
               button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text &&
               button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text &&
               button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text &&
               button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text &&
               button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                MessageBox.Show("O Win！");
                reset();
            }


        }
        void XWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text &&
                      button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text &&
               button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text &&
               button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text &&
               button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text &&
               button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text &&
               button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text &&
               button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text &&
               button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                MessageBox.Show("X Win！");
                reset();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button1.Text = "O";
                OX = false;
                button1.Enabled = false;
                OWin();
            }
            else
            {
                button1.Text = "X";
                OX = true;
                button1.Enabled = false;
                XWin();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button2.Text = "O";
                OX = false;
                button2.Enabled = false;
                OWin();
            }
            else
            {
                button2.Text = "X";
                OX = true;
                button2.Enabled = false;
                XWin();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button3.Text = "O";
                OX = false;
                button3.Enabled = false;
                OWin();
            }
            else
            {
                button3.Text = "X";
                OX = true;
                button3.Enabled = false;
                XWin();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button4.Text = "O";
                OX = false;
                button4.Enabled = false;
                OWin();
            }
            else
            {
                button4.Text = "X";
                OX = true;
                button4.Enabled = false;
                XWin();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button5.Text = "O";
                OX = false;
                button5.Enabled = false;
                OWin();
            }
            else
            {
                button5.Text = "X";
                OX = true;
                button5.Enabled = false;
                XWin();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button6.Text = "O";
                OX = false;
                button6.Enabled = false;
                OWin();
            }
            else
            {
                button6.Text = "X";
                OX = true;
                button6.Enabled = false;
                XWin();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button7.Text = "O";
                OX = false;
                button7.Enabled = false;
                OWin();
            }
            else
            {
                button7.Text = "X";
                OX = true;
                button7.Enabled = false;
                XWin();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button8.Text = "O";
                OX = false;
                button8.Enabled = false;
                OWin();
            }
            else
            {
                button8.Text = "X";
                OX = true;
                button8.Enabled = false;
                XWin();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (OX == true)
            {
                button9.Text = "O";
                OX = false;
                button9.Enabled = false;
                OWin();
            }
            else
            {
                button9.Text = "X";
                OX = true;
                button9.Enabled = false;
                XWin();
            }
        }
    }
}
