namespace TeamProject
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            btnLogin = new Button();
            CB_Category = new ComboBox();
            label4 = new Label();
            dTPStart = new DateTimePicker();
            dTPEnd = new DateTimePicker();
            fLPMain = new FlowLayoutPanel();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 시작";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "날짜 끝";
            // 
            // txtName
            // 
            txtName.Location = new Point(1134, 218);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "영화이름으로 검색하세요";
            txtName.Size = new Size(275, 31);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1021, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "영화이름 검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1275, 174);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(1417, 91);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // CB_Category
            // 
            this.CB_Category.FormattingEnabled = true;
            this.CB_Category.Items.AddRange(new object[] {
            "오름차순",
            "내림차순",
            "매출순위",
            "개봉일자"});
            this.CB_Category.Location = new System.Drawing.Point(253, 174);
            this.CB_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Category.Name = "CB_Category";
            this.CB_Category.Size = new System.Drawing.Size(165, 28);
            this.CB_Category.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "카테고리 선택";
            // 
            // dTPStart
            // 
            dTPStart.Location = new Point(599, 215);
            dTPStart.Margin = new Padding(3, 2, 3, 2);
            dTPStart.Name = "dTPStart";
            dTPStart.Size = new Size(263, 31);
            dTPStart.TabIndex = 10;
            // 
            // dTPEnd
            // 
            dTPEnd.Location = new Point(867, 218);
            dTPEnd.Margin = new Padding(3, 2, 3, 2);
            dTPEnd.Name = "dTPEnd";
            dTPEnd.Size = new Size(263, 31);
            dTPEnd.TabIndex = 11;
            // 
            // fLPMain
            // 
            this.fLPMain.AutoScroll = true;
            this.fLPMain.Location = new System.Drawing.Point(253, 205);
            this.fLPMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fLPMain.Name = "fLPMain";
            this.fLPMain.Size = new System.Drawing.Size(1236, 604);
            this.fLPMain.TabIndex = 12;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1543, 91);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 32);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "로그아웃";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 1022);
            Controls.Add(btnLogout);
            Controls.Add(fLPMain);
            Controls.Add(dTPEnd);
            Controls.Add(dTPStart);
            Controls.Add(label4);
            Controls.Add(CB_Category);
            Controls.Add(btnLogin);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Button btnSearch;
        private Button btnLogin;
        private ComboBox CB_Category;
        private Label label4;
        private DateTimePicker dTPStart;
        private DateTimePicker dTPEnd;
        private FlowLayoutPanel fLPMain;
        private Button btnLogout;
    }
}