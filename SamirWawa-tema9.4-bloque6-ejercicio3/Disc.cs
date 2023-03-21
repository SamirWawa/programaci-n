class Disc
{
    public string Album{get;set;}
    public string Artist{get;set;}
    public string[] Songs{get;set;}
    public string NombreCancion(in int song)=>Songs[song];
    public Disc(string album, string artist, string[] songs)
    {
        Album = album;
        Artist = artist;
        Array.Copy(songs, Songs, songs.Length);
    }
    public override string ToString()
    {
        return $"Album: {Album} Artist: {Artist}";
    }
}