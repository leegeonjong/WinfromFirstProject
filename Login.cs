using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TeamProject
{
    public partial class LoginForm : Form
    {

        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        private Main MainForm;
        
        public LoginForm(Main mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            Check check = new();
            int result = check.LogIn(TextId.Text.Trim(), TextPassword.Text.Trim());
            if (result == 1)
            {
                // 현재 로그인한 사용자가 관리자인 경우에만 adminpage를 띄움
                bool isAdmin = check.IsAdmin(TextId.Text.Trim());
                if (isAdmin)
                {
                    MessageBox.Show("관리자 로그인 성공");
                    var adminPage = new Admin_Page();
                    adminPage.Show();
                    this.Close();
                    return;
                }

                MessageBox.Show("로그인 성공");

                Main mainForm1 = new();
                {
                    Check check1 = new();

                    mainForm1.userNickname = check1.UserNickName(TextId.Text, TextPassword.Text);
                    mainForm1.userid = TextId.Text.Trim();
                }
                MainForm.Hide();
                mainForm1.Main_Load_1(sender, e);
                mainForm1.Show();      
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void btID_Click(object sender, EventArgs e)
        {
            Find_ID FID = new();
            FID.Show();
        }

        private void btPW_Click(object sender, EventArgs e)
        {
            Find_PW FPW = new();
            FPW.Show();
        }

        private void btJoin_Click(object sender, EventArgs e)
        {
            join_membership Jms = new join_membership();
            Jms.Show();
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextId_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
