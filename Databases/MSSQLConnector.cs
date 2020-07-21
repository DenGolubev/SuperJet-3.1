using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SQ = System.Data.SqlClient;

namespace SuperJet_3._1.Databases
{
    class MSSQLConnector
    {
        private string serverName { get; set; }
        private string databaseName { get; set; }
        private string userName { get; set; }
        private string password { get; set; }
        private SQ.SqlConnection connection { get; set; }

        MSSQLConnector(string serverName, string databaseName, string userName, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.userName = userName;
            this.password = password;
        }

        /*
         * Формирует строку соединения
         */
        private string getSqlConnectionString()
        {
            SQ.SqlConnectionStringBuilder sqlStringBuilder = new SQ.SqlConnectionStringBuilder();
            sqlStringBuilder.DataSource = this.serverName;
            sqlStringBuilder.InitialCatalog = this.databaseName;
            sqlStringBuilder.UserID = this.userName;
            sqlStringBuilder.Password = this.password;
            sqlStringBuilder.IntegratedSecurity = false;
            sqlStringBuilder.Encrypt = true;
            sqlStringBuilder.ConnectTimeout = 2;

            return sqlStringBuilder.ToString();
            
        }
        
        /*
         * Подключение к БД
         */
        private void Connect()
        {
            try
            {
                if (this.connection != null)
                {
                    this.connection = new SQ.SqlConnection(this.getSqlConnectionString());
                }
                
                this.connection.Open();
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        /*
         * Закрывает соединение с проверкой
         */
        private void CloseConnection()
        {
            try
            {

                if (this.GetStateConnection() == "Open")
                {
                    this.connection.Close();
                }

            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        /*
         * Получает состояние соединения
         */
        private string GetStateConnection()
        {
            return this.connection.State.ToString();
        }


        /*
         * Возвращает данные в виде DataTable
         */
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            this.Connect();

            SQ.SqlCommand sqlCmd = new SQ.SqlCommand(query, this.connection);
            SQ.SqlDataAdapter dataAdapted = new SQ.SqlDataAdapter(sqlCmd);
            dataAdapted.Fill(data);

            this.CloseConnection();

            return data;
        }

        /*
         * Закрываем соединение в случае удаления объекта
         */
        ~MSSQLConnector()
        {
            this.connection.Close();
        }
    }
}
