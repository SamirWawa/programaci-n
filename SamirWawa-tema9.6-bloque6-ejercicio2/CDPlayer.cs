class CDPlayer : IRemovableMedia<Disc>
{
    private int Track { get; set; }
    private MediaState State { get; set; }
    public bool MediaIn { get; }
    public string Name { get; }
    public Disc disco { get; set; }

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
        Name = "CD";
        MediaIn = true;
    }

    public void InsertMedia(in Disc media) => disco = media;
    public bool RemoveMedia()
    {
        disco = null;
        return !MediaIn;
    } 
    public void Play()
    {
        if (State == MediaState.Stopped)
        {
            Track = 1;
            State = MediaState.Playing;
        }
        if (State == MediaState.Paused)
            State = MediaState.Playing;
    }
    public void Pause() => State = MediaState.Paused;
    public void Stop()
    {
        State = MediaState.Stopped;
    }
    public void Previous()
    {
        if (Track - 1 < 0)
            Track = disco.NumTracks - 1;
        else
            Track--;
    }
    public void Next()
    {
        if (Track == disco.NumTracks - 1)
            Track = 0;
        else
            Track++;
    }
    public object Clone() => new CDPlayer();
}
