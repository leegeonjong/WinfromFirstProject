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

namespace TeamProject
{
    public partial class Admin_Page : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";

        public static Admin_Page mainForm;

        public Admin_Page()
        {
            InitializeComponent();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            DataViewLoad();
        }

        private void DataViewLoad()
        {

            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_level, u_nickname FROM project_user";
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            memberView.DataSource = dataTable;

            // 리소스 정리
            reader.Close();
            cmd.Dispose();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in memberView.SelectedCells)
                {
                    cell.OwningRow.Selected = true;
                }

                Cursor = Cursors.WaitCursor;

                if (memberView.SelectedRows.Count == 0) return; // 삭제하려는 row가 선택되어 있지 않으면 return


                // 삭제전에 확인
                if (MessageBox.Show($"{memberView.SelectedRows.Count}명의 유저를 삭제하시겠습니까?", "삭제확인"
                     , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                { return; }

                using SqlConnection conn = new(strConn);
                conn.Open();

                string sql = "DELETE project_user WHERE u_uid = @u_uid";

                int cnt = 0;

                foreach (DataGridViewRow row in memberView.SelectedRows)
                {
                    string uid = row.Cells[0].Value.ToString();  // PK 값은 첫번째 컬럼
                    using SqlCommand cmd = new(sql, conn);
                    cmd.Parameters.AddWithValue("@u_uid", uid);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        cnt += result;
                    }
                }

                DataViewLoad();   // 다시 로딩 해야 한다
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            

            foreach (DataGridViewCell cell in memberView.SelectedCells)
            {
                cell.OwningRow.Selected = true;
            }

            Admin_InformUpdate updatePage = new Admin_InformUpdate(this);
            updatePage.Show();
        }

        public void LoadMemberView()
        {
            try
            {
                // certification 인스턴스 생성 및 SqlCommand 객체 가져오기
                certification cert = new certification(strConn);
                SqlCommand cmd = cert.GetSqlCommand();

                // SELECT 쿼리문 작성
                string sql = "SELECT u_uid, u_id, u_name, u_phonenum, u_level, u_nickname FROM project_user";

                // SqlCommand 객체에 SELECT 쿼리문 설정
                cmd.CommandText = sql;

                // SqlDataReader 객체 생성
                SqlDataReader reader = cmd.ExecuteReader();

                // DataTable 객체 생성
                DataTable dataTable = new DataTable();

            memberView.DataSource = ds.Tables[0];

            memberView.Columns[0].ReadOnly = true;
            memberView.Columns[0].Width = 30;

            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //나머지 여백 차지해줌
            dataGridView1.AllowUserToDeleteRows = false; // 직접 행 삭제 불가
        }
    }
}
