public class MyTriple<T1, T2, T3> : MyPair<T1, T2>
{
    private T3 third;
    public MyTriple(T1 first, T2 second, T3 third) : base(first, second)
    {
        this.third = third;
    }
    public object this[int index]
    {
        get
        {
            if (index == 0) return first;
            else if (index == 1) return second;
            else if (index == 2) return third;
            else return null;
        }
        set
        {
            if (index == 0) first = (T1)value;
            else if (index == 1) second = (T2)value;
            else if (index == 2) third = (T3)value;
           
        }
    }
}