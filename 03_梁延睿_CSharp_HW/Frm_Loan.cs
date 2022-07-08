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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }
        //public class Num
        //{
        //    public int loan;
        //    public int year;
        //    public int rate;
        //    public int month;
        //    public int down;
        //    public double mp;
        //    public double tp;
        //}

        //public double cal(int loan, double year, double rate, int down)
        //{
        //    double Mrate = (rate / 100) / 12;
        //    double month = year * 12;
        //    double mp = (loan - down) * ((Mrate * Math.Pow((1 + Mrate), month)) / (Math.Pow((1 + Mrate), month)));
        //    return mp;
        //}

        private void btn_mp_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Loan.loan_num.loan = double.Parse(txt_loan.Text);
                Class_Loan.loan_num.year = double.Parse(txt_year.Text);
                Class_Loan.loan_num.rate = double.Parse(txt_rate.Text);
                Class_Loan.loan_num.down = double.Parse(txt_down.Text);
                Class_Loan MP = new Class_Loan();
                Class_Loan.loan_num.mp = MP.calmp(Class_Loan.loan_num.loan, Class_Loan.loan_num.year, Class_Loan.loan_num.rate, Class_Loan.loan_num.down);
                MessageBox.Show("Monthly Payment : " + string.Format("{0,0:C2}", Class_Loan.loan_num.mp));
                //MessageBox.Show("Monthly Payment : " + Class_Loan.loan_num.mp.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numbers correctly !");
            }
            
        }

        private void btn_tp_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Loan.loan_num.loan = double.Parse(txt_loan.Text);
                Class_Loan.loan_num.year = double.Parse(txt_year.Text);
                Class_Loan.loan_num.rate = double.Parse(txt_rate.Text);
                Class_Loan.loan_num.down = double.Parse(txt_down.Text);
                Class_Loan MP = new Class_Loan();
                Class_Loan TP = new Class_Loan();
                Class_Loan.loan_num.mp = MP.calmp(Class_Loan.loan_num.loan, Class_Loan.loan_num.year, Class_Loan.loan_num.rate, Class_Loan.loan_num.down);
                Class_Loan.loan_num.tp = TP.caltp(Class_Loan.loan_num.mp, Class_Loan.loan_num.year);
                MessageBox.Show("Total Payment : " + string.Format("{0,0:C2}", Class_Loan.loan_num.tp));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numbers correctly !");
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Class_Loan.loan_num.loan = double.Parse(txt_loan.Text);
            Class_Loan.loan_num.year = double.Parse(txt_year.Text);
            Class_Loan.loan_num.rate = double.Parse(txt_rate.Text);
            Class_Loan.loan_num.down = double.Parse(txt_down.Text);
            Class_Loan MP = new Class_Loan();
            Class_Loan.loan_num.mp = MP.calmp(Class_Loan.loan_num.loan, Class_Loan.loan_num.year, Class_Loan.loan_num.rate, Class_Loan.loan_num.down);

            Frm_Loan_Report report = new Frm_Loan_Report();
            report.Show();
        }
    }
}
