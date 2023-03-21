class DABRadio:IMedia
{
    const float SEEK_STEP = 0.5f;
    const float MAX_FREQUENCY = 108f;
    const float MIN_FREQUENCY = 87.5f;
    private float Frequency{get;set;}
    public string MessageToDisplay{get;}
    public MediaState State{get;set;}
    public DABRadio()
    {
        State = MediaState.Playing;
        Frequency = MIN_FREQUENCY;
        MessageToDisplay = $"MODO: DAB\nSTATE: {State} FM - {Frequency}\n[1]Play [2]Pause [3]Stop [4]Previous [5]Next [6]Switch [ESC]Exit";
    }
    public void Play()
    {
        if(State == MediaState.Stopped)
            Frequency = MIN_FREQUENCY;
        if(State == MediaState.Playing)
            State = MediaState.Paused;
        else
            State = MediaState.Playing;
        
    }
    public void Stop()
    {
        if(State == MediaState.Stopped)
            throw new Exception("Ya esta parado");
        else
            State = MediaState.Stopped;
    }
    public void Pause()
    {
        if(State == MediaState.Paused)
            State = MediaState.Playing;
        else
            State = MediaState.Paused;
    }
    public void Next()
    {
        if(Frequency==MAX_FREQUENCY)
            Frequency = MIN_FREQUENCY;
        else 
            Frequency+= SEEK_STEP;
    }
    public void Previous()
    {
        if(Frequency==MIN_FREQUENCY)
            Frequency = MAX_FREQUENCY;
        else 
            Frequency-= SEEK_STEP;
    }
}