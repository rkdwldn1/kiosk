namespace WinFormsApp2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            imageList1=new System.Windows.Forms.ImageList(components);
            button1=new System.Windows.Forms.Button();
            button2=new System.Windows.Forms.Button();
            label1=new System.Windows.Forms.Label();
            label2=new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth=System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList1.ImageStream=(System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor=System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "강쥐1.jpg");
            imageList1.Images.SetKeyName(1, "강쥐2.jpg");
            imageList1.Images.SetKeyName(2, "강쥐3.jpg");
            imageList1.Images.SetKeyName(3, "강쥐4.jpg");
            imageList1.Images.SetKeyName(4, "강쥐5.jpg");
            // 
            // button1
            // 
            button1.ImageKey="강쥐5.jpg";
            button1.ImageList=imageList1;
            button1.Location=new System.Drawing.Point(79, 212);
            button1.Name="button1";
            button1.Size=new System.Drawing.Size(150, 150);
            button1.TabIndex=0;
            button1.Text="ㅣ";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.ImageKey="강쥐1.jpg";
            button2.ImageList=imageList1;
            button2.Location=new System.Drawing.Point(400, 212);
            button2.Name="button2";
            button2.Size=new System.Drawing.Size(150, 150);
            button2.TabIndex=1;
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new System.Drawing.Point(400, 393);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(12, 15);
            label1.TabIndex=2;
            label1.Text="-";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new System.Drawing.Point(79, 393);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(12, 15);
            label2.TabIndex=3;
            label2.Text="-";
            // 
            // Form6
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name="Form6";
            Text="Form6";
            Paint+=Form6_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}