Console.WriteLine("Hello, World!");

Console.WriteLine("Moja pierwsza modyfikacja");

if (true)
{
    Console.WriteLine("Pierwszy warunek logiczny");
}
Console.WriteLine("Podaj swoja liczbe");
int a = int.Parse(Console.ReadLine());
int b = a * a;
Console.WriteLine("Oto kwadrat z twojej liczby= " + b);

if (b % 2 != 0)
{
    throw new ArgumentException("Kwadrat liczby nie jest parzysty");
}

public class StaticsHelper
{
    public static double CalculateAverage(int[] vals)
    {
        if (vals == null || vals.Length == 0) return 0;
        return vals.Average();
    }
    public static int CalculateMax(int[] vals)
    {
        if (vals == null || vals.Length == 0) return 0;
        return vals.Max();

    }
    public static int CalculateMin(int[] vals)
    {
        if (vals == null || vals.Length == 0) return 0;
        return vals.Min();
    }
}
