using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    internal class CharacterInfoClass
    {
        public static void Register(string Name, string Floor, int Lvl)
        {
            if (Name.Trim() != null &&  Floor.Trim() != null && Lvl != null)
            {
                string connString = @"Data Source = DBSRV\vip2024; Initial Catalog = Saveli_MMORPG; Integrated Security = True;";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand command = new SqlCommand($"insert into Character ([Name], [Floor], [Level]) values ('{Name.Trim()}', '{Floor.Trim()}', '{Lvl}')", connection);
                int? entries = command.ExecuteNonQuery();
                if (entries != null) { MessageBox.Show("Успешно"); }
                else { MessageBox.Show("Не удалось"); }
            }
        }
    }
}
