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
    public partial class Find_ID : Form
    {
        public string id { get; set; }
        public Find_ID()
        {
            InitializeComponent();
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            Check check = new Check();
          
            
            id = check.FindID(NameBox.Text, PhonenumBox.Text);
            if (id == null)
            {
                MessageBox.Show("잘못된 값입니다");
            }
            else
                MessageBox.Show(id);
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
