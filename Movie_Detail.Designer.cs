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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratebox = new System.Windows.Forms.ComboBox();
            this.ReviewView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.reviewBox = new System.Windows.Forms.TextBox();
            this.book = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtplot = new System.Windows.Forms.TextBox();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtlActor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(365, 148);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(87, 20);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "개봉 일자 : ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(365, 108);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "장르: ";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltitle.Location = new System.Drawing.Point(104, 46);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(78, 41);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "제목";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ratebox);
            this.panel1.Controls.Add(this.ReviewView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NickNameBox);
            this.panel1.Controls.Add(this.reviewBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 494);
            this.panel1.TabIndex = 4;
            // 
            // ratebox
            // 
            this.ratebox.FormattingEnabled = true;
            this.ratebox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ratebox.Location = new System.Drawing.Point(158, 22);
            this.ratebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(58, 28);
            this.ratebox.TabIndex = 4;
            this.ratebox.Text = "별점";
            // 
            // ReviewView
            // 
            this.ReviewView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReviewView.Location = new System.Drawing.Point(0, 158);
            this.ReviewView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReviewView.Name = "ReviewView";
            this.ReviewView.RowHeadersWidth = 51;
            this.ReviewView.RowTemplate.Height = 29;
            this.ReviewView.Size = new System.Drawing.Size(854, 336);
            this.ReviewView.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NickNameBox
            // 
            this.NickNameBox.Location = new System.Drawing.Point(17, 22);
            this.NickNameBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.ReadOnly = true;
            this.NickNameBox.Size = new System.Drawing.Size(133, 27);
            this.NickNameBox.TabIndex = 1;
            // 
            // reviewBox
            // 
            this.reviewBox.Location = new System.Drawing.Point(239, 22);
            this.reviewBox.Margin = new System.Windows.Forms.Padding(4);
            this.reviewBox.Multiline = true;
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.Size = new System.Drawing.Size(334, 78);
            this.reviewBox.TabIndex = 0;
            this.reviewBox.Text = "comment";
            // 
            // book
            // 
            this.book.Image = global::TeamProject.Properties.Resources.bookmarkoff;
            this.book.Location = new System.Drawing.Point(0, 38);
            this.book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(75, 62);
            this.book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.book.TabIndex = 5;
            this.book.TabStop = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(366, 128);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(82, 20);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "별점 평균: ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(365, 168);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(87, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "영화 감독 : ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(366, 188);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(87, 20);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "출연 배우 : ";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(366, 250);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(67, 20);
            this.lbl7.TabIndex = 9;
            this.lbl7.Text = "줄거리 : ";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(365, 88);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(87, 20);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "러닝 타임 : ";
            // 
            // txtplot
            // 
            this.txtplot.Location = new System.Drawing.Point(380, 305);
            this.txtplot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtplot.Multiline = true;
            this.txtplot.Name = "txtplot";
            this.txtplot.ReadOnly = true;
            this.txtplot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtplot.Size = new System.Drawing.Size(451, 190);
            this.txtplot.TabIndex = 11;
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(467, 88);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(54, 20);
            this.lblRuntime.TabIndex = 12;
            this.lblRuntime.Text = "준비중";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(467, 168);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(54, 20);
            this.lblDirector.TabIndex = 14;
            this.lblDirector.Text = "준비중";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(467, 148);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 20);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "준비중";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(467, 128);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(54, 20);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "준비중";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(467, 108);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "준비중";
            // 
            // txtlActor
            // 
            this.txtlActor.Location = new System.Drawing.Point(465, 190);
            this.txtlActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlActor.Multiline = true;
            this.txtlActor.Name = "txtlActor";
            this.txtlActor.ReadOnly = true;
            this.txtlActor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtlActor.Size = new System.Drawing.Size(376, 82);
            this.txtlActor.TabIndex = 18;
            // 
            // Movie_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 1018);
            this.Controls.Add(this.txtlActor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.txtplot);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.book);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Movie_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie_Detail";
            this.Load += new System.EventHandler(this.Movie_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}