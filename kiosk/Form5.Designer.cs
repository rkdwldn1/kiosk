namespace WinFormsApp2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox1=new System.Windows.Forms.PictureBox();
            btnLocation=new System.Windows.Forms.Button();
            pictureBox2=new System.Windows.Forms.PictureBox();
            rb1=new System.Windows.Forms.RadioButton();
            rb2=new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new System.Drawing.Point(44, 40);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new System.Drawing.Size(235, 176);
            pictureBox1.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // btnLocation
            // 
            btnLocation.Location=new System.Drawing.Point(67, 367);
            btnLocation.Name="btnLocation";
            btnLocation.Size=new System.Drawing.Size(75, 23);
            btnLocation.TabIndex=1;
            btnLocation.Text="좌표 이동";
            btnLocation.UseVisualStyleBackColor=true;
            btnLocation.Click+=btnLocation_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location=new System.Drawing.Point(330, 40);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new System.Drawing.Size(243, 176);
            pictureBox2.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=2;
            pictureBox2.TabStop=false;
            // 
            // rb1
            // 
            rb1.AutoSize=true;
            rb1.Location=new System.Drawing.Point(622, 75);
            rb1.Name="rb1";
            rb1.Size=new System.Drawing.Size(49, 19);
            rb1.TabIndex=3;
            rb1.TabStop=true;
            rb1.Text="삭제";
            rb1.UseVisualStyleBackColor=true;
            rb1.CheckedChanged+=rb1_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize=true;
            rb2.Location=new System.Drawing.Point(622, 129);
            rb2.Name="rb2";
            rb2.Size=new System.Drawing.Size(49, 19);
            rb2.TabIndex=4;
            rb2.TabStop=true;
            rb2.Text="복제";
            rb2.UseVisualStyleBackColor=true;
            rb2.CheckedChanged+=rb2_CheckedChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(pictureBox2);
            Controls.Add(btnLocation);
            Controls.Add(pictureBox1);
            Name="Form5";
            Text="Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
    }
}