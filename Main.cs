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

namespace TeamProject
{
    public partial class Main : Form
    {

        public bool logStatus { get; set; }
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

        private async void LoadMovieDataAsync()
        {
            //Admin_Page adminPage = new Admin_Page();
            //adminPage.Show();


            const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
            string Country = "한국";

            using SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList", conn);
            SqlParameter parameter = new SqlParameter("@Country", System.Data.SqlDbType.VarChar);
            parameter.Value = Country;
            cmd.Parameters.Add(parameter);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            rank = 0;
            while (await reader.ReadAsync())
            {
                string title = reader.GetString(0);
                string imageUrl = await GetPosterUrlAsync(title);
                AddMovieItem(title, imageUrl);
            }

        }

        public async Task<string> GetPosterUrlAsync(string title)
        {
            //https://api.themoviedb.org/3/discover/movie?api_key=9587124340afc34dae9ecf63d2710f6f&language=ko-KR
            //TMDbClient client = new TMDbClient("9587124340afc34dae9ecf63d2710f6f");
            //Movie movie = client.GetMovieAsync(299536).Result;
            ////Console.WriteLine($"Movie name: {movie.Title}\n\n");

            //SearchContainer<SearchMovie> results = client.SearchMovieAsync("어벤져스").Result;

            //Console.WriteLine($"Got {results.Results.Count:N0} of {results.TotalResults:N0} results");
            //foreach (SearchMovie result in results.Results)
            //    Console.WriteLine($"| TItle: {result.Title,-45} | Poster Path: {result.PosterPath,-35} |{result.Id}");
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
                AutoSize = false,
                Size = new Size(120, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            panel.Controls.Add(titleLabel);

            fLPMain.Controls.Add(panel);

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lg = new(this);
            lg.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            logStatus = false;
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            logStatus = true;
        }

        private void Main_Load_2(object sender, EventArgs e)
        {

        }

        private async void CB_Category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //오름차순
            //내림차순
            //매출순위
            //개봉일자
            string name = txtName.Text;
            using SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            if (CB_Category.SelectedIndex == 0)//오름
            {
                using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList ORDER BY ReleaseDate ASC;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();
                fLPMain.Controls.Clear();
                rank = 0;
                while (await reader.ReadAsync())
                {
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }

            }
            if (CB_Category.SelectedIndex == 1)//내림
            {
                using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList ORDER BY ReleaseDate DESC;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                fLPMain.Controls.Clear();
                rank = 0;
                while (await reader.ReadAsync())
                {
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }
            }
            if (CB_Category.SelectedIndex == 2)//매출
            {
                using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList ORDER BY Sales;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                fLPMain.Controls.Clear();
                rank = 0;
                while (await reader.ReadAsync())
                {
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }
            }
            if (CB_Category.SelectedIndex == 3)//개봉
            {
                using SqlCommand cmd = new SqlCommand("SELECT TOP 50 Title FROM MovieList ORDER BY ReleaseDate;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                fLPMain.Controls.Clear();
                rank = 0;
                while (await reader.ReadAsync())
                {
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }
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
            btnSearch.Click += (sender, e) =>
            {
                if (startDatePickerChanged && endDatePickerChanged)
                {
                    DateTime startDate = dTPStart.Value;
                    DateTime endDate = dTPEnd.Value;
                    Console.WriteLine($"시작 날짜: {startDate}");
                    // 시작 날짜를 사용하여 원하는 작업을 수행하세요.
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
                string imageUrl = await GetPosterUrlAsync(title);

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
    }
}