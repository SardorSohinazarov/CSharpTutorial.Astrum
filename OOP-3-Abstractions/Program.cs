internal class Program
{
    private static void Main(string[] args)
    {
        Animal dog = new Dog();

        IAnimal dog1 = new Dog();

        dog1.MakeSound("");

        dog.MakeSound();
    }
}

public abstract class Animal
{
    int a = 4;
    public abstract void MakeSound();
}
/*
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("WOW");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Myov");
    }
}*/

interface IAnimal
{
    public string Name { get; set; }
    public void MakeSound(string text);
}

interface IWild
{
    public void EetMeat();
}

public partial class Dog : Animal, IAnimal, IWild
{
    public string Name { get; set; }

    public void EetMeat()
    {
        throw new NotImplementedException();
    }
}

public partial class Dog
{
    public override void MakeSound()
    {
    }

    void IAnimal.MakeSound(string text)
    {
        throw new NotImplementedException();
    }
}