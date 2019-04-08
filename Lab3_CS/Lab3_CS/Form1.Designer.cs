namespace Lab3_CS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown6 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(53, 12);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a =";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(114, 12);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown2.TabIndex = 0;
            this.domainUpDown2.Text = "0";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(175, 12);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown3.TabIndex = 0;
            this.domainUpDown3.Text = "0";
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Location = new System.Drawing.Point(53, 44);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown4.TabIndex = 0;
            this.domainUpDown4.Text = "0";
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.Location = new System.Drawing.Point(114, 44);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown5.TabIndex = 0;
            this.domainUpDown5.Text = "0";
            // 
            // domainUpDown6
            // 
            this.domainUpDown6.Location = new System.Drawing.Point(175, 44);
            this.domainUpDown6.Name = "domainUpDown6";
            this.domainUpDown6.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown6.TabIndex = 0;
            this.domainUpDown6.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b = ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(236, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(193, 136);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CALC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainUpDown6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown5);
            this.Controls.Add(this.domainUpDown3);
            this.Controls.Add(this.domainUpDown4);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.DomainUpDown domainUpDown5;
        private System.Windows.Forms.DomainUpDown domainUpDown6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

