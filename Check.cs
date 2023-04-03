
using Microsoft.Data.SqlClient;

namespace TeamProject
{
    public class Check
    {
        public void AddUser(string i, string i2, string i3, string i4, string i5)
        {
            string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
            var db = new certification(strConn);
            SqlCommand cmd = db.GetSqlCommand();
            cmd.CommandText = $"INSERT INTO Project_User" +
                $"(u_id, u_password, u_name, u_phonenum, u_nickname) " +
                $"VALUES ('{i}', '{i2}', '{i3}', '{i4}', '{i5}') ";
           cmd.ExecuteNonQuery();
        }
        //public Login() 
        //{
        //    string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";
        //    var db = new certification(strConn);
        //    SqlCommand cmd = db.GetSqlCommand();
        //}
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