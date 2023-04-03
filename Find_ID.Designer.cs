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
            label1 = new Label();
            NameBox = new TextBox();
            PhonenumBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_Result = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 47);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "아이디 찾기";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(167, 106);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 1;
            // 
            // PhonenumBox
            // 
            PhonenumBox.Location = new Point(167, 163);
            PhonenumBox.Name = "PhonenumBox";
            PhonenumBox.Size = new Size(100, 23);
            PhonenumBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 114);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 166);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "휴대폰 번호";
            // 
            // btn_Result
            // 
            btn_Result.Location = new Point(69, 231);
            btn_Result.Name = "btn_Result";
            btn_Result.Size = new Size(75, 23);
            btn_Result.TabIndex = 5;
            btn_Result.Text = "조회하기";
            btn_Result.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(192, 231);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Find_ID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PhonenumBox);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Name = "Find_ID";
            Text = "아이디 찾기";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private TextBox PhonenumBox;
        private Label label2;
        private Label label3;
        private Button btn_Result;
        private Button btn_Cancel;
    }
}