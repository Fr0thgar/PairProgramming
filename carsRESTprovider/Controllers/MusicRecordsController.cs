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
        [HttpGet("{title}", Name = "Get")]
        public MusicRecord Get(string title)
        {
            return Records.Find(r => r.Title == title);
        }

        // POST: api/MusicRecords
        [HttpPost]
        public void Post([FromBody] MusicRecord value)
        {
            Records.Add(value);
        }

        // PUT: api/MusicRecords/5
        [HttpPut("{title}")]
        public void Put(string title, [FromBody] MusicRecord value)
        {
            if (value != null)
            {
                MusicRecord temp = new MusicRecord();
                temp = Get(title);
                temp = value;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{title}")]
        public void Delete(string title)
        {
            Records.Remove(Records.Find(r => r.Title == title));
        }
    }
}
