using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_06_Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
            int sol = 0;

            try
            {
                if (rbOsszead.Checked) sol = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                else if (rbKivon.Checked) sol = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                else if (rbSzoroz.Checked) sol = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                else if (rbOszt.Checked)
                    try
                    {
                        sol = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                    }
                    catch (Exception oszt)
                    {
                    }
            }
            catch (Exception e)
            {
            }


            try
            {
                solution.Text = sol.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void rbKivon_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void rbOsszead_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void rbSzoroz_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void rbOszt_CheckedChanged(object sender, EventArgs e)
        {
            calculate();
        }

    }
}