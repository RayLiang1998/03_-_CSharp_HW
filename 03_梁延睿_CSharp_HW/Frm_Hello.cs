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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello ! 我是" + txt_CN.Text + ",\n英文名字是"
               + txt_EN.Text + ",\n性別為" + cb_sex.Text + ",\n星座是" + cb_zodiac.Text
               + ",\n很高興認識你 !");

        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi ! 我是" + txt_CN.Text + ",\n英文名字是"
                + txt_EN.Text + ",\n性別為" + cb_sex.Text + ",\n星座是" + cb_zodiac.Text
                + ",\n很高興認識你 !");

        }
    }
}
