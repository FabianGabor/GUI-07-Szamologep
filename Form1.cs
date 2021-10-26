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
            try
            {
                labelOsszeadasEredmeny.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
                labelKivonasEredmeny.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
                labelSzorzasEredmeny.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
                
                try
                {
                    labelOsztasEredmeny.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                }
                catch (Exception)
                {
                    labelOsztasEredmeny.Text = "Nem ertelmezheto";
                }
            }
            catch (Exception)
            {
                // TODO
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
    }
}