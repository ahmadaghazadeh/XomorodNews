using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoManager;

namespace RssFeedsCloud.Model
{
    public static class DatabaseConnectionProvider
    {
        private static ConnectionManager _connection;
        //public static DatabaseDataContext Connection => _connection ?? (_connection = new DatabaseDataContext());


        static DatabaseConnectionProvider()
        {
            var data = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Web.config");
            var start = data.IndexOf("<connectionStrings>", StringComparison.Ordinal);
            var end = data.IndexOf("</connectionStrings>", StringComparison.Ordinal);
            data = data.Substring(start, end - start + 20);


            ConnectionManager.LoadFromXml(data);
            
            ConnectionManager.SetToDefaultConnection("Xomorod");
        }

        public static ConnectionManager Connection => _connection ?? (_connection = ConnectionManager.GetDefaultConnection());
    }
}