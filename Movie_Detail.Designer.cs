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
            lbl1 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(298, 117);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(60, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "label1";
            // 
            // Movie_Detail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Name = "Movie_Detail";
            Text = "Movie_Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
    }
}