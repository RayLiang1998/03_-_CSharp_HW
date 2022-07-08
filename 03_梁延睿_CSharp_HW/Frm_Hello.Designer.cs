
namespace _03_梁延睿_CSharp_HW
{
    partial class Frm_Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Hello));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CN = new System.Windows.Forms.TextBox();
            this.txt_EN = new System.Windows.Forms.TextBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.cb_zodiac = new System.Windows.Forms.ComboBox();
            this.btn_Hello = new System.Windows.Forms.Button();
            this.btn_Hi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(64, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "星座: ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(64, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別: ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(64, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "English Name: ";
            // 
            // txt_CN
            // 
            this.txt_CN.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CN.Location = new System.Drawing.Point(402, 47);
            this.txt_CN.Name = "txt_CN";
            this.txt_CN.Size = new System.Drawing.Size(257, 43);
            this.txt_CN.TabIndex = 4;
            // 
            // txt_EN
            // 
            this.txt_EN.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_EN.Location = new System.Drawing.Point(402, 112);
            this.txt_EN.Name = "txt_EN";
            this.txt_EN.Size = new System.Drawing.Size(257, 43);
            this.txt_EN.TabIndex = 5;
            // 
            // cb_sex
            // 
            this.cb_sex.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "男",
            "女",
            "其他"});
            this.cb_sex.Location = new System.Drawing.Point(402, 183);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(257, 43);
            this.cb_sex.TabIndex = 6;
            // 
            // cb_zodiac
            // 
            this.cb_zodiac.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_zodiac.FormattingEnabled = true;
            this.cb_zodiac.Items.AddRange(new object[] {
            "牡羊座",
            "金牛座",
            "雙子座",
            "巨蟹座",
            "獅子座",
            "處女座",
            "天秤座",
            "天蠍座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "雙魚座"});
            this.cb_zodiac.Location = new System.Drawing.Point(402, 251);
            this.cb_zodiac.Name = "cb_zodiac";
            this.cb_zodiac.Size = new System.Drawing.Size(257, 43);
            this.cb_zodiac.TabIndex = 7;
            // 
            // btn_Hello
            // 
            this.btn_Hello.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Hello.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hello.Location = new System.Drawing.Point(70, 344);
            this.btn_Hello.Name = "btn_Hello";
            this.btn_Hello.Size = new System.Drawing.Size(246, 46);
            this.btn_Hello.TabIndex = 8;
            this.btn_Hello.Text = "Say Hello !";
            this.btn_Hello.UseVisualStyleBackColor = false;
            this.btn_Hello.Click += new System.EventHandler(this.btn_Hello_Click);
            // 
            // btn_Hi
            // 
            this.btn_Hi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Hi.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Hi.Location = new System.Drawing.Point(402, 344);
            this.btn_Hi.Name = "btn_Hi";
            this.btn_Hi.Size = new System.Drawing.Size(257, 46);
            this.btn_Hi.TabIndex = 9;
            this.btn_Hi.Text = "Say Hi !";
            this.btn_Hi.UseVisualStyleBackColor = false;
            this.btn_Hi.Click += new System.EventHandler(this.btn_Hi_Click);
            // 
            // Frm_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Hi);
            this.Controls.Add(this.btn_Hello);
            this.Controls.Add(this.cb_zodiac);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.txt_EN);
            this.Controls.Add(this.txt_CN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Hello";
            this.Text = "Hello C# !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CN;
        private System.Windows.Forms.TextBox txt_EN;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.ComboBox cb_zodiac;
        private System.Windows.Forms.Button btn_Hello;
        private System.Windows.Forms.Button btn_Hi;
    }
}

