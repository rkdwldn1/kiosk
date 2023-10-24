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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName+"파일을 엽니다.";
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter="All file(*.*)|(*.*)";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName+"파일을 저장합니다.";
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()!=DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
