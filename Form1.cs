using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);
            double delta, x1, x2;
            if (a == 0)
                if (b != 0)
                {
                    lblKQ.Text = "PT co nghiem duy nhat x=" + -c / b;
                }
                else
                {
                    if (c != 0)
                    {
                        lblKQ.Text = "PT vo nghiem\n";
                    }
                    else
                    {
                        lblKQ.Text = "PT vo so nghiem\n";
                    }
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblKQ.Text = "PT vo nghiem\n";
                }
                else if (delta == 0)
                {
                    lblKQ.Text = "PT co nghiem kep x1 = x2 = " + (double)-b / (2 * a);
                }
                else
                {
                    x1 = ((double)-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = ((double)-b - Math.Sqrt(delta)) / (2 * a);
                    lblKQ.Text = "PT co hai nghiem\n " + "x1 = " + x1 + " \nx2 = " + x2;

                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtA.Text = tbA.Value.ToString();
        }

        private void tbB_Scroll(object sender, EventArgs e)
        {
            txtB.Text = tbB.Value.ToString();
        }

        private void tbC_Scroll(object sender, EventArgs e)
        {
            txtC.Text = tbC.Value.ToString();
        }
    }
       
           
}









