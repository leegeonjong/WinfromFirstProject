namespace TeamProject
{
    partial class Find_PW
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
            label1 = new Label();
            lblName = new Label();
            lblID = new Label();
            textBox1 = new TextBox();
            IDBox = new TextBox();
            lblPhonenum = new Label();
            PhoneNumbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 67);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "비밀번호 찾기";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(51, 128);
            lblName.Name = "lblName";
            lblName.Size = new Size(31, 15);
            lblName.TabIndex = 1;
            lblName.Text = "이름";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(51, 188);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 15);
            lblID.TabIndex = 2;
            lblID.Text = "아이디";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // IDBox
            // 
            IDBox.Location = new Point(160, 185);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(100, 23);
            IDBox.TabIndex = 4;
            // 
            // lblPhonenum
            // 
            lblPhonenum.AutoSize = true;
            lblPhonenum.Location = new Point(51, 242);
            lblPhonenum.Name = "lblPhonenum";
            lblPhonenum.Size = new Size(71, 15);
            lblPhonenum.TabIndex = 5;
            lblPhonenum.Text = "휴대폰 번호";
            // 
            // PhoneNumbox
            // 
            PhoneNumbox.Location = new Point(160, 251);
            PhoneNumbox.Name = "PhoneNumbox";
            PhoneNumbox.Size = new Size(100, 23);
            PhoneNumbox.TabIndex = 6;
            // 
            // Find_PW
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 450);
            Controls.Add(PhoneNumbox);
            Controls.Add(lblPhonenum);
            Controls.Add(IDBox);
            Controls.Add(textBox1);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Find_PW";
            Text = "비밀번호 찾기";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblID;
        private TextBox textBox1;
        private TextBox IDBox;
        private Label lblPhonenum;
        private TextBox PhoneNumbox;
    }
}