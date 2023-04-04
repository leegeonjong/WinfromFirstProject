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
            label3 = new Label();
            btnSearch = new Button();
            btnLogin = new Button();
            label4 = new Label();
            fLPMain = new FlowLayoutPanel();
            btnLogout = new Button();
            dTPStart = new DateTimePicker();
            dTPEnd = new DateTimePicker();
            txtName = new TextBox();
            CB_Category = new ComboBox();
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
            label1.Location = new Point(456, 141);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "날짜 시작";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(732, 141);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "날짜 끝";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1001, 141);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "영화이름 검색";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1389, 164);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(1261, 71);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 141);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "카테고리 선택";
            // 
            // fLPMain
            // 
            fLPMain.AutoScroll = true;
            fLPMain.Location = new Point(253, 205);
            fLPMain.Margin = new Padding(3, 2, 3, 2);
            fLPMain.Name = "fLPMain";
            fLPMain.Size = new Size(1236, 604);
            fLPMain.TabIndex = 12;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1378, 71);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 32);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "로그아웃";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            // 
            // dTPStart
            // 
            dTPStart.Location = new Point(456, 166);
            dTPStart.Name = "dTPStart";
            dTPStart.Size = new Size(270, 31);
            dTPStart.TabIndex = 14;
            // 
            // dTPEnd
            // 
            dTPEnd.Location = new Point(732, 166);
            dTPEnd.Name = "dTPEnd";
            dTPEnd.Size = new Size(270, 31);
            dTPEnd.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(1008, 166);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "검색할 영화이름을 입력하세요";
            txtName.Size = new Size(375, 31);
            txtName.TabIndex = 16;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // CB_Category
            // 
            CB_Category.FormattingEnabled = true;
            CB_Category.Items.AddRange(new object[] { "오름차순", "내림차순", "매출일자", "개봉일자" });
            CB_Category.Location = new Point(253, 165);
            CB_Category.Name = "CB_Category";
            CB_Category.Size = new Size(182, 33);
            CB_Category.TabIndex = 17;
            CB_Category.SelectedIndexChanged += CB_Category_SelectedIndexChanged_1;
            // 
            // nicknamelabel
            // 
            this.nicknamelabel.AutoSize = true;
            this.nicknamelabel.Location = new System.Drawing.Point(1389, 110);
            this.nicknamelabel.Name = "nicknamelabel";
            this.nicknamelabel.Size = new System.Drawing.Size(0, 20);
            this.nicknamelabel.TabIndex = 13;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(1389, 132);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 20);
            this.idLabel.TabIndex = 14;
            // 
            // mypage
            // 
            this.mypage.Location = new System.Drawing.Point(1524, 70);
            this.mypage.Name = "mypage";
            this.mypage.Size = new System.Drawing.Size(94, 29);
            this.mypage.TabIndex = 15;
            this.mypage.Text = "마이페이지";
            this.mypage.UseVisualStyleBackColor = true;
            this.mypage.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 1022);
            Controls.Add(CB_Category);
            Controls.Add(txtName);
            Controls.Add(dTPEnd);
            Controls.Add(dTPStart);
            Controls.Add(btnLogout);
            Controls.Add(fLPMain);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private Button btnLogin;
        private Label label4;
        private FlowLayoutPanel fLPMain;
        private Button btnLogout;
        private DateTimePicker dTPStart;
        private DateTimePicker dTPEnd;
        private TextBox txtName;
        private ComboBox CB_Category;
    }
}