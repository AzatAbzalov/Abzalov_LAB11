//Задание 1, пункт а
using System.Security.Cryptography;
static void Swap<T>(T[] array, int i, int j)
{
    T h = array[i];
    array[i] = array[j];
    array[j] = h;
}

int[] a = { 1, 2, 3, 4, 5 };
Swap(a, 0, a.Length - 1);
Console.WriteLine(string.Join(", ", a));

double[] a2 = { 1.0, 2.0, 3.0, 4.0, 5.0 };
Swap(a2, 0, a2.Length - 1);
Console.WriteLine(string.Join(", ", a2));

string[] a3 = { "aaa", "bbb", "ccc", "ddd", "eee" };
Swap(a3, 0, a3.Length - 1);
Console.WriteLine(string.Join(", ", a3));

Person[] P = { new Person("Азат", "Абзалов", default, 'М'), new Person("Кристина", "Иванова", default, 'Ж') };
Swap(P, 0, 1);
Console.WriteLine(Person.ToString(P));


//Задание 1.Пункт Б

T[] Delete<T>(T[] a, int i)
{
    T[] array = new T[a.Length - 1];
    Array.Copy(a, array, i);
    Array.Copy(a, i + 1, array, i, a.Length - i - 1);
    return array;
}


int[] b = { 1, 2, 3, 4, 5, 6 };
int[] b_new = Delete(b, 3);
Console.WriteLine(string.Join(", ", b));


double[] b1 = { 1.0, 2.0, 3.0 };
double[] b1_new = Delete(b1, 1);
Console.WriteLine(string.Join(", ", b1));


string[] b2 = { "red", "green", "blue" };
string[] b2_new = Delete(b2, 0);
Console.WriteLine(string.Join(", ", b2));


Person[] PArr = { new Person("Азат", "Абзалов", default, 'М'), new Person("Кристина", "Иванова", default, 'Ж') };
Person[] PArr_new = Delete(PArr, 1);
Console.WriteLine(Person.ToString(PArr));

//Задание 2. Пункт А

Person p1 = new("Азат", "Абзалов", new DateTime(2005, 2, 2), 'м'); 
Person p2 = new("Кристина", "Иванова", new DateTime(2003, 12, 11), 'ж');
Console.WriteLine(p1.CompareTo(p2));
Console.WriteLine(p2.CompareTo(p1));
Console.WriteLine(p1.CompareTo(p1));

Person[] people = { new Person(p1.FirstName, p1.LastName, p1.BirthDate, p1.Gender),
    new Person(p2.FirstName, p2.LastName, p2.BirthDate, p2.Gender),
    new Person("Михаил", "Баталов", new DateTime(2000,10, 4), 'ж') };
Array.Sort(people);
foreach (Person p in people)
{
    p.Output();
    Console.WriteLine();
}
Console.WriteLine("Максимальный элемент массива");
Max(people).Output();

static Person Max(Person[] people)
{
    Person max = people[0];
    for (int i = 1; i < people.Length; i++)
    {
        if (people[i].CompareTo(max) > 0)
            max = people[i];
    }
    return max;
}

//Задание 2. Пункт Б
Person[] pers = { new Person("Азат", "Абзалов", new DateTime(2005, 2, 2), 'м'),
    new Person("Кристина", "Иванова", new DateTime(2003, 12, 11), 'ж'),
    new Person("Азамат", "Абзалов", new DateTime(2006, 12, 21), 'ж'),
    new Person("Михаил", "Баталов", new DateTime(2002, 10, 4), 'м') };
Array.Sort(people, new AgeComp());
Console.WriteLine("Сортировка по возрасту");
foreach (Person p in people)
    p.Output();
Array.Sort(people, new GenderComp());
Console.WriteLine("\nСортировка по полу");
foreach (Person p in people)
    p.Output();

Person maxperson = GetMax<Person>(people, new AgeComp());
Console.WriteLine("\nМаксимальное значение по возрасту");
maxperson.Output();
maxperson = GetMax<Person>(people, new GenderComp());
Console.WriteLine("\nМаксимальное значение по полу");
maxperson.Output();
static T GetMax<T>(T[] array, IComparer<T> comparer)
{
    T max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (comparer.Compare(array[i], max) > 0)
            max = array[i];
    }
    return max;
}
//Задание 3
MyPair<string, int> pair1 = new("aaa", 12);
Console.WriteLine(pair1[0] + " " + pair1[0].GetType());
Console.WriteLine(pair1[1] + " " + pair1[1].GetType());
MyTriple<string, double, char> triple1 = new("bbb", 33.144, 'М');
Console.WriteLine(triple1[0] + " " + triple1[0].GetType());
Console.WriteLine(triple1[1] + " " + triple1[1].GetType());
Console.WriteLine(triple1[2] + " " + triple1[2].GetType());