using System;
using System.IO;
using AdoManager;

namespace XomorodNews.Models
{
    public static class DatabaseConnectionProvider
    {
        private static ConnectionManager _connection;
        //public static DatabaseDataContext Connection => _connection ?? (_connection = new DatabaseDataContext());


        static DatabaseConnectionProvider()
        {
            var data = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Web.config");

            ConnectionManager.LoadFromXml(data);
            
            ConnectionManager.SetToDefaultConnection("Xomorod");
        }

        public static ConnectionManager Connection => _connection ?? (_connection = ConnectionManager.GetDefaultConnection());
    }
}