using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _03_梁延睿_CSharp_HW
{
    public partial class Frm_Score : Form
    {
        public Frm_Score()
        {
            InitializeComponent();
        }
        //ArrayList scorelist = new ArrayList();
        string name;
        string max;
        string min;
        double high;
        double low;
        double chi;
        double math;
        double eng;
        private void btn_save_Click(object sender, EventArgs e)
        {
        

            name = txt_name.Text;
            chi = double.Parse(txt_chi.Text);
            math = double.Parse(txt_math.Text);
            eng = double.Parse(txt_eng.Text);


        }

        private void btn_show_Click(object sender, EventArgs e)
        {
    

            lab_saved.Text = "Name: " + name + "\nChinese Score: " + chi + "\nMath Score: " + math + "\nEnglish Score" + eng;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] score = { chi, math, eng };
            Array.Sort(score);
            high = score[2];
            low = score[0];

            Dictionary<string, double> d = new Dictionary<string, double>();
            d.Add("Chinese", chi);
            d.Add("Math", math);
            d.Add("English", eng);

            foreach (var val in d)
            {
                if (val.Value == high)
                {
                    max = val.Key;
                }
                if(val.Value == low)
                {
                    min = val.Key;
                }
            }
            lab_highlow.Text = "The Highest Score is " + max + " " + score[2] + "\nThe Lowest Score is " + min + " " + score[0];
        }
    }
}
