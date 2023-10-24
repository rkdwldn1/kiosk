namespace WinFormsApp2
{
    partial class Form12
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
            label1=new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(214, 166);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(299, 32);
            label1.TabIndex=0;
            label1.Text="모달리스 대화상자 입니다.";
            // 
            // Form12
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Name="Form12";
            Text="Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}