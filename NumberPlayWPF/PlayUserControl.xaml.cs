using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NumberPlayWPF
{
    /// <summary>
    /// Interaction logic for PlayUserControl.xaml
    /// </summary>
    public partial class PlayUserControl : UserControl
    {
        public PlayUserControl()
        {
            InitializeComponent();
        }
        string matn1 = "";
        string matn2 = "";
        string matn3 = "";
        string matn4 = "";
        int times = 10;
        int notAnswer = 0;
        int AllTime = 0;
        int Question = 0;
        void raqam()
        {
            Question++;
            int a3=0;
            AnswerClass answer = new AnswerClass();
            List<int> vs = answer.GetAll();
            Random r = new Random();
            switch (vs[4])
            {
                case 1234:
                    {
                        a3 = r.Next();
                        a3 %= 5;
                        if (a3 % 5 == 0)
                            a3 = 1;
                        break;
                    }
                case 1230:
                    {
                        int[] massiv = { 1, 2, 3 };
                        a3 = r.Next();
                        a3 = massiv[a3 % 3];                     
                        break;
                    }
                case 1200:
                    {
                        int[] massiv = { 1, 2,};
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 1000:
                    {
                        a3 = 1;
                        break;
                    }
                case 200:
                    {
                        a3 = 2;
                        break;
                    }
                case 30:
                    {
                        a3 = 3;
                        break;
                    }
                case 4:
                    {
                        a3 = 4;
                        break;
                    }
                case 1204:
                    {
                        int[] massiv = { 1, 2, 4};
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 1034:
                    {
                        int[] massiv = { 1, 3, 4};
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 1004:
                    {
                        int[] massiv = { 1, 4, };
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 1030:
                    {
                        int[] massiv = { 1, 3, };
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 234:
                    {
                        int[] massiv = { 3, 2, 4};
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 230:
                    {
                        int[] massiv = { 3, 2, };
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 204:
                    {
                        int[] massiv = { 4, 2, };
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }
                case 34:
                    {
                        int[] massiv = { 3, 4, };
                        a3 = r.Next();
                        a3 = massiv[a3 % massiv.Length];
                        break;
                    }

            }

            //int a3 = r.Next();
            //a3 %= 4;
        l:
            double a1 = r.Next(vs[1], vs[2]);
            double a2 = r.Next(vs[1], vs[2]);
            matn1 = (a1 + a2).ToString();
            matn2 = (a1 - a2).ToString();
            matn3 = (a1 * a2).ToString();
            matn4 = (a1 / a2).ToString();
            switch (a3)
            {
                case 2:
                    {
                        if (double.Parse(matn4) % 1 == 0)
                        {
                            TextBlock.Text = a1 + " " + ":" + " " + a2;
                            break;
                        }
                        else
                            goto l;
                    }
                case 3:
                    TextBlock.Text = a1 + " " + "+" + " " + a2;
                    break;
                case 4:
                    {
                        if (int.Parse(matn2) > -1)
                        {
                            TextBlock.Text = a1 + " " + "-" + " " + a2;
                            break;
                        }
                        else
                            goto l;
                    }
                case 1:
                    TextBlock.Text = a1 + " " + "*" + " " + a2;
                    break;
            }
            AnswerText.Text = "";
        }
        private void AnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AnswerBtn.Content.ToString() == "Boshlash")
            {
                AnswerBtn.Content = "Tekshirish";
                DispatcherTimer LiveTime = new DispatcherTimer();
                LiveTime.Interval = TimeSpan.FromSeconds(1);
                LiveTime.Tick += timer_Tick;
                LiveTime.Start();
                AnswerClass answer = new AnswerClass();
                List<int> t = answer.GetAll();
                times = t[0];
                raqam();
            }
            else
            {
                Answer();
           
            }
        }
        private void Answer()
        {
            AnswerClass answer = new AnswerClass();
            List<int> t = answer.GetAll();
            if (AnswerText.Text.Trim() == "")
            {
                ErrorText.Visibility = Visibility.Visible;
            }
            else
            {
                if (AnswerText.Text == matn1 || AnswerText.Text == matn2 || AnswerText.Text == matn3 || AnswerText.Text == matn4)
                {
                    if (ErrorText.Visibility == Visibility.Visible)
                        ErrorText.Visibility = Visibility.Hidden;
                    Count.Text = (Convert.ToInt32(Count.Text) + 1).ToString();
                    if (times < 180)
                    {
                        times += t[0];
                    }
                    if (Question == t[3])
                    {
                        UpDate();
                        Question = 0;
                        AllTime = 0;
                    }
                }
                else
                {

                    if (Convert.ToInt32(Count.Text) == 0)
                    {
                        UpDate();
                        Question = 0;
                        AllTime = 0;
                    }
                    else
                    {
                        //Count.Text = (Convert.ToInt32(Count.Text) - 1).ToString();
                        notAnswer++;
                        //if (notAnswer == 3)
                        //{
                        //    UpDate();
                        //    Question = 0;
                        //    AllTime = 0;
                        //    notAnswer = 0;
                        //}
                    }
                }
                raqam();
                AnswerText.Text = "";
            }
        }

        private void UpDate()
        {
            DataUpDateClass data = new DataUpDateClass();
            DataTable dt=data.DataUpDate();
            SQLiteConnection con = new SQLiteConnection("Data Source=Account.db;Version=3;");
            con.Open();
            string query1 = "UPDATE Jadval SET Answer=@answer,AllAnswer=@all,Time=@time WHERE ID=@id";
            SQLiteCommand com1 = new SQLiteCommand(query1, con);
            com1.Parameters.AddWithValue("@Answer", Count.Text);
            com1.Parameters.AddWithValue("@all", Question);
            com1.Parameters.AddWithValue("@time", (AllTime/60+":"+AllTime%60));
            com1.Parameters.AddWithValue("@id", dt.Rows[dt.Rows.Count - 1]["ID"]);
            com1.ExecuteNonQuery();

            GridPlayPanel.Children.Clear();
            GridPlayPanel.Children.Add(new FinishUserControl());
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            times--;
            AllTime++;
            vaqtText.Text = (times / 60).ToString() + ":" + (times % 60).ToString();
            if (times==0)
            {
               UpDate();
                Question = 0;
                AllTime = 0;
            }
            //tugash qismi bor
        }
        private void AnswerText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                Answer();
            }
        }
    }
}
