using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private double[] a = new double[] { 2.4, 3.0, 3.6 };
        private double[] b = new double[] { 1.05, 1.12, 1.2 };
        private double[] c = new double[] { 2.5, 2.5, 2.5 };
        private double[] d = new double[] { 0.38, 0.35, 0.32 };
        private double PM = 0, TM = 0, SS = 0, P = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        public void Calc(int i, int size)
        {
            PM = a[i] * Math.Pow(size, b[i]);
            TM = c[i] * Math.Pow(PM, d[i]);
            SS = PM / TM;
            P = size / PM;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Calc(comboBox1.SelectedIndex, Convert.ToInt32(textBox1.Text));
                if (PM != 0)
                {
                    textBox2.Text = String.Format("{0:0.00}", PM);
                    textBox3.Text = String.Format("{0:0}", TM) + " годин";
                    textBox4.Text = String.Format("{0:0}", SS);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
