using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Timers;
namespace Atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(44, 152, 224);
            label1.ForeColor = Color.White;

            label2.BackColor = Color.FromArgb(105, 105, 105);
            label2.ForeColor = Color.FromArgb(171, 171, 171);
            label3.BackColor = Color.FromArgb(105, 105, 105);
            label3.ForeColor = Color.FromArgb(171, 171, 171);
            label4.BackColor = Color.FromArgb(105, 105, 105);
            label4.ForeColor = Color.FromArgb(171, 171, 171);
            label5.BackColor = Color.FromArgb(105, 105, 105);
            label5.ForeColor = Color.FromArgb(171, 171, 171);
            label6.BackColor = Color.FromArgb(105, 105, 105);
            label6.ForeColor = Color.FromArgb(171, 171, 171);
            label7.BackColor = Color.FromArgb(105, 105, 105);
            label7.ForeColor = Color.FromArgb(171, 171, 171);

            Form form2 = new Form2();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            panel8.Controls.Add(form2);
            form2.Show();
        }

        public void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(254, 208, 114);
            label2.ForeColor = Color.White;

            label1.BackColor = Color.FromArgb(105, 105, 105);
            label1.ForeColor = Color.FromArgb(171, 171, 171);
            label3.BackColor = Color.FromArgb(105, 105, 105);
            label3.ForeColor = Color.FromArgb(171, 171, 171);
            label4.BackColor = Color.FromArgb(105, 105, 105);
            label4.ForeColor = Color.FromArgb(171, 171, 171);
            label5.BackColor = Color.FromArgb(105, 105, 105);
            label5.ForeColor = Color.FromArgb(171, 171, 171);
            label6.BackColor = Color.FromArgb(105, 105, 105);
            label6.ForeColor = Color.FromArgb(171, 171, 171);
            label7.BackColor = Color.FromArgb(105, 105, 105);
            label7.ForeColor = Color.FromArgb(171, 171, 171);


            Form form3 = new Form3();
            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.WindowState = FormWindowState.Maximized;
            panel8.Controls.Add(form3);
            form3.Show();
        }

        public void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(235, 124, 107);
            label3.ForeColor = Color.White;

            label2.BackColor = Color.FromArgb(105, 105, 105);
            label2.ForeColor = Color.FromArgb(171, 171, 171);
            label1.BackColor = Color.FromArgb(105, 105, 105);
            label1.ForeColor = Color.FromArgb(171, 171, 171);
            label4.BackColor = Color.FromArgb(105, 105, 105);
            label4.ForeColor = Color.FromArgb(171, 171, 171);
            label5.BackColor = Color.FromArgb(105, 105, 105);
            label5.ForeColor = Color.FromArgb(171, 171, 171);
            label6.BackColor = Color.FromArgb(105, 105, 105);
            label6.ForeColor = Color.FromArgb(171, 171, 171);
            label7.BackColor = Color.FromArgb(105, 105, 105);
            label7.ForeColor = Color.FromArgb(171, 171, 171);

            Form form4 = new Form4();
            form4.TopLevel = false;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.WindowState = FormWindowState.Maximized;
            panel8.Controls.Add(form4);
            form4.Show();
        }
        
        public void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(27, 184, 155);
            label4.ForeColor = Color.White;

            label2.BackColor = Color.FromArgb(105, 105, 105);
            label2.ForeColor = Color.FromArgb(171, 171, 171);
            label3.BackColor = Color.FromArgb(105, 105, 105);
            label3.ForeColor = Color.FromArgb(171, 171, 171);
            label1.BackColor = Color.FromArgb(105, 105, 105);
            label1.ForeColor = Color.FromArgb(171, 171, 171);
            label5.BackColor = Color.FromArgb(105, 105, 105);
            label5.ForeColor = Color.FromArgb(171, 171, 171);
            label6.BackColor = Color.FromArgb(105, 105, 105);
            label6.ForeColor = Color.FromArgb(171, 171, 171);
            label7.BackColor = Color.FromArgb(105, 105, 105);
            label7.ForeColor = Color.FromArgb(171, 171, 171);

            
            

            Form5 form5 = new Form5();
            form5.TopLevel = false;
            form5.FormBorderStyle = FormBorderStyle.None;
            form5.WindowState = FormWindowState.Maximized;
            panel8.Controls.Add(form5);
            form5.Show();
           

            
            
        }

        public void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(162, 82, 45);
            label5.ForeColor = Color.White;

            label2.BackColor = Color.FromArgb(105, 105, 105);
            label2.ForeColor = Color.FromArgb(171, 171, 171);
            label3.BackColor = Color.FromArgb(105, 105, 105);
            label3.ForeColor = Color.FromArgb(171, 171, 171);
            label4.BackColor = Color.FromArgb(105, 105, 105);
            label4.ForeColor = Color.FromArgb(171, 171, 171);
            label1.BackColor = Color.FromArgb(105, 105, 105);
            label1.ForeColor = Color.FromArgb(171, 171, 171);
            label6.BackColor = Color.FromArgb(105, 105, 105);
            label6.ForeColor = Color.FromArgb(171, 171, 171);
            label7.BackColor = Color.FromArgb(105, 105, 105);
            label7.ForeColor = Color.FromArgb(171, 171, 171);

            Form form8 = new Form8();
            form8.TopLevel = false;
            form8.FormBorderStyle = FormBorderStyle.None;
            form8.WindowState = FormWindowState.Maximized;
            panel8.Controls.Add(form8);
            form8.Show();
        }

        public void label7_Click(object sender, EventArgs e)
        {
            
            /*label7.BackColor = Color.FromArgb(178, 34, 34);
            label7.ForeColor = Color.White;

            label2.BackColor = Color.FromArgb(105, 105, 105);
            label2.ForeColor = Color.FromArgb(171, 171, 171);
            label3.BackColor = Color.FromArgb(105, 105, 105);
            label3.ForeColor = Color.FromArgb(171, 171, 171);
            label4.BackColor = Color.FromArgb(105, 105, 105);
            label4.ForeColor = Color.FromArgb(171, 171, 171);
            label5.BackColor = Color.FromArgb(105, 105, 105);
            label5.ForeColor = Color.FromArgb(171, 171, 171);
            label6.BackColor = Color.FromArgb(105, 105, 105);
            label6.ForeColor = Color.FromArgb(171, 171, 171);
            label1.BackColor = Color.FromArgb(105, 105, 105);
            label1.ForeColor = Color.FromArgb(171, 171, 171);*/
            Application.Exit();
           
        }

        private void m1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(255, 228, 181);
            label6.ForeColor = Color.White;

            label2.BackColor = Color.FromArgb(105, 105, 105);
            label2.ForeColor = Color.FromArgb(171, 171, 171);
            label3.BackColor = Color.FromArgb(105, 105, 105);
            label3.ForeColor = Color.FromArgb(171, 171, 171);
            label4.BackColor = Color.FromArgb(105, 105, 105);
            label4.ForeColor = Color.FromArgb(171, 171, 171);
            label5.BackColor = Color.FromArgb(105, 105, 105);
            label5.ForeColor = Color.FromArgb(171, 171, 171);
            label1.BackColor = Color.FromArgb(105, 105, 105);
            label1.ForeColor = Color.FromArgb(171, 171, 171);
            label7.BackColor = Color.FromArgb(105, 105, 105);
            label7.ForeColor = Color.FromArgb(171, 171, 171);

            Form form9 = new Form9();
            form9.TopLevel = false;
            form9.FormBorderStyle = FormBorderStyle.None;
            form9.WindowState = FormWindowState.Maximized;
            panel8.Controls.Add(form9);
            form9.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
