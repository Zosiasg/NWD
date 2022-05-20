using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWD__Aplikacja_formatkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int nwd(int m, int n)
        {
            int roznica;

            while (m != n)
            {
                if (m > n)
                {
                    roznica = m - n;
                    m = roznica;
                }
                else
                {
                    roznica = n - m;
                    n = roznica;
                }
            }
            return n;
        }

private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse (textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            label1.Text = "NWD dla liczb " + a + " i " + b + " wynosi " + nwd(a, b);
        }
    }
}
