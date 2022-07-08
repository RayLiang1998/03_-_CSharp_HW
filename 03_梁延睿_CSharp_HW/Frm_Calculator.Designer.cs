
namespace _03_梁延睿_CSharp_HW
{
    partial class Frm_Calculator
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_deduction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_devition = new System.Windows.Forms.Button();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(116, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Number 1 : ";
            // 
            // txt_1
            // 
            this.txt_1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_1.Location = new System.Drawing.Point(374, 58);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(326, 35);
            this.txt_1.TabIndex = 1;
            this.txt_1.TextChanged += new System.EventHandler(this.txt_1_TextChanged);
            // 
            // txt_2
            // 
            this.txt_2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_2.Location = new System.Drawing.Point(374, 116);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(326, 35);
            this.txt_2.TabIndex = 3;
            this.txt_2.TextChanged += new System.EventHandler(this.txt_2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(116, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter Number 2 : ";
            // 
            // btn_addition
            // 
            this.btn_addition.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addition.Location = new System.Drawing.Point(64, 192);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(148, 97);
            this.btn_addition.TabIndex = 4;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_deduction
            // 
            this.btn_deduction.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deduction.Location = new System.Drawing.Point(240, 192);
            this.btn_deduction.Name = "btn_deduction";
            this.btn_deduction.Size = new System.Drawing.Size(148, 97);
            this.btn_deduction.TabIndex = 5;
            this.btn_deduction.Text = "-";
            this.btn_deduction.UseVisualStyleBackColor = true;
            this.btn_deduction.Click += new System.EventHandler(this.btn_deduction_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_multiplication.Location = new System.Drawing.Point(416, 192);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(148, 97);
            this.btn_multiplication.TabIndex = 6;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_devition
            // 
            this.btn_devition.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_devition.Location = new System.Drawing.Point(603, 192);
            this.btn_devition.Name = "btn_devition";
            this.btn_devition.Size = new System.Drawing.Size(148, 97);
            this.btn_devition.TabIndex = 7;
            this.btn_devition.Text = "/";
            this.btn_devition.UseVisualStyleBackColor = true;
            this.btn_devition.Click += new System.EventHandler(this.btn_devition_Click);
            // 
            // txt_ans
            // 
            this.txt_ans.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ans.Location = new System.Drawing.Point(374, 358);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(326, 35);
            this.txt_ans.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(235, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(34, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(741, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "=============================================================";
            // 
            // Frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_devition);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_deduction);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Calculator";
            this.Text = "Frm_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_deduction;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_devition;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}