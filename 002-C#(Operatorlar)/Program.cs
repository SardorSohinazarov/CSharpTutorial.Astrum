internal class Program
{
    private static void Main()
    {
        /*        Console.WriteLine("Hello, World!");


                //Matimatik
                var result = 2 + 3;
                var result1 = 2 - 3;
                var result2 = 2 * 3;
                var result3 = 2 / 3;

                var qoldiq = 10 % 3;

                //Assignment
                var qiymat = 2;
                qiymat += 3; // qiymat = qiymat + 3;
                qiymat -= 3; // qiymat = qiymat - 3;
                qiymat *= 3; // qiymat = qiymat * 3;
                qiymat /= 3; // qiymat = qiymat / 3;

                // Comparison
                var kichik = 2 <= 3;
                var katta = 2 == 3;

                // Ternory
                var teng = 1 == 1 ? "Teng" : "Unaqamas";
        */

        /*
                // Null-coalescing
                string satr = null;

                Console.WriteLine(satr);

                int? a = null;

                Console.WriteLine(a);
        */

        /*      // Equality 

              var teng = 1 == 1;
              var teng2 = 1 != 1;

              // Logical
              var rost = true;
              var yolgon = false;

              Console.WriteLine(rost && rost);

              //Bitwise
              var bir = 1;
              var besh = 5;*/

        /*     var son = int.Parse(Console.ReadLine());
             Console.WriteLine(son);*/


        /*     var otadi = int.TryParse(Console.ReadLine(), out var son2);

             if (otadi)
             {
                 Console.WriteLine(son2);
             }
             else
             {
                 Console.WriteLine("Matn raqam emas!");
             }*/

        /*var son = Convert.ToInt32(Console.ReadLine());*/
        //var son3 = Convert.ToBoolean(Console.ReadLine());
        /*var son3 = Convert.ToString(Console.ReadLine());*/


        /*        //Implicit
                byte byteSon = 255;
                int intSon = byteSon;

                intSon = 513;

                //Explicit
                byteSon = (byte)intSon;

                Console.WriteLine(byteSon);
        */

        /*        var funksiyaniNomi = nameof(Qanadur);

                Console.WriteLine(funksiyaniNomi);

                var olchamInt = sizeof(int);
                Console.WriteLine(olchamInt);
                var olchamDouble = sizeof(double);
                Console.WriteLine(olchamDouble);*/

        /* if (2 * 2 == 4)//Shart
         {
             Console.WriteLine("4");
         }
         else
         {
             Console.WriteLine("5");
         }*/

        //Ternory
        /*Console.WriteLine(2 * 3 == 4 ? false : true);*/
        /*Console.WriteLine(2 * 3 == 4 ? false : true ? 5 : 7);*/

        /* var qiymat = Console.ReadLine();

         switch (qiymat)
         {
             case "Sardor": Console.WriteLine("Zo'r bola"); break;
             case "Sarvar": Console.WriteLine("ukasi"); break;

             default: Console.WriteLine("Noma'lum"); break;
         }*/

        /* var description = "";
         var qiymat = Console.ReadLine();

         description = qiymat switch
         {
             "Sardor" => "Zo'r bola",
             "Sarvar" => "ukasi",
             _ => "Noma'lum"
         };

         Console.WriteLine(description);

         Main();*/

        /* // Ref  
        int a = 1000;
        Incrment(ref a);

        Console.WriteLine(a);

        private static void Incrment(ref int a)
        {
            a++;
        }*/

        /* // Out  
        int a;
        Incrment(out a);

        Console.WriteLine(a);

        private static void Incrment(out int a)
        {
            a++;
        }*/

        //String

        /*    string satr = "Salom, Dunyo!";
            String satr2 = "Salom, Dunyo!";

            string.Concat(satr, satr2);

            string.Compare(satr, satr2);

            string.Equals(satr, satr2);

            string a = "      ";
    */
        /*        var charlar = new char[] { 'a', 'b', 'c' };
                Console.Write(string.Join(':', charlar));*/

        /* string satr = "Salom, Dunyo!";

         var path = @$"Sardor{satr}\n \t Sardor\{satr}\Sarvar\\New folder\\kino.mp4";

         Console.Write(path);*/

        /*   var hozir = DateTime.Now;

           Console.WriteLine(hozir.ToString("F"));*/


        /*       string nullSatr = "ksmdc";

               var a = nullSatr ?? "nullsatr o'zgaruvchisi null edi";


               var juft = 3 == 1 ? "Teng" : "Teng emas";

               Console.WriteLine(a);*/

        float raqam = default;

        string satr = default;
        Console.WriteLine(raqam);
        Console.WriteLine(satr);
    }




    /*    //Recursiv
        static void RecursivFunksiya(int a)
        {
            a--;

            Console.WriteLine(a);

            if (a == 0)
            {
                return;
            }
            else
            {
                RecursivFunksiya(a);
            }
        }*/
}