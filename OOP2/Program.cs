using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        /*  var aviatsiya = new Aviatsiya("aviatiya");

          aviatsiya.Name = "Boeing 747";

          aviatsiya.Move();

          var auto = new Auto("avto");

          auto.Move();

          var temir = new TemirYol("temiryo'l");

          temir.Move();*/


        //overloading

        /*    Math2 math = new Math2();

            int a = 7;

            Console.WriteLine(math.Sum(1,2,4));
            Console.WriteLine(math.Sum(1,2));
            Console.WriteLine(math.Sum(1.0,2.0));*/


        /* Math2.Sum(1, 2, 3);


         Math.Max(1, 2);*/

        /*  const int a = 5;
          a = 6;*/

        Math2.Minus(1, 2);
        Math2.Sum(1, 2);
    }
}

class a { }

class Transport
{
    public Transport(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public void GetStatistics()
    {
        Console.WriteLine($"Statistics({Name}):");
    }

    public virtual void Move()
    {
        Console.WriteLine("Move -> ");
    }
}

class TemirYol : Transport
{
    public TemirYol(string name) : base(name)
    {
    }

    public override void Move()
    {
        base.Move();
    }
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