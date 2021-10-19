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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.Muveletek = new System.Windows.Forms.GroupBox();
            this.rbOszt = new System.Windows.Forms.RadioButton();
            this.rbSzoroz = new System.Windows.Forms.RadioButton();
            this.rbKivon = new System.Windows.Forms.RadioButton();
            this.rbOsszead = new System.Windows.Forms.RadioButton();
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(296, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Muveletek.Controls.Add(this.rbOszt);
            this.Muveletek.Controls.Add(this.rbSzoroz);
            this.Muveletek.Controls.Add(this.rbKivon);
            this.Muveletek.Controls.Add(this.rbOsszead);
            this.Muveletek.Location = new System.Drawing.Point(233, 198);
            this.Muveletek.Name = "Muveletek";
            this.Muveletek.Size = new System.Drawing.Size(165, 140);
            this.Muveletek.TabIndex = 7;
            this.Muveletek.TabStop = false;
            this.Muveletek.Text = "Muveletek";
            // 
            // rbOszt
            // 
            this.rbOszt.Location = new System.Drawing.Point(6, 109);
            this.rbOszt.Name = "rbOszt";
            this.rbOszt.Size = new System.Drawing.Size(104, 24);
            this.rbOszt.TabIndex = 3;
            this.rbOszt.Text = "oszt";
            this.rbOszt.UseVisualStyleBackColor = true;
            this.rbOszt.CheckedChanged += new System.EventHandler(this.rbOszt_CheckedChanged);
            // 
            // rbSzoroz
            // 
            this.rbSzoroz.Location = new System.Drawing.Point(6, 79);
            this.rbSzoroz.Name = "rbSzoroz";
            this.rbSzoroz.Size = new System.Drawing.Size(104, 24);
            this.rbSzoroz.TabIndex = 2;
            this.rbSzoroz.Text = "szoroz";
            this.rbSzoroz.UseVisualStyleBackColor = true;
            this.rbSzoroz.CheckedChanged += new System.EventHandler(this.rbSzoroz_CheckedChanged);
            // 
            // rbKivon
            // 
            this.rbKivon.Location = new System.Drawing.Point(6, 49);
            this.rbKivon.Name = "rbKivon";
            this.rbKivon.Size = new System.Drawing.Size(104, 24);
            this.rbKivon.TabIndex = 1;
            this.rbKivon.Text = "kivon";
            this.rbKivon.UseVisualStyleBackColor = true;
            this.rbKivon.CheckedChanged += new System.EventHandler(this.rbKivon_CheckedChanged);
            // 
            // rbOsszead
            // 
            this.rbOsszead.Checked = true;
            this.rbOsszead.Location = new System.Drawing.Point(6, 19);
            this.rbOsszead.Name = "rbOsszead";
            this.rbOsszead.Size = new System.Drawing.Size(104, 24);
            this.rbOsszead.TabIndex = 0;
            this.rbOsszead.TabStop = true;
            this.rbOsszead.Text = "osszead";
            this.rbOsszead.UseVisualStyleBackColor = true;
            this.rbOsszead.CheckedChanged += new System.EventHandler(this.rbOsszead_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Muveletek);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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

        private System.Windows.Forms.RadioButton rbSzoroz;

        private System.Windows.Forms.RadioButton rbKivon;

        private System.Windows.Forms.RadioButton rbOsszead;

        private System.Windows.Forms.RadioButton rbOszt;

        private System.Windows.Forms.GroupBox Muveletek;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;

        private System.Windows.Forms.Label solution;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}