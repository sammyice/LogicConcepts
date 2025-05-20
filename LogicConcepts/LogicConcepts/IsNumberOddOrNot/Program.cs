﻿var numberString = string.Empty;  // "45"
do
{
    Console.Write("Ingrese número entero o 'Salir' para salir: ");
    numberString = Console.ReadLine();  // "45"
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))  // 45
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El número {numberInt}, es impar.");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
    }
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over.");