namespace Кокарев_формы.forms
{
    partial class function3
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
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.function_1 = new System.Windows.Forms.PictureBox();
            this.calcbutton = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.function_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(530, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Результат:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(477, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 172);
            this.listBox1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(107, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(106, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Будет вычеслено значение следующей функции:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // function_1
            // 
            this.function_1.Image = global::Кокарев_формы.Properties.Resources._3function;
            this.function_1.InitialImage = null;
            this.function_1.Location = new System.Drawing.Point(111, 64);
            this.function_1.Name = "function_1";
            this.function_1.Size = new System.Drawing.Size(584, 50);
            this.function_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.function_1.TabIndex = 13;
            this.function_1.TabStop = false;
            // 
            // calcbutton
            // 
            this.calcbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(202)))), ((int)(((byte)(77)))));
            this.calcbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcbutton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.calcbutton.Location = new System.Drawing.Point(111, 365);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(217, 52);
            this.calcbutton.TabIndex = 24;
            this.calcbutton.Text = "Вычислить";
            this.calcbutton.UseVisualStyleBackColor = false;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(202)))), ((int)(((byte)(77)))));
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnexit.Location = new System.Drawing.Point(478, 365);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(217, 52);
            this.btnexit.TabIndex = 25;
            this.btnexit.Text = "Выйти";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(107, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Введите m:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(107, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Введите n:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 289);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 31;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(107, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Введите U:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(221, 313);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(108, 20);
            this.textBox5.TabIndex = 33;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(107, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Введите V:";
            // 
            // function3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.function_1);
            this.Controls.Add(this.label1);
            this.Name = "function3";
            this.Text = "3 функция";
            ((System.ComponentModel.ISupportInitialize)(this.function_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox function_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
    }
}