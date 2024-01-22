internal class Program
{
    public static double soucet_fce(double x, double y)
    {
        double z = 0;
        z = x + y;
        return z;
    }
    public static double rozdil_fce(double x, double y)
    {
        double z = 0;
        z = x - y;
        return z;
    }
    public static double podil_fce(double x, double y)
    {
        double z = 0;
        z = x / y;
        return z;
    }
    public static double soucin_fce(double x, double y)
    {
        double z = 0;
        z = x * y;
        return z;
    }

    private static void Main(string[] args)
    {
        double soucet = soucet_fce(2, 5);
        Console.WriteLine(soucet);

        double rozdil = rozdil_fce(7, 3);
        Console.WriteLine(rozdil);

        double podil = podil_fce(16, 4);
        Console.WriteLine(podil);

        double soucin = soucin_fce(7, 2);
        Console.WriteLine(soucin);

        Console.ReadKey();
    }
}
