namespace WinFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1=new System.Windows.Forms.TreeView();
            tbNode=new System.Windows.Forms.TextBox();
            btnAdd=new System.Windows.Forms.Button();
            btnDelete=new System.Windows.Forms.Button();
            btnExpandAll=new System.Windows.Forms.Button();
            btnCollapseAll=new System.Windows.Forms.Button();
            btnClick=new System.Windows.Forms.Button();
            btnClear=new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location=new System.Drawing.Point(29, 23);
            treeView1.Name="treeView1";
            treeView1.Size=new System.Drawing.Size(502, 398);
            treeView1.TabIndex=0;
            // 
            // tbNode
            // 
            tbNode.Location=new System.Drawing.Point(573, 23);
            tbNode.Name="tbNode";
            tbNode.Size=new System.Drawing.Size(189, 23);
            tbNode.TabIndex=1;
            // 
            // btnAdd
            // 
            btnAdd.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location=new System.Drawing.Point(606, 188);
            btnAdd.Name="btnAdd";
            btnAdd.Size=new System.Drawing.Size(131, 32);
            btnAdd.TabIndex=2;
            btnAdd.Text="추가";
            btnAdd.UseVisualStyleBackColor=true;
            btnAdd.Click+=btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location=new System.Drawing.Point(606, 250);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new System.Drawing.Size(131, 37);
            btnDelete.TabIndex=3;
            btnDelete.Text="삭제";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // btnExpandAll
            // 
            btnExpandAll.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExpandAll.Location=new System.Drawing.Point(606, 307);
            btnExpandAll.Name="btnExpandAll";
            btnExpandAll.Size=new System.Drawing.Size(131, 37);
            btnExpandAll.TabIndex=4;
            btnExpandAll.Text="확장";
            btnExpandAll.UseVisualStyleBackColor=true;
            btnExpandAll.Click+=btnExpandAll_Click;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCollapseAll.Location=new System.Drawing.Point(606, 363);
            btnCollapseAll.Name="btnCollapseAll";
            btnCollapseAll.Size=new System.Drawing.Size(131, 35);
            btnCollapseAll.TabIndex=5;
            btnCollapseAll.Text="축소";
            btnCollapseAll.UseVisualStyleBackColor=true;
            btnCollapseAll.Click+=btnCollapseAll_Click;
            // 
            // btnClick
            // 
            btnClick.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClick.Location=new System.Drawing.Point(606, 68);
            btnClick.Name="btnClick";
            btnClick.Size=new System.Drawing.Size(131, 32);
            btnClick.TabIndex=6;
            btnClick.Text="클릭";
            btnClick.UseVisualStyleBackColor=true;
            btnClick.Click+=btnClick_Click;
            // 
            // btnClear
            // 
            btnClear.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location=new System.Drawing.Point(606, 124);
            btnClear.Name="btnClear";
            btnClear.Size=new System.Drawing.Size(131, 31);
            btnClear.TabIndex=7;
            btnClear.Text="삭제";
            btnClear.UseVisualStyleBackColor=true;
            btnClear.Click+=btnClear_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnClick);
            Controls.Add(btnCollapseAll);
            Controls.Add(btnExpandAll);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbNode);
            Controls.Add(treeView1);
            Name="Form4";
            Text="Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbNode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnClear;
    }
}