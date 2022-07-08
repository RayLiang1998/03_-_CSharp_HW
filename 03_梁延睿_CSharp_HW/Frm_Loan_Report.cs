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
    public partial class Frm_Loan_Report : Form
    {
        public Frm_Loan_Report()
        {
            InitializeComponent();
        }

        private void Frm_Loan_Report_Load(object sender, EventArgs e)
        {
            Class_Loan MP = new Class_Loan();
            Class_Loan TP = new Class_Loan();
            Class_Loan.loan_num.mp = MP.calmp(Class_Loan.loan_num.loan, Class_Loan.loan_num.year, Class_Loan.loan_num.rate, Class_Loan.loan_num.down);
            Class_Loan.loan_num.tp = TP.caltp(Class_Loan.loan_num.mp, Class_Loan.loan_num.year);

            lab_loan.Text = Class_Loan.loan_num.loan.ToString();
            lab_year.Text = Class_Loan.loan_num.year.ToString();
            lab_rate.Text = Class_Loan.loan_num.rate.ToString();
            lab_down.Text = Class_Loan.loan_num.down.ToString();
            lab_mp.Text = string.Format("{0,0:C2}", Class_Loan.loan_num.mp);
            lab_tp.Text = string.Format("{0,0:C2}", Class_Loan.loan_num.tp);

        }
        private void btn_email_Click(object sender, EventArgs e)
        {

        }
    }
}
