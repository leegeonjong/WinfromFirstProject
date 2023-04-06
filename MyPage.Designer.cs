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
            label10 = new Label();
            this.myBookmarkView = new DataGridView();
            tab1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myReviewView).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.myBookmarkView).BeginInit();
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
            tab1.Controls.Add(tabPage1);
            tab1.Controls.Add(tabPage2);
            tab1.Controls.Add(tabPage3);
            tab1.Dock = DockStyle.Bottom;
            tab1.Location = new Point(0, 4);
            tab1.Margin = new Padding(4);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(774, 548);
            tab1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_Cancel);
            tabPage1.Controls.Add(btn_update);
            tabPage1.Controls.Add(pnBox);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(lvBox);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(nnBox);
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(pwBox);
            tabPage1.Controls.Add(idBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(752, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "회원정보";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(283, 457);
            btn_Cancel.Margin = new Padding(4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(96, 31);
            btn_Cancel.TabIndex = 17;
            btn_Cancel.Text = "취소하기";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(139, 457);
            btn_update.Margin = new Padding(4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(96, 31);
            btn_update.TabIndex = 16;
            btn_update.Text = "수정";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // pnBox
            // 
            pnBox.Location = new Point(251, 259);
            pnBox.Margin = new Padding(4);
            pnBox.Name = "pnBox";
            pnBox.Size = new Size(127, 23);
            pnBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 269);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 14;
            label8.Text = "휴대폰번호";
            // 
            // lvBox
            // 
            lvBox.Location = new Point(251, 373);
            lvBox.Margin = new Padding(4);
            lvBox.Name = "lvBox";
            lvBox.Size = new Size(127, 23);
            lvBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 384);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "레벨";
            // 
            // nnBox
            // 
            nnBox.Location = new Point(251, 316);
            nnBox.Margin = new Padding(4);
            nnBox.Name = "nnBox";
            nnBox.Size = new Size(127, 23);
            nnBox.TabIndex = 11;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(251, 201);
            nameBox.Margin = new Padding(4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(127, 23);
            nameBox.TabIndex = 10;
            // 
            // pwBox
            // 
            pwBox.Location = new Point(251, 144);
            pwBox.Margin = new Padding(4);
            pwBox.Name = "pwBox";
            pwBox.Size = new Size(127, 23);
            pwBox.TabIndex = 9;
            // 
            // idBox
            // 
            idBox.Location = new Point(251, 87);
            idBox.Margin = new Padding(4);
            idBox.Name = "idBox";
            idBox.Size = new Size(127, 23);
            idBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 327);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "닉네임";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 212);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "비밀번호";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "아이디";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_reviewclose);
            tabPage2.Controls.Add(btn_reviewUpdate);
            tabPage2.Controls.Add(myReviewView);
            tabPage2.Controls.Add(label6);
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(766, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "내가 남긴 리뷰";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reviewclose
            // 
            btn_reviewclose.Location = new Point(647, 27);
            btn_reviewclose.Margin = new Padding(4);
            btn_reviewclose.Name = "btn_reviewclose";
            btn_reviewclose.Size = new Size(96, 31);
            btn_reviewclose.TabIndex = 3;
            btn_reviewclose.Text = "닫기";
            btn_reviewclose.UseVisualStyleBackColor = true;
            // 
            // btn_reviewUpdate
            // 
            btn_reviewUpdate.Location = new Point(473, 27);
            btn_reviewUpdate.Margin = new Padding(4);
            btn_reviewUpdate.Name = "btn_reviewUpdate";
            btn_reviewUpdate.Size = new Size(96, 31);
            btn_reviewUpdate.TabIndex = 2;
            btn_reviewUpdate.Text = "수정하기";
            btn_reviewUpdate.UseVisualStyleBackColor = true;
            // 
            // myReviewView
            // 
            myReviewView.BackgroundColor = Color.White;
            myReviewView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myReviewView.GridColor = Color.LightGray;
            myReviewView.Location = new Point(4, 80);
            myReviewView.Margin = new Padding(4);
            myReviewView.Name = "myReviewView";
            myReviewView.RowHeadersWidth = 51;
            myReviewView.RowTemplate.Height = 25;
            myReviewView.Size = new Size(739, 427);
            myReviewView.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "내가 남긴 리뷰";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(this.myBookmarkView);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(766, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "즐겨찾기";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(346, 41);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 0;
            label10.Text = "내 즐겨찾기";
            // 
            // myBookmarkView
            // 
            this.myBookmarkView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myBookmarkView.Dock = DockStyle.Bottom;
            this.myBookmarkView.Location = new Point(0, 86);
            this.myBookmarkView.Name = "myBookmarkView";
            this.myBookmarkView.RowTemplate.Height = 25;
            this.myBookmarkView.Size = new Size(766, 434);
            this.myBookmarkView.TabIndex = 1;
            // 
            // MyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 552);
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.myBookmarkView).EndInit();
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
       
        private Label label10;
    }
}