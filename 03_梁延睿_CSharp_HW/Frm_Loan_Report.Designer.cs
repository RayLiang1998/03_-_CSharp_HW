
namespace _03_梁延睿_CSharp_HW
{
    partial class Frm_Loan_Report
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_loan = new System.Windows.Forms.Label();
            this.lab_year = new System.Windows.Forms.Label();
            this.lab_rate = new System.Windows.Forms.Label();
            this.lab_down = new System.Windows.Forms.Label();
            this.btn_email = new System.Windows.Forms.Button();
            this.lab_mp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_tp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(54, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of Loan : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Life of Loan (Years): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(54, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interest Rate (%) : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(54, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Down Payment : ";
            // 
            // lab_loan
            // 
            this.lab_loan.AutoSize = true;
            this.lab_loan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_loan.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_loan.Location = new System.Drawing.Point(248, 53);
            this.lab_loan.Name = "lab_loan";
            this.lab_loan.Size = new System.Drawing.Size(25, 24);
            this.lab_loan.TabIndex = 7;
            this.lab_loan.Text = "   ";
            // 
            // lab_year
            // 
            this.lab_year.AutoSize = true;
            this.lab_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_year.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_year.Location = new System.Drawing.Point(248, 116);
            this.lab_year.Name = "lab_year";
            this.lab_year.Size = new System.Drawing.Size(25, 24);
            this.lab_year.TabIndex = 8;
            this.lab_year.Text = "   ";
            // 
            // lab_rate
            // 
            this.lab_rate.AutoSize = true;
            this.lab_rate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_rate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_rate.Location = new System.Drawing.Point(248, 180);
            this.lab_rate.Name = "lab_rate";
            this.lab_rate.Size = new System.Drawing.Size(25, 24);
            this.lab_rate.TabIndex = 9;
            this.lab_rate.Text = "   ";
            // 
            // lab_down
            // 
            this.lab_down.AutoSize = true;
            this.lab_down.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_down.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_down.Location = new System.Drawing.Point(248, 242);
            this.lab_down.Name = "lab_down";
            this.lab_down.Size = new System.Drawing.Size(25, 24);
            this.lab_down.TabIndex = 10;
            this.lab_down.Text = "   ";
            // 
            // btn_email
            // 
            this.btn_email.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_email.Location = new System.Drawing.Point(547, 315);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(179, 66);
            this.btn_email.TabIndex = 11;
            this.btn_email.Text = "Email";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // lab_mp
            // 
            this.lab_mp.AutoSize = true;
            this.lab_mp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_mp.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_mp.Location = new System.Drawing.Point(248, 306);
            this.lab_mp.Name = "lab_mp";
            this.lab_mp.Size = new System.Drawing.Size(25, 24);
            this.lab_mp.TabIndex = 13;
            this.lab_mp.Text = "   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(54, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Monthly Payment : ";
            // 
            // lab_tp
            // 
            this.lab_tp.AutoSize = true;
            this.lab_tp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_tp.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_tp.Location = new System.Drawing.Point(248, 377);
            this.lab_tp.Name = "lab_tp";
            this.lab_tp.Size = new System.Drawing.Size(25, 24);
            this.lab_tp.TabIndex = 15;
            this.lab_tp.Text = "   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(54, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Payment : ";
            // 
            // Frm_Loan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_tp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_mp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.lab_down);
            this.Controls.Add(this.lab_rate);
            this.Controls.Add(this.lab_year);
            this.Controls.Add(this.lab_loan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Loan_Report";
            this.Text = "Frm_Loan_Report";
            this.Load += new System.EventHandler(this.Frm_Loan_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_loan;
        private System.Windows.Forms.Label lab_year;
        private System.Windows.Forms.Label lab_rate;
        private System.Windows.Forms.Label lab_down;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Label lab_mp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_tp;
        private System.Windows.Forms.Label label8;
    }
}