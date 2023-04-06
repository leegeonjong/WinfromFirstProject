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
            mypage = new Button();
            dTPStart = new DateTimePicker();
            dTPEnd = new DateTimePicker();
            txtName = new TextBox();
            CB_Category = new ComboBox();
            label_id = new Label();
            label_nn = new Label();
            label5 = new Label();
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
            label1.Location = new Point(224, 134);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "날짜 시작";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 134);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "날짜 끝";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(769, 134);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "영화이름 검색";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1157, 154);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(1029, 64);
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
            label4.Location = new Point(21, 134);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 9;
            label4.Text = "카테고리 선택";
            // 
            // fLPMain
            // 
            fLPMain.AutoScroll = true;
            fLPMain.Location = new Point(21, 197);
            fLPMain.Margin = new Padding(3, 2, 3, 2);
            fLPMain.Name = "fLPMain";
            fLPMain.Size = new Size(1331, 602);
            fLPMain.TabIndex = 12;
            // 
            // mypage
            // 
            mypage.Location = new Point(1145, 64);
            mypage.Margin = new Padding(3, 2, 3, 2);
            mypage.Name = "mypage";
            mypage.Size = new Size(111, 32);
            mypage.TabIndex = 13;
            mypage.Text = "마이페이지";
            mypage.UseVisualStyleBackColor = true;
            mypage.Visible = false;
            mypage.Click += mypage_Click;
            // 
            // dTPStart
            // 
            dTPStart.Location = new Point(224, 160);
            dTPStart.Margin = new Padding(3, 2, 3, 2);
            dTPStart.Name = "dTPStart";
            dTPStart.Size = new Size(270, 31);
            dTPStart.TabIndex = 14;
            // 
            // dTPEnd
            // 
            dTPEnd.Location = new Point(501, 160);
            dTPEnd.Margin = new Padding(3, 2, 3, 2);
            dTPEnd.Name = "dTPEnd";
            dTPEnd.Size = new Size(270, 31);
            dTPEnd.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(775, 160);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "검색할 영화이름을 입력하세요";
            txtName.Size = new Size(375, 31);
            txtName.TabIndex = 16;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // CB_Category
            // 
            CB_Category.FormattingEnabled = true;
            CB_Category.Items.AddRange(new object[] { "매출액 순서", "오름차순", "내림차순", "최신 작품순", "예전 작품순", "별점 높은순", "별점 낮은순?" });
            CB_Category.Location = new Point(21, 158);
            CB_Category.Margin = new Padding(3, 4, 3, 4);
            CB_Category.Name = "CB_Category";
            CB_Category.Size = new Size(201, 33);
            CB_Category.TabIndex = 17;
            CB_Category.SelectedIndexChanged += CB_Category_SelectedIndexChanged_1;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(1029, 114);
            label_id.Name = "label_id";
            label_id.Size = new Size(21, 25);
            label_id.TabIndex = 18;
            label_id.Text = "v";
            // 
            // label_nn
            // 
            label_nn.AutoSize = true;
            label_nn.Location = new Point(1157, 114);
            label_nn.Name = "label_nn";
            label_nn.Size = new Size(0, 25);
            label_nn.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(523, 32);
            label5.Name = "label5";
            label5.Size = new Size(197, 54);
            label5.TabIndex = 20;
            label5.Text = "영화 리뷰";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 815);
            Controls.Add(label5);
            Controls.Add(label_nn);
            Controls.Add(label_id);
            Controls.Add(CB_Category);
            Controls.Add(txtName);
            Controls.Add(dTPEnd);
            Controls.Add(dTPStart);
            Controls.Add(mypage);
            Controls.Add(fLPMain);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private Button mypage;
        private DateTimePicker dTPStart;
        private DateTimePicker dTPEnd;
        private TextBox txtName;
        private ComboBox CB_Category;
        private Label lable_id;
        private Label lable_nickname;
        private Label label_id;
        private Label label_nn;
        private Label label5;
    }
}