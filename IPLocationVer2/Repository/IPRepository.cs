using IPLocationVer2.Model;
using IPLocationVer2.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLocationVer2.Repository
{
    public class IPRepository : IIPInfoRepository
    {
        private readonly MongodbContext _context = null;

        public IPRepository(IOptions<Settings> settings)
        {
            _context = new MongodbContext(settings);
        }

        public Task<IEnumerable<IPInfo>> GetAllIP()
        {
            throw new NotImplementedException();
        }

        // get IP info from given ip
        // done
        public IEnumerable<IPInfo> GetIP(string IPAsHexString)
        {


            string queryString = "{$and: [{IPFrom: {$lte:"+ IPAsHexString + " }}" +
                                 ",{IPTo: {$gte: " + IPAsHexString + "}}]}";

            try
            {
                var t = _context.getCollection.Find(queryString);

                return _context.getCollection.Find(ip => HandlerIP.CompareHexString(ip.IPFrom.ToString(), IPAsHexString.ToString()) <= 0
                                                    && HandlerIP.CompareHexString(ip.IPTo.ToString(), IPAsHexString.ToString()) >= 0
                                                    && HandlerIP.CompareHexString(ip.IPFrom.ToString(), "00000000000000000000000000000000") != 0).ToList();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        public Task AddIP(IPInfo item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAllIP()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNote(string id, string content)
        {
            throw new NotImplementedException();
        }
    }
}
