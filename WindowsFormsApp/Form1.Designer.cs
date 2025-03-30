namespace WindowsFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxIn2 = new System.Windows.Forms.TextBox();
            this.button_c2 = new System.Windows.Forms.Button();
            this.button_eq = new System.Windows.Forms.Button();
            this.button_c1 = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.textBoxIn1 = new System.Windows.Forms.TextBox();
            this.button_7 = new System.Windows.Forms.Button();
            this.label_calc = new System.Windows.Forms.Label();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxAr);
            this.panel1.Controls.Add(this.textBoxOut);
            this.panel1.Controls.Add(this.textBoxIn2);
            this.panel1.Controls.Add(this.button_c2);
            this.panel1.Controls.Add(this.button_eq);
            this.panel1.Controls.Add(this.button_c1);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.button_mul);
            this.panel1.Controls.Add(this.button_minus);
            this.panel1.Controls.Add(this.button_plus);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.textBoxIn1);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.label_calc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 503);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.30189F);
            this.textBoxOut.Location = new System.Drawing.Point(335, 42);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(468, 125);
            this.textBoxOut.TabIndex = 19;
            this.textBoxOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOut.TextChanged += new System.EventHandler(this.textBoxOut_TextChanged);
            // 
            // textBoxIn2
            // 
            this.textBoxIn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxIn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.30189F);
            this.textBoxIn2.Location = new System.Drawing.Point(229, 42);
            this.textBoxIn2.Multiline = true;
            this.textBoxIn2.Name = "textBoxIn2";
            this.textBoxIn2.ReadOnly = true;
            this.textBoxIn2.Size = new System.Drawing.Size(100, 125);
            this.textBoxIn2.TabIndex = 18;
            this.textBoxIn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIn2.TextChanged += new System.EventHandler(this.textBoxIn2_TextChanged);
            // 
            // button_c2
            // 
            this.button_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_c2.Location = new System.Drawing.Point(747, 279);
            this.button_c2.Name = "button_c2";
            this.button_c2.Size = new System.Drawing.Size(56, 100);
            this.button_c2.TabIndex = 17;
            this.button_c2.Text = "C";
            this.button_c2.UseVisualStyleBackColor = true;
            this.button_c2.Click += new System.EventHandler(this.button_c2_Click);
            // 
            // button_eq
            // 
            this.button_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_eq.Location = new System.Drawing.Point(335, 385);
            this.button_eq.Name = "button_eq";
            this.button_eq.Size = new System.Drawing.Size(468, 100);
            this.button_eq.TabIndex = 16;
            this.button_eq.Text = "=";
            this.button_eq.UseVisualStyleBackColor = true;
            this.button_eq.Click += new System.EventHandler(this.button_eq_Click);
            // 
            // button_c1
            // 
            this.button_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_c1.Location = new System.Drawing.Point(747, 173);
            this.button_c1.Name = "button_c1";
            this.button_c1.Size = new System.Drawing.Size(56, 100);
            this.button_c1.TabIndex = 15;
            this.button_c1.Text = "C";
            this.button_c1.UseVisualStyleBackColor = true;
            this.button_c1.Click += new System.EventHandler(this.button_c1_Click);
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del.Location = new System.Drawing.Point(541, 279);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(200, 100);
            this.button_del.TabIndex = 14;
            this.button_del.Text = "/";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mul.Location = new System.Drawing.Point(541, 173);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(200, 100);
            this.button_mul.TabIndex = 13;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(335, 279);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(200, 100);
            this.button_minus.TabIndex = 12;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(335, 173);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(200, 100);
            this.button_plus.TabIndex = 11;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_3.Location = new System.Drawing.Point(229, 385);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(100, 100);
            this.button_3.TabIndex = 10;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_2.Location = new System.Drawing.Point(123, 385);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(100, 100);
            this.button_2.TabIndex = 9;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_1.Location = new System.Drawing.Point(17, 385);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(100, 100);
            this.button_1.TabIndex = 8;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_6.Location = new System.Drawing.Point(229, 279);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(100, 100);
            this.button_6.TabIndex = 7;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_5.Location = new System.Drawing.Point(123, 279);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(100, 100);
            this.button_5.TabIndex = 6;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_4.Location = new System.Drawing.Point(17, 279);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(100, 100);
            this.button_4.TabIndex = 5;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_9.Location = new System.Drawing.Point(229, 173);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(100, 100);
            this.button_9.TabIndex = 4;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_8.Location = new System.Drawing.Point(123, 173);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(100, 100);
            this.button_8.TabIndex = 3;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // textBoxIn1
            // 
            this.textBoxIn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxIn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.30189F);
            this.textBoxIn1.Location = new System.Drawing.Point(17, 42);
            this.textBoxIn1.Multiline = true;
            this.textBoxIn1.Name = "textBoxIn1";
            this.textBoxIn1.ReadOnly = true;
            this.textBoxIn1.Size = new System.Drawing.Size(100, 125);
            this.textBoxIn1.TabIndex = 2;
            this.textBoxIn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxIn1.TextChanged += new System.EventHandler(this.textBoxIn1_TextChanged);
            // 
            // button_7
            // 
            this.button_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F);
            this.button_7.Location = new System.Drawing.Point(17, 173);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(100, 100);
            this.button_7.TabIndex = 1;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // label_calc
            // 
            this.label_calc.AutoSize = true;
            this.label_calc.Font = new System.Drawing.Font("Roboto", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calc.ForeColor = System.Drawing.Color.Cornsilk;
            this.label_calc.Location = new System.Drawing.Point(12, 9);
            this.label_calc.Name = "label_calc";
            this.label_calc.Size = new System.Drawing.Size(174, 30);
            this.label_calc.TabIndex = 0;
            this.label_calc.Text = "Калькулятор";
            // 
            // textBoxAr
            // 
            this.textBoxAr.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.30189F);
            this.textBoxAr.Location = new System.Drawing.Point(123, 42);
            this.textBoxAr.Multiline = true;
            this.textBoxAr.Name = "textBoxAr";
            this.textBoxAr.ReadOnly = true;
            this.textBoxAr.Size = new System.Drawing.Size(100, 125);
            this.textBoxAr.TabIndex = 20;
            this.textBoxAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAr.TextChanged += new System.EventHandler(this.textBoxAr_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Калькулятор от катзи";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.TextBox textBoxIn1;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Label label_calc;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_c1;
        private System.Windows.Forms.Button button_c2;
        private System.Windows.Forms.Button button_eq;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.TextBox textBoxIn2;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

