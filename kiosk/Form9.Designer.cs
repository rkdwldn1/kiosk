namespace WinFormsApp2
{
    partial class Form9
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
            components=new System.ComponentModel.Container();
            menuStrip1=new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1=new System.Windows.Forms.ToolStripMenuItem();
            ToolStripNew=new System.Windows.Forms.ToolStripMenuItem();
            toolStripOpen=new System.Windows.Forms.ToolStripMenuItem();
            toolStripSave=new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1=new System.Windows.Forms.ToolStripMenuItem();
            toolStripExit=new System.Windows.Forms.ToolStripMenuItem();
            프로그램ToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuCa=new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuPi=new System.Windows.Forms.ToolStripMenuItem();
            색상ToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            colorToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            frontToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            backToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            fontToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            lbResult=new System.Windows.Forms.Label();
            contextMenuStrip1=new System.Windows.Forms.ContextMenuStrip(components);
            ToolStripCopy=new System.Windows.Forms.ToolStripMenuItem();
            ToolStripPaste=new System.Windows.Forms.ToolStripMenuItem();
            ToolStripCut=new System.Windows.Forms.ToolStripMenuItem();
            button1=new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, 프로그램ToolStripMenuItem, 색상ToolStripMenuItem });
            menuStrip1.Location=new System.Drawing.Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripNew, toolStripOpen, toolStripSave, toolStripSeparator1, toolStripExit });
            toolStripMenuItem1.Name="toolStripMenuItem1";
            toolStripMenuItem1.Size=new System.Drawing.Size(43, 20);
            toolStripMenuItem1.Text="파일";
            // 
            // ToolStripNew
            // 
            ToolStripNew.Name="ToolStripNew";
            ToolStripNew.Size=new System.Drawing.Size(141, 22);
            ToolStripNew.Text="새로만들기";
            ToolStripNew.Click+=ToolStripNew_Click;
            // 
            // toolStripOpen
            // 
            toolStripOpen.Name="toolStripOpen";
            toolStripOpen.ShortcutKeys=System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.O;
            toolStripOpen.Size=new System.Drawing.Size(141, 22);
            toolStripOpen.Text="열기";
            toolStripOpen.Click+=toolStripOpen_Click;
            // 
            // toolStripSave
            // 
            toolStripSave.Name="toolStripSave";
            toolStripSave.ShortcutKeys=System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.S;
            toolStripSave.Size=new System.Drawing.Size(141, 22);
            toolStripSave.Text="저장";
            toolStripSave.Click+=toolStripSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name="toolStripSeparator1";
            toolStripSeparator1.Size=new System.Drawing.Size(141, 22);
            toolStripSeparator1.Text="-";
            // 
            // toolStripExit
            // 
            toolStripExit.Name="toolStripExit";
            toolStripExit.Size=new System.Drawing.Size(141, 22);
            toolStripExit.Text="종료";
            toolStripExit.Click+=toolStripExit_Click;
            // 
            // 프로그램ToolStripMenuItem
            // 
            프로그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuCa, ToolStripMenuPi });
            프로그램ToolStripMenuItem.Name="프로그램ToolStripMenuItem";
            프로그램ToolStripMenuItem.Size=new System.Drawing.Size(67, 20);
            프로그램ToolStripMenuItem.Text="프로그램";
            // 
            // toolStripMenuCa
            // 
            toolStripMenuCa.Name="toolStripMenuCa";
            toolStripMenuCa.Size=new System.Drawing.Size(110, 22);
            toolStripMenuCa.Text="계산기";
            toolStripMenuCa.Click+=toolStripMenuCa_Click;
            // 
            // ToolStripMenuPi
            // 
            ToolStripMenuPi.Name="ToolStripMenuPi";
            ToolStripMenuPi.Size=new System.Drawing.Size(110, 22);
            ToolStripMenuPi.Text="그림판";
            ToolStripMenuPi.Click+=ToolStripMenuPi_Click;
            // 
            // 색상ToolStripMenuItem
            // 
            색상ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { colorToolStripMenuItem, fontToolStripMenuItem });
            색상ToolStripMenuItem.Name="색상ToolStripMenuItem";
            색상ToolStripMenuItem.Size=new System.Drawing.Size(43, 20);
            색상ToolStripMenuItem.Text="색상";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { frontToolStripMenuItem, backToolStripMenuItem });
            colorToolStripMenuItem.Name="colorToolStripMenuItem";
            colorToolStripMenuItem.Size=new System.Drawing.Size(180, 22);
            colorToolStripMenuItem.Text="Color";
            // 
            // frontToolStripMenuItem
            // 
            frontToolStripMenuItem.Name="frontToolStripMenuItem";
            frontToolStripMenuItem.Size=new System.Drawing.Size(180, 22);
            frontToolStripMenuItem.Text="Front";
            frontToolStripMenuItem.Click+=frontToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name="backToolStripMenuItem";
            backToolStripMenuItem.Size=new System.Drawing.Size(180, 22);
            backToolStripMenuItem.Text="Back";
            backToolStripMenuItem.Click+=backToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name="fontToolStripMenuItem";
            fontToolStripMenuItem.Size=new System.Drawing.Size(180, 22);
            fontToolStripMenuItem.Text="Font";
            fontToolStripMenuItem.Click+=fontToolStripMenuItem_Click;
            // 
            // lbResult
            // 
            lbResult.AutoSize=true;
            lbResult.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbResult.Location=new System.Drawing.Point(33, 181);
            lbResult.Name="lbResult";
            lbResult.Size=new System.Drawing.Size(144, 21);
            lbResult.TabIndex=1;
            lbResult.Text="결과를 출력합니다";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripCopy, ToolStripPaste, ToolStripCut });
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new System.Drawing.Size(123, 70);
            // 
            // ToolStripCopy
            // 
            ToolStripCopy.Name="ToolStripCopy";
            ToolStripCopy.Size=new System.Drawing.Size(122, 22);
            ToolStripCopy.Text="복사";
            ToolStripCopy.Click+=ToolStripCopy_Click;
            // 
            // ToolStripPaste
            // 
            ToolStripPaste.Name="ToolStripPaste";
            ToolStripPaste.Size=new System.Drawing.Size(122, 22);
            ToolStripPaste.Text="붙여넣기";
            ToolStripPaste.Click+=ToolStripPaste_Click;
            // 
            // ToolStripCut
            // 
            ToolStripCut.Name="ToolStripCut";
            ToolStripCut.Size=new System.Drawing.Size(122, 22);
            ToolStripCut.Text="잘라내기";
            ToolStripCut.Click+=ToolStripCut_Click;
            // 
            // button1
            // 
            button1.Location=new System.Drawing.Point(410, 127);
            button1.Name="button1";
            button1.Size=new System.Drawing.Size(212, 133);
            button1.TabIndex=2;
            button1.Text="button1";
            button1.UseVisualStyleBackColor=true;
            // 
            // Form9
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            ContextMenuStrip=contextMenuStrip1;
            Controls.Add(button1);
            Controls.Add(lbResult);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="Form9";
            Text="Form9";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ToolStripMenuItem 프로그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCa;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuPi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCut;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}