namespace carsRESTprovider.model
{
    public class MusicRecord
    {
        public string tile { get; set; }
        public string artist { get; set; }
        public string duration { get; set; }
        public string yearOfPublication { get; set; }
        public string numberOfTracks { get; set; }

        public MusicRecord()
        {
        }

        public MusicRecord(string tile, string artist, string duration, string yearOfPublication, string numberOfTracks)
        {
            this.tile = tile;
            this.artist = artist;
            this.duration = duration;
            this.yearOfPublication = yearOfPublication;
            this.numberOfTracks = numberOfTracks;
        }

    }
}
