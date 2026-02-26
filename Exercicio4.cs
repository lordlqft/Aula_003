using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_003
{
    public class Exercicio4
    {
        public static void Executar()
        {
            int x = 0;
            int y = 0;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine()!);
            
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine()!);


            Console.WriteLine($"\nO valor de X é: {x}");
            Console.WriteLine($"O valor de Y é: {y}");

            Console.Write("(Troca feita");
            (x, y) = (y, x);

            
            Console.WriteLine($"\nO valor de X é: {x}");
            Console.WriteLine($"O valor de Y é: {y}");
        }
    }
}