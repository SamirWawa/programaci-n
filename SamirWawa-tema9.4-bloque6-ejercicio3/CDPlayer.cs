class CDPlayer:IMedia
{
    private ushort Track{get;set;}
    public MediaState State{get;set;}
    public bool MediaIn{get;}
    public string MessageToDisplay{get;}
    public Disc d=null;

    public CDPlayer()
    {
        Track = 1;
        State = MediaState.Playing;
        MediaIn = true;
        MessageToDisplay=$"MODO: CD\nSTATE: {State} {d.ToString()} {d.NombreCancion(Track)}\n[1]Play [2]Pause [3]Stop [4]Previous [5]Next [6]Switch [7]Insert CD [8]Extract CD [ESC]Exit";
    }
    public void Play()
    {
        if(State==MediaState.Stopped)
        {
            Track = 1;
            State=MediaState.Playing;
        }
        if(State ==MediaState.Paused)
            State = MediaState.Playing;
        Console.Write(MessageToDisplay);
    }
    public void Stop()
    {
        State = MediaState.Stopped;
        Console.Write(MessageToDisplay);
    }
    public void Pause()
    {
        if(State==MediaState.Paused)
            State=MediaState.Playing;
        else
            State = MediaState.Paused;
        Console.Write(MessageToDisplay);
    }
    public void Next()
    {
        if(Track==d.Songs.Length-1)
            Track = 0;
        else
            Track+=1;
    }
    public void Previous()
    {
        if(Track==0)
        {
            Track = (ushort)d.Songs.Length;
            Track-=1;
        }
        else
            Track-=1;
    }
    public void InsertMedia(Disc media)
    {
        d = media;
    }
    public bool ExtractMedia()
    {
        return MediaIn;
    }
}