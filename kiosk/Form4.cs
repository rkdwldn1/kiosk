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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e) //추가
        {



        }

        private void btnDelete_Click(object sender, EventArgs e) //삭제 
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e) //확장
        {
            treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e) //축소
        {
            treeView1.CollapseAll();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("SLT");


            TreeNode treeNode = new TreeNode("관리본부");
            treeNode.Nodes.Add("인사팀");
            treeNode.Nodes.Add("총무팀");
            treeNode.Nodes.Add("회계팀");

            TreeNode tn2 = new TreeNode("관리본부");

            tn2.Nodes.Add("인사팀");
            tn2.Nodes.Add("총무팀");

            treeNode.Nodes.Add(tn2);


            TreeNode tn3 = new TreeNode("IT 사업부");
            tn3.Nodes.Add("AI팀");
            tn3.Nodes.Add("loT팀");
            TreeNode tn4 = new TreeNode("연구소");
            tn4.Nodes.Add("소프트웨어팀");
            tn4.Nodes.Add("하드웨어팀");



            treeView1.Nodes.Add(tn);
            treeView1.Nodes.Add(treeNode);

            treeView1.Nodes.Add(tn3);
            treeView1.Nodes.Add(tn4);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
