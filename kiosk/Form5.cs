﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            pictureBox1.Location =  new Point(80, 0);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked==true)
            {
                pictureBox2.Image = null;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked==true)
            {
                pictureBox2.Image = pictureBox1.Image;

            }
        }
    }
}
