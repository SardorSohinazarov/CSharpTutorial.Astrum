internal class Program
{
    private static void Main(string[] args)
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        var abs = new double[] { a, b, c };

        //var result = Return(a, b, c);
        var result = abs.Solve();

        Console.WriteLine(string.Join(",", result));
    }

    private static double[] Return(double a, double b, double c)
    {
        //var D = b * b - 4 * a * c;
        var D = Math.Pow(b, 2) - 4 * a * c;

        return D switch
        {
            < 0 => new double[0],
            0 => new double[1] { -b / (2 * a) },
            _ => new double[2] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) }
        };
    }

    //Extension method

}
public static class Math2
{

    public static double[] Solve(this double[] abs)
    {
        double a = abs[0], b = abs[1], c = abs[2];
        //var D = b * b - 4 * a * c;
        var D = Math.Pow(b, 2) - 4 * a * c;

        return D switch
        {
            < 0 => new double[0],
            0 => new double[1] { -b / (2 * a) },
            _ => new double[2] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) }
        };
    }
}