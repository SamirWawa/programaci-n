interface IRemovableMedia<T> : IMedia
{
    bool MediaIn { get; }

    void InsertMedia(in T media);
    bool RemoveMedia();
}