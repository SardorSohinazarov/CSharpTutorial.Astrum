internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.WriteLine("Hello, World!");

         *//*
                 Tuple<int, string, char> tuple
                     = new Tuple<int, string, char>(1, "Sardor", '$');

                 Console.WriteLine(tuple.Item1);
                 Console.WriteLine(tuple.Item2);
                 Console.WriteLine(tuple.Item3);*//*

         var javob = Something(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

         Console.WriteLine(javob.Max);
         Console.WriteLine(javob.Min);
         Console.WriteLine(javob.Avg);*/

        //null coalescing operator
        int? a = null;
        int b = a ?? 8;
        Console.WriteLine(b);

        //odatiy
        int? A = null;
        int? B;
        if (A.HasValue)
            B = A;
        else
            B = 8;


        //const mumkinmas
        /* const int c = 10;
         a = 8;
         bool? b = null;


         (int, string, double, Result) a = (1,"S",1.1, new Result() { Item1 = 1, Item2 = 2, Item3 = 3.3 }); 
 */
    }


    public static (int Max, int Min, double Avg) Something(int[] arr)
    {
        var max = arr.Max();
        var min = arr.Min();
        var avg = arr.Average();

        return (Max: max, Min: min, Avg: avg);
    }

    /*    public static Result Something(int[] arr)
        {
            var max = arr.Max();
            var min = arr.Min();
            var avg = arr.Average();

            return new Result()
            {
                Item1 = max,
                Item2 = min,
                Item3 = avg
            };
        }*/
}

class Result
{
    public int Item1;
    public int Item2;
    public double Item3;
}