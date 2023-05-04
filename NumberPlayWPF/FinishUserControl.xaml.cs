using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberPlayWPF
{
    /// <summary>
    /// Interaction logic for FinishUserControl.xaml
    /// </summary>
    public partial class FinishUserControl : UserControl
    {
        public FinishUserControl()
        {
            InitializeComponent();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=Account.db;Version=3;");
            con.Open();
            string query = "SELECT * FROM Jadval";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AnswerTextBlock.Text = dt.Rows[dt.Rows.Count-1]["Answer"].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            GridFinishPanel.Children.Clear();
            GridFinishPanel.Children.Add(new MainUserControl());
            //main.Show();
            
        }
    }
}
