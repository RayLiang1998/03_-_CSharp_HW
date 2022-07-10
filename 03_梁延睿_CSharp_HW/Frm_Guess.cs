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
    public partial class Frm_Guess : Form
    {
        public Frm_Guess()
        {
            InitializeComponent();
        }
        public static int result, min, max;
        Random rm = new Random();
        public void Guess()
        {
            min = 1;
            max = 100;
            result = rm.Next(1, 100);
        }

        private void Frm_Guess_Load(object sender, EventArgs e)
        {
            Guess();
        }
        public void changeLabel1()
        {
            label1.Text = "Too Small!!!" + "\nBetween " + min + "and" + max;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("answer: " + result);
        }

        public void changeLabel2()
        {
            label1.Text = "Too Large!!!" + "\nBetween " + min + "and" + max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_GuessIp Ip = new Frm_GuessIp();
            Ip.Show();
        }


    }
}
