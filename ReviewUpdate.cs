using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ReviewUpdate : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        MyPage mypage;

        string UserId;
        int UserUid;

        public ReviewUpdate(MyPage form)
        {
            InitializeComponent();
            this.mypage = form;
            UserUid = form.UserUid;
            UserId = form.UserId;

            if (mypage.myReviewView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = mypage.myReviewView.SelectedRows[0];
                nnBox.Text = selectedRow.Cells["u_nickname"].Value.ToString();
                mnBox.Text = selectedRow.Cells["Title"].Value.ToString();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReviewUpdate_Load(object sender, EventArgs e)
        {
            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            string uid = mypage.myReviewView.SelectedRows[0].Cells[0].Value.ToString();

           


            cmd.CommandText = $"SELECT u.u_nickname, m.title, r.r_rate, r.r_content, r.r_date " +
                                $"FROM review r " +
                                $"INNER JOIN project_user u ON r.u_uid = u.u_uid " +
                                $"INNER JOIN MovieList M ON r.MovieUID = m.MovieUID " +
                                $"WHERE u.u_uid = {UserUid}";
            cmd.Parameters.AddWithValue("@u_uid", uid);

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                rvBox.Text = reader["r_content"].ToString();
                rtBox.Text = reader["r_rate"].ToString();

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
                SqlCommand checkid = cert.GetSqlCommand();


                // UPDATE 쿼리문 작성
                string sql = "UPDATE review SET " +
                    "r_content = @r_content , r_rate = @r_rate, r_date = @r_date";

                // SqlCommand 객체에 UPDATE 쿼리문 설정
                cmd.CommandText = sql;

                // UPDATE 쿼리문의 매개변수 값 설정
                cmd.Parameters.AddWithValue("@r_content", rvBox.Text);
                cmd.Parameters.AddWithValue("@r_rate", rtBox.Text);
                cmd.Parameters.AddWithValue("@r_date", DateTime.Now);
               

                // UPDATE 쿼리문 실행
                int rowsAffected = cmd.ExecuteNonQuery();

                mypage.LoadReviewView();
                mypage.Refresh();




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
           

            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
