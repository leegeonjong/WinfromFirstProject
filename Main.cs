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

namespace TeamProject
{
    public partial class Main : Form
    {
        const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        SqlConnection conn;
        SqlDataReader reader;
        private FlowLayoutPanel flowLayoutPanel;


        public Main()
        {
            InitializeComponent();

            LoadMovieDataAsync();

        }

        private async void LoadMovieDataAsync()
        {
            //Admin_Page adminPage = new Admin_Page();
            //adminPage.Show();

            const string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
            string name = "한국";
            using SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            using SqlCommand cmd = new SqlCommand("SELECT Title FROM MovieList WHERE Country = @name", conn);
            SqlParameter parameter = new SqlParameter("@name", System.Data.SqlDbType.VarChar);
            parameter.Value = name;
            cmd.Parameters.Add(parameter);

            using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                string title = reader.GetString(0);
                string imageUrl = await GetPosterUrlAsync(title);
                AddMovieItem(title, imageUrl);
            }

        }

        public async Task<string> GetPosterUrlAsync(string title)
        {
            string clientId = "FXqKsjIoNLVFmlkXvTzt";
            string clientSecret = "RZVA7QWEda";

            string apiUrl = $"https://openapi.naver.com/v1/search/movie.json?query={title}";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Naver-Client-Id", clientId);
            client.DefaultRequestHeaders.Add("X-Naver-Client-Secret", clientSecret);

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(result);
                JArray items = (JArray)json["item"];

                if (items.Count > 0)
                {
                    string imageUrl = (string)items[0]["image"];
                    MessageBox.Show(imageUrl);
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
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Size = new Size(5 * 130, 0)
            };

            this.Controls.Add(flowLayoutPanel);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
        }
    }
}