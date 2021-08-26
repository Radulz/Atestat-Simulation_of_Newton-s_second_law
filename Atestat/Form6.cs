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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static double mass = 0.0, kem = 0.0, distance = 0.0, time = 0.0, vel = 0.0, H = 0.0, pem = 0.0;
        private void button1_Click(object sender, EventArgs e)
        {
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
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form7 = new Form7();
            form7.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && radioButton1.Checked)
            {
                MessageBox.Show("Please enter a value for mass");
                radioButton1.Checked = false;
            }
            else if (radioButton1.Checked)
            {
                mass = Convert.ToDouble(textBox1.Text);
                kem = (Math.Pow(Form4.vmax, 2) * mass) / 2;
                decimal x = 0, s = 0;
                x = Convert.ToDecimal(kem);
                s = Math.Round(x, 2);
                label1.Text = Convert.ToString(s);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox2.Text == "") && radioButton2.Checked)
            {
                MessageBox.Show("Please enter a value for mass and one for distance");
                radioButton2.Checked = false;
            }
            else if (radioButton2.Checked)
            {
                mass = Convert.ToDouble(textBox1.Text);
                distance = Convert.ToDouble(textBox2.Text);
                H = Math.Sin((Form4.Angle * Math.PI) / 180) * Form4.Distance;
                pem = 10 * mass * H;
                double h = Math.Sin((Form4.Angle * Math.PI) / 180) * distance;
                double pex = 10 * mass * h;
                double kex = pem - pex;
                decimal x1 = 0, x2 = 0, s1 = 0, s2 = 0;
                x1 = Convert.ToDecimal(kex);
                s1 = Math.Round(x1, 2);
                x2 = Convert.ToDecimal(pex);
                s2 = Math.Round(x2, 2);
                label2.Text = Convert.ToString(s1);
                label9.Text = Convert.ToString(s2);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox4.Text == "") && radioButton3.Checked) 
            {
                MessageBox.Show("Please enter a value for mass and one for time");
                radioButton3.Checked = false;
            }
            else if(radioButton3.Checked)
            {
                mass = Convert.ToDouble(textBox1.Text);
                time = Convert.ToDouble(textBox4.Text);
                H = Math.Sin((Form4.Angle * Math.PI) / 180) * Form4.Distance;
                pem = 10 * mass * H;
                double d = 10 * (Math.Sin((Form4.Angle * Math.PI) / 180) * Math.Pow(time, 2)) / 2;
                double h = Math.Sin((Form4.Angle * Math.PI) / 180) * d;
                double pet = 10 * mass * h, ket = pem - pet;
                decimal x1 = 0, x2 = 0, s1 = 0, s2 = 0;
                x1 = Convert.ToDecimal(ket);
                s1 = Math.Round(x1, 2);
                x2 = Convert.ToDecimal(pet);
                s2 = Math.Round(x2, 2);
                label3.Text = Convert.ToString(s1);
                label10.Text = Convert.ToString(s2);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "" && radioButton4.Checked) 
            {
                MessageBox.Show("Please enter a value for time");
                radioButton4.Checked = false;
            }
            else if(radioButton4.Checked)
            {
                time = Convert.ToDouble(textBox4.Text);
                double v = Form4.Acc * time;
                decimal x1 = 0, s1 = 0;
                x1 = Convert.ToDecimal(v);
                s1 = Math.Round(x1, 2);
                label4.Text = Convert.ToString(s1);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && radioButton5.Checked) 
            {
                MessageBox.Show("Please enter a value for distance");
                radioButton5.Checked = false;
            }
            else if(radioButton5.Checked)
            {
                distance = Convert.ToDouble(textBox2.Text);
                double v = Math.Sqrt(2 * Form4.Acc * distance);
                decimal x1 = 0, s1 = 0;
                x1 = Convert.ToDecimal(v);
                s1 = Math.Round(x1, 2);
                label5.Text = Convert.ToString(s1);

            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox3.Text==""&&radioButton6.Checked)
            {
                MessageBox.Show("Please enter a value for velocity");
                radioButton6.Checked = false;
            }
            else if(radioButton6.Checked)
            {
                vel = Convert.ToDouble(textBox3.Text);
                double t = vel / Form4.Acc;
                decimal x1 = 0, s1 = 0;
                x1 = Convert.ToDecimal(t);
                s1 = Math.Round(x1, 2);
                label6.Text = Convert.ToString(s1);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "" && radioButton7.Checked)
            {
                MessageBox.Show("Please enter a value for velocity");
                radioButton7.Checked = false;
            }
            else if(radioButton7.Checked)
            {
                vel = Convert.ToDouble(textBox3.Text);
                double d = Math.Pow(vel, 2) / (2 * Form4.Acc);
                decimal x1 = 0, s1 = 0;
                x1 = Convert.ToDecimal(d);
                s1 = Math.Round(x1, 2);
                label7.Text = Convert.ToString(s1);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox2.Text==""&&radioButton8.Checked)
            {
                MessageBox.Show("Please enter a value for distance");
                radioButton8.Checked = false;
            }
            else if(radioButton8.Checked)
            {
                distance = Convert.ToDouble(textBox2.Text);
                double v = Math.Sqrt(2 * Form4.Acc * distance);
                double t = v / Form4.Acc;
                decimal x1 = 0, s1 = 0;
                x1 = Convert.ToDecimal(t);
                s1 = Math.Round(x1, 2);
                label8.Text = Convert.ToString(s1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //velocity
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mass
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //time
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //distance
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
