namespace ByteBites;

internal static class Program
{
    private static readonly string[] Dishes =
    [
        "Festivalburger",
        "Sprøde fritter",
        "Vegansk bowl"
    ];

    private static void Main()
    {
        var running = true;

        Console.WriteLine("ByteBites – festivalens foodtruck");

        while (running)
        {
            ShowMenu();
            var choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    ShowDishes();
                    break;
                case "2":
                    Console.WriteLine("Oprettelse af bestillinger er endnu ikke implementeret.");
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Vælg 0, 1 eller 2.");
                    break;
            }
        }

        Console.WriteLine("Programmet er afsluttet.");
    }

    private static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Vis retter");
        Console.WriteLine("2. Opret bestilling");
        Console.WriteLine("0. Afslut");
        Console.Write("Vælg: ");
    }

    private static void ShowDishes()
    {
        Console.WriteLine("Retter:");

        for (var i = 0; i < Dishes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Dishes[i]}");
        }
    }
}
