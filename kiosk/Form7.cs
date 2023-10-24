using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e) //추가 버튼
        {
            

        }

        private void btnClear_Click(object sender, EventArgs e) //삭제버튼
        {

        }

        private void btnInsert_Click(object sender, EventArgs e) //확장버튼
        {

        }

        private void btnCollapseAll_Click(object sender, EventArgs e) //축소버튼
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("C언어");

            TreeNode treeNode = new TreeNode("조건문");
            treeNode.Nodes.Add("if-else");
            tn.Nodes.Add(treeNode);

            TreeNode tn2 = new TreeNode("반복문");

            tn2.Nodes.Add("for");
            tn2.Nodes.Add("do-While");
            tn2.Nodes.Add("While");

            treeNode.Nodes.Add(tn2);

            treeView2.Nodes.Add(tn);
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            treeView2.Nodes.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("C언어");

            TreeNode treeNode = new TreeNode("조건문");
            treeNode.Nodes.Add("if-else");
            tn.Nodes.Add(treeNode);

            TreeNode tn2 = new TreeNode("반복문");

            tn2.Nodes.Add("for");
            tn2.Nodes.Add("do-While");
            tn2.Nodes.Add("While");

            treeNode.Nodes.Add(tn2);

            treeView2.Nodes.Add(tn);

            treeView2.ExpandAll();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            treeView2.CollapseAll();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e) //삭제
        {
            treeView1.Nodes.Clear();
        }

        private void btnInsert_Click_1(object sender, EventArgs e) //확장
        {
            TreeNode tn = new TreeNode("C언어");

            TreeNode treeNode = new TreeNode("조건문");
            treeNode.Nodes.Add("if-else");
            tn.Nodes.Add(treeNode);

            TreeNode tn2 = new TreeNode("반복문");

            tn2.Nodes.Add("for");
            tn2.Nodes.Add("do-While");
            tn2.Nodes.Add("While");

            tn.Nodes.Add(tn2);

            treeView1.Nodes.Add(tn);

            treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click_1(object sender, EventArgs e) //축소
        {
            treeView1.CollapseAll();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            if (tb1.Text =="")
            {
                MessageBox.Show("텍스트 박스에 입력하세요.");
                return;
            }
            if (treeView2.SelectedNode != null)
            {
                treeView2.SelectedNode.Nodes.Add(tb1.Text);
                tb1.Text="";
            }
            else
            {
                treeView2.Nodes.Add(tb1.Text);
                tb1.Text="";
            }
        }

        private void btnsum1_Click(object sender, EventArgs e)
        {
            if (tb1.Text =="")
            {
                MessageBox.Show("텍스트 박스에 입력하세요.");
                return;
            }
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(tb1.Text);
                tb1.Text="";
            }
            else
            {
                treeView1.Nodes.Add(tb1.Text);
                tb1.Text="";
            }
        }
    }
}
