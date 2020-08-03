using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocationVer2.Model
{
    public class IPInfo
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public int ID { get; set; }
        public string IPFrom { get; set; }
        public string IPTo { get; set; }
        public int IPType { get; set; }
        public string Country { get; set; }
        public string StateProvince { get; set; }
        public string CityDistrict { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string TimeZoneOffset { get; set; }
        public string TimeZoneName { get; set; }
        public string ISPName { get; set; }
        public string ConnectionType { get; set; }
        public string OUName { get; set; }
    }
}
