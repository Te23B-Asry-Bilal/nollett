Console.WriteLine("Hej");

Console.WriteLine("Välj ett tal mellan 10 och 0");
while (true)
{
    string valj = Console.ReadLine();
    int pick;
    int.TryParse(valj, out pick);


    if (pick <= 6 && pick >= 3)
    {
        Console.WriteLine("Hello World!");

        break;
    }

    else if (pick > 6 || pick < 3)
    {
        Console.WriteLine("försök igen!!");

    }
}

Console.ReadLine();


if (6 >= 3) {
    Console.WriteLine("Hello world");
}
