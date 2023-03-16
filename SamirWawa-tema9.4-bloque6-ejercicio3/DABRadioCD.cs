class DABRadioCD:IMedia
{
    private IMedia ActiveDevice{get;set;}
    public Disc InsertCD{get;set;}
    public string MessageToDisplay=$"MODO: (DAB ? CD : modo)\nSTATE: {}\n[1]Play [2]Pause [3]Stop [4]Previous [5]Next [6]Switch [7]Insert CD [8]Extract CD [ESC]Exit";
    public DABRadioCD()
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
    public void ExtractCD()
    {

    } 
    public void SwitchMode()
    {

    }
}