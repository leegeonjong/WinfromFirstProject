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
            nmcomp = new Button();
            phncom = new Button();
            nmcom = new Button();
            pwcom = new Button();
            idcom = new Button();
            nnmodify = new Button();
            phnmodify = new Button();
            nmmodify = new Button();
            pwmodify = new Button();
            button_update = new Button();
            button3 = new Button();
            idmodify = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label9 = new Label();
            btn_Cancel = new Button();
            btn_update = new Button();
            pnBox = new TextBox();
            label8 = new Label();
            nnBox = new TextBox();
            nameBox = new TextBox();
            pwBox = new TextBox();
            idBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel11 = new Panel();
            btn_reviewDelete = new Button();
            btn_reviewUpdate = new Button();
            btn_reviewclose = new Button();
            panel8 = new Panel();
            label11 = new Label();
            myReviewView = new DataGridView();
            tabPage3 = new TabPage();
            panel10 = new Panel();
            btn_bmdelete = new Button();
            button1 = new Button();
            panel9 = new Panel();
            label6 = new Label();
            myBookmarkView = new DataGridView();
            tab1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myReviewView).BeginInit();
            tabPage3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myBookmarkView).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
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
            tab1.Location = new Point(0, 47);
            tab1.Margin = new Padding(4);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(818, 540);
            tab1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(nmcomp);
            tabPage1.Controls.Add(phncom);
            tabPage1.Controls.Add(nmcom);
            tabPage1.Controls.Add(pwcom);
            tabPage1.Controls.Add(idcom);
            tabPage1.Controls.Add(nnmodify);
            tabPage1.Controls.Add(phnmodify);
            tabPage1.Controls.Add(nmmodify);
            tabPage1.Controls.Add(pwmodify);
            tabPage1.Controls.Add(button_update);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(idmodify);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(btn_Cancel);
            tabPage1.Controls.Add(btn_update);
            tabPage1.Controls.Add(pnBox);
            tabPage1.Controls.Add(label8);
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
            tabPage1.Size = new Size(810, 512);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "회원정보";
            // 
            // nmcomp
            // 
            nmcomp.BackColor = Color.FromArgb(108, 190, 250);
            nmcomp.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            nmcomp.FlatStyle = FlatStyle.Flat;
            nmcomp.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nmcomp.ForeColor = Color.White;
            nmcomp.Location = new Point(571, 392);
            nmcomp.Margin = new Padding(4);
            nmcomp.Name = "nmcomp";
            nmcomp.Size = new Size(60, 25);
            nmcomp.TabIndex = 34;
            nmcomp.Text = "완료";
            nmcomp.UseVisualStyleBackColor = false;
            nmcomp.Click += nmcomp_Click;
            // 
            // phncom
            // 
            phncom.BackColor = Color.FromArgb(108, 190, 250);
            phncom.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            phncom.FlatStyle = FlatStyle.Flat;
            phncom.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phncom.ForeColor = Color.White;
            phncom.Location = new Point(571, 320);
            phncom.Margin = new Padding(4);
            phncom.Name = "phncom";
            phncom.Size = new Size(60, 25);
            phncom.TabIndex = 33;
            phncom.Text = "완료";
            phncom.UseVisualStyleBackColor = false;
            phncom.Click += phncom_Click;
            // 
            // nmcom
            // 
            nmcom.BackColor = Color.FromArgb(108, 190, 250);
            nmcom.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            nmcom.FlatStyle = FlatStyle.Flat;
            nmcom.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nmcom.ForeColor = Color.White;
            nmcom.Location = new Point(571, 238);
            nmcom.Margin = new Padding(4);
            nmcom.Name = "nmcom";
            nmcom.Size = new Size(60, 25);
            nmcom.TabIndex = 32;
            nmcom.Text = "완료";
            nmcom.UseVisualStyleBackColor = false;
            nmcom.Click += nmcom_Click;
            // 
            // pwcom
            // 
            pwcom.BackColor = Color.FromArgb(108, 190, 250);
            pwcom.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            pwcom.FlatStyle = FlatStyle.Flat;
            pwcom.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pwcom.ForeColor = Color.White;
            pwcom.Location = new Point(571, 166);
            pwcom.Margin = new Padding(4);
            pwcom.Name = "pwcom";
            pwcom.Size = new Size(60, 25);
            pwcom.TabIndex = 31;
            pwcom.Text = "완료";
            pwcom.UseVisualStyleBackColor = false;
            pwcom.Click += pwcom_Click;
            // 
            // idcom
            // 
            idcom.BackColor = Color.FromArgb(108, 190, 250);
            idcom.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            idcom.FlatStyle = FlatStyle.Flat;
            idcom.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idcom.ForeColor = Color.White;
            idcom.Location = new Point(571, 97);
            idcom.Margin = new Padding(4);
            idcom.Name = "idcom";
            idcom.Size = new Size(60, 25);
            idcom.TabIndex = 30;
            idcom.Text = "완료";
            idcom.UseVisualStyleBackColor = false;
            idcom.Click += idcom_Click;
            // 
            // nnmodify
            // 
            nnmodify.BackColor = Color.FromArgb(108, 190, 250);
            nnmodify.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            nnmodify.FlatStyle = FlatStyle.Flat;
            nnmodify.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nnmodify.ForeColor = Color.White;
            nnmodify.Location = new Point(503, 392);
            nnmodify.Margin = new Padding(4);
            nnmodify.Name = "nnmodify";
            nnmodify.Size = new Size(60, 25);
            nnmodify.TabIndex = 29;
            nnmodify.Text = "수정";
            nnmodify.UseVisualStyleBackColor = false;
            nnmodify.Click += nnmodify_Click;
            // 
            // phnmodify
            // 
            phnmodify.BackColor = Color.FromArgb(108, 190, 250);
            phnmodify.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            phnmodify.FlatStyle = FlatStyle.Flat;
            phnmodify.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phnmodify.ForeColor = Color.White;
            phnmodify.Location = new Point(503, 320);
            phnmodify.Margin = new Padding(4);
            phnmodify.Name = "phnmodify";
            phnmodify.Size = new Size(60, 25);
            phnmodify.TabIndex = 28;
            phnmodify.Text = "수정";
            phnmodify.UseVisualStyleBackColor = false;
            phnmodify.Click += phnmodify_Click;
            // 
            // nmmodify
            // 
            nmmodify.BackColor = Color.FromArgb(108, 190, 250);
            nmmodify.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            nmmodify.FlatStyle = FlatStyle.Flat;
            nmmodify.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nmmodify.ForeColor = Color.White;
            nmmodify.Location = new Point(503, 238);
            nmmodify.Margin = new Padding(4);
            nmmodify.Name = "nmmodify";
            nmmodify.Size = new Size(60, 25);
            nmmodify.TabIndex = 27;
            nmmodify.Text = "수정";
            nmmodify.UseVisualStyleBackColor = false;
            nmmodify.Click += nmmodify_Click;
            // 
            // pwmodify
            // 
            pwmodify.BackColor = Color.FromArgb(108, 190, 250);
            pwmodify.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            pwmodify.FlatStyle = FlatStyle.Flat;
            pwmodify.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pwmodify.ForeColor = Color.White;
            pwmodify.Location = new Point(503, 166);
            pwmodify.Margin = new Padding(4);
            pwmodify.Name = "pwmodify";
            pwmodify.Size = new Size(60, 25);
            pwmodify.TabIndex = 26;
            pwmodify.Text = "수정";
            pwmodify.UseVisualStyleBackColor = false;
            pwmodify.Click += pwmodify_Click;
            // 
            // button_update
            // 
            button_update.BackColor = Color.FromArgb(108, 190, 250);
            button_update.Enabled = false;
            button_update.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(217, 474);
            button_update.Margin = new Padding(4);
            button_update.Name = "button_update";
            button_update.Size = new Size(102, 27);
            button_update.TabIndex = 25;
            button_update.Text = "수정하기";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += btn_update_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(108, 190, 250);
            button3.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(388, 474);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(102, 27);
            button3.TabIndex = 24;
            button3.Text = "닫기";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_Cancel_Click;
            // 
            // idmodify
            // 
            idmodify.BackColor = Color.FromArgb(108, 190, 250);
            idmodify.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            idmodify.FlatStyle = FlatStyle.Flat;
            idmodify.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idmodify.ForeColor = Color.White;
            idmodify.Location = new Point(503, 96);
            idmodify.Margin = new Padding(4);
            idmodify.Name = "idmodify";
            idmodify.Size = new Size(60, 25);
            idmodify.TabIndex = 23;
            idmodify.Text = "수정";
            idmodify.UseVisualStyleBackColor = false;
            idmodify.Click += button2_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(108, 160, 220);
            panel6.Location = new Point(313, 429);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(163, 1);
            panel6.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(108, 160, 220);
            panel5.Location = new Point(313, 352);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(163, 1);
            panel5.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(108, 160, 220);
            panel4.Location = new Point(313, 276);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(163, 1);
            panel4.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(108, 160, 220);
            panel3.Location = new Point(313, 200);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 1);
            panel3.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 160, 220);
            panel2.Location = new Point(313, 130);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 1);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 160, 220);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 66);
            panel1.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(329, 21);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 30);
            label9.TabIndex = 0;
            label9.Text = "내 정보";
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.FromArgb(108, 160, 220);
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(405, 556);
            btn_Cancel.Margin = new Padding(5);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(123, 41);
            btn_Cancel.TabIndex = 17;
            btn_Cancel.Text = "취소하기";
            btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(108, 160, 220);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(196, 556);
            btn_update.Margin = new Padding(5);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(123, 41);
            btn_update.TabIndex = 16;
            btn_update.Text = "수정";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // pnBox
            // 
            pnBox.BorderStyle = BorderStyle.None;
            pnBox.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pnBox.Location = new Point(313, 320);
            pnBox.Margin = new Padding(5);
            pnBox.Name = "pnBox";
            pnBox.ReadOnly = true;
            pnBox.Size = new Size(163, 18);
            pnBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(144, 330);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 14;
            label8.Text = "휴대폰번호";
            // 
            // nnBox
            // 
            nnBox.BorderStyle = BorderStyle.None;
            nnBox.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nnBox.Location = new Point(313, 396);
            nnBox.Margin = new Padding(5);
            nnBox.Name = "nnBox";
            nnBox.ReadOnly = true;
            nnBox.Size = new Size(163, 18);
            nnBox.TabIndex = 11;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.None;
            nameBox.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nameBox.Location = new Point(313, 242);
            nameBox.Margin = new Padding(5);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(163, 18);
            nameBox.TabIndex = 10;
            // 
            // pwBox
            // 
            pwBox.BorderStyle = BorderStyle.None;
            pwBox.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pwBox.Location = new Point(313, 166);
            pwBox.Margin = new Padding(5);
            pwBox.Name = "pwBox";
            pwBox.ReadOnly = true;
            pwBox.Size = new Size(163, 18);
            pwBox.TabIndex = 9;
            // 
            // idBox
            // 
            idBox.BorderStyle = BorderStyle.None;
            idBox.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            idBox.Location = new Point(313, 96);
            idBox.Margin = new Padding(5);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(163, 18);
            idBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(160, 408);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 7;
            label4.Text = "닉네임";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(168, 254);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 6;
            label3.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(151, 178);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 5;
            label2.Text = "비밀번호";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 101);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 4;
            label1.Text = "아이디";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel11);
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(myReviewView);
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(810, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "내가 남긴 리뷰";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(108, 160, 220);
            panel11.Controls.Add(btn_reviewDelete);
            panel11.Controls.Add(btn_reviewUpdate);
            panel11.Controls.Add(btn_reviewclose);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(4, 469);
            panel11.Name = "panel11";
            panel11.Size = new Size(802, 39);
            panel11.TabIndex = 22;
            // 
            // btn_reviewDelete
            // 
            btn_reviewDelete.BackColor = Color.FromArgb(108, 190, 250);
            btn_reviewDelete.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            btn_reviewDelete.FlatStyle = FlatStyle.Flat;
            btn_reviewDelete.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reviewDelete.ForeColor = Color.White;
            btn_reviewDelete.Location = new Point(276, 7);
            btn_reviewDelete.Margin = new Padding(4);
            btn_reviewDelete.Name = "btn_reviewDelete";
            btn_reviewDelete.Size = new Size(102, 27);
            btn_reviewDelete.TabIndex = 4;
            btn_reviewDelete.Text = "삭제하기";
            btn_reviewDelete.UseVisualStyleBackColor = false;
            btn_reviewDelete.Click += btn_reviewDelete_Click;
            // 
            // btn_reviewUpdate
            // 
            btn_reviewUpdate.BackColor = Color.FromArgb(108, 190, 250);
            btn_reviewUpdate.FlatAppearance.BorderColor = Color.FromArgb(108, 190, 250);
            btn_reviewUpdate.FlatStyle = FlatStyle.Flat;
            btn_reviewUpdate.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reviewUpdate.ForeColor = Color.White;
            btn_reviewUpdate.Location = new Point(386, 7);
            btn_reviewUpdate.Margin = new Padding(4);
            btn_reviewUpdate.Name = "btn_reviewUpdate";
            btn_reviewUpdate.Size = new Size(102, 27);
            btn_reviewUpdate.TabIndex = 2;
            btn_reviewUpdate.Text = "수정하기";
            btn_reviewUpdate.UseVisualStyleBackColor = false;
            btn_reviewUpdate.Click += btn_reviewUpdate_Click;
            // 
            // btn_reviewclose
            // 
            btn_reviewclose.BackColor = Color.FromArgb(108, 190, 250);
            btn_reviewclose.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            btn_reviewclose.FlatStyle = FlatStyle.Flat;
            btn_reviewclose.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reviewclose.ForeColor = Color.White;
            btn_reviewclose.Location = new Point(496, 7);
            btn_reviewclose.Margin = new Padding(4);
            btn_reviewclose.Name = "btn_reviewclose";
            btn_reviewclose.Size = new Size(75, 27);
            btn_reviewclose.TabIndex = 3;
            btn_reviewclose.Text = "닫기";
            btn_reviewclose.UseVisualStyleBackColor = false;
            btn_reviewclose.Click += btn_Cancel_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(108, 160, 220);
            panel8.Controls.Add(label11);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(4, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(802, 42);
            panel8.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(207, 5);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(153, 30);
            label11.TabIndex = 0;
            label11.Text = "내가 남긴 리뷰";
            // 
            // myReviewView
            // 
            myReviewView.BackgroundColor = Color.White;
            myReviewView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myReviewView.EnableHeadersVisualStyles = false;
            myReviewView.GridColor = Color.LightGray;
            myReviewView.Location = new Point(4, 53);
            myReviewView.Margin = new Padding(4);
            myReviewView.Name = "myReviewView";
            myReviewView.RowHeadersWidth = 5;
            myReviewView.RowTemplate.Height = 25;
            myReviewView.Size = new Size(802, 417);
            myReviewView.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel10);
            tabPage3.Controls.Add(panel9);
            tabPage3.Controls.Add(myBookmarkView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(810, 512);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "즐겨찾기";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(108, 160, 220);
            panel10.Controls.Add(btn_bmdelete);
            panel10.Controls.Add(button1);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 469);
            panel10.Name = "panel10";
            panel10.Size = new Size(810, 43);
            panel10.TabIndex = 21;
            // 
            // btn_bmdelete
            // 
            btn_bmdelete.BackColor = Color.FromArgb(108, 190, 250);
            btn_bmdelete.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            btn_bmdelete.FlatStyle = FlatStyle.Flat;
            btn_bmdelete.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bmdelete.ForeColor = Color.White;
            btn_bmdelete.Location = new Point(467, 7);
            btn_bmdelete.Margin = new Padding(4);
            btn_bmdelete.Name = "btn_bmdelete";
            btn_bmdelete.Size = new Size(131, 36);
            btn_bmdelete.TabIndex = 3;
            btn_bmdelete.Text = "즐겨찾기 삭제";
            btn_bmdelete.UseVisualStyleBackColor = false;
            btn_bmdelete.Click += btn_bmdelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(108, 190, 250);
            button1.FlatAppearance.BorderColor = Color.FromArgb(108, 160, 220);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(606, 7);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 2;
            button1.Text = "닫기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_Cancel_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(108, 160, 220);
            panel9.Controls.Add(label6);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(810, 46);
            panel9.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(324, 7);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 30);
            label6.TabIndex = 0;
            label6.Text = "내 즐겨찾기";
            // 
            // myBookmarkView
            // 
            myBookmarkView.BackgroundColor = Color.White;
            myBookmarkView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myBookmarkView.Location = new Point(4, 43);
            myBookmarkView.Margin = new Padding(4);
            myBookmarkView.Name = "myBookmarkView";
            myBookmarkView.RowHeadersWidth = 51;
            myBookmarkView.RowTemplate.Height = 25;
            myBookmarkView.Size = new Size(798, 427);
            myBookmarkView.TabIndex = 1;
            // 
            // MyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 587);
            Controls.Add(tab1);
            Controls.Add(label5);
            Name = "MyPage";
            Text = "MyPage";
            Load += MyPage_Load;
            tab1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myReviewView).EndInit();
            tabPage3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myBookmarkView).EndInit();
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
        private TextBox pnBox;
        private Label label8;
        private Button btn_update;
        private Button btn_Cancel;
        private Button btn_reviewclose;
        private Button btn_reviewUpdate;
        public DataGridView myReviewView;
        private Label label9;
        private DataGridView myBookmarkView;
        private Button button1;
        private Button btn_bmdelete;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
        private Label label11;
        private Panel panel9;
        private Label label6;
        private Panel panel11;
        private Panel panel10;
        private Button btn_reviewDelete;
        private Button nnmodify;
        private Button phnmodify;
        private Button nmmodify;
        private Button pwmodify;
        private Button button_update;
        private Button button3;
        private Button idmodify;
        private Button nmcomp;
        private Button phncom;
        private Button nmcom;
        private Button pwcom;
        private Button idcom;
        public TextBox idBox;
    }
}