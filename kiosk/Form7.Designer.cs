namespace WinFormsApp2
{
    partial class Form7
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
            tabControl1=new System.Windows.Forms.TabControl();
            tabPage1=new System.Windows.Forms.TabPage();
            btnsum1=new System.Windows.Forms.Button();
            btnCollapseAll=new System.Windows.Forms.Button();
            btnInsert=new System.Windows.Forms.Button();
            btnClear=new System.Windows.Forms.Button();
            treeView1=new System.Windows.Forms.TreeView();
            tabPage2=new System.Windows.Forms.TabPage();
            button2=new System.Windows.Forms.Button();
            label2=new System.Windows.Forms.Label();
            tabPage3=new System.Windows.Forms.TabPage();
            btnsum=new System.Windows.Forms.Button();
            btn4=new System.Windows.Forms.Button();
            btn3=new System.Windows.Forms.Button();
            btn2=new System.Windows.Forms.Button();
            treeView2=new System.Windows.Forms.TreeView();
            tb1=new System.Windows.Forms.TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location=new System.Drawing.Point(0, 0);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new System.Drawing.Size(827, 438);
            tabControl1.TabIndex=0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnsum1);
            tabPage1.Controls.Add(btnCollapseAll);
            tabPage1.Controls.Add(btnInsert);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(treeView1);
            tabPage1.Location=new System.Drawing.Point(4, 24);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new System.Windows.Forms.Padding(3);
            tabPage1.Size=new System.Drawing.Size(819, 410);
            tabPage1.TabIndex=0;
            tabPage1.Text="C언어";
            tabPage1.UseVisualStyleBackColor=true;
            tabPage1.Click+=tabPage1_Click;
            // 
            // btnsum1
            // 
            btnsum1.Location=new System.Drawing.Point(467, 127);
            btnsum1.Name="btnsum1";
            btnsum1.Size=new System.Drawing.Size(75, 60);
            btnsum1.TabIndex=8;
            btnsum1.Text="삽입";
            btnsum1.UseVisualStyleBackColor=true;
            btnsum1.Click+=btnsum1_Click;
            // 
            // btnCollapseAll
            // 
            btnCollapseAll.Location=new System.Drawing.Point(595, 219);
            btnCollapseAll.Name="btnCollapseAll";
            btnCollapseAll.Size=new System.Drawing.Size(75, 66);
            btnCollapseAll.TabIndex=7;
            btnCollapseAll.Text="축소";
            btnCollapseAll.UseVisualStyleBackColor=true;
            btnCollapseAll.Click+=btnCollapseAll_Click_1;
            // 
            // btnInsert
            // 
            btnInsert.Location=new System.Drawing.Point(467, 219);
            btnInsert.Name="btnInsert";
            btnInsert.Size=new System.Drawing.Size(75, 66);
            btnInsert.TabIndex=6;
            btnInsert.Text="확장";
            btnInsert.UseVisualStyleBackColor=true;
            btnInsert.Click+=btnInsert_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location=new System.Drawing.Point(595, 127);
            btnClear.Name="btnClear";
            btnClear.Size=new System.Drawing.Size(75, 67);
            btnClear.TabIndex=5;
            btnClear.Text="삭제";
            btnClear.UseVisualStyleBackColor=true;
            btnClear.Click+=btnClear_Click_1;
            // 
            // treeView1
            // 
            treeView1.Location=new System.Drawing.Point(8, 6);
            treeView1.Name="treeView1";
            treeView1.Size=new System.Drawing.Size(405, 384);
            treeView1.TabIndex=3;
            treeView1.AfterSelect+=treeView1_AfterSelect;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location=new System.Drawing.Point(4, 24);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new System.Windows.Forms.Padding(3);
            tabPage2.Size=new System.Drawing.Size(819, 410);
            tabPage2.TabIndex=1;
            tabPage2.Text="C++";
            tabPage2.UseVisualStyleBackColor=true;
            // 
            // button2
            // 
            button2.Location=new System.Drawing.Point(125, 101);
            button2.Name="button2";
            button2.Size=new System.Drawing.Size(75, 23);
            button2.TabIndex=1;
            button2.Text="C++";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new System.Drawing.Point(146, 164);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(39, 15);
            label2.TabIndex=0;
            label2.Text="label2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnsum);
            tabPage3.Controls.Add(btn4);
            tabPage3.Controls.Add(btn3);
            tabPage3.Controls.Add(btn2);
            tabPage3.Controls.Add(treeView2);
            tabPage3.Location=new System.Drawing.Point(4, 24);
            tabPage3.Name="tabPage3";
            tabPage3.Size=new System.Drawing.Size(819, 410);
            tabPage3.TabIndex=2;
            tabPage3.Text="C#";
            tabPage3.UseVisualStyleBackColor=true;
            // 
            // btnsum
            // 
            btnsum.Location=new System.Drawing.Point(459, 139);
            btnsum.Name="btnsum";
            btnsum.Size=new System.Drawing.Size(75, 62);
            btnsum.TabIndex=1;
            btnsum.Text="삽입";
            btnsum.UseVisualStyleBackColor=true;
            btnsum.Click+=btnsum_Click;
            // 
            // btn4
            // 
            btn4.Location=new System.Drawing.Point(604, 242);
            btn4.Name="btn4";
            btn4.Size=new System.Drawing.Size(75, 60);
            btn4.TabIndex=8;
            btn4.Text="축소";
            btn4.UseVisualStyleBackColor=true;
            btn4.Click+=btn4_Click;
            // 
            // btn3
            // 
            btn3.Location=new System.Drawing.Point(459, 242);
            btn3.Name="btn3";
            btn3.Size=new System.Drawing.Size(75, 60);
            btn3.TabIndex=7;
            btn3.Text="확장";
            btn3.UseVisualStyleBackColor=true;
            btn3.Click+=btn3_Click;
            // 
            // btn2
            // 
            btn2.Location=new System.Drawing.Point(604, 139);
            btn2.Name="btn2";
            btn2.Size=new System.Drawing.Size(75, 64);
            btn2.TabIndex=6;
            btn2.Text="삭제";
            btn2.UseVisualStyleBackColor=true;
            btn2.Click+=btn2_Click;
            // 
            // treeView2
            // 
            treeView2.Location=new System.Drawing.Point(8, 3);
            treeView2.Name="treeView2";
            treeView2.Size=new System.Drawing.Size(399, 404);
            treeView2.TabIndex=0;
            // 
            // tb1
            // 
            tb1.Location=new System.Drawing.Point(440, 96);
            tb1.Name="tb1";
            tb1.Size=new System.Drawing.Size(295, 23);
            tb1.TabIndex=0;
            // 
            // Form7
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(1138, 658);
            Controls.Add(tb1);
            Controls.Add(tabControl1);
            Name="Form7";
            Text="Form7";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnsum1;
    }
}