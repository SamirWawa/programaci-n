class CDPlayer:IMedia
{
    private ushort Track{get;set;}
    private MediaState State{get;set;}
    public bool MediaIn{get;}
    public string MessageToDisplay{get;}

    public CDPlayer()
    {

    }
    public void Play()
    {

    }
    public void Stop()
    {

    }
    public void Pause()
    {

    }
    public void Next()
    {

    }
    public void Previous()
    {

    }
    public void InsertMedia(Disc media)
    {

    }
    public bool ExtractMedia()
    {
        return MediaIn;
    }
}