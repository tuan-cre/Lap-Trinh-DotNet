﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            double tong = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    tong += 1.0/i;
                }
            }
            txtS.Text = tong.ToString();
        }
    }
}
