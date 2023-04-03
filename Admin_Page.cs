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
    public partial class Admin_Page : Form
    {
        string strConn = "Server=127.0.0.1; Database=teamproject; uid=project; pwd=1234; Encrypt=false";


        public Admin_Page()
        {
            InitializeComponent();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {
            DataViewLoad();
        }

        private void DataViewLoad()
        {
            using SqlConnection conn = new(strConn);
            conn.Open();

            string sql = "SELECT u_uid , u_id , u_passwaord , u_phonenum, u_level, u_nickname FROM T_Phonebook";

            using SqlCommand cmd = new(sql, conn);
            using SqlDataAdapter adapter = new(cmd);
            DataSet ds = new();
            adapter.Fill(ds);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return;

            memberView.DataSource = ds.Tables[0];

            memberView.Columns[0].ReadOnly = true;
            memberView.Columns[0].Width = 30;

            memberView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //나머지 여백 차지해줌
            memberView.AllowUserToDeleteRows = false; // 직접 행 삭제 불가
        }
    }
}
