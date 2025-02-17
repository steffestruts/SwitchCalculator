Console.WriteLine("Skriv första talet:");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Vilken operator vill du använda: (+, -, *, /):");
string typeSymbole = Console.ReadLine()!;
Console.WriteLine("Skriv andra talet:");
int numberB = int.Parse(Console.ReadLine()!);

switch (typeSymbole)
{
    case "+":
        Console.Clear();
        Console.WriteLine(numberA + numberB);
        break;
    case "-":
        Console.Clear();
        Console.WriteLine(numberA - numberB);
        break;
    case "*":
        Console.Clear();
        Console.WriteLine(numberA * numberB);
        break;
    case "/":
        Console.Clear();
        Console.WriteLine(numberA / numberB);
        break;
    default:
        Console.WriteLine("Felaktig operator");
        break;
}

Console.ReadKey();