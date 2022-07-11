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
    public partial class Frm_Panel : Form
    {
        public Frm_Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Hello H = new Frm_Hello();
            H.TopLevel = false;
            H.Top = 20;
            H.Left = 20;
            splitContainer1.Panel2.Controls.Add(H);
            H.FormBorderStyle = FormBorderStyle.None;
            H.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Loan L = new Frm_Loan();
            L.TopLevel = false;
            L.Top = 20;
            L.Left = 20;
            splitContainer1.Panel2.Controls.Add(L);
            L.FormBorderStyle = FormBorderStyle.None;
            L.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Calculator C = new Frm_Calculator();
            C.TopLevel = false;
            C.Top = 20;
            C.Left = 20;
            splitContainer1.Panel2.Controls.Add(C);
            C.FormBorderStyle = FormBorderStyle.None;
            C.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_POS P = new Frm_POS();
            P.TopLevel = false;
            P.Top = 20;
            P.Left = 20;
            splitContainer1.Panel2.Controls.Add(P);
            P.FormBorderStyle = FormBorderStyle.None;
            P.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Score S = new Frm_Score();
            S.TopLevel = false;
            S.Top = 20;
            S.Left = 20;
            splitContainer1.Panel2.Controls.Add(S);
            S.FormBorderStyle = FormBorderStyle.None;
            S.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_ScreenProtect SP = new Frm_ScreenProtect();
            SP.TopLevel = false;
            SP.Top = 20;
            SP.Left = 20;
            splitContainer1.Panel2.Controls.Add(SP);
            SP.FormBorderStyle = FormBorderStyle.None;
            SP.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_OOXX ox = new Frm_OOXX();
            ox.TopLevel = false;
            ox.Top = 20;
            ox.Left = 20;
            splitContainer1.Panel2.Controls.Add(ox);
            ox.FormBorderStyle = FormBorderStyle.None;
            ox.Show();
        }

        
    }
}
