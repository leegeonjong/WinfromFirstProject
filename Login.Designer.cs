namespace TeamProject
{
    partial class LoginForm
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
            TextId = new TextBox();
            TextPassword = new TextBox();
            btID = new Button();
            btPW = new Button();
            btJoin = new Button();
            btLogIn = new Button();
            btCancle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "로그인";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 91);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 129);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "비밀번호";
            // 
            // TextId
            // 
            TextId.Location = new Point(183, 91);
            TextId.Margin = new Padding(4);
            TextId.Name = "TextId";
            TextId.Size = new Size(127, 23);
            TextId.TabIndex = 3;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(187, 129);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(100, 23);
            TextPassword.TabIndex = 4;
            // 
            // btID
            // 
            btID.Location = new Point(51, 233);
            btID.Name = "btID";
            btID.Size = new Size(75, 23);
            btID.TabIndex = 5;
            btID.Text = "ID 찾기";
            btID.UseVisualStyleBackColor = true;
            btID.Click += btID_Click;
            // 
            // btPW
            // 
            btPW.Location = new Point(161, 233);
            btPW.Name = "btPW";
            btPW.Size = new Size(75, 23);
            btPW.TabIndex = 6;
            btPW.Text = "PW 찾기";
            btPW.UseVisualStyleBackColor = true;
            btPW.Click += btPW_Click;
            // 
            // btJoin
            // 
            btJoin.Location = new Point(274, 233);
            btJoin.Name = "btJoin";
            btJoin.Size = new Size(75, 23);
            btJoin.TabIndex = 7;
            btJoin.Text = "회원가입";
            btJoin.UseVisualStyleBackColor = true;
            btJoin.Click += btJoin_Click;
            // 
            // btLogIn
            // 
            btLogIn.Location = new Point(86, 309);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(75, 23);
            btLogIn.TabIndex = 8;
            btLogIn.Text = "로그인";
            btLogIn.UseVisualStyleBackColor = true;
            btLogIn.Click += button4_Click;
            // 
            // btCancle
            // 
            btCancle.Location = new Point(212, 309);
            btCancle.Name = "btCancle";
            btCancle.Size = new Size(75, 23);
            btCancle.TabIndex = 9;
            btCancle.Text = "취소";
            btCancle.UseVisualStyleBackColor = true;
            btCancle.Click += btCancle_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(btCancle);
            Controls.Add(btLogIn);
            Controls.Add(btJoin);
            Controls.Add(btPW);
            Controls.Add(btID);
            Controls.Add(TextPassword);
            Controls.Add(TextId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextId;
        private TextBox TextPassword;
        private Button btID;
        private Button btPW;
        private Button btJoin;
        private Button btLogIn;
        private Button btCancle;
    }
}