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
    public partial class Frm_ScreenProtect : Form
    {
        public Frm_ScreenProtect()
        {
            InitializeComponent();
        }

        int move;
        int x;
        int y;
        int Start = 0;
        void TL()
        {
            pictureBox1.Top--;
            pictureBox1.Left--;
        }
        void TR()
        {
            pictureBox1.Top--;
            pictureBox1.Left++;
        }
        void BL()
        {
            pictureBox1.Top++;
            pictureBox1.Left--;
        }
        void BR()
        {
            pictureBox1.Top++;
            pictureBox1.Left++;
        }
        private void Screen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MoveC()
        {
            if (Cursor.Position.X - x > 50 || Cursor.Position.Y - y > 50)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            if (Start == 0)
            {
                Start = 1;
                move = 2;
                this.Cursor = new Cursor(Cursor.Current.Handle);
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
                pictureBox1.Top = 0;
                pictureBox1.Left = 0;
            }

            if (this.pictureBox1.Left <= 0 || this.pictureBox1.Left >= this.Width - this.pictureBox1.Width ||
                this.pictureBox1.Top <= 0 || this.pictureBox1.Top >= this.Height - this.pictureBox1.Height)
            {
                if (move == 1)
                {
                    move = 4;
                }
                else if (move == 4)
                {
                    move = 3;
                }
                else if (move == 3)
                {
                    move = 2;
                }
                else if (move == 2)
                {
                    move = 1;
                }

            }
            switch (move)
            {
                case 1:
                    BR();
                    break;
                case 2:
                    BL();
                    break;
                case 3:
                    TL();
                    break;
                case 4:
                    TR();
                    break;
            }
            MoveC();
        }

        
    }
}
