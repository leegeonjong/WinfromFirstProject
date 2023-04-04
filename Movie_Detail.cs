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
    public partial class Movie_Detail : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        string MovieTitle;
        string UserId;
        int MovieUid;
        public Movie_Detail()
        {
            InitializeComponent();

        }


        public void AddReview(int movieUid, string userUid, string comment, string rate)
        {
            Check check1 = new();
            certification cert = new certification(strConn);
            SqlCommand cmd = cert.GetSqlCommand();

            int mvUid = check1.FindMvUid();
           

            comment = reviewBox.Text;
            rate = rateBox.Text;

            if (mvUid == 0)
                throw new ArgumentException("영화가 존재하지 않습니다.");

            if (uid == 0)
                throw new ArgumentException("유저가 존재하지 않습니다.");

            cmd.CommandText = $"INSERT INTO Review (m_uid, u_uid, r_content, r_rate) " +
                  $"VALUES ('{movieUid}', '{userUid}', '{comment}' ,{rate})";
            cmd.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReview(MovieUid,UserId,reviewBox.Text,rateBox.Text);
        }
    }
}
