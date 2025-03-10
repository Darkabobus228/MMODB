using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;

namespace WpfApp1
{
    internal class SingInClass
    {
        public static bool RegisterUserDB(string login, string password)
        {
            if (login.Trim() != null && password.Trim() != null)
            {
                string connString = @"Data Source = DBSRV\vip2024; Initial Catalog = Saveli_MMORPG; Integrated Security = True;";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand($"insert into player ([Login], [Password]) values ('{login.Trim()}', '{password.Trim()}')", connection);
                int? entries = command.ExecuteNonQuery();
                if (entries != null) 
                {
                    connection.Close();
                    MessageBox.Show("Успешно");
                    return true;
                }
                connection.Close();
                MessageBox.Show("Не удалось");
                return false;
            }
            return false;
        }

        public static bool CheckUserDB(string login, string password)
        {
            if (login.Trim() != null && password.Trim() != null)
            {
                string connString = @"Data Source = DBSRV\vip2024; Initial Catalog = Saveli_MMORPG; Integrated Security = True;";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand($"select * from player where [Login] = '{login.Trim()}' and [Password] = '{password.Trim()}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                { 
                    MessageBox.Show("Успешный вход");
                    connection.Close();
                    return true;
                }
                connection.Close();
                MessageBox.Show("Не удалось");
            }
            return false;
        }
    }
}
