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
        ArrayList scorelist = new ArrayList();

        private void btn_save_Click(object sender, EventArgs e)
        {
            Utilities.score s = new Utilities.score();
            string name = txt_name.Text;
            double chi = double.Parse(txt_chi.Text);
            double math = double.Parse(txt_math.Text);
            double eng = double.Parse(txt_eng.Text);

            scorelist.Add(name);
            scorelist.Add(chi);
            scorelist.Add(math);
            scorelist.Add(eng);


        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            foreach (var item in scorelist)
            {
                lab_saved.Text = score
            }
            
        }
    }
}
