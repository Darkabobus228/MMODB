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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для SingInWin.xaml
    /// </summary>
    public partial class SingInWin : Window
    {
        public SingInWin()
        {
            InitializeComponent();
        }

        private void bt_signIn_Click(object sender, RoutedEventArgs e)
        {
            bool result = SingInClass.CheckUserDB(tb_login.Text, tb_password.Text);
            if (result) 
            { 
                MainWindow win = new MainWindow();
                this.Close();
                win.ShowDialog();
            }
        }

        private void bt_register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWin win = new RegisterWin();
            this.Close();
            win.ShowDialog();
        }
    }
}
