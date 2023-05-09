public class MyPair<T1, T2>
{
    protected T1 first;
    protected T2 second;
    public MyPair(T1 first, T2 second)
    {
        this.first = first;
        this.second = second;
    }
    public object this[int i]
    {
        get
        {
            if (i == 0) return first;
            else if (i == 1) return second;
            else return null;
        }
        set
        {
            if (i == 0) first = (T1)value;
            else if (i == 1) second = (T2)value;
           
        }
    }

}