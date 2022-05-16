using static NewFeaturesApp.Bands;
namespace NewFeaturesApp
{
    public static class PublicMethods
    {
        public static void MainMenu()
        {
            Console.WriteLine("Hello!\nChoose the band:");
            for (int i = 1; i <= bandsList.Count; i++)
            { Console.WriteLine(i + " - " + bandsList.ElementAt(i).BandName); }
            string responce = Console.ReadLine();
            bool success = Int32.TryParse(responce, out int n);
            if (success && n > 0 && n < bandsList.Count())
            {
                BandInfo(bandsList.ElementAt(n - 1));
            }
            else
            {
                Console.WriteLine("Input string is invalid.");
                MainMenu();
            }
        }
        public static void BandInfo(Band band)
        {

            Console.WriteLine(band.BandName);
            if (band.Genres != null)
            {
                Console.WriteLine("Band genres: ");
                foreach (Genre genre in band.Genres)
                {
                    Console.Write(genre + " ");
                }
            }
            Console.WriteLine("Year of fundation: " + band.YearOfFundation);
            if (band.Country != null) Console.WriteLine("Country: " + band.Country);
            if (band.City != null) Console.WriteLine("City: " + band.City);
            Console.WriteLine("Band members: ");
            foreach ((string, string) member in band.Members)
            {
                Console.Write(member);
            }
            if (band.ExMembers != null)
            {
                Console.WriteLine("Band ex-members: ");
                foreach (string member in band.ExMembers)
                {
                    Console.Write(member);
                }
            }

            List<Album> albums = band.LPs
                        .Union(band.EPs)
                        .Union(band.SinglesAndDemos)
                        .Union(band.SplitsAndCompilations)
                        .ToList();
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine(i + 1 + albums.ElementAt(i).Year + " " + albums.ElementAt(i).AlbumName);
            }
            if (band.Labels != null)
            {
                ListLabels(band.Labels);
            }
            else
            {
                List<Label> labels = new List<Label>();
                foreach (Album album in albums)
                { if (album.Label != null && !labels.Contains(album.Label)) labels.Add(album.Label); }
                ListLabels(labels);
            }

            Console.WriteLine("Choose the album or type zero to back to the main menu: ");
            string responce = Console.ReadLine();
            bool success = Int32.TryParse(responce, out int n);
            if (success && n >= 0 && n <= albums.Count)
            {
                switch (n)
                {
                    case 0:
                        MainMenu();
                        break;
                    case > 0:
                        AlbumMenu(albums.ElementAt(n - 1));
                        break;
                }

            }
            else
            {
                Console.WriteLine("Input string is invalid.");
                BandInfo(band);
            }

        }
        public static void AlbumMenu(Album album)
        {
            Console.WriteLine("Album name: " + album.AlbumName);
            Console.WriteLine("Year: " + album.Year);
            if (album.Type != null) Console.WriteLine("Album type: " + album.Type);
            for (int i = 0; i < album.Songs.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + album.Songs[i - 1].SongName);
            }
            AlbumMenu(album);

        }
        public static void ListLabels(List<Label> labels)
        {
            if (labels.Count > 0)
            {
                Console.WriteLine("Genres: ");
                foreach (string label in labels)
                { Console.Write(label + " "); }
            }
        }
    }
}
