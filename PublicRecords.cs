namespace NewFeaturesApp
{
    // Record type:
    public record Song(
        string SongName,
        string? Duration = null,
        Year? Year = null,
        Band? Band = null,
        string? Authors = null,
        Genre? Geanre = null,
        (Album, uint)[]? AlbumsAndTrackNumbers = null);
    public record Album(
        string AlbumName,
        Year Year,
        Band[]? Bands = null,
        Song[]? Songs = null,
        string? Type = "LP",
        Genre[]? Genres = null,
        Label? Label = null);
    public record Band(
        string BandName,
        List<(string, string)> Members,
        uint YearOfFundation,
        List<string>? ExMembers = null,
        string? Country = null,
        string? City = null,
        List<Album>? LPs = null,
        List<Album>? EPs = null,
        List<Album>? SinglesAndDemos = null,
        List<Album>? SplitsAndCompilations = null,
        Genre[]? Genres = null,
        List<Label>? Labels = null);
}
