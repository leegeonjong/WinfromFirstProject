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
            lblName = new Label();
            lblID = new Label();
            NameBox = new TextBox();
            IDBox = new TextBox();
            lblPhonenum = new Label();
            PhoneNumbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel9 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(37, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 17);
            lblName.TabIndex = 1;
            lblName.Text = "이름";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(30, 185);
            lblID.Name = "lblID";
            lblID.Size = new Size(47, 17);
            lblID.TabIndex = 2;
            lblID.Text = "아이디";
            // 
            // NameBox
            // 
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.Location = new Point(126, 100);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(167, 18);
            NameBox.TabIndex = 3;
            // 
            // IDBox
            // 
            IDBox.BorderStyle = BorderStyle.None;
            IDBox.Location = new Point(126, 168);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(167, 18);
            IDBox.TabIndex = 4;
            // 
            // lblPhonenum
            // 
            lblPhonenum.AutoSize = true;
            lblPhonenum.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhonenum.Location = new Point(14, 249);
            lblPhonenum.Name = "lblPhonenum";
            lblPhonenum.Size = new Size(78, 17);
            lblPhonenum.TabIndex = 5;
            lblPhonenum.Text = "휴대폰 번호";
            // 
            // PhoneNumbox
            // 
            PhoneNumbox.BorderStyle = BorderStyle.None;
            PhoneNumbox.Location = new Point(126, 232);
            PhoneNumbox.Name = "PhoneNumbox";
            PhoneNumbox.Size = new Size(167, 18);
            PhoneNumbox.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(108, 160, 220);
            button1.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(110, 315);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 7;
            button1.Text = "조회하기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(108, 160, 220);
            button2.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(224, 315);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(83, 29);
            button2.TabIndex = 8;
            button2.Text = "닫기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(108, 160, 220);
            panel9.Controls.Add(label1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(369, 46);
            panel9.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "비밀번호 찾기";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 160, 220);
            panel2.Location = new Point(126, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 1);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 160, 220);
            panel1.Location = new Point(126, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 1);
            panel1.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(108, 160, 220);
            panel3.Location = new Point(126, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 1);
            panel3.TabIndex = 25;
            // 
            // Find_PW
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(369, 385);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PhoneNumbox);
            Controls.Add(lblPhonenum);
            Controls.Add(IDBox);
            Controls.Add(NameBox);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Find_PW";
            Text = "비밀번호 찾기";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblID;
        private TextBox NameBox;
        private TextBox IDBox;
        private Label lblPhonenum;
        private TextBox PhoneNumbox;
        private Button button1;
        private Button button2;
        private Panel panel9;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}