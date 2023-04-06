namespace TeamProject
{
    partial class Find_ID
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
            NameBox = new TextBox();
            PhonenumBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_Result = new Button();
            btn_Cancel = new Button();
            panel9 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.Location = new Point(167, 98);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(127, 16);
            NameBox.TabIndex = 1;
            // 
            // PhonenumBox
            // 
            PhonenumBox.BorderStyle = BorderStyle.None;
            PhonenumBox.Location = new Point(167, 163);
            PhonenumBox.Name = "PhonenumBox";
            PhonenumBox.Size = new Size(127, 16);
            PhonenumBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 111);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 3;
            label2.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 176);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 4;
            label3.Text = "휴대폰 번호";
            // 
            // btn_Result
            // 
            btn_Result.FlatStyle = FlatStyle.Flat;
            btn_Result.Location = new Point(132, 274);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new Size(75, 23);
            btn_Result.TabIndex = 5;
            btn_Result.Text = "조회하기";
            btn_Result.UseVisualStyleBackColor = true;
            btn_Result.Click += btn_Result_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(241, 274);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(108, 160, 220);
            panel9.Controls.Add(label1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(328, 47);
            panel9.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 0;
            label1.Text = "아이디 찾기";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 160, 220);
            panel2.Location = new Point(167, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 1);
            panel2.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 160, 220);
            panel1.Location = new Point(167, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 1);
            panel1.TabIndex = 23;
            // 
            // Find_ID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(328, 324);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PhonenumBox);
            Controls.Add(NameBox);
            Name = "Find_ID";
            Text = "아이디 찾기";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameBox;
        private TextBox PhonenumBox;
        private Label label2;
        private Label label3;
        private Button btn_Result;
        private Button btn_Cancel;
        private Panel panel9;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}