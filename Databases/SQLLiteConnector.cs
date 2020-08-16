using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SuperJet_3._1.Databases
{
    class SQLLiteConnector
    {
        /*
         * Пусть файла БД
         */
        private string DataBaseFilePath { set; get; }
        /*
         * Открытое соединение с БД
         */
        private SQLiteConnection Connection { get; set; }

        /*
         * Метод соединения с БД
         */
        private void Connect()
        {
            
        }

        /*
         * Закрытие соединения с файлом после использования
         */
        private void CloseConnection()
        {

        }

        /*
         * Возвращает строку подключения
         */
        private void GetConnectionString()
        {

        }

        /*
         * Выполняет запрос к базе данных
         */
        public void ExecuteQuery()
        {

        }

        
    }
}
