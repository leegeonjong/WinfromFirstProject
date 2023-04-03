namespace TeamProject
{
    partial class Admin_InformUpdate
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            UidBox = new TextBox();
            IdBox = new TextBox();
            PwBox = new TextBox();
            NameBox = new TextBox();
            nnBox = new TextBox();
            pnBox = new TextBox();
            lvBox = new TextBox();
            btn_Update = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 23);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "회원정보 수정";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 80);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "회원 Uid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 114);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "회원 ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 154);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "회원 비밀번호";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 195);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "회원 이름";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 237);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "회원 닉네임";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 274);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 6;
            label7.Text = "회원 휴대폰번호";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 318);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "회원 레벨";
            // 
            // UidBox
            // 
            UidBox.Location = new Point(169, 72);
            UidBox.Name = "UidBox";
            UidBox.ReadOnly = true;
            UidBox.Size = new Size(146, 23);
            UidBox.TabIndex = 8;
            // 
            // IdBox
            // 
            IdBox.Location = new Point(169, 114);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(146, 23);
            IdBox.TabIndex = 9;
            // 
            // PwBox
            // 
            PwBox.Location = new Point(169, 154);
            PwBox.Name = "PwBox";
            PwBox.Size = new Size(146, 23);
            PwBox.TabIndex = 10;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(169, 195);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(146, 23);
            NameBox.TabIndex = 11;
            // 
            // nnBox
            // 
            nnBox.Location = new Point(169, 234);
            nnBox.Name = "nnBox";
            nnBox.Size = new Size(146, 23);
            nnBox.TabIndex = 12;
            // 
            // pnBox
            // 
            pnBox.Location = new Point(169, 274);
            pnBox.Name = "pnBox";
            pnBox.Size = new Size(146, 23);
            pnBox.TabIndex = 13;
            // 
            // lvBox
            // 
            lvBox.Location = new Point(169, 318);
            lvBox.Name = "lvBox";
            lvBox.Size = new Size(146, 23);
            lvBox.TabIndex = 14;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(98, 378);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 15;
            btn_Update.Text = "확인";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 378);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            // 
            // Admin_InformUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(button2);
            Controls.Add(btn_Update);
            Controls.Add(lvBox);
            Controls.Add(pnBox);
            Controls.Add(nnBox);
            Controls.Add(NameBox);
            Controls.Add(PwBox);
            Controls.Add(IdBox);
            Controls.Add(UidBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_InformUpdate";
            Text = "회원정보 수정";
            Load += Admin_InformUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox UidBox;
        private TextBox IdBox;
        private TextBox PwBox;
        private TextBox NameBox;
        private TextBox nnBox;
        private TextBox pnBox;
        private TextBox lvBox;
        private Button btn_Update;
        private Button button2;
    }
}