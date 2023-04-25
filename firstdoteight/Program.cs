using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первую дату в формате dd/mm/yyyy: ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.Write("Введите вторую дату в формате dd/mm/yyyy: ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Количество лет, которое прошло между первой и второй датой: {date2.Year - date1.Year}");

        Console.Write("Введите время: ");
        TimeOnly time = TimeOnly.Parse(Console.ReadLine());
        Console.Write("Введите количество потреблённой электроэнергии в кВт: ");
        double energy = double.Parse(Console.ReadLine());
        Console.Write("Введите цену кВт/ч: ");
        double price = double.Parse(Console.ReadLine());
        TimeOnly minMorningFirstZone = minMorningFirstZone.AddHours(8);
        TimeOnly maxMorningFirstZone = minMorningFirstZone.AddHours(11);
        TimeOnly minEveningFirstZone = minMorningFirstZone.AddHours(20);
        TimeOnly maxEveningFirstZone = minMorningFirstZone.AddHours(23);
        TimeOnly minMorningSecondZone = minMorningFirstZone.AddHours(7);
        TimeOnly maxMorningSecondZone = minMorningFirstZone.AddHours(8);
        TimeOnly minEveningSecondZone = minMorningFirstZone.AddHours(11);
        TimeOnly maxEveningSecondZone = minMorningFirstZone.AddHours(20);
        if ((time > minMorningFirstZone && time < maxMorningFirstZone) || (time > minEveningFirstZone && time < maxEveningFirstZone))
            Console.WriteLine(energy / price);
        else if ((time > minMorningSecondZone && time < maxMorningSecondZone) || (time > minEveningSecondZone && time < maxEveningSecondZone))
            Console.WriteLine(energy / price * 0.7);
        else
            Console.WriteLine(energy / price * 0.4);
    }
}