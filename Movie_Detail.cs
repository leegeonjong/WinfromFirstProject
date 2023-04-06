using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Objects.Search;

namespace TeamProject
{
    public partial class Movie_Detail : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        string MovieTitle;
        int UseruId;
        int MovieUid;

        bool bookmarkstatus;

        private Main MainForm;
        public Movie_Detail(Main mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            MovieUid = MainForm.movieuid;
            UseruId = MainForm.useruid;
        }
        public void SetMovieDetails(string movieTitle, string moviePosterUrl)
        {
            //영화 포스터
            pictureBox1.ImageLocation = moviePosterUrl;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void Movie_Detail_Load(object sender, EventArgs e)
        {
            Check check = new Check();
            bookmarkstatus = check.bookmarkis(MovieUid, UseruId);
            if (bookmarkstatus == true)
            {
                book.Image = Properties.Resources.bookmarkon;
            }
            else if (bookmarkstatus == false)
            {
                book.Image = Properties.Resources.bookmarkoff;
            }


            MovieTitle = check.FindMvName(MovieUid);
            labeltitle.Text = MovieTitle;
            if (MainForm.logStatus == true)
            {
                NickNameBox.Text = MainForm.userNickname;
            }

            await SearchMovie(MovieTitle);

            DataViewLoad();
        }
        public async Task<string> SearchMovie(string title)
        {
            string jsonResult = await RequestKMDbAPIAsync(title);

            if (jsonResult != null)
            {
                JObject movieData = JObject.Parse(jsonResult);
                JArray movies = (JArray)movieData["Data"][0]["Result"];

                // 첫 번째 결과만 처리
                JObject Movie = (JObject)movies[0];
                lblGenre.Text = (string)Movie["genre"];

                string dateString = (string)Movie["repRlsDate"];

                if (!string.IsNullOrEmpty(dateString))
                {
                    DateTime date = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
                    string formattedDate = date.ToString("yyyy년 MM월 dd일");
                    lblDate.Text = formattedDate;
                }
                else
                {
                    lblDate.Text = "날짜 정보 없음";
                }
                lblRuntime.Text = (string)Movie["runtime"] + "(분)";

                // 영화감독 이름 추출
                string directorNames = string.Join(", ", Movie["directors"]["director"].Select(d => d["directorNm"].ToString()));

                // 출연배우 이름 추출
                string actorNames = string.Join(", ", Movie["actors"]["actor"].Select(a => a["actorNm"].ToString()));

                // 줄거리 추출
                string plotText = Movie["plots"]["plot"].FirstOrDefault(p => p["plotLang"].ToString() == "한국어")?["plotText"].ToString();

                // 추출한 데이터를 레이블에 할당합니다.
                lblDirector.Text = directorNames;
                txtlActor.Text = actorNames;
                txtplot.Text = plotText;
            }

            return null;
        }
        public async Task<string> RequestKMDbAPIAsync(string query)
        {
            string apiKey = "P28PN59FB6LVB4301Z83";
            string apiUrl = $" http://api.koreafilm.or.kr/openapi-data2/wisenut/search_api/search_json2.jsp?collection=kmdb_new2&detail=Y" +
                $"&title={query}&ServiceKey={apiKey}";

            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    return jsonResult;
                }
            }

            return null;
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


            if (reviewBox.Text.IsNullOrEmpty())
            {
                reviewBox.Text = "재밌어요";
            }

            if (NickNameBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("로그인후 별점과 comment를 남겨주세요");
            }

            if (check.countreview(MovieUid, UseruId) > 0)
            {
                MessageBox.Show("이미 리뷰를 등록한 영화입니다");
            }
            else
            {
                check.Addcontentt(MovieUid, UseruId, reviewBox.Text, rate, d1);
                check.UpdateAvgRate(MovieUid);
                MessageBox.Show("리뷰등록!");
            }

            DataViewLoad();



        }

        private void book_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            if (NickNameBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("로그인하지않으면 즐겨찾기 불가!");
                return;
            }
            if (bookmarkstatus == false)
            {
                MessageBox.Show("즐겨찾기 추가");

                book.Image = Properties.Resources.bookmarkon;

                check.bookmarkon(MovieUid, UseruId, bookmarkstatus);
                bookmarkstatus = true;
            }
            else if (bookmarkstatus == true)
            {
                MessageBox.Show("즐겨찾기 해제");

                book.Image = Properties.Resources.bookmarkoff;
                check.bookmarkon(MovieUid, UseruId, bookmarkstatus);
                bookmarkstatus = false;
            }
        }
    }
}
