using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте!");
        bool a = true;
        while (a)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
            Console.Write("Выберите пункт: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n[ФИО]: Алтухов Павел");
                    break;
                case "2":
                    Console.WriteLine("\n[Группа]: ИСП-241");
                    break;
                case "3":
                    Console.WriteLine($"\n[Текущая дата]: {DateTime.Now}");
                    break;
                case "4":
                    Console.WriteLine("\nВыход из программы. До свидания!");
                    a = false;
                    break;
            }
        }
    }
}

git commit -m "создание папок