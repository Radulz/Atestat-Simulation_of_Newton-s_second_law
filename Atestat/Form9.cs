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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Pen pen;
                Graphics vector;
                double angle = 0;
                angle = Convert.ToInt32(textBox1.Text);
                angle = (Math.PI * angle) / 180;
                float aux = (float)Math.Tan(angle) * 210, aux1 = (float)Math.Tan(angle + Math.PI / 2) * 20, aux2 = (float)Math.Tan(angle) * 20;
                float aux3 = (float)Math.Tan(angle) * 50;
                float CentreX = 70, CentreY = 375;

                pen = new Pen(Color.Black);
                vector = CreateGraphics();

                vector.Clear(Color.FromArgb(105, 105, 105));
                //axis
                vector.DrawLine(pen, 60, CentreY, 500, CentreY);
                vector.DrawLine(pen, CentreX, 0, CentreX, CentreY + 10);
                //Plan
                vector.DrawLine(pen, CentreX, CentreY, CentreX + 210, CentreY - aux);
                vector.DrawLine(pen, CentreX + 210, CentreY - aux, CentreX + 210, CentreY);
                //Object
                vector.DrawLine(pen, CentreX + 190, CentreY - aux + aux2, CentreX + 170, CentreY - aux + aux2 + aux1);
                vector.DrawLine(pen, CentreX + 160, CentreY - aux + aux3, CentreX + 140, CentreY - aux + aux3 + aux1);
                vector.DrawLine(pen, CentreX + 170, CentreY - aux + aux2 + aux1, CentreX + 140, CentreY - aux + aux3 + aux1);
                //CentreX + 180, CentreY - aux + aux2 + aux1
            }
            else MessageBox.Show("Please enter a value for angle between 5 and 60 degrees.");

        }
    }
}
