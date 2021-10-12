using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWA.Settings
{
    public class MongoDbConfig
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string ConnectionString => $"mongodb://localhost:27017";
    }
}
