using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPLocationVer2.Model;

namespace IPLocationVer2.Repository
{
    public class IPRepositorySql : IIPInfoRepository
    {
        public Task AddIP(IPInfo item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IPInfo>> GetAllIP()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPInfo> GetIP(string IPAsHexString)
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
