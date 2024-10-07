using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPhuongTrinhBac2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtHeSoA.Text);
            int b = int.Parse(txtHeSoB.Text);
            int c = int.Parse(txtHeSoC.Text);

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                txtKetQua.Text = "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txtKetQua.Text = "Phương trình có nghiệm kép x1 = x2 = " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x1 = Math.Round(x1, 2);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = Math.Round(x2, 2);
                txtKetQua.Text = "Phương trình có 2 nghiệm phân biệt x1 = " + x1 + ", x2 = " + x2;
            }
        }
    }
}
