namespace WinFormsApp2
{
    partial class Modaless
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
            모달리스대화상자=new System.Windows.Forms.ToolStripMenuItem();
            모달리스대화상자ToolStripMenuItem1=new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 모달리스대화상자 });
            menuStrip1.Location=new System.Drawing.Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // 모달리스대화상자
            // 
            모달리스대화상자.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { 모달리스대화상자ToolStripMenuItem1 });
            모달리스대화상자.Name="모달리스대화상자";
            모달리스대화상자.Size=new System.Drawing.Size(119, 20);
            모달리스대화상자.Text="모달리스 대화상자";
            모달리스대화상자.Click+=모달리스대화상자_Click;
            // 
            // 모달리스대화상자ToolStripMenuItem1
            // 
            모달리스대화상자ToolStripMenuItem1.Name="모달리스대화상자ToolStripMenuItem1";
            모달리스대화상자ToolStripMenuItem1.Size=new System.Drawing.Size(180, 22);
            모달리스대화상자ToolStripMenuItem1.Text="모달리스 대화상자";
            // 
            // Modaless
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="Modaless";
            Text="Modaless";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 모달리스대화상자;
        private System.Windows.Forms.ToolStripMenuItem 모달리스대화상자ToolStripMenuItem1;
    }
}