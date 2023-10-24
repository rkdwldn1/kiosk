namespace WinFormsApp2
{
    partial class Form3
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
            label2=new System.Windows.Forms.Label();
            label3=new System.Windows.Forms.Label();
            tbName=new System.Windows.Forms.TextBox();
            tbPhone=new System.Windows.Forms.TextBox();
            tbOrg=new System.Windows.Forms.TextBox();
            btnAdd=new System.Windows.Forms.Button();
            btnDelete=new System.Windows.Forms.Button();
            btnChange=new System.Windows.Forms.Button();
            btnInsert=new System.Windows.Forms.Button();
            listView1=new System.Windows.Forms.ListView();
            chName=new System.Windows.Forms.ColumnHeader();
            chPhone=new System.Windows.Forms.ColumnHeader();
            chOrg=new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location=new System.Drawing.Point(67, 27);
            label1.Name="label1";
            label1.Size=new System.Drawing.Size(52, 21);
            label1.TabIndex=0;
            label1.Text="이름 :";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location=new System.Drawing.Point(51, 87);
            label2.Name="label2";
            label2.Size=new System.Drawing.Size(68, 21);
            label2.TabIndex=1;
            label2.Text="휴대폰 :";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location=new System.Drawing.Point(67, 147);
            label3.Name="label3";
            label3.Size=new System.Drawing.Size(52, 21);
            label3.TabIndex=2;
            label3.Text="소속 :";
            // 
            // tbName
            // 
            tbName.Location=new System.Drawing.Point(143, 29);
            tbName.Name="tbName";
            tbName.Size=new System.Drawing.Size(403, 23);
            tbName.TabIndex=3;
            tbName.TextChanged+=textBox1_TextChanged;
            // 
            // tbPhone
            // 
            tbPhone.Location=new System.Drawing.Point(143, 89);
            tbPhone.Name="tbPhone";
            tbPhone.Size=new System.Drawing.Size(403, 23);
            tbPhone.TabIndex=4;
            // 
            // tbOrg
            // 
            tbOrg.Location=new System.Drawing.Point(143, 147);
            tbOrg.Name="tbOrg";
            tbOrg.Size=new System.Drawing.Size(403, 23);
            tbOrg.TabIndex=5;
            // 
            // btnAdd
            // 
            btnAdd.Location=new System.Drawing.Point(607, 25);
            btnAdd.Name="btnAdd";
            btnAdd.Size=new System.Drawing.Size(75, 23);
            btnAdd.TabIndex=6;
            btnAdd.Text="입력";
            btnAdd.UseVisualStyleBackColor=true;
            btnAdd.Click+=btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location=new System.Drawing.Point(607, 63);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new System.Drawing.Size(75, 23);
            btnDelete.TabIndex=7;
            btnDelete.Text="삭제";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location=new System.Drawing.Point(607, 102);
            btnChange.Name="btnChange";
            btnChange.Size=new System.Drawing.Size(75, 23);
            btnChange.TabIndex=8;
            btnChange.Text="수정";
            btnChange.UseVisualStyleBackColor=true;
            btnChange.Click+=btnChange_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location=new System.Drawing.Point(607, 145);
            btnInsert.Name="btnInsert";
            btnInsert.Size=new System.Drawing.Size(75, 23);
            btnInsert.TabIndex=9;
            btnInsert.Text="삽입";
            btnInsert.UseVisualStyleBackColor=true;
            btnInsert.Click+=btnInsert_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chName, chPhone, chOrg });
            listView1.Location=new System.Drawing.Point(32, 190);
            listView1.Name="listView1";
            listView1.Size=new System.Drawing.Size(756, 237);
            listView1.TabIndex=10;
            listView1.UseCompatibleStateImageBehavior=false;
            listView1.View=System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            chName.Text="이름";
            chName.Width=150;
            // 
            // chPhone
            // 
            chPhone.Text="휴대폰";
            chPhone.Width=150;
            // 
            // chOrg
            // 
            chOrg.Text="소속";
            chOrg.Width=150;
            // 
            // Form3
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnInsert);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbOrg);
            Controls.Add(tbPhone);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form3";
            Text="Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbOrg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chOrg;
    }
}