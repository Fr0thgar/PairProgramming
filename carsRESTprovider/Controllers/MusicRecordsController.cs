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
            new MusicRecord("Enough", "Counterfit", 151, "2017", "10"),
            new MusicRecord("Leibe ist für Alle da", "Rammstein",200, "2015","16"),
            new MusicRecord("Tangled", "Disney", 20, "2010", "8"),
            new MusicRecord("Ht me baby", "baseBalls", 20, "2016", "10")
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
            return Records.Find(r => r.Title.ToLower().Contains(title.ToLower()));
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
                MusicRecord record = Get(title);

                if (record != null)
                {
                    record.Artist = value.Artist;
                    record.YearOfPublication = value.YearOfPublication;
                    record.Duration = value.Duration;
                    record.NumberOfTracks = value.NumberOfTracks;
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{title}")]
        public void Delete(string title)
        {
            Records.Remove(Records.Find(r => r.Title == title));
        }

        [HttpGet]
        [Route("artist/{artist}")]
        public IEnumerable<MusicRecord> FindArtist(string artist)
        {
            List<MusicRecord> list = new List<MusicRecord>();
            foreach (MusicRecord musicRecord in Records)
            {
                if (musicRecord.Artist.ToLower().Contains(artist.ToLower()))
                {
                    list.Add(musicRecord);
                }
            }

            return list;
        }

        [HttpGet]
        [Route("search")]
        public IEnumerable<MusicRecord> FindDuration([FromQuery] FilterRecord filter)
        {
            //List<MusicRecord> list = new List<MusicRecord>();

            //if (filter.High == 0)
            //{
            //    filter.High = int.MaxValue;
            //}

            //list.Add(Records.Find(r => r.Duration > filter.Low && r.Duration < filter.High));

            //return list;

            List<MusicRecord> itemList = new List<MusicRecord>();
            if (filter.High <= 0)
            {
                filter.High = int.MaxValue;
            }
            foreach (MusicRecord item in Get())
            {

                if (item.Duration > filter.Low && item.Duration < filter.High)
                {
                    itemList.Add(item);
                }
            }
            return itemList;
        }
    }
}
