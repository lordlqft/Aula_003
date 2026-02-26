using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_003
{
    public static class Exercicio1
    {
        public static void Executar()
        {
            Console.Write("Informe o valor do produto (R$): ");
            decimal valorProduto = decimal.Parse(Console.ReadLine()!);

            Console.Write("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Console.Write("Informe o desconto (%): ");
            decimal percentualDesconto = decimal.Parse(Console.ReadLine()!);

            decimal subtotal = valorProduto * quantidade;
            decimal valorDesconto = subtotal * percentualDesconto / 100;
            decimal totalPagar = subtotal - valorDesconto;

            Console.WriteLine(" ");
            Console.WriteLine($"Subtotal: R$ {subtotal:F2}"); 
            Console.WriteLine($"Desconto: R$ {valorDesconto:F2}");
            Console.WriteLine($"Total a pagar: R$ {totalPagar:F2}");
        }
    }
}