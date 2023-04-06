namespace TeamProject
{
    partial class ReviewUpdate
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
            btn_Cancel = new Button();
            btn_Update = new Button();
            rvBox = new TextBox();
            mnBox = new TextBox();
            nnBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rtBox = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.FromArgb(108, 160, 220);
            btn_Cancel.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(259, 346);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 25);
            btn_Cancel.TabIndex = 33;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(108, 160, 220);
            btn_Update.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(144, 346);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 25);
            btn_Update.TabIndex = 32;
            btn_Update.Text = "확인";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // rvBox
            // 
            rvBox.Location = new Point(144, 210);
            rvBox.Multiline = true;
            rvBox.Name = "rvBox";
            rvBox.Size = new Size(190, 103);
            rvBox.TabIndex = 27;
            // 
            // mnBox
            // 
            mnBox.BackColor = Color.White;
            mnBox.BorderStyle = BorderStyle.None;
            mnBox.Location = new Point(144, 119);
            mnBox.Name = "mnBox";
            mnBox.ReadOnly = true;
            mnBox.Size = new Size(190, 16);
            mnBox.TabIndex = 26;
            // 
            // nnBox
            // 
            nnBox.BackColor = Color.White;
            nnBox.BorderStyle = BorderStyle.None;
            nnBox.Location = new Point(144, 77);
            nnBox.Name = "nnBox";
            nnBox.ReadOnly = true;
            nnBox.Size = new Size(190, 16);
            nnBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 166);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 21;
            label5.Text = "평점";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 212);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 20;
            label4.Text = "리뷰";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 118);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 19;
            label3.Text = "영화 제목";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 18;
            label2.Text = "회원 닉네임";
            // 
            // rtBox
            // 
            rtBox.FormattingEnabled = true;
            rtBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            rtBox.Location = new Point(144, 160);
            rtBox.Name = "rtBox";
            rtBox.Size = new Size(190, 23);
            rtBox.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 160, 220);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 57);
            panel1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 0;
            label1.Text = "리뷰 수정하기";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 160, 220);
            panel2.Location = new Point(144, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 1);
            panel2.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(108, 160, 220);
            panel3.Location = new Point(144, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 1);
            panel3.TabIndex = 37;
            // 
            // ReviewUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 394);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(rtBox);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Update);
            Controls.Add(rvBox);
            Controls.Add(mnBox);
            Controls.Add(nnBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ReviewUpdate";
            Text = "리뷰 수정";
            Load += ReviewUpdate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_Update;
        private TextBox rvBox;
        private TextBox mnBox;
        private TextBox nnBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox rtBox;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
    }
}