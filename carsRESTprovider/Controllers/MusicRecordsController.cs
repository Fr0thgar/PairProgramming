using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carsRESTprovider.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace carsRESTprovider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        public static List<MusicRecord> Records = new List<MusicRecord>()
        {
            new MusicRecord("Enough", "Counterfit", "151", "2017", "10"),
            new MusicRecord("Leibe ist für Alle da", "Rammstein","200", "2015","16")
        };

        // GET: api/MusicRecords
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MusicRecords/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MusicRecords
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/MusicRecords/5
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
