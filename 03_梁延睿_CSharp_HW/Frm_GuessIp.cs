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
    public partial class Frm_GuessIp : Form
    {
        public Frm_GuessIp()
        {
            InitializeComponent();
        }
        int myguess;

        Frm_Guess frmG = new Frm_Guess();

        private void Button1_Click(object sender, EventArgs e)
        {
            myguess = Convert.ToInt32(textBox1.Text);


            if (Frm_Guess.result == myguess)
            {
                MessageBox.Show("Congratulations! You got " + myguess);
                this.Close();
                frmG.Guess();
            }
            else if (Frm_Guess.result > myguess)
            {

                Frm_Guess.min = myguess;
                MessageBox.Show("Too Small!!!" + "\nBetween " + Frm_Guess.min + " and " + Frm_Guess.max);
            }
            else
            {
                Frm_Guess.max = myguess;
                MessageBox.Show("Too Large!!!" + "\nBetween " + Frm_Guess.min + " and " + Frm_Guess.max);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
