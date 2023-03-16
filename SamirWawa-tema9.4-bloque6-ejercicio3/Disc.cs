class Disc
{
    private string Album{get;set;}
    private string Artist{get;set;}
    private string[] Songs{get;set;}
    public string NombreCancion(in int song)=>Songs[song];
    public Disc(string album, string artist, string[] songs)
    {
        Album = album;
        Artist = artist;
        Array.Copy(songs, Songs, songs.Length);
    }
    public override string ToString()
    {
        return base.ToString();
    }
}