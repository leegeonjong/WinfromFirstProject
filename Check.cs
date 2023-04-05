
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace TeamProject
{
    public class Check
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        public void AddUser(string i, string i2, string i3, string i4, string i5)
        {

            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"INSERT INTO Project_User" +
                $"(u_id, u_password, u_name, u_phonenum, u_nickname) " +
                $"VALUES ('{i}', '{i2}', '{i3}', '{i4}', '{i5}') ";
            cmd.ExecuteNonQuery();
        }
        public int LogIn(string id, string password)
        {

            var db = new certification(strConn);
            using SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Project_User WHERE u_id = '{id}' AND u_password = '{password}'", conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();

            return count == 1 ? 1 : 2;
        }
        public string FindID(string Name, string Phnum)
        {

            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_id FROM Project_User WHERE u_name = '{Name}' AND u_phonenum = '{Phnum}'";
            return cmd.ExecuteScalar()?.ToString();


        }
        public string FindPW(string Name, string ID, string Phnum)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_id FROM Project_User " +
                $"WHERE u_name = '{Name}' AND u_id= '{ID}' AND u_phonenum= '{Phnum}'";
            return cmd.ExecuteScalar()?.ToString();


        }


        public bool IsAdmin(string userId)
        {
            string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_isadmin FROM Project_User WHERE u_id='{userId}'";
            object isAdmin = cmd.ExecuteScalar();
            if (isAdmin != null && isAdmin != DBNull.Value)
            {
                return (bool)isAdmin;
            }
            return false;



        }

        public int CheckID(string ID)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_id FROM Project_User " +
             $"WHERE u_id = '{ID}'";
            string ch = cmd.ExecuteScalar()?.ToString();
            if (ch == null)
            {
                return 1;
            }
            else
                return 2;
        }
        public string UserNickName(string ID, string PW)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_nickname FROM Project_User " +
                $"WHERE u_id = '{ID}' AND u_password= '{PW}'";
            return cmd.ExecuteScalar()?.ToString();
        }

        public int FindUid(string ID)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_uid FROM Project_User " +
                $"WHERE u_id = '{ID}'";
            return (int)cmd.ExecuteScalar();
        }
        public string Findid(int uid)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_id FROM Project_User " +
                $"WHERE u_uid = '{uid}'";
            return cmd.ExecuteScalar()?.ToString();
        }
        public string Findnick(int uid)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT u_nickname FROM Project_User " +
                $"WHERE u_uid = '{uid}'";
            return cmd.ExecuteScalar()?.ToString();
        }

        public int FindMvUid(string Title)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT MovieUID FROM MovieList " +
                $"WHERE Title = '{Title.Trim()}'";
            object result = cmd.ExecuteScalar();
            return Convert.ToInt32(result);
        }
        public string FindMvName(int uid)
        {
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"SELECT Title FROM MovieList " +
                $"WHERE MovieUid = '{uid}'";
            string result = cmd.ExecuteScalar()?.ToString();
            return result;
        }
        public void Addcontentt(int muid, int uuid, string content, int rate, DateTime date)
        {

            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();


            cmd.CommandText = $"INSERT INTO Review " +
                    $"(u_uid, MovieUID, r_content, r_rate, r_date) " +
                    $"VALUES ('{uuid}', '{muid}', '{content}', '{rate}', '{date.ToString("yyyy-MM-dd HH:mm:ss")}')";

            cmd.ExecuteNonQuery();
        }

    }
}
//u_uid int NOT NULL IDENTITY(1,1),
//  u_id varchar(20) NOT NULL,
//  u_password varchar(20) NOT NULL,
//  u_name     varchar(10) NOT NULL,
//  u_phonenum varchar     NOT NULL,
//  u_level    int         NOT NULL DEFAULT 1,
//  u_nickname varchar     NOT NULL,
//  u_isadmin  bit         NOT NULL DEFAULT 0,