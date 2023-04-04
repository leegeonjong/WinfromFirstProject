using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    
    public partial class join_membership : Form
    {
        int ch = 0;
        int i = 0;
        public join_membership()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("id중복검사를 해주세요");
                return;
            }
            else if (i == 2 || i == 3)
            {
                MessageBox.Show("id중복검사에 실패했습니다");
                return;
            }
            else if (i == 1) 
            {
            
            }
            checking(IDBox.Text.Trim());
            checking(PWbox.Text.Trim());
            checking(NameBox.Text.Trim());
            checking(PhnBox.Text.Trim());
            checking(nnBox.Text.Trim());
            if (ch != 0)
            {
                MessageBox.Show("빈칸이 있는 항목이 있습니다. 회원가입이 실패했습니다.");
                ch = 0;
                return;
            }
            if (IDBox.ReadOnly == false)
            {
                MessageBox.Show("ID 중복검사를 해주세요");
                 return;
            }
            Check check = new Check();
            check.AddUser(IDBox.Text.Trim(), PWbox.Text.Trim(), NameBox.Text.Trim(), PhnBox.Text.Trim(), nnBox.Text.Trim());
            this.Close();
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            
            i = check.CheckID(IDBox.Text.Trim());
            if (IDBox.Text.Trim().IsNullOrEmpty())
            {
                i = 3;
             }
            if (i == 1)
            {
                MessageBox.Show("중복검사에 성공하였습니다");
                IDBox.ReadOnly = true;


            }
            else if (i == 2)
            {
                MessageBox.Show("중복검사에 실패하였습니다");
                IDBox.Text = "";
            }
            else if (i == 3) 
            {
                MessageBox.Show("빈칸 입력 불가");
            }
        }
        private int checking(string a)
        {
            
            if (a.IsNullOrEmpty())
            {
                ch++;
            }
            return ch;
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDBox.ReadOnly = false;
        }
    }
 
}
