interface IRemovableMedia<T>
{
    bool MediaIn{get;}

    void InsertMedia(in T media);
    bool RemoveMedia();
}