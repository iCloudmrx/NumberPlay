using NumberPlayWPF.ServiceLayer.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace NumberPlayWPF
{
    class OrderBy
    {
        int t = 1;
        public List<UserModel> Saralash()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Account.db;Version=3;");
            conn.Open();
            string query = "SELECT * FROM Jadval";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<UserModel> users = new List<UserModel>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                users.Add(new UserModel()
                {
                    ID = t,
                    FirstName = dt.Rows[i]["FirstName"].ToString(),
                    LastName = dt.Rows[i]["LastName"].ToString(),
                    Username = dt.Rows[i]["Username"].ToString(),
                    Answer = dt.Rows[i]["Answer"].ToString(),
                    AllAnswer = dt.Rows[i]["AllAnswer"].ToString(),
                    Time = dt.Rows[i]["Time"].ToString()

                });
                t++;
            }
            t = 1;
            //List<UserModel> res = (from i in users
            //           orderby i.Answer descending
            //           select i).ToList();
            return users;
        }
    }
}
