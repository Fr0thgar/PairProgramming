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
            new MusicRecord("Leibe ist für Alle da", "Rammstein","200", "2015","16"),
            new MusicRecord("Tangled", "Disney", "20", "2010", "8"),
            new MusicRecord("Ht me baby", "baseBalls", "20.42", "2016", "10")
        };

        // GET: api/MusicRecords
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return Records;
        }

        // GET: api/MusicRecords/5
        [HttpGet("{name}", Name = "Get")]
        public string Get(string name)
        {
            return Records.find(r => r.Name = name);
        }

        // POST: api/MusicRecords
        [HttpPost]
        public void Post([FromBody] MusicRecord value)
        {
            Records.add(value);
        }

        // PUT: api/MusicRecords/5
        [HttpPut("{name}")]
        public void Put(string name, [FromBody] MusicRecord value)
        {
            Get(name) = value;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            Records.remove(name);
        }
    }
}
