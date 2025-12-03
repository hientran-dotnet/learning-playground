namespace bai_3
{
    public interface IPlayable
    {
        public void Play();
    }

    public abstract class MediaFile : IPlayable
    {
        private string Name;
        private string Duration;

        public MediaFile(string name, string duration)
        {
            this.Name = name;
            this.Duration = duration;
        }

        public abstract void Play();
    }

    public class Song : MediaFile
    {
        private string Name;
        private string Duration;
        private string Artist;

        public Song(string name, string duration, string artist) : base(name, duration)
        {
            this.Name = name;
            this.Duration = duration;
            this.Artist = artist;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getDuration()
        {
            return this.Duration;
        }

        public string getArtist()
        {
            return this.Artist;
        }

        public override void Play()
        {
            Console.WriteLine("PLAYING SONG");
            Console.WriteLine($"NAME: {getName()}");
            Console.WriteLine($"DURATION: {getDuration()}");
            Console.WriteLine($"ARTIST: {getArtist()}");
        }
    }

    public class Video : MediaFile
    {
        private string Name;
        private string Duration;
        private string TotalView;

        public Video(string name, string duration, string totalView) : base(name, duration)
        {
            this.Name = name;
            this.Duration = duration;
            this.TotalView = totalView;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getDuration()
        {
            return this.Duration;
        }

        public string getTotalView()
        {
            return this.TotalView;
        }

        public override void Play()
        {
            Console.WriteLine("PLAYING VIDEO");
            Console.WriteLine($"NAME: {getName()}");
            Console.WriteLine($"DURATION: {getDuration()}");
            Console.WriteLine($"TOTAL VIEW: {getTotalView()}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MediaFile song1 = new Song("Thien Ly oi", "3m20s", "Jack - J97");
            MediaFile stream1 = new Video("Restream hom qua.....", "3h20m", "12898992");

            song1.Play();
            stream1.Play();
        }
    }
}
