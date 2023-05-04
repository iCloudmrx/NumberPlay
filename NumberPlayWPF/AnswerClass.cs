using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NumberPlayWPF
{
    class AnswerClass
    {
        public List<int> GetAll()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Account.db;Version=3;");
            conn.Open();
            string query = "SELECT * FROM Main";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<int> t = new List<int>();
            t.Add(Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["time"]));
            t.Add(Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["start"]));
            t.Add(Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["finish"]));
            t.Add(Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["maxNumber"]));
            t.Add(Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["IDAmal"]));
            return t;
        }
    }
}
