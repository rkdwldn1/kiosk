﻿namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1=new System.Windows.Forms.NumericUpDown();
            domainUpDown1=new System.Windows.Forms.DomainUpDown();
            label1=new System.Windows.Forms.Label();
            label2=new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location=new System.Drawing.Point(74, 60);
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex=0;
            numericUpDown1.ValueChanged+=numericUpDown1_ValueChanged;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("딸기");
            domainUpDown1.Items.Add("오렌지");
            domainUpDown1.Items.Add("포도");
            domainUpDown1.Items.Add("바나나");
            domainUpDown1.Items.Add("메론");
            domainUpDown1.Location=new System.Drawing.Point(273, 60);
            domainUpDown1.Name="domainUpDown1";
            domainUpDown1.Size=new System.Drawing.Size(120, 23);
            domainUpDown1.TabIndex=1;
            domainUpDown1.Text="domainUpDown1";
            domainUpDown1.SelectedItemChanged+=domainUpDown1_SelectedItemChanged;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new System.Drawing.Point(110, 109);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(39, 15);
            label1.TabIndex=2;
            label1.Text="label1";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new System.Drawing.Point(319, 109);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(39, 15);
            label2.TabIndex=3;
            label2.Text="label2";
            // 
            // Form1
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(665, 397);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(domainUpDown1);
            Controls.Add(numericUpDown1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
