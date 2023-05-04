using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace NumberPlayWPF
{
    class DataUpDateClass
    {
        public DataTable DataUpDate()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=Account.db;Version=3;");
            con.Open();
            string query = "SELECT * FROM Jadval";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            return dt;

        }
    }
}
