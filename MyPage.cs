using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeamProject
{
    public partial class MyPage : Form
    {

        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";

        Admin_Page adminform;
        public MyPage(Admin_Page form)
        {
            InitializeComponent();

            this.adminform = form;
         
        }

        private void MyPage_Load(object sender, EventArgs e)
        {
            certification cert = new certification(strConn);           
            SqlCommand cmd = cert.GetSqlCommand();

            foreach (DataGridViewCell cell in adminform.memberView.SelectedCells)
            {
                cell.OwningRow.Selected = true;
            }

            string uid = adminform.memberView.SelectedCells[0].Value.ToString();

            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_level, u_nickname FROM project_user WHERE u_uid = @u_uid";
            cmd.Parameters.AddWithValue("@u_uid", uid);



            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
               
                idBox.Text = reader["u_id"].ToString();
                pwBox.Text = reader["u_password"].ToString();
                nameBox.Text = reader["u_name"].ToString();
                pnBox.Text = reader["u_phonenum"].ToString();
                nnBox.Text = reader["u_nickname"].ToString();
                lvBox.Text = reader["u_level"].ToString();
              
            }

            // SqlDataReader 객체를 닫습니다.
            reader.Close();
        }
    }
}
