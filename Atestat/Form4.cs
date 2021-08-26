using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static double Distance , Angle , Miu;
        public static double Acc = 0.0, Acc1 = 0.0, t = 0.0, ts = 0.0, ds = 0.0, vmax = 0.0;
        public static decimal x = 0, s = 0, xv = 0, sv = 0, xt = 0, st = 0, xts = 0, sts = 0, xds = 0, sds = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Creare form nou care realizeaza calcul+colorat.
            int sw = 1;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please enter the values for each gap.");
                sw = 0;
            }
            else
            {
                Distance = Convert.ToDouble(textBox1.Text);
                Angle = Convert.ToDouble(textBox2.Text);
                Miu = Convert.ToDouble(textBox3.Text);
            }
            if (sw == 1 && (Miu == 0 || Miu > (Math.Sin((Angle * Math.PI) / 180)))) 
                MessageBox.Show("μ has to be greater than 0 and smaller than " + Math.Sin((Angle * Math.PI) / 180));
            if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") && (Miu > 0 && Miu < Math.Sin((Angle * Math.PI) / 180))) 
            {
                //Distance = Convert.ToDouble(textBox1.Text);
                //Angle = Convert.ToDouble(textBox2.Text);
               //Miu = Convert.ToDouble(textBox3.Text);

                Acc = 10 * (Math.Sin((Angle * Math.PI) / 180) - Miu * Math.Cos((Angle * Math.PI) / 180));
                x = Convert.ToDecimal(Acc);
                s = Math.Round(x, 4);

                Acc1 = Miu * 10;

                t = Math.Sqrt(2 * Distance / Acc);
                xt = Convert.ToDecimal(t);
                st = Math.Round(xt, 4);

                vmax = Acc * t;
                xv = Convert.ToDecimal(vmax);
                sv = Math.Round(xv, 4);

                ts = vmax / Acc1 + t;
                xts = Convert.ToDecimal(ts);
                sts = Math.Round(xts, 4);

                ds = Math.Pow(vmax, 2) / 2 * Acc1 + Distance;
                xds = Convert.ToDecimal(ds);
                sds = Math.Round(xds, 4);


                Form5 form5 = new Form5();
                Form1 form1 = new Form1();
                form5.TopLevel = false;
                form5.FormBorderStyle = FormBorderStyle.None;
                form5.WindowState = FormWindowState.Maximized;
                form1.panel8.Controls.Add(form5);
                form1.Show();
                form5.Show();

                form1.label4.BackColor = Color.FromArgb(27, 184, 155);
                form1.label4.ForeColor = Color.White;

                form1.label2.BackColor = Color.FromArgb(105, 105, 105);
                form1.label2.ForeColor = Color.FromArgb(171, 171, 171);
                form1.label3.BackColor = Color.FromArgb(105, 105, 105);
                form1.label3.ForeColor = Color.FromArgb(171, 171, 171);
                form1.label1.BackColor = Color.FromArgb(105, 105, 105);
                form1.label1.ForeColor = Color.FromArgb(171, 171, 171);
                form1.label5.BackColor = Color.FromArgb(105, 105, 105);
                form1.label5.ForeColor = Color.FromArgb(171, 171, 171);
                form1.label6.BackColor = Color.FromArgb(105, 105, 105);
                form1.label6.ForeColor = Color.FromArgb(171, 171, 171);
                form1.label7.BackColor = Color.FromArgb(105, 105, 105);
                form1.label7.ForeColor = Color.FromArgb(171, 171, 171);
            }
        }
    }
}
