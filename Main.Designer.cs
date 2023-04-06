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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.mypage = new System.Windows.Forms.Button();
            this.dTPStart = new System.Windows.Forms.DateTimePicker();
            this.dTPEnd = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CB_Category = new System.Windows.Forms.ComboBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_nn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(195, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 시작";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(444, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "날짜 끝";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(685, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "영화이름 검색";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1036, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLogin.Location = new System.Drawing.Point(1036, 117);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 30);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "카테고리 선택";
            // 
            // fLPMain
            // 
            this.fLPMain.AutoScroll = true;
            this.fLPMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.fLPMain.Location = new System.Drawing.Point(12, 186);
            this.fLPMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fLPMain.Name = "fLPMain";
            this.fLPMain.Size = new System.Drawing.Size(1198, 482);
            this.fLPMain.TabIndex = 12;
            // 
            // mypage
            // 
            this.mypage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.mypage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.mypage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mypage.ForeColor = System.Drawing.Color.White;
            this.mypage.Location = new System.Drawing.Point(1036, 40);
            this.mypage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mypage.Name = "mypage";
            this.mypage.Size = new System.Drawing.Size(100, 34);
            this.mypage.TabIndex = 13;
            this.mypage.Text = "마이페이지";
            this.mypage.UseVisualStyleBackColor = false;
            this.mypage.Visible = false;
            this.mypage.Click += new System.EventHandler(this.mypage_Click);
            // 
            // dTPStart
            // 
            this.dTPStart.Location = new System.Drawing.Point(195, 156);
            this.dTPStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPStart.Name = "dTPStart";
            this.dTPStart.Size = new System.Drawing.Size(243, 27);
            this.dTPStart.TabIndex = 14;
            // 
            // dTPEnd
            // 
            this.dTPEnd.Location = new System.Drawing.Point(444, 156);
            this.dTPEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPEnd.Name = "dTPEnd";
            this.dTPEnd.Size = new System.Drawing.Size(243, 27);
            this.dTPEnd.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(691, 156);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "검색할 영화이름을 입력하세요";
            this.txtName.Size = new System.Drawing.Size(338, 27);
            this.txtName.TabIndex = 16;
            // 
            // CB_Category
            // 
            this.CB_Category.FormattingEnabled = true;
            this.CB_Category.Items.AddRange(new object[] {
            "매출액 순서",
            "오름차순",
            "내림차순",
            "최신 작품순",
            "예전 작품순",
            "별점 높은순",
            "별점 낮은순"});
            this.CB_Category.Location = new System.Drawing.Point(12, 154);
            this.CB_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Category.Name = "CB_Category";
            this.CB_Category.Size = new System.Drawing.Size(181, 28);
            this.CB_Category.TabIndex = 17;
            this.CB_Category.SelectedValueChanged += new System.EventHandler(this.CB_Category_SelectedIndexChanged_1);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(871, 47);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 20);
            this.label_id.TabIndex = 18;
            // 
            // label_nn
            // 
            this.label_nn.AutoSize = true;
            this.label_nn.ForeColor = System.Drawing.Color.White;
            this.label_nn.Location = new System.Drawing.Point(935, 47);
            this.label_nn.Name = "label_nn";
            this.label_nn.Size = new System.Drawing.Size(0, 20);
            this.label_nn.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(536, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 46);
            this.label5.TabIndex = 20;
            this.label5.Text = "영화 리뷰";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.label_nn);
            this.panel1.Controls.Add(this.mypage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 112);
            this.panel1.TabIndex = 21;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 684);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CB_Category);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dTPEnd);
            this.Controls.Add(this.dTPStart);
            this.Controls.Add(this.fLPMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel1;
    }
}