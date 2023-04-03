class USB
{
    public string[] Files { get; set; }
    public int NumberOfFiles { get; }
    public string NombreFichero(in int file) { get; }
    public USB(string album, string artist, string[] songs)
}