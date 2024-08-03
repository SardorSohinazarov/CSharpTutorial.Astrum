//delegate int MyDelegate(int a, int b);

class Program

//Action -> void
//Func -> return type
//Predicate -> bool
{
    public static void Main()
    {
        //MyDelegate myDelegate = new MyDelegate(Add);
        //myDelegate += Sub;

        /*  Func<int, int, int> myfunc = new Func<int, int, int>(Add);

          myfunc += Sub;

          Console.WriteLine(myfunc.Invoke(1, 2));*/

        /* Action action = new Action(Print);
         action.Invoke();*/

        /*Predicate<int> predicate = new Predicate<int>(Equal);
        Console.WriteLine(predicate.Invoke(7));*/


        Action<string> action = new Action<string>(LogToBot);
        action += LogToConsole;
        action += LogToServer;
        action += (text) => //Lambda expression
        {
            Console.WriteLine(text);
            Console.WriteLine(text);
            Console.WriteLine(text);
            Console.WriteLine(text);
        };

        action += delegate (string text) //Anonymous method
        {
            Console.WriteLine(text);
        };


    }

    static void LogToConsole(string text) => Console.WriteLine(text);
    static void LogToServer(string text) => Console.WriteLine(text);
    static void LogToBot(string text) => Console.WriteLine(text);

    static bool Equal(int a) => a == 0;

    static void Print(int a) => Console.WriteLine("Qales" + a);

    static int Add(int a, int b) => a + b;

    static int Sub(int a, int b) => a - b;

    /*   static void NmadurQil(MyDelegate myDelegate)
       {
           Delegate[] delegates = myDelegate.GetInvocationList();

           foreach (var del in delegates)
           {
               Console.WriteLine(del.DynamicInvoke(1, 2));
           }
       }*/
}
