using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_003
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.Write("Informe a temperatura em Celsius (°C): ");
        double celsius = double.Parse(Console.ReadLine()!);

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Temperatura em Fahrenheit (°F): {fahrenheit:F2}");
        }
    }
}