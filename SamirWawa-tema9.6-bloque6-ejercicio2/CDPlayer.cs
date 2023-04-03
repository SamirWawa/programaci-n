class CDPlayer : IRemovableMedia<Disc>
{
    private ushort Track { get; set; }
    private MediaState State { get; set; }

    public class CDPlayerException : MediaException
    {
        public CDPlayerException(string message) : base(message)
        {
        }
    }

    public CDPlayer()
    {
        Track = 0;
        State = MediaState.Stopped;
    }

    public void InsertMedia(in Disc media)
    public bool RemoveMedia()
}
