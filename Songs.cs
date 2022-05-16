using static NewFeaturesApp.Albums;
using static NewFeaturesApp.Bands;

namespace NewFeaturesApp
{
    public class Songs
    {
        public static List<Song> songList = new() {
            NichHaspyda,
            BurevijSong,
            ZatoplenaSichDemo,
            ZatoplenaSichRelease,
            RidnaZemliaSong,
            KolyJaOzhyvu,
            ShchoLyshyv,
            KudyJaIdu,
            NaPaliu,
            Pursuit,
            TsarehradSingle,
            BrateVitreSong,
            BrateVitreSong2,
            Starets,
            Starets2,
            Sura,
            TryShliakhy,
            TryShliakhy2,
            Karna,
            Karna2,
            Kujaba,
            Kujaba2,
            Kruk,
            Kruk2,
            VesnoKrasna,
            VesnoKrasna2,
            VerbovajaDoshchechka,
            VerbovajaDoshchechka2,
            BogatyrskajaSila,
            HerrMannelig,
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
        };

        public static Song NichHaspyda = new(
            SongName: "Ніч Гаспида",
            Duration: "05:37",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 2), (RidnaZemlia, 1) }
            );
        public static Song BurevijSong = new(
            SongName: "Буревій",
            Duration: "05:35",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 1) }
            );
        public static Song ZatoplenaSichDemo = new(
            SongName: "Затоплена Січ",
            Year: 2009,
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (ZatoplenaSich, 1), (RidnaZemlia, 5) }
            );
        public static Song ZatoplenaSichRelease = new(
            SongName: "Затоплена Січ",
            Duration: "05:41",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 7) }
            );
        public static Song RidnaZemliaSong = new(
            SongName: "Рідна Земля",
            Duration: "06:38",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 3), (RidnaZemlia, 3) }
            );
        public static Song KolyJaOzhyvu = new(
            SongName: "Коли Я Оживу",
            Duration: "04:44",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 6), (RidnaZemlia, 2) }
            );
        public static Song ShchoLyshyv = new(
            SongName: "Що Лишив Ти За Собою",
            Duration: "08:22",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 8), (RidnaZemlia, 4) }
            );
        public static Song KudyJaIdu = new(
            SongName: "Куди Я Іду",
            Duration: "04:47",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 4) }
            );
        public static Song NaPaliu = new(
            SongName: "На Палю!",
            Duration: "05:10",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 5) }
            );
        public static Song Pursuit = new(
            SongName: "У Погоні Варягів! (Amon Amarth 'Pursuit of Vicings' cover)",
            Duration: "05:10",
            Authors: "Amon Amarth",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Burevij, 9) }
            );
        public static Song TsarehradSingle = new(
            SongName: "Цареград",
            Duration: "04:44",
            Band: Haspyd,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Tsarehrad, 1) }
            );
        public static Song BrateVitreSong = new(
            SongName: "Брате Вітре",
            Duration: "08:11",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 1) }
            );
        public static Song BrateVitreSong2 = new(
            SongName: "Брате Вітре",
            Duration: "08:00",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 1) }
            );
        public static Song Starets = new(
            SongName: "Старець",
            Duration: "05:59",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 2) }
            );
        public static Song Starets2 = new(
            SongName: "Старець",
            Duration: "05:55",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 2) }
            );
        public static Song Sura = new(
            SongName: "Сура",
            Duration: "05:55",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 4) }
            );
        public static Song TryShliakhy = new(
            SongName: "Три Шляхи",
            Duration: "05:44",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 3) }
            );
        public static Song TryShliakhy2 = new(
            SongName: "Три Шляхи",
            Duration: "05:44",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 7) }
            );
        public static Song Karna = new(
            SongName: "Карна",
            Duration: "08:37",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 4) }
            );
        public static Song Karna2 = new(
            SongName: "Карна",
            Duration: "08:28",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 6) }
            );
        public static Song Kujaba = new(
            SongName: "Куяба",
            Duration: "06:32",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 5) }
            );
        public static Song Kujaba2 = new(
            SongName: "Куяба",
            Duration: "06:36",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 5) }
            );
        public static Song Kruk = new(
            SongName: "Крук",
            Duration: "06:06",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 6) }
            );
        public static Song Kruk2 = new(
            SongName: "Крук",
            Duration: "05:53",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 3) }
            );
        public static Song VesnoKrasna = new(
            SongName: "Весно Красна",
            Duration: "06:18",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 7) }
            );
        public static Song VesnoKrasna2 = new(
            SongName: "Весно Красна",
            Duration: "06:17",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 8) }
            );
        public static Song VerbovajaDoshchechka = new(
            SongName: "Вербовая Дощечка",
            Duration: "06:13",
            Band: Chur,
            Authors: "Українська народна (обрядова)",
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitreDemo, 8) }
            );
        public static Song VerbovajaDoshchechka2 = new(
            SongName: "Вербовая Дощечка",
            Duration: "06:13",
            Band: Chur,
            Authors: "Українська народна (обрядова)",
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 9) }
            );
        public static Song BogatyrskajaSila = new(
            SongName: "Богатырская Сила",
            Duration: "03:59",
            Band: Chur,
            Authors: "ВИА Самоцветы",
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 10) }
            );
        public static Song HerrMannelig = new(
            SongName: "Герр Маннелиг",
            Duration: "05:47",
            Band: Chur,
            Authors: "Скандинавська народна",
            AlbumsAndTrackNumbers: new (Album, uint)[] { (BrateVitre, 11) }
            );
        public static Song Lirnyk = new(
            SongName: "Intro: Лірник",
            Duration: "00:40",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 1) }
            );
        public static Song LykhoSong = new(
            SongName: "Лихо",
            Duration: "04:51",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 2) }
            );
        public static Song Braty = new(
            SongName: "Брати",
            Duration: "08:42",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 3) }
            );
        public static Song Mara = new(
            SongName: "Мара",
            Duration: "06:30",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 4) }
            );
        public static Song Nebo = new(
            SongName: "Небо",
            Duration: "05:54",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 5) }
            );
        public static Song Maty = new(
            SongName: "Мати",
            Duration: "06:07",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 6) }
            );
        public static Song JduNaVy = new(
            SongName: "Йду На Ви!",
            Duration: "06:03",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 7) }
            );
        public static Song Zahovir = new(
            SongName: "Заговір",
            Duration: "07:11",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 8) }
            );
        public static Song Vesna = new(
            SongName: "Весна",
            Duration: "07:41",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 9) }
            );
        public static Song Chas = new(
            SongName: "Час",
            Duration: "06:25",
            Band: Chur,
            AlbumsAndTrackNumbers: new (Album, uint)[] { (Lykho, 10) }
            );
    }
}
