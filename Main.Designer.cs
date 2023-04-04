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
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(200, 100);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 182);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "날짜 시작";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(867, 182);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "날짜 끝";
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
            label3.AutoSize = true;
            label3.Location = new Point(1134, 188);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "영화이름 검색";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1417, 218);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 32);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            CB_Category.FormattingEnabled = true;
            CB_Category.Items.AddRange(new object[] { "오름차순", "내림차순", "매출순위", "개봉일자" });
            CB_Category.Location = new Point(281, 218);
            CB_Category.Margin = new Padding(3, 2, 3, 2);
            CB_Category.Name = "CB_Category";
            CB_Category.Size = new Size(183, 33);
            CB_Category.TabIndex = 8;
            CB_Category.SelectedIndexChanged += CB_Category_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 188);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "카테고리 선택";
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
            fLPMain.AutoScroll = true;
            fLPMain.Location = new Point(281, 256);
            fLPMain.Margin = new Padding(3, 2, 3, 2);
            fLPMain.Name = "fLPMain";
            fLPMain.Size = new Size(1373, 755);
            fLPMain.TabIndex = 12;
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