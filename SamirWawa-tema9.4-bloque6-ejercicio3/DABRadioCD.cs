class DABRadioCD:IMedia
{
    public IMedia ActiveDevice{get;set;}
    public Disc InsertCD{get;set;}
    public string MessageToDisplay{get;}
    public CDPlayer CD{get;set;}
    public DABRadio Radio{get;set;}
    public string modo{get;set;}
    public DABRadioCD()
    {
        CD = new CDPlayer();
        Radio = new DABRadio();
        MessageToDisplay=$"MODO: {modo}\nSTATE: {Radio.State} {InsertCD.ToString()}\n[1]Play [2]Pause [3]Stop [4]Previous [5]Next [6]Switch [7]Insert CD [8]Extract CD [ESC]Exit";
    }
    public void Play()
    {
        ActiveDevice.Play();
    }
    public void Stop()
    {
        ActiveDevice.Stop();
    }
    public void Pause()
    {
        ActiveDevice.Pause();
    }
    public void Next()
    {
        ActiveDevice.Next();
    }
    public void Previous()
    {
        ActiveDevice.Previous();
    }
    public void ExtractCD()
    {
        CD.ExtractMedia();
    } 
    public void SwitchMode()
    {
        if(modo=="CD")
            modo="DAB";
        else
            modo="CD";
    }
}