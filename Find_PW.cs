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
    public partial class Find_PW : Form
    {
        public Find_PW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            
            string pw;
            pw = check.FindPW(NameBox.Text, IDBox.Text, PhoneNumbox.Text);
            if (pw == null) {
                MessageBox.Show("잘못된입력입니다");
            }
            else { MessageBox.Show(pw); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
