namespace TeamProject
{
    partial class Find_Result
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
            IDBox = new TextBox();
            PWBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "조회결과";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 134);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 195);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "비밀번호";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(180, 131);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(100, 23);
            IDBox.TabIndex = 3;
            // 
            // PWBox
            // 
            PWBox.Location = new Point(180, 195);
            PWBox.Name = "PWBox";
            PWBox.Size = new Size(100, 23);
            PWBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(151, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = true;
            // 
            // Find_Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(button1);
            Controls.Add(PWBox);
            Controls.Add(IDBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Find_Result";
            Text = "Find_Result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IDBox;
        private TextBox PWBox;
        private Button button1;
    }
}