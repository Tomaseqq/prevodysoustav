using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prevody_soustav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int num = int.Parse(textBox1.Text);
                string base1 = Convert.ToString(num, 2);
                textBox2.Text = base1;
            }

            if (radioButton2.Checked)
            {
                int num = int.Parse(textBox1.Text);
                string base1 = Convert.ToString(num, 16);
                textBox2.Text = base1;
            }

            if (radioButton3.Checked)
            {
                int num, bin, dec = 0, base1 = 1, rem;
                num = int.Parse(textBox1.Text);
                bin = num;
                while (num > 0)
                {
                    rem = num % 10;
                    dec = dec + rem * base1;
                    num = num / 10;
                    base1 = base1 * 2;
                }
                textBox2.Text = dec.ToString();
            }

            if (radioButton4.Checked)
            {
                int num, hex, dec = 0, base1 = 1, rem;
                num = int.Parse(textBox1.Text);
                hex = num;
                while (num > 0)
                {
                    rem = num % 10;
                    dec = dec + rem * base1;
                    num = num / 10;
                    base1 = base1 * 16;
                }
                textBox2.Text = dec.ToString();


            }

            if (radioButton4.Checked)
            {

            }

            if (radioButton4.Checked)
            {

            }

        }

    }
}
