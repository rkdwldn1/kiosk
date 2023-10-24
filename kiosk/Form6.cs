using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics, 0, 0, 0);
            imageList1.Draw(e.Graphics, 140, 0, 1);
            imageList1.Draw(e.Graphics, 280, 0, 2);
            imageList1.Draw(e.Graphics, 420, 0, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "댕댕이 귀여워";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " 강쥐들 귀여워";
        }
    }
}
