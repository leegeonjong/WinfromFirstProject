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
            label1 = new Label();
            SearchBox = new TextBox();
            btn_Search = new Button();
            memberView = new DataGridView();
            btn_delete = new Button();
            btn_Update = new Button();
            ((System.ComponentModel.ISupportInitialize)memberView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "관리자 페이지";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(518, 70);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(100, 23);
            SearchBox.TabIndex = 1;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(633, 69);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "검색";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // memberView
            // 
            memberView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberView.Dock = DockStyle.Bottom;
            memberView.Location = new Point(0, 128);
            memberView.Name = "memberView";
            memberView.RowTemplate.Height = 25;
            memberView.Size = new Size(800, 322);
            memberView.TabIndex = 3;
            memberView.CellDoubleClick += memberView_CellDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(12, 99);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "삭제";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(104, 99);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(101, 23);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "회원정보 수정";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // Admin_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Update);
            Controls.Add(btn_delete);
            Controls.Add(memberView);
            Controls.Add(btn_Search);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Name = "Admin_Page";
            Text = "Admin_Page";
            Load += Admin_Page_Load;
            ((System.ComponentModel.ISupportInitialize)memberView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchBox;
        private Button btn_Search;
        private Button btn_delete;
        private Button btn_Update;
        public DataGridView memberView;
    }
}