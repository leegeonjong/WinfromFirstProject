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
        public join_membership()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.AddUser(IDBox.Text, PWbox.Text,NameBox.Text,PhnBox.Text ,nnBox.Text);
            this.Close();
        }
    }
}
