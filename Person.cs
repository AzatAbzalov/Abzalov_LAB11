using System.Runtime.CompilerServices;

public class Person : IComparable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public char Gender { get; set; }

    public Person() : this("null", " ", new DateTime(), 'М')
    { }
    public Person(string firstName, string lastName, DateTime birthdate, char gender)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthdate;
        Gender = gender;
    }
    public int CompareTo(Person other)
    {
        return FirstName.CompareTo(other.FirstName);
    }
    public void Output()
    {
        Console.WriteLine("Имя:" + FirstName);
        Console.WriteLine("Фамилия:" + LastName);
        Console.WriteLine("Дата Рождения: " + BirthDate);
        Console.WriteLine("Пол: " + Gender);
    }
    public override string ToString()
    {
        return ($"{FirstName},{LastName},{BirthDate},{Gender}");
    }

    public static string ToString(Person[] a)
    {
        string str = "";
        foreach (Person p in a)
        {
            str += p.ToString() + "\n";
        }
        return str;
    }

    public int Age()
    {
        int x = DateTime.Today.Year - BirthDate.Year;
        if (BirthDate.Month > DateTime.Today.Month || (BirthDate.Month == DateTime.Today.Month && BirthDate.Day > DateTime.Today.Day))
            x--;
        return x;
    }
}


