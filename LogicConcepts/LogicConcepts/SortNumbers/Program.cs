using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 3 números diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer numero : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero: ");
    if (a == b) 
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar");
        continue;
    }
    var c = ConsoleExtension.GetInt("Ingrese tercer numero : ");
    if (b == c || a == c)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El número mayor es {a}, el medio en {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El número mayor es {a}, el medio en {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El número mayor es {b}, el medio en {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El número mayor es {b}, el medio en {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El número mayor es {c}, el medio en {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El número mayor es {c}, el medio en {b}, el menor es {a}");
        }
    }

} while (true);