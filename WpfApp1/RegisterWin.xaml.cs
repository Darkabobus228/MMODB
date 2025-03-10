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
    /// Логика взаимодействия для RegisterWin.xaml
    /// </summary>
    public partial class RegisterWin : Window
    {
        public RegisterWin()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            bool result = SingInClass.RegisterUserDB(tb_loginLog.Text, tb_loginPass.Text);
            if (result) 
            {
                MainWindow win = new MainWindow();
                this.Close();
                win.ShowDialog();
            }
        }
    }
}
