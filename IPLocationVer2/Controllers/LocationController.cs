using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPLocationVer2.Model;
using IPLocationVer2.Repository;
using IPLocationVer2.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPLocationVer2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IIPInfoRepository _IPInfoRepository;

        public LocationController(IIPInfoRepository IPInfoRepository)
        {
            _IPInfoRepository = IPInfoRepository;
        }


        // GET: api/Location
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return new string[] { "value1", "value2" };
        }

        // GET: api/Location/5
        [HttpGet("{IP}", Name = "Get")]
        public string Get(string IP)
        {
            string ip = HandlerIP.ConvertIPToHexString(IP);
            IEnumerable<IPInfo> ipInfo  = _IPInfoRepository.GetIP(ip);

            IPInfo res = ipInfo.ElementAt(0);

            return res.ToString();
        }

        // POST: api/Location
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Location/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
