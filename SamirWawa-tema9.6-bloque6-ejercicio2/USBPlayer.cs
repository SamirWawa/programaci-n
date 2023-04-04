class USBPlayer : IRemovableMedia<USB>
{
    public int FileNumber { get; set; }
    public MediaState State { get; set; }
    public bool MediaIn { get; }
    public string Name { get; }
    public USB usb { get; set; }
    public USBPlayer()
    {
        FileNumber = 0;
        State = MediaState.Playing;
        Name = "USB";
        usb = null;
        MediaIn = true;
    }
    public void InsertMedia(in USB media) => usb = media;
    public bool RemoveMedia()
    {
        usb = null;
        return false;
    }
    public void Play()
    {
        if (State == MediaState.Stopped)
        {
            FileNumber = 0;
            State = MediaState.Playing;
        }
        if (State == MediaState.Paused)
            State = MediaState.Playing;
    }
    public void Pause() => State = MediaState.Paused;
    public void Stop() => State = MediaState.Stopped;
    public void Previous()
    {
        if (FileNumber -1 < 0)
            FileNumber = usb.NumberOfFiles - 1;
        else
            FileNumber--;
    }
    public void Next()
    {
        if (FileNumber >= usb.NumberOfFiles -1)
            FileNumber = 0;
        else
            FileNumber++;
    }
    public object Clone() => new USBPlayer();
}
