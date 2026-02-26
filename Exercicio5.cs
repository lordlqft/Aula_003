using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_003
{
    public class Exercicio5
    {
        public static void Executar()
        {   
            Console.Write("Informe o valor da venda: R$ ");
            double valorVenda = double.Parse(Console.ReadLine()!);

            Console.Write("Informe a quantidade vendida: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Console.Write("Informe o percentual de comissão (%): ");
            double percentualComissao = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o salário fixo do vendedor: R$ ");
            double salarioFixo = double.Parse(Console.ReadLine()!);

            double totalVendido = valorVenda * quantidade;
            double comissao = totalVendido * (percentualComissao / 100);
            double totalReceber = salarioFixo + comissao;

            Console.WriteLine($"Total vendido: R$ {totalVendido:F2}");
            Console.WriteLine($"Comissão: R$ {comissao:F2}");
            Console.WriteLine($"Salário Total: R$ {totalReceber:F2}");

        }
    }
}