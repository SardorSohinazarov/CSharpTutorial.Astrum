class MeningExceptionim : Exception
{
    public MeningExceptionim()
        : base("Mening exceptionim chiqdi")
    {
    }

    public MeningExceptionim(string message)
        : base(message)
    {
    }

    public MeningExceptionim(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public MeningExceptionim(Exception innerException)
       : base("Mening exceptionim chiqdi", innerException)
    {
    }
}

internal class Program
{
    private static void Main()
    {
        try
        {
            QalesMehtod();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void QalesMehtod()
    {
        try
        {
            int a = 5;
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a / b);
        }
        catch (FormatException ex)
        {
            throw new Exception("Format xato", ex);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Nolga bo'lish mumkin emas");
        }
        finally
        {
            //throw new Exception("Dastur tugadi");
            Console.WriteLine("Dastur tugadi");
        }

        Console.WriteLine("Qales");
    }



    /* private static int MyParse(string str)
     {
         if (int.TryParse(str, out int result))
         {
             return result;
         }
         else
         {
             throw new Exception("Faqat son kirit");
         }
     }*/
}