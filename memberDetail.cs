using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeamProject
{
    public partial class memberDetail : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";

        Admin_Page adminform;

        public memberDetail(Admin_Page form)
        {
            InitializeComponent();

            this.adminform = form;
            if (adminform.memberView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = adminform.memberView.SelectedRows[0];
                UidBox.Text = selectedRow.Cells["u_uid"].Value.ToString();
            }

        }

        private void Admin_InformUpdate_Load(object sender, EventArgs e)
        {
            Check check = new Check();
            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();
            int uid = (int)adminform.memberView.SelectedRows[0].Cells[0].Value;


            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_level, u_nickname FROM project_user WHERE u_uid = @u_uid";
            cmd.Parameters.AddWithValue("@u_uid", uid);

            SqlDataReader reader = cmd.ExecuteReader();


            int countriview = check.countreview1(uid);
            int countbookmark = check.countrbookmark(uid);


            while (reader.Read())
            {
                UidBox.Text = reader["u_uid"].ToString();
                IdBox.Text = reader["u_id"].ToString();
                PwBox.Text = reader["u_password"].ToString();
                NameBox.Text = reader["u_name"].ToString();
                pnBox.Text = reader["u_phonenum"].ToString();
                nnBox.Text = reader["u_nickname"].ToString();
            }

            rvBox.Text = countriview.ToString() + "개";
            textBox1.Text = countbookmark.ToString() + "개";

            // SqlDataReader 객체를 닫습니다.
            reader.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
