using NumberPlayWPF.ServiceLayer.User;
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
    /// Interaction logic for MainUserControl.xaml
    /// </summary>
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
        }
        public int IDAmallar = 0;
        public int MyIDAmallar
        {
            get { return IDAmallar; }
            set { IDAmallar = value; }
        }
        public MainUserControl(int _IdAmaliy)
        {
            IDAmallar = _IdAmaliy;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StartNumber.Text.Trim() != "" && FinishNumber.Text.Trim() != "" && TimeBtn.Text.Trim() != "" && MaxNumber.Text.Trim() != "")
            {
                if (Kopaytirish.IsChecked == true || Bolish.IsChecked == true || Qoshish.IsChecked == true || Ayrish.IsChecked == true)
                {
                    if (Kopaytirish.IsChecked == true)
                        IDAmallar += 1000;
                    if (Bolish.IsChecked == true)
                        IDAmallar += 200;
                    if (Qoshish.IsChecked == true)
                        IDAmallar += 30;
                    if (Ayrish.IsChecked == true)
                        IDAmallar += 4;
                    TimeAndNumbers();
                    InformationText.Visibility = Visibility.Hidden;
                    GridMainPanel.Children.Clear();
                    GridMainPanel.Children.Add(new Account());
                }
                else
                {
                    InformationText.Text = "Siz amallarni tanlamadingiz!!!";
                    InformationText.Visibility = Visibility.Visible;
                }
            }
            else
            {
                InformationText.Text = "Siz hammasini to'liq to'ldirmadingiz!!!";
                InformationText.Visibility = Visibility.Visible;
            }
        }
        private void TimeAndNumbers()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Account.db;Version=3;");
            conn.Open();
            string query = "Insert Into Main (time,start,finish,maxNumber,IDAmal) Values(@time,@start,@finish,@maxNumber,@IDAmal)";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@time", TimeBtn.Text);
            cmd.Parameters.AddWithValue("@start", StartNumber.Text);
            cmd.Parameters.AddWithValue("@finish", FinishNumber.Text);
            cmd.Parameters.AddWithValue("@maxNumber", MaxNumber.Text);
            cmd.Parameters.AddWithValue("@IDAmal", IDAmallar);
            cmd.ExecuteNonQuery();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            OrderBy ob = new OrderBy();
            dataGrid.ItemsSource = ob.Saralash();

           

        }

        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.CellStyle = new Style(typeof(DataGridCell));
            e.Column.CellStyle.Setters.Add(new Setter(DataGridCell.BackgroundProperty, new SolidColorBrush(Colors.Red)));
        }

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    IDAmallar += 1000;
        //}

        //private void Ayrish_Checked(object sender, RoutedEventArgs e)
        //{
        //    IDAmallar += 4;
        //}

        //private void Bolish_Checked(object sender, RoutedEventArgs e)
        //{
        //    IDAmallar += 200;
        //}

        //private void Qoshish_Checked(object sender, RoutedEventArgs e)
        //{
        //    IDAmallar += 30;
        //}
    }
}
