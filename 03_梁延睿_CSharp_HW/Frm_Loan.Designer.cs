
namespace _03_梁延睿_CSharp_HW
{
    partial class Frm_Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_loan = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_down = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_mp = new System.Windows.Forms.Button();
            this.btn_tp = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of Loan: ";
            // 
            // txt_loan
            // 
            this.txt_loan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_loan.Location = new System.Drawing.Point(266, 47);
            this.txt_loan.Name = "txt_loan";
            this.txt_loan.Size = new System.Drawing.Size(207, 35);
            this.txt_loan.TabIndex = 1;
            this.txt_loan.Text = "100000";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_year.Location = new System.Drawing.Point(266, 106);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(207, 35);
            this.txt_year.TabIndex = 3;
            this.txt_year.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Life of Loan (Year): ";
            // 
            // txt_rate
            // 
            this.txt_rate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_rate.Location = new System.Drawing.Point(266, 167);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(207, 35);
            this.txt_rate.TabIndex = 5;
            this.txt_rate.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(46, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interest Rate (%): ";
            // 
            // txt_down
            // 
            this.txt_down.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_down.Location = new System.Drawing.Point(266, 230);
            this.txt_down.Name = "txt_down";
            this.txt_down.Size = new System.Drawing.Size(207, 35);
            this.txt_down.TabIndex = 7;
            this.txt_down.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(46, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Down Payment: ";
            // 
            // btn_mp
            // 
            this.btn_mp.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_mp.Location = new System.Drawing.Point(51, 327);
            this.btn_mp.Name = "btn_mp";
            this.btn_mp.Size = new System.Drawing.Size(200, 67);
            this.btn_mp.TabIndex = 8;
            this.btn_mp.Text = "    Calculate     Monthly Payment";
            this.btn_mp.UseVisualStyleBackColor = true;
            this.btn_mp.Click += new System.EventHandler(this.btn_mp_Click);
            // 
            // btn_tp
            // 
            this.btn_tp.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_tp.Location = new System.Drawing.Point(273, 327);
            this.btn_tp.Name = "btn_tp";
            this.btn_tp.Size = new System.Drawing.Size(200, 67);
            this.btn_tp.TabIndex = 9;
            this.btn_tp.Text = "    Calculate     Total Payment";
            this.btn_tp.UseVisualStyleBackColor = true;
            this.btn_tp.Click += new System.EventHandler(this.btn_tp_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(554, 327);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(200, 67);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_tp);
            this.Controls.Add(this.btn_mp);
            this.Controls.Add(this.txt_down);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_loan);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Loan";
            this.Text = "Frm_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_loan;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_down;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_mp;
        private System.Windows.Forms.Button btn_tp;
        private System.Windows.Forms.Button btn_report;
    }
}