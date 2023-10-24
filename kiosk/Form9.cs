using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            lbResult.Text = "새 파일을 만듭니다.";
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            lbResult.Text = "파일을 엽니다.";
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            lbResult.Text = "파일을 저장합니다.";
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuCa_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void ToolStripMenuPi_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void ToolStripCopy_Click(object sender, EventArgs e) //복사
        {
            lbResult.Text="복사 되었습니다.";
        }

        private void ToolStripPaste_Click(object sender, EventArgs e) //붙여넣기
        {
            lbResult.Text="붙여넣기 되었습니다";
        }

        private void ToolStripCut_Click(object sender, EventArgs e) //잘라내기
        {
            lbResult.Text="잘라내기 되었습니다.";
        }

        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)           
                button1.ForeColor =dlg.Color;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                button1.BackColor =dlg.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
                button1.Font =dlg.Font;
        }
    }
}
