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
            this.label1.Location = new System.Drawing.Point(410, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 시작";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "날짜 끝";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(901, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "영화이름 검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1250, 130);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1135, 58);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 26);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "카테고리 선택";
            // 
            // fLPMain
            // 
            this.fLPMain.AutoScroll = true;
            this.fLPMain.Location = new System.Drawing.Point(228, 164);
            this.fLPMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fLPMain.Name = "fLPMain";
            this.fLPMain.Size = new System.Drawing.Size(1112, 482);
            this.fLPMain.TabIndex = 12;
            // 
            // mypage
            // 
            this.mypage.Location = new System.Drawing.Point(1239, 58);
            this.mypage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mypage.Name = "mypage";
            this.mypage.Size = new System.Drawing.Size(100, 26);
            this.mypage.TabIndex = 13;
            this.mypage.Text = "마이페이지";
            this.mypage.UseVisualStyleBackColor = true;
            this.mypage.Visible = false;
            // 
            // dTPStart
            // 
            this.dTPStart.Location = new System.Drawing.Point(410, 134);
            this.dTPStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPStart.Name = "dTPStart";
            this.dTPStart.Size = new System.Drawing.Size(243, 27);
            this.dTPStart.TabIndex = 14;
            // 
            // dTPEnd
            // 
            this.dTPEnd.Location = new System.Drawing.Point(660, 134);
            this.dTPEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPEnd.Name = "dTPEnd";
            this.dTPEnd.Size = new System.Drawing.Size(243, 27);
            this.dTPEnd.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(906, 134);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "검색할 영화이름을 입력하세요";
            this.txtName.Size = new System.Drawing.Size(338, 27);
            this.txtName.TabIndex = 16;
            // 
            // CB_Category
            // 
            CB_Category.FormattingEnabled = true;
            CB_Category.Items.AddRange(new object[] { "매출액 순서", "오름차순", "내림차순", "최신 작품순", "예전 작품순" });
            CB_Category.Location = new Point(253, 165);
            CB_Category.Name = "CB_Category";
            CB_Category.Size = new Size(181, 33);
            CB_Category.TabIndex = 17;
            CB_Category.SelectedIndexChanged += CB_Category_SelectedIndexChanged_1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(1135, 98);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 20);
            this.label_id.TabIndex = 18;
            this.label_id.Text = "v";
            // 
            // label_nn
            // 
            this.label_nn.AutoSize = true;
            this.label_nn.Location = new System.Drawing.Point(1250, 98);
            this.label_nn.Name = "label_nn";
            this.label_nn.Size = new System.Drawing.Size(0, 20);
            this.label_nn.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 818);
            this.Controls.Add(this.label_nn);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.CB_Category);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dTPEnd);
            this.Controls.Add(this.dTPStart);
            this.Controls.Add(this.mypage);
            this.Controls.Add(this.fLPMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form1";
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
    }
}