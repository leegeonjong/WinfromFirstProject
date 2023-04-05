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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            labeltitle = new Label();
            panel1 = new Panel();
            ratebox = new ComboBox();
            ReviewView = new DataGridView();
            button1 = new Button();
            NickNameBox = new TextBox();
            reviewBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReviewView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 77);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "상세정보들 넣을곳";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "상세정보들 넣을곳";
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitle.Location = new Point(222, 28);
            labeltitle.Margin = new Padding(2, 0, 2, 0);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(62, 32);
            labeltitle.TabIndex = 3;
            labeltitle.Text = "제목";
            // 
            // panel1
            // 
            panel1.Controls.Add(ratebox);
            panel1.Controls.Add(ReviewView);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(NickNameBox);
            panel1.Controls.Add(reviewBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 320);
            panel1.TabIndex = 4;
            // 
            // ratebox
            // 
            ratebox.FormattingEnabled = true;
            ratebox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            ratebox.Location = new Point(9, 39);
            ratebox.Margin = new Padding(2);
            ratebox.Name = "ratebox";
            ratebox.Size = new Size(46, 23);
            ratebox.TabIndex = 4;
            ratebox.Text = "별점";
            // 
            // ReviewView
            // 
            ReviewView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReviewView.Dock = DockStyle.Bottom;
            ReviewView.Location = new Point(0, 68);
            ReviewView.Margin = new Padding(2);
            ReviewView.Name = "ReviewView";
            ReviewView.RowHeadersWidth = 51;
            ReviewView.RowTemplate.Height = 29;
            ReviewView.Size = new Size(529, 252);
            ReviewView.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(436, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // NickNameBox
            // 
            this.NickNameBox.Location = new System.Drawing.Point(91, 53);
            this.NickNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.ReadOnly = true;
            this.NickNameBox.Size = new System.Drawing.Size(104, 27);
            this.NickNameBox.TabIndex = 1;
            // 
            // reviewBox
            // 
            reviewBox.Location = new Point(166, 39);
            reviewBox.Name = "reviewBox";
            reviewBox.Size = new Size(216, 23);
            reviewBox.TabIndex = 0;
            reviewBox.Text = "comment";
            // 
            // bookmarkon
            // 
            this.bookmarkon.BackgroundImage = global::TeamProject.Properties.Resources.pngwing_com;
            this.bookmarkon.Image = global::TeamProject.Properties.Resources.bookmarkoff;
            this.bookmarkon.Location = new System.Drawing.Point(30, 66);
            this.bookmarkon.Name = "bookmarkon";
            this.bookmarkon.Size = new System.Drawing.Size(40, 31);
            this.bookmarkon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookmarkon.TabIndex = 6;
            this.bookmarkon.TabStop = false;
            this.bookmarkon.Click += new System.EventHandler(this.bookmarkon_Click);
            // 
            // Movie_Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 602);
            Controls.Add(panel1);
            Controls.Add(labeltitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Movie_Detail";
            Text = "Movie_Detail";
            Load += Movie_Detail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReviewView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label labeltitle;
        private Panel panel1;
        private Button button1;
        private TextBox NickNameBox;
        private TextBox reviewBox;
        private DataGridView ReviewView;
        private ComboBox ratebox;
        private PictureBox bookmarkon;
    }
}