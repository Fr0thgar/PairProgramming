namespace carsRESTprovider.model
{
    public class MusicRecord
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Duration { get; set; }
        public string YearOfPublication { get; set; }
        public string NumberOfTracks { get; set; }

        public MusicRecord()
        {
        }

        public MusicRecord(string title, string artist, string duration, string yearOfPublication, string numberOfTracks)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
            this.YearOfPublication = yearOfPublication;
            this.NumberOfTracks = numberOfTracks;
        }

    }
}
