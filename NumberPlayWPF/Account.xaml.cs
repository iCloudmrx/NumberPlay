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
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddData();
            AccountGridPanel.Children.Clear();
            AccountGridPanel.Children.Add(new PlayUserControl());
        }
        private void AddData()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Account.db;Version=3;");
            conn.Open();
            string query = "Insert Into jadval (FirstName,LastName,Username) Values(@firstname,@lastname,@username)";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@firstname", FirtName.Text);
            cmd.Parameters.AddWithValue("@lastname", LastName.Text);
            cmd.Parameters.AddWithValue("@username", Username.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
