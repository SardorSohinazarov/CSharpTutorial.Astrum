namespace OOP2;

public partial class Math2
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Sum(int a, int b, int c)
        => a + b + c;

    public static double Sum(double a, double b)
        => a + b;
}
/*
class Auto : Transport
{
    public Auto(string name) : base(name)
    {
    }

    public override sealed void Move()
    {
        Console.WriteLine("Yo'lda yur");
    }
}

class Matiz : Auto
{
    public Matiz() : base("Matiz")
    {
        
    }

    public override void Move()
    {
        Console.WriteLine("Matiz yo'lda yur");
    }
}

class Aviatsiya : Transport
{
    public Aviatsiya(string Name) : base(Name)
    {
        this.Name = Name;
        this.Move();
    }

    public override void Move()
    {
        Console.WriteLine("Havoda yur");
    }
}


*/


/*internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student(1, "Sardor", "+998912040618");

        student.Display();
    }
}

public class Person
{
    public Person(int id, string name, string phoneNumber)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public virtual void Display()
    {
        Console.WriteLine($"Person: Id: {Id}, Name: {Name}, PhoneNumber: {PhoneNumber}");
    }
}

public class Student : Person
{
    public Student(int id, string name, string phoneNumber)
        : base(id, name, phoneNumber)
    {
    }

    public override void Display()
    {
        *//*base.Display();*//*
        Console.WriteLine($"Student: Id: {Id}, Name: {Name}, PhoneNumber: {PhoneNumber}");
    }
}*/