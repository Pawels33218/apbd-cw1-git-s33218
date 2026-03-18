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

