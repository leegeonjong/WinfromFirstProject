
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