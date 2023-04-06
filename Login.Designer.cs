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
            TextId = new TextBox();
            btID = new Button();
            btPW = new Button();
            btJoin = new Button();
            btLogIn = new Button();
            btCancle = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            TextPassword = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "로그인";
            // 
            // TextId
            // 
            TextId.BorderStyle = BorderStyle.None;
            TextId.Location = new Point(78, 25);
            TextId.Margin = new Padding(4);
            TextId.Name = "TextId";
            TextId.Size = new Size(247, 16);
            TextId.TabIndex = 3;
            // 
            // btID
            // 
            btID.BackColor = Color.White;
            btID.FlatStyle = FlatStyle.Flat;
            btID.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btID.ForeColor = Color.FromArgb(108, 160, 220);
            btID.Location = new Point(12, 318);
            btID.Name = "btID";
            btID.Size = new Size(75, 30);
            btID.TabIndex = 5;
            btID.Text = "ID 찾기";
            btID.UseVisualStyleBackColor = false;
            btID.Click += btID_Click;
            // 
            // btPW
            // 
            btPW.BackColor = Color.White;
            btPW.FlatStyle = FlatStyle.Flat;
            btPW.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btPW.ForeColor = Color.FromArgb(108, 160, 220);
            btPW.Location = new Point(120, 318);
            btPW.Name = "btPW";
            btPW.Size = new Size(75, 30);
            btPW.TabIndex = 6;
            btPW.Text = "PW 찾기";
            btPW.UseVisualStyleBackColor = false;
            btPW.Click += btPW_Click;
            // 
            // btJoin
            // 
            btJoin.BackColor = Color.White;
            btJoin.FlatStyle = FlatStyle.Flat;
            btJoin.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btJoin.ForeColor = Color.FromArgb(108, 160, 220);
            btJoin.Location = new Point(226, 318);
            btJoin.Name = "btJoin";
            btJoin.Size = new Size(75, 30);
            btJoin.TabIndex = 7;
            btJoin.Text = "회원가입";
            btJoin.UseVisualStyleBackColor = false;
            btJoin.Click += btJoin_Click;
            // 
            // btLogIn
            // 
            btLogIn.BackColor = Color.FromArgb(108, 160, 220);
            btLogIn.FlatStyle = FlatStyle.Flat;
            btLogIn.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btLogIn.ForeColor = Color.White;
            btLogIn.Location = new Point(78, 144);
            btLogIn.Name = "btLogIn";
            btLogIn.Size = new Size(247, 60);
            btLogIn.TabIndex = 8;
            btLogIn.Text = "로그인";
            btLogIn.UseVisualStyleBackColor = false;
            btLogIn.Click += button4_Click;
            // 
            // btCancle
            // 
            btCancle.BackColor = Color.White;
            btCancle.FlatStyle = FlatStyle.Flat;
            btCancle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btCancle.ForeColor = Color.FromArgb(108, 160, 220);
            btCancle.Location = new Point(326, 318);
            btCancle.Name = "btCancle";
            btCancle.Size = new Size(75, 30);
            btCancle.TabIndex = 9;
            btCancle.Text = "취소";
            btCancle.UseVisualStyleBackColor = false;
            btCancle.Click += btCancle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 160, 220);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 57);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(78, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 1);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TextPassword);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btLogIn);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(TextId);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(12, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 216);
            panel4.TabIndex = 13;
            // 
            // TextPassword
            // 
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Location = new Point(78, 78);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(247, 16);
            TextPassword.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(78, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 1);
            panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.로그인3;
            pictureBox1.Location = new Point(21, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.물쇠2;
            pictureBox2.Location = new Point(21, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(413, 493);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(btCancle);
            Controls.Add(btJoin);
            Controls.Add(btPW);
            Controls.Add(btID);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TextId;
        private Button btID;
        private Button btPW;
        private Button btJoin;
        private Button btLogIn;
        private Button btCancle;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox TextPassword;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}