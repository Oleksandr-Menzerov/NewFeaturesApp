using static NewFeaturesApp.Bands;
using static NewFeaturesApp.Songs;

namespace NewFeaturesApp
{
    public class Albums
    {
        public static List<Album> albumList = new()
        { Burevij, RidnaZemlia, ZatoplenaSich, Tsarehrad,BrateVitreDemo, BrateVitre, Lykho };
        public static Album Burevij = new(
            AlbumName: "Буревій",
            Bands: new Band[] { Haspyd },
            Year: 2014,
            Songs: new Song[] {
                BurevijSong,
                NichHaspyda,
                RidnaZemliaSong,
                KudyJaIdu, NaPaliu,
                KolyJaOzhyvu,
                ZatoplenaSichRelease,
                ShchoLyshyv,
                Pursuit },
            Type: "LP",
            Label: "Sound Age Productions"
        );
        public static Album RidnaZemlia = new(
            AlbumName: "Рідна Земля",
            Bands: new Band[] { Haspyd },
            Year: 2013,
            Songs: new Song[] {
                NichHaspyda,
                KolyJaOzhyvu,
                RidnaZemliaSong,
                ShchoLyshyv,
                ZatoplenaSichDemo,
                BurevijSong },
            Type: "EP"
        );
        public static Album ZatoplenaSich = new(
            AlbumName: "Затоплена Січ",
            Bands: new Band[] { Haspyd },
            Year: 2009,
            Songs: new Song[] { ZatoplenaSichDemo },
            Type: "Demo Single"
        );
        public static Album Tsarehrad = new(
            AlbumName: "Цареград",
            Bands: new Band[] { Haspyd },
            Year: 2016,
            Songs: new Song[] { TsarehradSingle },
            Type: "Single"
        );
        public static Album BrateVitreDemo = new(
            AlbumName: "Брате Вітре (Демо)",
            Bands: new Band[] { Chur },
            Year: 2005,
            Songs: new Song[] {
                BrateVitreSong,
                Starets,
                TryShliakhy,
                Karna,
                Kujaba,
                Kruk,
                VesnoKrasna,
                VerbovajaDoshchechka},
            Type: "Demo"
        );
        public static Album BrateVitre = new(
            AlbumName: "Брате Вітре",
            Bands: new Band[] { Chur },
            Year: 2006,
            Songs: new Song[] {
                        BrateVitreSong2,
                        Starets2,
                        Kruk2,
                        Sura,
                        Kujaba2,
                        Karna2,
                        TryShliakhy,
                        VesnoKrasna2,
                        VerbovajaDoshchechka2,
                        BogatyrskajaSila,
                        HerrMannelig
                        },
            Type: "LP"
        );
        public static Album Lykho = new(
            AlbumName: "Лихо",
            Bands: new Band[] { Chur },
            Year: 2009,
            Songs: new Song[] {
                                Lirnyk,
                                LykhoSong,
                                Braty,
                                Mara,
                                Nebo,
                                Maty,
                                JduNaVy,
                                Zahovir,
                                Vesna,
                                Chas
                        },
            Type: "LP"
        );
    }
}
