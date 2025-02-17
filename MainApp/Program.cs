/// <summary>
/// Miniräknare som kan addera, subtrahera, multiplicera och dividera två tal.
/// </summary>

Console.WriteLine("Skriv första talet:");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Vilken operator vill du använda: (+, -, *, /):");
string typeSymbole = Console.ReadLine()!;
Console.WriteLine("Skriv andra talet:");
int numberB = int.Parse(Console.ReadLine()!);

// Räkna ut beroende på vilken operator som används
switch (typeSymbole)
{
    // Om operatorn är + så adderas numberA och numberB
    case "+":
        Console.Clear();
        Console.WriteLine(numberA + numberB);
        break;
    // Om operatorn är - så subtraheras numberA och numberB
    case "-":
        Console.Clear();
        Console.WriteLine(numberA - numberB);
        break;
    // Om operatorn är * så multipliceras numberA och numberB
    case "*":
        Console.Clear();
        Console.WriteLine(numberA * numberB);
        break;
    // Om operatorn är / så divideras numberA och numberB
    case "/":
        Console.Clear();
        Console.WriteLine(numberA / numberB);
        break;
    // Om operatorn inte är någon av de ovanstående så skrivs ett felmeddelande ut
    default:
        Console.WriteLine("Felaktig operator");
        break;
}

Console.ReadKey();