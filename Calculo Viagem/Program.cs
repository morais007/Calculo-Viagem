using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculo_Viagem
            
            CultureInfo Ci = CultureInfo.InvariantCulture;

            double litrosPorKm;
            double distancia;
            double precoCombustivel;
            double litrosConsumidos;
            double resultado;

            Console.WriteLine("Calculo de Viagem");
            Console.WriteLine();

            // Qual a distancia
            Console.Write("Qual a distância: ");
            distancia = int.Parse(Console.ReadLine(), Ci);

            // Com quantos litros por KM?
            Console.Write("Quantos km seu carro faz com 1/litro: ");

            litrosPorKm = int.Parse(Console.ReadLine(), Ci);
            // Qual o preço do combustivel?
            Console.Write("Valor do Combustivel: ");
            precoCombustivel = double.Parse(Console.ReadLine(), Ci);

            // Resultado da Viagem

            litrosConsumidos = distancia / litrosPorKm;
            resultado = litrosConsumidos * precoCombustivel;

            Console.WriteLine($"Se você percorrer {distancia} Km, você irá gasta {resultado.ToString("F2", Ci)} R$...");

            Console.ReadKey();

        }
    }
}
