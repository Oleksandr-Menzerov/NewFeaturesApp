using static NewFeaturesApp.Albums;
namespace NewFeaturesApp
{
    public class Bands
    {
        public static List<Band> bandsList = new() { Haspyd, Chur };
        public static Band Haspyd = new(
            BandName: "Haspyd",
            Members: new List<(string, string)>() {
                ("Олександр Мензеров", "Вокал, сопілка, дримба, жалійка"),
                ("Сергій Степаненко", "Гітара"),
                ("Сергій Куприков", "Гітара"),
                ("Олександр Петрушан", "Барабани"),
                ("Андрій Савченко", "Бас") },
            YearOfFundation: 2009,
            ExMembers: new List<string>() {
                        "Євген Головченко",
                        "Денис Калінін"},
            Country: "Ukraine",
            City: "Kharkiv",
            LPs: new List<Album>() { Burevij, new Album("Перехрестя Двох Вітрів", 2020, Label: new Label("Eternal Winter Records")) },
            EPs: new List<Album>() { RidnaZemlia },
            SinglesAndDemos: new List<Album>() { ZatoplenaSich, Tsarehrad },
            SplitsAndCompilations: null,
            Genres: new Genre[] { "Folk Metal", "Pagan Metal", "Melodic Death Metal" }
        );
        public static Band Chur = new(
            BandName: "Чур",
            Members: new List<(string, string)>() {
                        ("Євген Кучеров", "Вокал, домра, бас, гітара, програмування") },
            YearOfFundation: 2005,
            ExMembers: new List<string>() {
                        "Вікторія Кумановська",
                        "Юрій Павлишин",
                        "Іван Попов",
                        "Святослав Силенко",
                        "Сашко Лірник",
                        "Вероніка Самандас",
                        "Олена Ваніна",
                        "Eisenslav",
                        "Костянтин Мельничук",
                        "Сергій Павлов",
                        "Юрій Кузькін"},
            Country: "Ukraine",
            City: "Kherson",
            LPs: new List<Album>() { BrateVitre, Lykho, new Album("Four​-​Faced", 2020) },
            SinglesAndDemos: new List<Album>() { BrateVitreDemo },
            SplitsAndCompilations: new List<Album>() {
                        new Album("Чур - З Мороку/Опричь - Огнецвет", 2008),
                        new Album("Чур/Опричь/Пярэвараццень - Триєдність (Чур відмовився від цього проєкту починаючи з 2014р.)", 2012) },
            Genres: new Genre[] { "Folk Metal", "Pagan Metal" }
        );
    }
}
