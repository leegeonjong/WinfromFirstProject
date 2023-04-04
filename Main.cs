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

namespace TeamProject
{
    public partial class Main : Form
    {
        public int logStatus { get; set; }
        const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        SqlConnection conn;
        SqlDataReader reader;
        private FlowLayoutPanel flowLayoutPanel;


        public Main()
        {
            InitializeComponent();

            CB_Category.SelectedIndex = 0;
            LoadMovieDataAsync();

        }

        private async void LoadMovieDataAsync()
        {
            //Admin_Page adminPage = new Admin_Page();
            //adminPage.Show();

           
            string name = "한국";
            using SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList WHERE Country = @name", conn);
            SqlParameter parameter = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            parameter.Value = name;
            cmd.Parameters.Add(parameter);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            int i = 0;
            while (await reader.ReadAsync())
            {
                if (i == 100)
                    return;
                string title = reader.GetString(0);
                string imageUrl = await GetPosterUrlAsync(title);
                AddMovieItem(title, imageUrl);
                i++;
            }

        }

        public async Task<string> GetPosterUrlAsync(string title)
        {
            string your_client_id = "FXqKsjIoNLVFmlkXvTzt";
            string your_client_secret = "RZVA7QWEda";

            string apiUrl = $"https://openapi.naver.com/v1/search/movie.json?query={Uri.EscapeDataString(title)}";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Naver-Client-Id", your_client_id);
            client.DefaultRequestHeaders.Add("X-Naver-Client-Secret", your_client_secret);

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(result);
                JArray items = (JArray)json["items"];

                if (items.Count > 0)
                {
                    string imageUrl = (string)items[0]["image"];
                    return imageUrl;
                }
            }

            return null; // 영화 포스터를 찾을 수 없는 경우
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

            var titleLabel = new Label
            {
                Text = title,
                Location = new Point(0, 180),
                AutoSize = false,
                Size = new Size(120, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            panel.Controls.Add(titleLabel);

            fLPMain.Controls.Add(panel);

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
         
            string name = txtName.Text;
            using SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList WHERE Title = @name", conn);
            SqlParameter parameter = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            parameter.Value = name;
            cmd.Parameters.Add(parameter);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            fLPMain.Controls.Clear();
            while (await reader.ReadAsync())
            {
                string title = reader.GetString(0);
                string imageUrl = await GetPosterUrlAsync(title);

                AddMovieItem(title, imageUrl);
            }
        }

        private async void CB_Category_SelectedIndexChanged(object sender, EventArgs e)
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
                using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList ORDER BY ReleaseDate ASC;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();
                fLPMain.Controls.Clear();
                int i = 0;
                while (await reader.ReadAsync())
                {
                    if (i == 100)
                        return;
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);

                    AddMovieItem(title, imageUrl);
                }

            }
            if (CB_Category.SelectedIndex == 1)//내림
            {
                using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList ORDER BY ReleaseDate DESC;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                fLPMain.Controls.Clear();
                int i = 0;
                while (await reader.ReadAsync())
                {
                    if (i == 100)
                        return;
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }
            }
            if (CB_Category.SelectedIndex == 2)//매출
            {
                using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList ORDER BY Sales;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                fLPMain.Controls.Clear();
                int i = 0;
                while (await reader.ReadAsync())
                {
                    if (i == 100)
                        return;
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }
            }
            if (CB_Category.SelectedIndex == 3)//개봉
            {
                using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList ORDER BY ReleaseDate;", conn);
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                fLPMain.Controls.Clear();
                int i = 0;
                while (await reader.ReadAsync())
                {
                    if (i == 100)
                        return;
                    string title = reader.GetString(0);
                    string imageUrl = await GetPosterUrlAsync(title);
                    AddMovieItem(title, imageUrl);
                }
            }
        }
    }
}