using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CheckUserDB()
        {
            if (tb_login.Text.Trim() != null && tb_password.Text.Trim() != null)
            {
                string connString = @"Data Source = DBSRV\vip2024; Initial Catalog = Saveli_MMORPG; Integrated Security = True;";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand($"select * from player where [Login] = '{tb_login.Text.Trim()}' and [Password] = '{tb_password.Text.Trim()}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) { MessageBox.Show("Успешный вход"); }
                else { MessageBox.Show("Не удалось"); }
            }
        }

        private void bt_signIn_Click(object sender, RoutedEventArgs e)
        {
            CheckUserDB();
        }
    }
}
