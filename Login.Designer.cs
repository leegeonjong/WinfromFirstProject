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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.btID = new System.Windows.Forms.Button();
            this.btPW = new System.Windows.Forms.Button();
            this.btJoin = new System.Windows.Forms.Button();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(190, 111);
            this.TextId.Margin = new System.Windows.Forms.Padding(4);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(127, 27);
            this.TextId.TabIndex = 3;
            this.TextId.TextChanged += new System.EventHandler(this.TextId_TextChanged);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(190, 172);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(127, 27);
            this.TextPassword.TabIndex = 4;
            // 
            // btID
            // 
            this.btID.Location = new System.Drawing.Point(66, 311);
            this.btID.Margin = new System.Windows.Forms.Padding(4);
            this.btID.Name = "btID";
            this.btID.Size = new System.Drawing.Size(96, 31);
            this.btID.TabIndex = 5;
            this.btID.Text = "ID 찾기";
            this.btID.UseVisualStyleBackColor = true;
            this.btID.Click += new System.EventHandler(this.btID_Click);
            // 
            // btPW
            // 
            this.btPW.Location = new System.Drawing.Point(207, 311);
            this.btPW.Margin = new System.Windows.Forms.Padding(4);
            this.btPW.Name = "btPW";
            this.btPW.Size = new System.Drawing.Size(96, 31);
            this.btPW.TabIndex = 6;
            this.btPW.Text = "PW 찾기";
            this.btPW.UseVisualStyleBackColor = true;
            this.btPW.Click += new System.EventHandler(this.btPW_Click);
            // 
            // btJoin
            // 
            this.btJoin.Location = new System.Drawing.Point(352, 311);
            this.btJoin.Margin = new System.Windows.Forms.Padding(4);
            this.btJoin.Name = "btJoin";
            this.btJoin.Size = new System.Drawing.Size(96, 31);
            this.btJoin.TabIndex = 7;
            this.btJoin.Text = "회원가입";
            this.btJoin.UseVisualStyleBackColor = true;
            this.btJoin.Click += new System.EventHandler(this.btJoin_Click);
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(111, 412);
            this.btLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(96, 31);
            this.btLogIn.TabIndex = 8;
            this.btLogIn.Text = "로그인";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.button4_Click);
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(273, 412);
            this.btCancle.Margin = new System.Windows.Forms.Padding(4);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(96, 31);
            this.btCancle.TabIndex = 9;
            this.btCancle.Text = "취소";
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 600);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.btJoin);
            this.Controls.Add(this.btPW);
            this.Controls.Add(this.btID);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

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