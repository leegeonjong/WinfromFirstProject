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
            lblreview = new Label();
            rtBox = new ComboBox();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(271, 385);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 33;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(100, 385);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 32;
            btn_Update.Text = "확인";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // rvBox
            // 
            rvBox.Location = new Point(171, 212);
            rvBox.Multiline = true;
            rvBox.Name = "rvBox";
            rvBox.Size = new Size(190, 103);
            rvBox.TabIndex = 27;
            // 
            // mnBox
            // 
            mnBox.Location = new Point(171, 121);
            mnBox.Name = "mnBox";
            mnBox.ReadOnly = true;
            mnBox.Size = new Size(190, 23);
            mnBox.TabIndex = 26;
            // 
            // nnBox
            // 
            nnBox.Location = new Point(171, 79);
            nnBox.Name = "nnBox";
            nnBox.ReadOnly = true;
            nnBox.Size = new Size(190, 23);
            nnBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 159);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 21;
            label5.Text = "평점";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 212);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 20;
            label4.Text = "리뷰";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 121);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 19;
            label3.Text = "영화 제목";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 82);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 18;
            label2.Text = "회원 닉네임";
            // 
            // lblreview
            // 
            lblreview.AutoSize = true;
            lblreview.Location = new Point(171, 30);
            lblreview.Name = "lblreview";
            lblreview.Size = new Size(83, 15);
            lblreview.TabIndex = 17;
            lblreview.Text = "리뷰 수정하기";
            // 
            // rtBox
            // 
            rtBox.FormattingEnabled = true;
            rtBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            rtBox.Location = new Point(171, 159);
            rtBox.Name = "rtBox";
            rtBox.Size = new Size(190, 23);
            rtBox.TabIndex = 34;
            // 
            // ReviewUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
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
            Controls.Add(lblreview);
            Name = "ReviewUpdate";
            Text = "리뷰 수정";
            Load += ReviewUpdate_Load;
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
        private Label lblreview;
        private ComboBox rtBox;
    }
}