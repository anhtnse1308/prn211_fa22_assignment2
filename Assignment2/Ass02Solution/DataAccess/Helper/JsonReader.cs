using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helper
{
    public class JsonReader
    {
        public string GetConnectionString()
        {
            string connectionString = null;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }
        //public MemberObject ImportJson()
        //{
        //    var jsonData = new ConfigurationBuilder().AddJsonFile(@"appsettings.json");
        //    IConfiguration config = jsonData.Build();

        //    var jsonAdmin = config.GetSection("AdminAccount").Get<MemberObject>();
        //    return (MemberObject)jsonAdmin;
        //}
    }
}
