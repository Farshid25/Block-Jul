using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Julius.Data
{
    public class Settings
    {
        private static readonly IConfigurationRoot Configuration = new ConfigurationBuilder()
     .SetBasePath(Directory.GetCurrentDirectory())
     .AddJsonFile("appsettings.json", true)
     .Build();

        public string ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
        public string Database = Configuration.GetSection("MongoConnection:Database").Value;
    }
}

 