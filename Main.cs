using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Xml;
using MySqlX.XDevAPI;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace TeamProject
{
    public partial class Main : Form
    {

        public bool logStatus { get; set; }
        public string userNickname { get; set; }
        public string userid { get; set; }
        public int useruid { get; set; }
        public int movieuid { get; set; }


        const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        SqlConnection conn;
        SqlDataReader reader;
        private FlowLayoutPanel flowLayoutPanel;
        int rank;

        public Main()
        {
            InitializeComponent();
            LoadMovieDataAsync();
            CB_Category.SelectedIndex = 0;
        }
        private async Task LoadMovieDataAsync()
        {
            //Admin_Page adminPage = new Admin_Page();
            //adminPage.Show();
            string Country = "한국";
            const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
            using SqlConnection conn = new SqlConnection(strConn);
            await conn.OpenAsync();

            using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList WHERE Country = @Country", conn);
            SqlParameter parameter = new SqlParameter("@Country", System.Data.SqlDbType.VarChar);
            parameter.Value = Country;
            cmd.Parameters.Add(parameter);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            rank = 0;
            while (await reader.ReadAsync())
            {
                string title = reader.GetString(0);
                string imageUrl = await SearchMovie(title);
                AddMovieItem(title, imageUrl);
            }

        }

        public async Task<string> SearchMovie(string title)
        {
            string jsonResult = await RequestKMDbAPIAsync(title);

            if (jsonResult != null)
            {
                JObject movieData = JObject.Parse(jsonResult);
                int totalCount = (int)movieData["TotalCount"];

                JArray movies = (JArray)movieData["Data"][0]["Result"];

                // 첫 번째 결과만 처리
                JObject firstMovie = (JObject)movies[0];
                string Title = (string)firstMovie["title"];
                string imageData = (string)firstMovie["posters"];
                string[] imageUrls = imageData.Split('|');
                string url = imageUrls[0];

                return url; // 여기서 URL을 반환합니다.
            }

            return null;
        }
        public async Task<string> RequestKMDbAPIAsync(string query)
        {
            string apiKey = "P28PN59FB6LVB4301Z83";
            string apiUrl = $" http://api.koreafilm.or.kr/openapi-data2/wisenut/search_api/search_json2.jsp?collection=kmdb_new2&detail=Y&query={query}&ServiceKey={apiKey}";

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
        private void AddMovieItem(string title, string posterUrl)
        {

            var panel = new Panel
            {
                Size = new Size(120, 200),
                Margin = new Padding(5)
            };

            var pictureBox = new PictureBox
            {
                Size = new Size(120, 180),
                Location = new Point(0, 0),
                ImageLocation = posterUrl,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            panel.Controls.Add(pictureBox);
            rank++;
            var titleLabel = new Label
            {
                Text = $"[{rank}] {title}",
                Location = new Point(0, 180),
                AutoSize = true,
                AutoEllipsis = false,
                Size = new Size(120, 40),
                TextAlign = ContentAlignment.TopCenter,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            titleLabel.DoubleClick += TitleLabel_DoubleClick;
            panel.Controls.Add(titleLabel);

            fLPMain.Controls.Add(panel);

        }
        private void TitleLabel_DoubleClick(object sender, EventArgs e)
        {
            Check check1 = new();
            if (sender is Label titleLabel)
            {
                string movieTitle = titleLabel.Text;
                movieuid = check1.FindMvUid(movieTitle.Trim().Substring(movieTitle.IndexOf(']') + 1));
                Movie_Detail MDT = new(this);
                MDT.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "로그아웃")
            {
                MessageBox.Show("로그아웃되었습니다.");
                this.Close();
                Main main = new Main();
                main.Main_Load(sender, e);
                main.Show();
                return;
            }
            LoginForm lg = new(this);
            lg.Show();

        }
        private void Main_Load(object sender, EventArgs e)
        {
            logStatus = false;

        }
        public void Main_Load_1(object sender, EventArgs e)
        {
            Check chk = new Check();
            logStatus = true;
            btnLogin.Text = "로그아웃";
            label_id.Text = userid;
            label_nn.Text = userNickname;
            useruid = chk.FindUid(label_id.Text);
            mypage.Visible = true;


        }
        private async void CB_Category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string orderByColumn = "Title ASC"; //기본정렬값
            orderByColumn = CB_Category.SelectedIndex switch
            {
                0 => "Sales",           //매출액 순서
                1 => "Title ASC",       //오름차순
                2 => "Title DESC",      //내림차순
                3 => "ReleaseDate DESC",//최신 작품순
                4 => "ReleaseDate ASC", //예전 작품순
            };
            DateTime startDate = dTPStart.Value;
            DateTime endDate = dTPEnd.Value;
            GetDataAndDisplay(startDate, endDate, orderByColumn);
            return;
        }

        private async void GetDataAndDisplay(DateTime startDate, DateTime endDate, string orderByColumn)
        {
            const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";

            using SqlConnection conn = new SqlConnection(strConn);
            await conn.OpenAsync();

            string query = $"SELECT TOP 50 Title FROM MovieList WHERE ReleaseDate BETWEEN @StartDate AND @EndDate ORDER BY {orderByColumn}";
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            fLPMain.Controls.Clear();
            rank = 0;
            while (await reader.ReadAsync())
            {
                string title = reader.GetString(0);
                string imageUrl = await SearchMovie(title);
                AddMovieItem(title, imageUrl);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            //paramBeginDate.Value = dtBegin.Value.ToString("yyyy-MM-dd");
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("1글자 이상 검색하세요");
                return;
            }

            const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
            string name = txtName.Text;
            using SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            bool startDatePickerChanged = false;
            bool endDatePickerChanged = false;
            dTPStart.ValueChanged += (sender, e) => startDatePickerChanged = true;
            dTPEnd.ValueChanged += (sender, e) => endDatePickerChanged = true;
            btnSearch.Click += async (sender, e) =>
            {
                if (startDatePickerChanged && endDatePickerChanged)
                {
                    DateTime startDate = dTPStart.Value;
                    DateTime endDate = dTPEnd.Value;

                    using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList WHERE ReleaseDate BETWEEN @startDate AND @endDate", conn);
                    SqlParameter startParam = new SqlParameter("@startDate", System.Data.SqlDbType.Date);
                    startParam.Value = startDate;
                    cmd.Parameters.Add(startParam);

                    SqlParameter endParam = new SqlParameter("@endDate", System.Data.SqlDbType.Date);
                    endParam.Value = endDate;
                    cmd.Parameters.Add(endParam);

                    using SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    fLPMain.Controls.Clear();
                    rank = 0;
                    while (await reader.ReadAsync())
                    {
                        string title = reader.GetString(0);
                        string imageUrl = await SearchMovie(title);
                        AddMovieItem(title, imageUrl);
                    }
                    return;
                }
            };

            using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList WHERE Title LIKE @name", conn);
            SqlParameter parameter = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            parameter.Value = "%" + name + "%";
            cmd.Parameters.Add(parameter);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            fLPMain.Controls.Clear();
            rank = 0;
            while (await reader.ReadAsync())
            {
                string title = reader.GetString(0);
                string imageUrl = await SearchMovie(title);
                AddMovieItem(title, imageUrl);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void mypage_Click(object sender, EventArgs e)
        {
            Check chk = new();
            useruid = chk.FindUid(label_id.Text);
            Admin_Page page = new Admin_Page(this);
            page.Show();
            page.Close();
            MyPage mypage = new MyPage(page, this);
            mypage.Show();

        }
    }
}