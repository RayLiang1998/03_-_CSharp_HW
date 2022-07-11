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
                button1.ForeColor = Color.Green;
                OX = false;
                button1.Enabled = false;
                OWin();
            }
            else
            {
                button1.Text = "X";
                button1.ForeColor = Color.Red;
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
                button2.ForeColor = Color.Green;
                OX = false;
                button2.Enabled = false;
                OWin();
            }
            else
            {
                button2.Text = "X";
                button2.ForeColor = Color.Red;
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
                button3.ForeColor = Color.Green;
                OX = false;
                button3.Enabled = false;
                OWin();
            }
            else
            {
                button3.Text = "X";
                button3.ForeColor = Color.Red;
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
                button4.ForeColor = Color.Green;
                OX = false;
                button4.Enabled = false;
                OWin();
            }
            else
            {
                button4.Text = "X";
                button4.ForeColor = Color.Red;
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
                button5.ForeColor = Color.Green;
                OX = false;
                button5.Enabled = false;
                OWin();
            }
            else
            {
                button5.Text = "X";
                button5.ForeColor = Color.Red;
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
                button6.ForeColor = Color.Green;
                OX = false;
                button6.Enabled = false;
                OWin();
            }
            else
            {
                button6.Text = "X";
                button6.ForeColor = Color.Red;
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
                button7.ForeColor = Color.Green;
                OX = false;
                button7.Enabled = false;
                OWin();
            }
            else
            {
                button7.Text = "X";
                button7.ForeColor = Color.Red;
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
                button8.ForeColor = Color.Green;
                OX = false;
                button8.Enabled = false;
                OWin();
            }
            else
            {
                button8.Text = "X";
                button8.ForeColor = Color.Red;
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
                button9.ForeColor = Color.Green;
                OX = false;
                button9.Enabled = false;
                OWin();
            }
            else
            {
                button9.Text = "X";
                button9.ForeColor = Color.Red;
                OX = true;
                button9.Enabled = false;
                XWin();
            }
        }
    }
}
