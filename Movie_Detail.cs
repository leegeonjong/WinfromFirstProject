using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Movie_Detail : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        string MovieTitle;
        int UseruId;
        int MovieUid;
        string username;
        
        
        bool bookmarkstatus;


        private Main MainForm;
        public Movie_Detail(Main mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            MovieUid = MainForm.movieuid;
            UseruId = MainForm.useruid;
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Detail_Load(object sender, EventArgs e)
        {
            Check check = new Check();
            //만약 즐겨찾기한경우라면 true
            bookmarkstatus = false;
            MovieTitle = check.FindMvName(MovieUid);
            labeltitle.Text = MovieTitle;
            if (MainForm.logStatus == true)
            {
                NickNameBox.Text = MainForm.userNickname;
            }

            DataViewLoad();
        }

        private void DataViewLoad()
        {

            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            Check check = new Check();
            string movieTitle = labeltitle.Text;
            MovieUid = check.FindMvUid(movieTitle);

            MovieTitle = check.FindMvName(MovieUid);
            cmd.CommandText = $"SELECT u.u_nickname, r.r_rate, r.r_content, r.r_date " +
                              $"FROM review r " +
                              $"INNER JOIN project_user u ON r.u_uid = u.u_uid " +
                              $"WHERE r.MovieUID = {MovieUid}";

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            ReviewView.DataSource = dataTable;

            // 리소스 정리
            reader.Close();
            cmd.Dispose();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            if (ratebox.Text == "별점")
            {
                MessageBox.Show("별점을 입력해주세요!!");
                return;
            }

            int rate = int.Parse(ratebox.Text);

            Check check = new Check();
            check.Addcontentt(MovieUid, UseruId, reviewBox.Text, rate, d1);

            if (reviewBox.Text.IsNullOrEmpty())
            {
                reviewBox.Text = "재밌어요";
            }
            
           
            if (check.countreview(MovieUid, UseruId) > 0)
            {
                MessageBox.Show("이미 리뷰를 등록한 영화입니다");
            }
            else
            {
                check.Addcontentt(MovieUid, UseruId, reviewBox.Text, rate, d1);
                MessageBox.Show("리뷰등록!");
            }

            DataViewLoad();



        }



        private void bookmarkon_Click(object sender, EventArgs e)
        {
            if (NickNameBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("로그인하지않으면 리뷰를 남길 수 없습니다");
            }
            if (bookmarkstatus == false)
            {
                MessageBox.Show("즐겨찾기 추가");
                bookmarkon.Image = Properties.Resources.bookmarkon;
                bookmarkstatus = true;
            }
            if (bookmarkstatus == true)
            {
                MessageBox.Show("즐겨찾기 해제");
                bookmarkon.Image = Properties.Resources.bookmarkon;
                bookmarkstatus = false;
            }



        }
    }
}
