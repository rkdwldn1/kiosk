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
    public partial class ModalForm12 : Form
    {
        public ModalForm12()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalForm12 modal1 = new ModalForm12();
            modal1.ShowDialog();
            modal1.Dispose();

            DialogResult result = modal1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK버튼이 눌러졌습니다.");
            }
            else if (result == DialogResult.Yes)
                MessageBox.Show("YES버튼이 눌러졌습니다.");
            else if (result == DialogResult.No)
                MessageBox.Show("No버튼이 눌러졌습니다.");
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) //OK
        {
            MessageBox.Show("OK버튼이 눌렸습니다.");
        }

        private void button2_Click(object sender, EventArgs e) //YES
        {
            MessageBox.Show("YES버튼이 눌렸습니다.");
        }

        private void button3_Click(object sender, EventArgs e) //NO
        {
            MessageBox.Show("NO버튼이 눌렸습니다.");
        }
    }
}
