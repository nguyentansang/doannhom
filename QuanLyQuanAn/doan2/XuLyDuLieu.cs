using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace doan2
{
    class XuLyDuLieu
    {
        public static String connecionString = "Provider=SQLNCLI11;Data Source=DESKTOP-HLD364P;Integrated Security=SSPI;Initial Catalog=QuanLyMonAn";

        public static DataTable docBang(String sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connecionString);
            adapter.Fill(dt);
            return dt;
        }

        public static void ghiBang(String tenBang, DataTable dt)
        {
            String selectSql = "select * from " + tenBang;
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connecionString);
            OleDbCommandBuilder buider = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }
    }
}
