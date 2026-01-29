namespace Homework7;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;

        if (ReferenceEquals(this, obj)) return true;

        if (obj is Person person)
            return Name == person.Name && Age == person.Age;

        return false;
    }

    public override int GetHashCode()
    {
        var key = 82;
        int res;
        unchecked
        {
            res = key * 23 ^ Name.GetHashCode() ^ Age;
        }

        return res;
    }

    public static bool operator ==(Person a, Person b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.Equals(b);
    }

    public static bool operator !=(Person a, Person b)
    {
        return !(a == b);
    }

    public static bool operator >(Person a, Person b)
    {
        if (ReferenceEquals(a, b)) return false;
        if (a is null || b is null) return false;

        return a.Age > b.Age;
    }

    public static bool operator <(Person a, Person b)
    {
        if (ReferenceEquals(a, b)) return false;
        if (a is null || b is null) return false;

        return a.Age < b.Age;
    }
}
