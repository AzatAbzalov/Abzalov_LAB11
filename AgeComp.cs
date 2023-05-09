public class AgeComp : IComparer<Person>
{
    public int Compare(Person a, Person b)
    {
        return a.Age().CompareTo(b.Gender);
    }
}