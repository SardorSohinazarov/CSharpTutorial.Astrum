internal class Program
{
    private static void Main()
    {
        /*     Console.WriteLine("Hello, World!");

             DateOnly date = new DateOnly(2024, 7, 25);

             Console.WriteLine(date.Day);
             Console.WriteLine(date.Month);
             Console.WriteLine(date.Year >= 18);
             Console.WriteLine(date.DayOfYear);
             Console.WriteLine(date.DayOfWeek);

             TimeOnly time = new TimeOnly(12, 30, 45);


             DateOnly date1 = new DateOnly(2024, 7, 25);

             DateTime dateTime = new DateTime(2024, 7, 25, 16, 16, 16);

             var newDate = dateTime.AddYears(5);

             Console.WriteLine(newDate.DayOfWeek);*/


        //System.Threading.Thread.Sleep(1000);
        //System.Console.Clear();
        var year = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());
        var day = int.Parse(Console.ReadLine());

        var tugulganKun = new DateTime(year, month, day);
        while (true)
        {
            Console.Clear();

            var farq = DateTime.Now - tugulganKun;

            Console.WriteLine(farq.Days + ":" + farq.Hours + ":" + farq.Minutes + ":" + farq.Seconds);

            Thread.Sleep(1000);
        }

    }
}

/*class DateOnly
{
    public int Year { get; set; }
    public byte Mounth { get; set; }
    public byte Day { get; set; }
}

class TimeOnly
{
    public byte Hour { get; set; }
    public byte Minute { get; set; }
    public byte Second { get; set; }
} 

class DateTime
{
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
}*/