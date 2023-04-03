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
    public partial class Admin_InformUpdate : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";

        Admin_Page adminform;

        public Admin_InformUpdate(Admin_Page form)
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

            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();
            string uid = adminform.memberView.SelectedRows[0].Cells[0].Value.ToString();

            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_level, u_nickname FROM project_user WHERE u_uid = @u_uid";
            cmd.Parameters.AddWithValue("@u_uid", uid);


            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                UidBox.Text = reader["u_uid"].ToString();
                IdBox.Text = reader["u_id"].ToString();
                PwBox.Text = reader["u_password"].ToString();
                NameBox.Text = reader["u_name"].ToString();
                pnBox.Text = reader["u_phonenum"].ToString();
                lvBox.Text = reader["u_level"].ToString();
                nnBox.Text = reader["u_nickname"].ToString();
            }

            // SqlDataReader 객체를 닫습니다.
            reader.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // certification 인스턴스 생성 및 SqlCommand 객체 가져오기
                certification cert = new certification(strConn);
                SqlCommand cmd = cert.GetSqlCommand();

                // UPDATE 쿼리문 작성
                string sql = "UPDATE project_user SET u_id = @u_id, u_password = @u_password, u_name = @u_name, u_phonenum = @u_phonenum, u_level = @u_level, u_nickname = @u_nickname WHERE u_uid = @u_uid";

                // SqlCommand 객체에 UPDATE 쿼리문 설정
                cmd.CommandText = sql;

                // UPDATE 쿼리문의 매개변수 값 설정
                cmd.Parameters.AddWithValue("@u_uid", UidBox.Text);
                cmd.Parameters.AddWithValue("@u_id", IdBox.Text);
                cmd.Parameters.AddWithValue("@u_password", PwBox.Text);
                cmd.Parameters.AddWithValue("@u_name", NameBox.Text);
                cmd.Parameters.AddWithValue("@u_phonenum", pnBox.Text);
                cmd.Parameters.AddWithValue("@u_level", lvBox.Text);
                cmd.Parameters.AddWithValue("@u_nickname", nnBox.Text);

                // UPDATE 쿼리문 실행
                int rowsAffected = cmd.ExecuteNonQuery();
                adminform.LoadMemberView();
                adminform.Refresh();



                if (rowsAffected > 0)
                {
                    
                    MessageBox.Show("데이터가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("데이터 수정에 실패하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
