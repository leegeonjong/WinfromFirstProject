namespace TeamProject
{
    partial class MyPage
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
            label5 = new Label();
            tab1 = new TabControl();
            tabPage1 = new TabPage();
            btn_Cancel = new Button();
            btn_update = new Button();
            pnBox = new TextBox();
            label8 = new Label();
            lvBox = new TextBox();
            label7 = new Label();
            nnBox = new TextBox();
            nameBox = new TextBox();
            pwBox = new TextBox();
            idBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btn_reviewclose = new Button();
            btn_reviewUpdate = new Button();
            myReviewView = new DataGridView();
            label6 = new Label();
            tabPage3 = new TabPage();
            tab1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myReviewView).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 21);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "마이페이지";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab1.Location = new System.Drawing.Point(0, 52);
            this.tab1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(977, 548);
            this.tab1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Cancel);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.pnBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lvBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nnBox);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.pwBox);
            this.tabPage1.Controls.Add(this.idBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(969, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "회원정보";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(283, 457);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(96, 31);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "취소하기";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(139, 457);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 31);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // pnBox
            // 
            this.pnBox.Location = new System.Drawing.Point(251, 259);
            this.pnBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnBox.Name = "pnBox";
            this.pnBox.Size = new System.Drawing.Size(127, 27);
            this.pnBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "휴대폰번호";
            // 
            // lvBox
            // 
            this.lvBox.Location = new System.Drawing.Point(251, 373);
            this.lvBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvBox.Name = "lvBox";
            this.lvBox.Size = new System.Drawing.Size(127, 27);
            this.lvBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "레벨";
            // 
            // nnBox
            // 
            this.nnBox.Location = new System.Drawing.Point(251, 316);
            this.nnBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nnBox.Name = "nnBox";
            this.nnBox.Size = new System.Drawing.Size(127, 27);
            this.nnBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(251, 201);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(127, 27);
            this.nameBox.TabIndex = 10;
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(251, 144);
            this.pwBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwBox.Name = "pwBox";
            this.pwBox.Size = new System.Drawing.Size(127, 27);
            this.pwBox.TabIndex = 9;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(251, 87);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(127, 27);
            this.idBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "닉네임";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "아이디";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_reviewclose);
            this.tabPage2.Controls.Add(this.btn_reviewUpdate);
            this.tabPage2.Controls.Add(this.myReviewView);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(969, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "내가 남긴 리뷰";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reviewclose
            // 
            this.btn_reviewclose.Location = new System.Drawing.Point(820, 27);
            this.btn_reviewclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reviewclose.Name = "btn_reviewclose";
            this.btn_reviewclose.Size = new System.Drawing.Size(96, 31);
            this.btn_reviewclose.TabIndex = 3;
            this.btn_reviewclose.Text = "닫기";
            this.btn_reviewclose.UseVisualStyleBackColor = true;
            // 
            // btn_reviewUpdate
            // 
            this.btn_reviewUpdate.Location = new System.Drawing.Point(678, 27);
            this.btn_reviewUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reviewUpdate.Name = "btn_reviewUpdate";
            this.btn_reviewUpdate.Size = new System.Drawing.Size(96, 31);
            this.btn_reviewUpdate.TabIndex = 2;
            this.btn_reviewUpdate.Text = "수정하기";
            this.btn_reviewUpdate.UseVisualStyleBackColor = true;
            // 
            // myReviewView
            // 
            this.myReviewView.BackgroundColor = System.Drawing.Color.White;
            this.myReviewView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myReviewView.GridColor = System.Drawing.Color.LightGray;
            this.myReviewView.Location = new System.Drawing.Point(4, 80);
            this.myReviewView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myReviewView.Name = "myReviewView";
            this.myReviewView.RowHeadersWidth = 51;
            this.myReviewView.RowTemplate.Height = 25;
            this.myReviewView.Size = new System.Drawing.Size(959, 427);
            this.myReviewView.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "내가 남긴 리뷰";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(752, 383);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "즐겨찾기";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // myBookmarkView
            // 
            myBookmarkView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myBookmarkView.Dock = DockStyle.Bottom;
            myBookmarkView.Location = new Point(0, 69);
            myBookmarkView.Name = "myBookmarkView";
            myBookmarkView.RowTemplate.Height = 25;
            myBookmarkView.Size = new Size(752, 314);
            myBookmarkView.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 23);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 0;
            label9.Text = "내가 즐겨찾기 한 목록";
            // 
            // MyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 450);
            Controls.Add(tab1);
            Controls.Add(label5);
            Name = "MyPage";
            Text = "MyPage";
            Load += MyPage_Load;
            tab1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myReviewView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TabControl tab1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private TextBox nnBox;
        private TextBox nameBox;
        private TextBox pwBox;
        private TextBox idBox;
        private Label label6;
        private TextBox lvBox;
        private Label label7;
        private TextBox pnBox;
        private Label label8;
        private Button btn_update;
        private Button btn_Cancel;
        private Button btn_reviewclose;
        private Button btn_reviewUpdate;
        public DataGridView myReviewView;
        private Label label9;
        private DataGridView myBookmarkView;
    }
}