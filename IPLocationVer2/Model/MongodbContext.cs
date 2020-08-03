﻿using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocationVer2.Model
{
   
    public class MongodbContext
    {
        private readonly IMongoDatabase _database = null;
        public MongodbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<IPInfo> getCollection
        {
            get
            {
                return _database.GetCollection<IPInfo>("ip");
            }
        }

    }
}
