class MultimediaDevice : IMedia
{
    public IMedia[] MediaDevices { get; set; }
    public IMedia ActiveDevice { get; set; }
    public IMessageToDisplay DevicesMenu { get; }
    public string MessageToDisplay { get; }

    public MultimediaDevice(in IMedia[] medios, in IMessageToDisplay devicesMenu)
    private IRemovableMedia<T> SetActiveDevicetoParametrizedMedia<T>()
    public void Insert<T>(in T media)
    public void Extract<T>()
    public void SwitchMode()
    public void Play()
    public void Stop()
    public void Pause()
    public void Next()
    public void Previous()
    public object Clone() => new MultimediaDevice();
}