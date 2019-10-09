using System.Collections.Generic;
using System.Linq;
using carsRESTprovider.model;
using Microsoft.AspNetCore.Mvc;

namespace carsRESTprovider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static readonly List<MusicRecord> Cars = new List<MusicRecord>
        {
            new MusicRecord {Id=1, Model = "Amazon", Vendor = "Volvo", Price = 12345},
            new MusicRecord {Id=2, Model = "A8", Vendor = "Audi", Price = 2222222},
            new MusicRecord {Id=3, Model = "Punto", Vendor = "Fiat", Price = 102022}
        };

        private static int _nextId = 4;

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return Cars;
        }

        // GET: api/Cars/5
        [HttpGet]
        [Route("{id}")]
        public MusicRecord Get(int id)
        {
            return Cars.FirstOrDefault(car => car.Id == id);
        }

        // POST: api/Cars
        [HttpPost]
        public int Post([FromBody] MusicRecord musicRecord)
        {
            musicRecord.Id = _nextId++;
            Cars.Add(musicRecord);
            return musicRecord.Id;
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string car)
        {
            //int index = Cars.FindIndex(car1 => car1.Id == id);
            //if (index > 0) { }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return Cars.RemoveAll(car => car.Id == id);
        }
    }
}
