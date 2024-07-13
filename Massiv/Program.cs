internal class Program
{
    private static void Main(string[] args)
    {
        /*        Console.WriteLine("Hello, World!");

                //single dementional array
                var array = new int[5];

                //multi dementional array
                var arrayMultyDementional = new int[4, 5];

                var horizantal = arrayMultyDementional.GetLength(0);
                var vertical = arrayMultyDementional.GetLength(1);

                for (var i = 0; i < horizantal; i++)
                {
                    for (var j = 0; j < vertical; j++)
                    {
                        Console.Write(i + ":" + j + " ");
                    }

                    Console.WriteLine();
                }
        */

        //jagged array

        /* var jaggedArray = new int[4][];
         jaggedArray[0] = new int[5];
         jaggedArray[1] = new int[5];
         jaggedArray[2] = new int[5];
         jaggedArray[3] = new int[5];


         for (var i = 0; i < jaggedArray.Length; i++)
         {
             for (var j = 0; j < jaggedArray[i].Length; j++)
             {
                 Console.Write(i + ":" + j + " ");
             }

             Console.WriteLine();
         }*/

        /*   var array = new int[5];
   */
        /* Array.Resize(ref array, 6);
         array[5] = 10;
         Console.WriteLine("dastlab");*/
        /*        foreach (var item in array)
                {
                    Console.WriteLine(item);
                }*/

        /*     Array.Clear(array, 0, array.Length);

             Console.WriteLine("tozalovdan keyin");
             foreach (var item in array)
             {
                 Console.WriteLine(item);
             }
     */
        /*var array2 = new int[5];
        array2[2] = 77;

        Array.Copy(array2, array, array2.Length);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }*/

        /* var array = new int[5, 5];
         var array2 = new int[5, 5];
         array2[2, 0] = 77;

         Array.Copy(array2, array, 10);

         for (var i = 0; i < array.GetLength(0); i++)
         {
             for (var j = 0; j < array.GetLength(1); j++)
             {
                 Console.Write(array[i, j] + " ");
             }

             Console.WriteLine();
         }*/

        /* var array = new int[5];
         var array3 = array;

         var array2 = new int[5];
         array2[2] = 77;


         Console.Write(Array.Equals(array, array3));*/

        /*   var array = new int[5];
           array[1] = 77;
           Console.Write(Array.IndexOf(array, 77));


           Array.BinarySearch(array, 77);*/

        var array = new int[5];
        var array2 = new int[5];

        Console.WriteLine(Array.Equals(array, array2));

        /*    Array.Fill(array, 77);


            Array.ReferenceEquals(array, array);*/
    }
}