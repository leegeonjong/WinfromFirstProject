namespace TeamProject
{
    partial class admin_reviewPage
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
            panel8 = new Panel();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            panel10 = new Panel();
            btn_delete = new Button();
            btn_cancel = new Button();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(108, 160, 220);
            panel8.Controls.Add(label11);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(593, 42);
            panel8.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(248, 5);
            label11.Name = "label11";
            label11.Size = new Size(104, 30);
            label11.TabIndex = 0;
            label11.Text = "리뷰 관리";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(593, 455);
            dataGridView1.TabIndex = 21;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(108, 160, 220);
            panel10.Controls.Add(btn_delete);
            panel10.Controls.Add(btn_cancel);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 509);
            panel10.Name = "panel10";
            panel10.Size = new Size(593, 43);
            panel10.TabIndex = 22;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(108, 190, 250);
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(393, 8);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 27);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "리뷰 삭제";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(108, 190, 250);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(501, 8);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 27);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "닫기";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // admin_reviewPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 552);
            Controls.Add(panel10);
            Controls.Add(dataGridView1);
            Controls.Add(panel8);
            Name = "admin_reviewPage";
            Text = "admin_reviewPage";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Label label11;
        private DataGridView dataGridView1;
        private Panel panel10;
        private Button btn_delete;
        private Button btn_cancel;
    }
}