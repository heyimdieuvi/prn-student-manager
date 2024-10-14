namespace StudentManagerV2.Services;

public class Cabinet<T>
{
    private T[] _arr;
    private int _count;

    public Cabinet()
    {
        
    }

    public void Add(T item)
    {
        _arr[_count++] = item;
    }
    //BTVN so 3: Hoan tat not class nay va thu nghiem.
}