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
            tab1.Controls.Add(tabPage1);
            tab1.Controls.Add(tabPage2);
            tab1.Controls.Add(tabPage3);
            tab1.Dock = DockStyle.Bottom;
            tab1.Location = new Point(0, 39);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(760, 411);
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
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(752, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "회원정보";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(220, 343);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 17;
            btn_Cancel.Text = "취소하기";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(108, 343);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 16;
            btn_update.Text = "수정";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // pnBox
            // 
            pnBox.Location = new Point(195, 194);
            pnBox.Name = "pnBox";
            pnBox.Size = new Size(100, 23);
            pnBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 202);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 14;
            label8.Text = "휴대폰번호";
            // 
            // lvBox
            // 
            lvBox.Location = new Point(195, 280);
            lvBox.Name = "lvBox";
            lvBox.Size = new Size(100, 23);
            lvBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 288);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "레벨";
            // 
            // nnBox
            // 
            nnBox.Location = new Point(195, 237);
            nnBox.Name = "nnBox";
            nnBox.Size = new Size(100, 23);
            nnBox.TabIndex = 11;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(195, 151);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 10;
            // 
            // pwBox
            // 
            pwBox.Location = new Point(195, 108);
            pwBox.Name = "pwBox";
            pwBox.Size = new Size(100, 23);
            pwBox.TabIndex = 9;
            // 
            // idBox
            // 
            idBox.Location = new Point(195, 65);
            idBox.Name = "idBox";
            idBox.Size = new Size(100, 23);
            idBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 245);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "닉네임";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 159);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 116);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "비밀번호";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 73);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "아이디";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(myReviewView);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(752, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "내가 남긴 리뷰";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // myReviewView
            // 
            myReviewView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myReviewView.Dock = DockStyle.Bottom;
            myReviewView.Location = new Point(3, 60);
            myReviewView.Name = "myReviewView";
            myReviewView.RowTemplate.Height = 25;
            myReviewView.Size = new Size(746, 320);
            myReviewView.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 20);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 0;
            label6.Text = "내가 남긴 리뷰";
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
        private DataGridView myReviewView;
    }
}