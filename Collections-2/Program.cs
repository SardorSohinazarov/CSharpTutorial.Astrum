abstract class Class1 { }
sealed class CLASS2 { }
class Class3 { }
internal class Class4 { }
static class Class5 { }
internal class Program
{
    private static void Main(string[] args)
    {
        /*  object a = (object)10;

          object b = a as long?;

          Console.WriteLine((long)b);*/

        /*        string.Concat(new string[] { "sardor", " ", "bekchanov" });

                B bar = new B();
                bar.Foo();*/

        int i = 0;
        i--;
        i = i + ++i;

        Console.WriteLine(i);

        /*  var intlar = GetInts();

          foreach (var item in intlar)
          {
              Console.WriteLine(item);
          }*/

        A a = new A(10) { Value = 10 };
    }

    public static IEnumerable<int> GetInts()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return i;
        }
    }
}

public class A
{
    public int Value { get; set; }
    public A(int a)
    {

    }
}

public interface IFoo
{
    int Foo();
}

class A : IFoo
{
    public int Foo() { return 1; }
}

class D : A, IFoo
{
    public int Foo() { return 3; }
}


/*using System.Collections;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDictionary valuePairs = new MyDictionary();

        valuePairs.Add(100, "sardor");

        valuePairs[1000] = ".NET Core 3.1";

        Console.WriteLine(valuePairs[100]);
        Console.WriteLine(valuePairs[1000]);


        A a = new A();

        var intQiymat = a[100];
    }
}

class A
{
    public int this[int index]
    {
        get
        {
            return 1;
        }
    }
}

class MyDictionary : IDictionary<int, string>
{
    private string[] values;

    public MyDictionary()
    {
        values = new string[1000000];
    }

    public string this[int key]
    {
        get
        {
            return values[key];
        }
        set
        {
            values[key] = value;
        }
    }

    public ICollection<int> Keys => throw new NotImplementedException();

    public ICollection<string> Values => throw new NotImplementedException();

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(int key, string value)
    {
        values[key] = value;
    }

    public void Add(KeyValuePair<int, string> item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(KeyValuePair<int, string> item)
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(int key)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(KeyValuePair<int, string>[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<KeyValuePair<int, string>> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Remove(int key)
    {
        throw new NotImplementedException();
    }

    public bool Remove(KeyValuePair<int, string> item)
    {
        throw new NotImplementedException();
    }

    public bool TryGetValue(int key, [MaybeNullWhen(false)] out string value)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
*/