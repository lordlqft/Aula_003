using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_003
{
    public class Exercicio3
    {
        public static void Executar()
        {
            Console.Write("Distância total da viagem (km): ");
            double distanciaKm = double.Parse(Console.ReadLine()!);

            Console.Write("Consumo do veículo (km/L): ");
            double consumoKmPorLitro = double.Parse(Console.ReadLine()!);

            Console.Write("Preço do combustível (R$/L): ");
            double precoLitro = double.Parse(Console.ReadLine()!);

            // Cálculos corretos
            double litrosNecessarios = distanciaKm / consumoKmPorLitro;
            double custoTotal = litrosNecessarios * precoLitro;
            double custoPorKm = custoTotal / distanciaKm;
    

            Console.WriteLine("\n=== Resumo da Viagem ===");
            Console.WriteLine($"Litros necessários: {litrosNecessarios} L");
            Console.WriteLine($"Custo total: R$ {custoTotal}");
            Console.WriteLine($"Custo por km: R$ {custoPorKm}");
        }
    }
}