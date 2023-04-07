namespace TeamProject
{
    partial class Movie_Detail
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            lbl3 = new Label();
            lbl1 = new Label();
            labeltitle = new Label();
            panel1 = new Panel();
            ratebox = new ComboBox();
            ReviewView = new DataGridView();
            button1 = new Button();
            NickNameBox = new TextBox();
            reviewBox = new TextBox();
            book = new PictureBox();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            txtplot = new TextBox();
            lblRuntime = new Label();
            lblDirector = new Label();
            lblDate = new Label();
            lblScore = new Label();
            lblGenre = new Label();
            txtlActor = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReviewView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)book).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 93);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(284, 152);
            lbl3.Margin = new Padding(2, 0, 2, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(70, 15);
            lbl3.TabIndex = 1;
            lbl3.Text = "개봉 일자 : ";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(284, 122);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 2;
            lbl1.Text = "장르: ";
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.Font = new Font("맑은 고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitle.Location = new Point(285, 23);
            labeltitle.Margin = new Padding(2, 0, 2, 0);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(75, 40);
            labeltitle.TabIndex = 3;
            labeltitle.Text = "제목";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ratebox);
            panel1.Controls.Add(ReviewView);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(NickNameBox);
            panel1.Controls.Add(reviewBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 345);
            panel1.TabIndex = 4;
            // 
            // ratebox
            // 
            ratebox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ratebox.FormattingEnabled = true;
            ratebox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            ratebox.Location = new Point(123, 16);
            ratebox.Margin = new Padding(2);
            ratebox.Name = "ratebox";
            ratebox.Size = new Size(46, 23);
            ratebox.TabIndex = 4;
            ratebox.Text = "별점";
            // 
            // ReviewView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ReviewView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ReviewView.BackgroundColor = Color.White;
            ReviewView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ReviewView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReviewView.Dock = DockStyle.Bottom;
            ReviewView.Location = new Point(0, 89);
            ReviewView.Margin = new Padding(2);
            ReviewView.Name = "ReviewView";
            ReviewView.RowHeadersWidth = 51;
            ReviewView.RowTemplate.Height = 29;
            ReviewView.Size = new Size(660, 252);
            ReviewView.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(108, 160, 220);
            button1.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(473, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // NickNameBox
            // 
            NickNameBox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NickNameBox.Location = new Point(13, 16);
            NickNameBox.Margin = new Padding(4);
            NickNameBox.Name = "NickNameBox";
            NickNameBox.ReadOnly = true;
            NickNameBox.Size = new Size(104, 23);
            NickNameBox.TabIndex = 1;
            // 
            // reviewBox
            // 
            reviewBox.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reviewBox.Location = new Point(186, 16);
            reviewBox.Multiline = true;
            reviewBox.Name = "reviewBox";
            reviewBox.Size = new Size(261, 60);
            reviewBox.TabIndex = 0;
            reviewBox.Text = "comment";
            // 
            // book
            // 
            book.Image = Properties.Resources.bookmarkoff;
            book.Location = new Point(11, 23);
            book.Margin = new Padding(2);
            book.Name = "book";
            book.Size = new Size(58, 46);
            book.SizeMode = PictureBoxSizeMode.Zoom;
            book.TabIndex = 5;
            book.TabStop = false;
            book.Click += book_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(285, 137);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(66, 15);
            lbl2.TabIndex = 6;
            lbl2.Text = "별점 평균: ";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.Location = new Point(284, 167);
            lbl4.Margin = new Padding(2, 0, 2, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(70, 15);
            lbl4.TabIndex = 7;
            lbl4.Text = "영화 감독 : ";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.Location = new Point(284, 200);
            lbl5.Margin = new Padding(2, 0, 2, 0);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(70, 15);
            lbl5.TabIndex = 8;
            lbl5.Text = "출연 배우 : ";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl7.Location = new Point(285, 272);
            lbl7.Margin = new Padding(2, 0, 2, 0);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(54, 15);
            lbl7.TabIndex = 9;
            lbl7.Text = "줄거리 : ";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl6.Location = new Point(284, 107);
            lbl6.Margin = new Padding(2, 0, 2, 0);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(70, 15);
            lbl6.TabIndex = 10;
            lbl6.Text = "러닝 타임 : ";
            // 
            // txtplot
            // 
            txtplot.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtplot.Location = new Point(285, 299);
            txtplot.Margin = new Padding(2);
            txtplot.Multiline = true;
            txtplot.Name = "txtplot";
            txtplot.ReadOnly = true;
            txtplot.ScrollBars = ScrollBars.Both;
            txtplot.Size = new Size(352, 115);
            txtplot.TabIndex = 11;
            // 
            // lblRuntime
            // 
            lblRuntime.AutoSize = true;
            lblRuntime.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRuntime.Location = new Point(363, 107);
            lblRuntime.Margin = new Padding(2, 0, 2, 0);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(43, 15);
            lblRuntime.TabIndex = 12;
            lblRuntime.Text = "준비중";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDirector.Location = new Point(363, 167);
            lblDirector.Margin = new Padding(2, 0, 2, 0);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(43, 15);
            lblDirector.TabIndex = 14;
            lblDirector.Text = "준비중";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(363, 152);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(43, 15);
            lblDate.TabIndex = 15;
            lblDate.Text = "준비중";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(363, 137);
            lblScore.Margin = new Padding(2, 0, 2, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(43, 15);
            lblScore.TabIndex = 16;
            lblScore.Text = "준비중";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenre.Location = new Point(363, 122);
            lblGenre.Margin = new Padding(2, 0, 2, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(43, 15);
            lblGenre.TabIndex = 17;
            lblGenre.Text = "준비중";
            // 
            // txtlActor
            // 
            txtlActor.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtlActor.Location = new Point(358, 200);
            txtlActor.Margin = new Padding(2);
            txtlActor.Multiline = true;
            txtlActor.Name = "txtlActor";
            txtlActor.ReadOnly = true;
            txtlActor.ScrollBars = ScrollBars.Both;
            txtlActor.Size = new Size(278, 62);
            txtlActor.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 160, 220);
            panel2.Controls.Add(labeltitle);
            panel2.Controls.Add(book);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 88);
            panel2.TabIndex = 19;
            // 
            // Movie_Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 764);
            Controls.Add(panel2);
            Controls.Add(txtlActor);
            Controls.Add(lblGenre);
            Controls.Add(lblScore);
            Controls.Add(lblDate);
            Controls.Add(lblDirector);
            Controls.Add(lblRuntime);
            Controls.Add(txtplot);
            Controls.Add(lbl6);
            Controls.Add(lbl7);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl2);
            Controls.Add(panel1);
            Controls.Add(lbl1);
            Controls.Add(lbl3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Movie_Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie_Detail";
            Load += Movie_Detail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReviewView).EndInit();
            ((System.ComponentModel.ISupportInitialize)book).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl3;
        private Label lbl1;
        private Label labeltitle;
        private Panel panel1;
        private Button button1;
        private TextBox NickNameBox;
        private TextBox reviewBox;
        private DataGridView ReviewView;
        private ComboBox ratebox;
        private PictureBox bookmarkon;
        private PictureBox book;
        private Label lbl2;
        private Label lbl4;
        private Label lbl5;
        private Label lbl7;
        private Label lbl6;
        private TextBox txtplot;
        private Label lblRuntime;
        private Label lblDirector;
        private Label lblDate;
        private Label lblScore;
        private Label lblGenre;
        private TextBox txtlActor;
        private Panel panel2;
    }
}