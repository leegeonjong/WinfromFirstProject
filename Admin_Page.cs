using Microsoft.Data.SqlClient;
using Mysqlx.Crud;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamProject
{
   
    public partial class Admin_Page : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        public int usuid { get; set; }
        public int userUid { get; set; }

        
        private Main MainForm;
        public Admin_Page(Main mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            DataViewLoad();
        }

        private void DataViewLoad()
        {

            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_nickname FROM project_user";
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
                 
                string sql = "DELETE Review WHERE u_uid = @u_uid; " +
                    " DELETE BookMark WHERE u_uid = @u_uid; " +
                    " DELETE project_user WHERE u_uid = @u_uid; ";



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
            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_nickname FROM project_user";
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            memberView.DataSource = dataTable;

            // 리소스 정리
            reader.Close();
            cmd.Dispose();

        }

        private void memberView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (colIndex == 0)
            {
                DataGridViewRow row = memberView.Rows[rowIndex];
                usuid = (int)row.Cells[0].Value;
                // detailForm 객체 생성 및 화면에 표시
                MyPage mypage = new MyPage(this,MainForm);              
                mypage.StartPosition = FormStartPosition.CenterScreen;
                mypage.Show();                
                
            }
            MainForm.useruid = userUid;                                
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            string searchText = SearchBox.Text.Trim(); // 텍스트박스에서 검색어 가져오기
            cmd.CommandText = "SELECT u_uid,u_id, u_password, u_name, u_phonenum, u_nickname FROM project_user WHERE u_id LIKE @searchText";
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // 검색어 매개변수 추가

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            memberView.DataSource = dataTable;

            // 리소스 정리
            reader.Close();
            cmd.Dispose();
        }

     
    }
}
