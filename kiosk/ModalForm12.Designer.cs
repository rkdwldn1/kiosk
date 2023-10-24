namespace WinFormsApp2
{
    partial class ModalForm12
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
            menuStrip1=new System.Windows.Forms.MenuStrip();
            파일ToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            열기ToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            닫기ToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            button1=new System.Windows.Forms.Button();
            button2=new System.Windows.Forms.Button();
            button3=new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 파일ToolStripMenuItem });
            menuStrip1.Location=new System.Drawing.Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 열기ToolStripMenuItem, 닫기ToolStripMenuItem });
            파일ToolStripMenuItem.Name="파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size=new System.Drawing.Size(43, 20);
            파일ToolStripMenuItem.Text="파일";
            // 
            // 열기ToolStripMenuItem
            // 
            열기ToolStripMenuItem.Name="열기ToolStripMenuItem";
            열기ToolStripMenuItem.Size=new System.Drawing.Size(122, 22);
            열기ToolStripMenuItem.Text="모달열기";
            열기ToolStripMenuItem.Click+=열기ToolStripMenuItem_Click;
            // 
            // 닫기ToolStripMenuItem
            // 
            닫기ToolStripMenuItem.Name="닫기ToolStripMenuItem";
            닫기ToolStripMenuItem.Size=new System.Drawing.Size(122, 22);
            닫기ToolStripMenuItem.Text="닫기";
            닫기ToolStripMenuItem.Click+=닫기ToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.DialogResult=System.Windows.Forms.DialogResult.OK;
            button1.Location=new System.Drawing.Point(515, 65);
            button1.Name="button1";
            button1.Size=new System.Drawing.Size(88, 42);
            button1.TabIndex=1;
            button1.Text="OK";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.DialogResult=System.Windows.Forms.DialogResult.Yes;
            button2.Location=new System.Drawing.Point(515, 147);
            button2.Name="button2";
            button2.Size=new System.Drawing.Size(88, 38);
            button2.TabIndex=2;
            button2.Text="YES";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.DialogResult=System.Windows.Forms.DialogResult.No;
            button3.Location=new System.Drawing.Point(514, 220);
            button3.Name="button3";
            button3.Size=new System.Drawing.Size(88, 41);
            button3.TabIndex=3;
            button3.Text="NO";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // ModalForm12
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="ModalForm12";
            Text="ModalForm12";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}