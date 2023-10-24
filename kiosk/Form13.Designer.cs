namespace WinFormsApp2
{
    partial class Form13
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
            btnOpen=new System.Windows.Forms.Button();
            btnFont=new System.Windows.Forms.Button();
            btnSave=new System.Windows.Forms.Button();
            btnColor=new System.Windows.Forms.Button();
            textBox1=new System.Windows.Forms.TextBox();
            colorDialog1=new System.Windows.Forms.ColorDialog();
            fontDialog1=new System.Windows.Forms.FontDialog();
            openFileDialog1=new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1=new System.Windows.Forms.SaveFileDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location=new System.Drawing.Point(12, 12);
            btnOpen.Name="btnOpen";
            btnOpen.Size=new System.Drawing.Size(119, 46);
            btnOpen.TabIndex=0;
            btnOpen.Text="열기";
            btnOpen.UseVisualStyleBackColor=true;
            btnOpen.Click+=btnOpen_Click;
            // 
            // btnFont
            // 
            btnFont.Location=new System.Drawing.Point(137, 12);
            btnFont.Name="btnFont";
            btnFont.Size=new System.Drawing.Size(119, 46);
            btnFont.TabIndex=1;
            btnFont.Text="폰트설정";
            btnFont.UseVisualStyleBackColor=true;
            btnFont.Click+=btnFont_Click;
            // 
            // btnSave
            // 
            btnSave.Location=new System.Drawing.Point(12, 59);
            btnSave.Name="btnSave";
            btnSave.Size=new System.Drawing.Size(119, 46);
            btnSave.TabIndex=2;
            btnSave.Text="저장";
            btnSave.UseVisualStyleBackColor=true;
            btnSave.Click+=btnSave_Click;
            // 
            // btnColor
            // 
            btnColor.Location=new System.Drawing.Point(137, 59);
            btnColor.Name="btnColor";
            btnColor.Size=new System.Drawing.Size(119, 46);
            btnColor.TabIndex=3;
            btnColor.Text="색상설정";
            btnColor.UseVisualStyleBackColor=true;
            btnColor.Click+=btnColor_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new System.Drawing.Point(12, 121);
            textBox1.Multiline=true;
            textBox1.Name="textBox1";
            textBox1.Size=new System.Drawing.Size(244, 276);
            textBox1.TabIndex=4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            // 
            // Form13
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnColor);
            Controls.Add(btnSave);
            Controls.Add(btnFont);
            Controls.Add(btnOpen);
            Name="Form13";
            Text="Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}