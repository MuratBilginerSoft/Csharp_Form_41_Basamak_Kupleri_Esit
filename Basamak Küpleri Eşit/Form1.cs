using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basamak_Küpleri_Eşit
{
    public partial class Form1 : Form
    {

        #region Değişkenler

        int sayı;
        double a, b, c;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            sayı = int.Parse(textBox1.Text);

            a = sayı % 10;
            b = ((sayı - a) / 10) % 10;
            c = (((sayı - a) / 10) - b) / 10;

            if (sayı == Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3))
            {
                label3.Text = sayı + " bir armstrong sayıdır";
            }

            else
            {
                label3.Text = sayı + " bir armstrong sayı değildir";
            }
        }
    }
}
