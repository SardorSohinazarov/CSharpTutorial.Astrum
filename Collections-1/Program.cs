internal class Program
{
    private static void Main(string[] args)
    {
        /*ArrayList array = new ArrayList();

        array.Add(1);
        array.Add(2);
        array.AddRange(new int[] { 1, 2 });

        Console.WriteLine(array.IndexOf(2));*//*


        List<int> intlar = new List<int>();
        List<string> strings = new List<string>()
        {
            "Sardor",
            "Sarvar",
            "Sanjar"
        };

        var sarvar = strings.Find(x => x == "Sarvar");
        strings.FirstOrDefault(x => x == "Sardor1");
        strings.Sort();

        strings.Contains("Sardor");
        strings.Any(x => x == "Sardor");

        *//*foreach (string s in strings)
        {
            if(s == "Sarvar")
            {
                Console.WriteLine(s);
                return;
            }
        }*//*


        List<Person> persons = new List<Person>()
        {
            new Person()
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Test",
                PhoneNumber = "Test",
            },
            new Person()
            {
                Id= 1,
                LastName= "Test2",
                FirstName= "Test2",
                PhoneNumber= "Test2",
            },
              new Person()
            {
                Id= 3,
                LastName= "Test3",
                FirstName= "Test3",
                PhoneNumber= "Test3",
            }
        };

        var personNull = persons.Find(x => x.FirstName == "Sardor" || x.Id == 7);

        Console.WriteLine(persons.FirstOrDefault(x => x.PhoneNumber == "Test7"));

        Console.WriteLine(persons.Any(x => x.FirstName == "Test"));
        Console.WriteLine(persons.FindAll(x => x.Id == 1));

        var ismlar = persons.Select(x => x.FirstName);

        foreach (var ism in ismlar)
        {
            Console.WriteLine(ism);
        }

        var person = persons.Skip(1).Take(1);

        var filteredpersons = persons.Where(x => x.FirstName.Contains("Sardor"));*/

        /*      LinkedList<string> list = new LinkedList<string>();

              list.AddFirst("a");
              list.AddLast("b");*/

        SortedList<string, Person> sortedarray = new SortedList<string, Person>();

        /*sortedarray.Add(1, 1);
        sortedarray.Add(0, 2);
        sortedarray.Add(4, 3);
        sortedarray.Add(2, 4);

        foreach (int i in sortedarray.Keys)
        {
            Console.WriteLine(i);
        }

        if (!sortedarray.ContainsKey(0))
        {
            sortedarray.Add(0, 7);
        }
        else
        {
            sortedarray.Remove(0);
            sortedarray.Add(0, 7);
        }


        foreach (int i in sortedarray.Values)
        {
            Console.WriteLine(i);
        }
*/
        //LIFO
        /*        Stack<string> stack = new Stack<string>();

                stack.Push("A");
                stack.Push("B");
                stack.Push("C");
                stack.Push("D");

                var d = stack.Peek();

                Console.WriteLine(d);
                d = stack.Pop();
                Console.WriteLine(d);
                Console.WriteLine(stack.Peek());*/

        //FIFO
        /*        Queue<string> queue = new Queue<string>();
                queue.Enqueue("A");
                queue.Enqueue("B");
                queue.Enqueue("C");

                var a = queue.Dequeue();
                Console.WriteLine(a);
                var b = queue.Dequeue();
                Console.WriteLine(b);

                queue.Enqueue("kfs");

                foreach (var q in queue)
                {
                    Console.WriteLine(q);
                }*/

        /* Dictionary<string, string> lugat = new Dictionary<string, string>();
         lugat.Add("Apple", "Olma -------------------------------");
         lugat.Add("Book", "Kitob -------------------------------");
         lugat.Add("Pen", "Ruchka --------------------------------------------");
         lugat.Add("djncls", "Oljsdnclscmslfdlllllllllllllllma");

         lugat.Add("Apple", "Nok ...");

         var value = lugat["Apple"];

         Console.WriteLine(value);*/
    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string PhoneNumber { get; set; }
}


/*class MyCollection
{
    private int[] array;
    private int pointer;

    public MyCollection()
    {
        array = new int[2];
        pointer = 0;
    }

    public void Add(int newValue)
    {
        if (pointer < array.Length)
        {
            array[pointer] = newValue;
            pointer++;
        }
        else
        {
            Array.Resize(ref array, array.Length * 2);
            Add(newValue);
        }
    }

    public void RemoveLast()
    {
        if(pointer > 0)
        {
            pointer--;
        }
    }

    public void Print()
    {
        for (int i = 0; i < pointer; i++)
        {
            Console.Write(array[i]);
        }
    }
}*/

