class MultimediaDeviceBuilder
{
    public Imedia CdPlayer { get; set; }
    public IMedia DABRadio { get; set; }
    public Imedia UsbPlayer { get; set; }
    public IMessageToDisplay MenuDeMedios { get; }

    public void MultimediaDeviceBuilder(in IMessageToDisplay menuDeMedios)
    public MultimediaDeviceBuilder SetMedia(in CDPlayer media)
    public MultimediaDeviceBuilder SetMedia(in DABRadio media)
    public MultimediaDeviceBuilder SetMedia(in UsbPlayer media)
    public MultimediaDevice Build()
}