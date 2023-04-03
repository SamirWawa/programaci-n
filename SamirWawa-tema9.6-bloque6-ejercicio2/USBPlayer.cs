class USBPlayer : IRemovableMedia<USB>
{
    public ushort FileNumber { get; set; }
    public MediaState State { get; set; }
    public USBPlayer()
    public void InsertMedia(in USB media)
    public bool RemoveMedia()
}
