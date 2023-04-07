namespace TeamProject
{
    partial class Admin_Page
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
            SearchBox = new TextBox();
            btn_Search = new Button();
            memberView = new DataGridView();
            btn_delete = new Button();
            btn_Update = new Button();
            panel9 = new Panel();
            label6 = new Label();
            panel10 = new Panel();
            ((System.ComponentModel.ISupportInitialize)memberView).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(438, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(100, 23);
            SearchBox.TabIndex = 1;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.FromArgb(108, 190, 250);
            btn_Search.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(555, 40);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 27);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "검색";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // memberView
            // 
            memberView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            memberView.BackgroundColor = Color.White;
            memberView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberView.EnableHeadersVisualStyles = false;
            memberView.Location = new Point(12, 77);
            memberView.Name = "memberView";
            memberView.RowTemplate.Height = 25;
            memberView.Size = new Size(630, 322);
            memberView.TabIndex = 3;
            memberView.CellDoubleClick += memberView_CellDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(108, 190, 250);
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(555, 7);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 32);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "삭제";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(108, 190, 250);
            btn_Update.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(448, 7);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(101, 32);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "회원정보 수정";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(108, 160, 220);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(btn_Search);
            panel9.Controls.Add(SearchBox);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(642, 71);
            panel9.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(225, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 30);
            label6.TabIndex = 0;
            label6.Text = "관리자 페이지";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(108, 160, 220);
            panel10.Controls.Add(btn_delete);
            panel10.Controls.Add(btn_Update);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 405);
            panel10.Name = "panel10";
            panel10.Size = new Size(642, 45);
            panel10.TabIndex = 22;
            // 
            // Admin_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(642, 450);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(memberView);
            Name = "Admin_Page";
            Text = "Admin_Page";
            Load += Admin_Page_Load;
            ((System.ComponentModel.ISupportInitialize)memberView).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox SearchBox;
        private Button btn_Search;
        private Button btn_delete;
        private Button btn_Update;
        public DataGridView memberView;
        private Panel panel9;
        private Label label6;
        private Panel panel10;
    }
}