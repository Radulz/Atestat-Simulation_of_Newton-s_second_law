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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        
        public void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Form4.Distance);
            label2.Text = Convert.ToString(Form4.Angle);
            label3.Text = Convert.ToString(Form4.Miu);
            label12.Text = Convert.ToString(Form4.s);
            label20.Text = Convert.ToString(Form4.sv);
            label23.Text = Convert.ToString(Form4.st);
            label15.Text = Convert.ToString(Form4.sts);
            label16.Text = Convert.ToString(Form4.sds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            Form1 form1 = new Form1();
            form6.TopLevel = false;
            form6.FormBorderStyle = FormBorderStyle.None;
            form6.WindowState = FormWindowState.Maximized;
            form1.panel8.Controls.Add(form6);
            form1.Show();
            form6.Show();

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
