using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте!");
        Console.WriteLine("ФИО: Алтухов Павел");
        Console.WriteLine("Группа: ИСП-241");
        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");

        Console.WriteLine("Меню:");
        Console.WriteLine("1 — Показать ФИО");
        Console.WriteLine("2 — Показать группу");
        Console.WriteLine("3 — Показать дату");
        Console.WriteLine("4 — Выход");
    }
}
