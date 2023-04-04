class MultimediaDeviceBuilder
{
    public IMedia CdPlayer { get; set; }
    public IMedia DABRadio { get; set; }
    public IMedia UsbPlayer { get; set; }
    public IMessageToDisplay MenuDeMedios { get; }

    public MultimediaDeviceBuilder(in IMessageToDisplay menuDeMedios)
    {
        MenuDeMedios = menuDeMedios;
        DABRadio = null;
        UsbPlayer = null;
        CdPlayer = null;
    }
    public MultimediaDeviceBuilder SetMedia(in CDPlayer media)
    public MultimediaDeviceBuilder SetMedia(in DABRadio media)
    public MultimediaDeviceBuilder SetMedia(in UsbPlayer media)
    public MultimediaDevice Build()
}