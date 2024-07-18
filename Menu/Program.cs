

internal class Program
{
    public static string menuText = "";
    public static int key = 0;
    public static List<string> list = new List<string>()
        {
            "Kitoblar",
            "Qo'shish",
            "O'chirish"
        };
    private static void Main()
    {
        var consoleKey = Console.ReadKey();

        if (consoleKey.Key == ConsoleKey.UpArrow)
        {
            OnPressUpArrow();
            Main();
        }
        else if (consoleKey.Key == ConsoleKey.DownArrow)
        {
            OnDownUpArrow();
            Main();
        }
        else if (consoleKey.Key == ConsoleKey.Enter)
        {
            if (key == 0)
            {
                PrintBooks();
            }
        }
        else if (consoleKey.Key == ConsoleKey.Backspace)
        {
            Main();
        }
        else { }
    }

    private static void PrintBooks()
    {
        Console.WriteLine("Yulduzli tunlar");
        Console.WriteLine("Ota");
        Console.WriteLine("Qales");

        Main();
    }

    private static void OnDownUpArrow()
    {
        if (key < 2)
        {
            key++;
        }

        var menuText = "";

        for (int i = 0; i < list.Count(); i++)
        {
            if (i == key)
            {
                menuText += $"\n>> {i + 1}:{list[i]}";
            }
            else
            {
                menuText += $"\n{i + 1}:{list[i]}";
            }
        }

        Console.Clear();
        Console.WriteLine(menuText);
    }

    private static void OnPressUpArrow()
    {
        if (key > 0)
        {
            key--;
        }

        var menuText = "";

        for (int i = 0; i < list.Count(); i++)
        {
            if (i == key)
            {
                menuText += $"\n  >>   :{list[i]}";
            }
            else
            {
                menuText += $"\n{i + 1}:{list[i]}";
            }
        }

        Console.Clear();
        Console.WriteLine(menuText);
    }
}