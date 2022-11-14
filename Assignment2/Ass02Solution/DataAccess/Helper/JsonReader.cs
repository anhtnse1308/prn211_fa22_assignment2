using DataAccess.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helper
{
    public static class JsonReader
    {
        public static string GetConnectionString()
        {
            string connectionString = null;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }
        public static Member GetAdmin()
        {
            var jsonData = new ConfigurationBuilder().AddJsonFile(@"appsettings.json");
            IConfiguration config = jsonData.Build();

            var jsonAdmin = config.GetSection("AdminAccount").Get<Member>();
            return (Member)jsonAdmin;
        }
    }
}
