namespace GUI_06_Forms2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.Muveletek = new System.Windows.Forms.GroupBox();
            this.labelOsztasEredmeny = new System.Windows.Forms.Label();
            this.labelSzorzasEredmeny = new System.Windows.Forms.Label();
            this.labelKivonasEredmeny = new System.Windows.Forms.Label();
            this.labelOsszeadasEredmeny = new System.Windows.Forms.Label();
            this.labelOsztas = new System.Windows.Forms.Label();
            this.labelSzorzas = new System.Windows.Forms.Label();
            this.labelKivonas = new System.Windows.Forms.Label();
            this.labelOsszeadas = new System.Windows.Forms.Label();
            this.Muveletek.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(236, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. szam";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(353, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. szam";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(429, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solution
            // 
            this.solution.Location = new System.Drawing.Point(495, 125);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(61, 20);
            this.solution.TabIndex = 6;
            // 
            // Muveletek
            // 
            this.Muveletek.Controls.Add(this.labelOsztasEredmeny);
            this.Muveletek.Controls.Add(this.labelSzorzasEredmeny);
            this.Muveletek.Controls.Add(this.labelKivonasEredmeny);
            this.Muveletek.Controls.Add(this.labelOsszeadasEredmeny);
            this.Muveletek.Controls.Add(this.labelOsztas);
            this.Muveletek.Controls.Add(this.labelSzorzas);
            this.Muveletek.Controls.Add(this.labelKivonas);
            this.Muveletek.Controls.Add(this.labelOsszeadas);
            this.Muveletek.Location = new System.Drawing.Point(233, 198);
            this.Muveletek.Name = "Muveletek";
            this.Muveletek.Size = new System.Drawing.Size(165, 140);
            this.Muveletek.TabIndex = 7;
            this.Muveletek.TabStop = false;
            this.Muveletek.Text = "Muveletek";
            // 
            // labelOsztasEredmeny
            // 
            this.labelOsztasEredmeny.Location = new System.Drawing.Point(42, 116);
            this.labelOsztasEredmeny.Name = "labelOsztasEredmeny";
            this.labelOsztasEredmeny.Size = new System.Drawing.Size(117, 21);
            this.labelOsztasEredmeny.TabIndex = 15;
            this.labelOsztasEredmeny.Text = "/";
            // 
            // labelSzorzasEredmeny
            // 
            this.labelSzorzasEredmeny.Location = new System.Drawing.Point(42, 86);
            this.labelSzorzasEredmeny.Name = "labelSzorzasEredmeny";
            this.labelSzorzasEredmeny.Size = new System.Drawing.Size(117, 21);
            this.labelSzorzasEredmeny.TabIndex = 14;
            this.labelSzorzasEredmeny.Text = "*";
            // 
            // labelKivonasEredmeny
            // 
            this.labelKivonasEredmeny.Location = new System.Drawing.Point(42, 55);
            this.labelKivonasEredmeny.Name = "labelKivonasEredmeny";
            this.labelKivonasEredmeny.Size = new System.Drawing.Size(117, 21);
            this.labelKivonasEredmeny.TabIndex = 13;
            this.labelKivonasEredmeny.Text = "-";
            // 
            // labelOsszeadasEredmeny
            // 
            this.labelOsszeadasEredmeny.Location = new System.Drawing.Point(42, 25);
            this.labelOsszeadasEredmeny.Name = "labelOsszeadasEredmeny";
            this.labelOsszeadasEredmeny.Size = new System.Drawing.Size(117, 21);
            this.labelOsszeadasEredmeny.TabIndex = 12;
            this.labelOsszeadasEredmeny.Text = "+";
            // 
            // labelOsztas
            // 
            this.labelOsztas.Location = new System.Drawing.Point(6, 116);
            this.labelOsztas.Name = "labelOsztas";
            this.labelOsztas.Size = new System.Drawing.Size(18, 21);
            this.labelOsztas.TabIndex = 11;
            this.labelOsztas.Text = "/";
            // 
            // labelSzorzas
            // 
            this.labelSzorzas.Location = new System.Drawing.Point(6, 86);
            this.labelSzorzas.Name = "labelSzorzas";
            this.labelSzorzas.Size = new System.Drawing.Size(18, 21);
            this.labelSzorzas.TabIndex = 10;
            this.labelSzorzas.Text = "*";
            // 
            // labelKivonas
            // 
            this.labelKivonas.Location = new System.Drawing.Point(6, 55);
            this.labelKivonas.Name = "labelKivonas";
            this.labelKivonas.Size = new System.Drawing.Size(18, 21);
            this.labelKivonas.TabIndex = 9;
            this.labelKivonas.Text = "-";
            // 
            // labelOsszeadas
            // 
            this.labelOsszeadas.Location = new System.Drawing.Point(6, 25);
            this.labelOsszeadas.Name = "labelOsszeadas";
            this.labelOsszeadas.Size = new System.Drawing.Size(18, 21);
            this.labelOsszeadas.TabIndex = 8;
            this.labelOsszeadas.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Muveletek);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Muveletek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelOsztas;
        private System.Windows.Forms.Label labelSzorzas;
        private System.Windows.Forms.Label labelKivonas;
        private System.Windows.Forms.Label labelOsszeadas;
        private System.Windows.Forms.Label labelOsztasEredmeny;
        private System.Windows.Forms.Label labelSzorzasEredmeny;
        private System.Windows.Forms.Label labelKivonasEredmeny;
        private System.Windows.Forms.Label labelOsszeadasEredmeny;
        
        private System.Windows.Forms.GroupBox Muveletek;

        private System.Windows.Forms.Label solution;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}