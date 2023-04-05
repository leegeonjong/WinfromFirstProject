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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratebox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.reviewBox = new System.Windows.Forms.TextBox();
            this.bookmarkon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "상세정보들 넣을곳";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "상세정보들 넣을곳";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltitle.Location = new System.Drawing.Point(213, 37);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(78, 41);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "제목";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ratebox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NickNameBox);
            this.panel1.Controls.Add(this.reviewBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 370);
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
            this.ratebox.Location = new System.Drawing.Point(12, 52);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(58, 28);
            this.ratebox.TabIndex = 4;
            this.ratebox.Text = "별점";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(680, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.reviewBox.Location = new System.Drawing.Point(213, 52);
            this.reviewBox.Margin = new System.Windows.Forms.Padding(4);
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.Size = new System.Drawing.Size(276, 27);
            this.reviewBox.TabIndex = 0;
            this.reviewBox.Text = "comment";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 803);
            this.Controls.Add(this.bookmarkon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Movie_Detail";
            this.Text = "Movie_Detail";
            this.Load += new System.EventHandler(this.Movie_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridView dataGridView1;
        private ComboBox ratebox;
        private PictureBox bookmarkon;
    }
}