using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano, idade;
            Console.WriteLine("Digite o ano do seu nascimento: ");
            ano = int.Parse(Console.ReadLine());

            idade = 2024 - ano;

            Console.WriteLine("sua idade é de: " + idade + " ano/s");

            if (idade >= 16)
            {
                Console.WriteLine("você pode votar!");
            }
            else
            {
                Console.WriteLine("você não pode votar ainda.");
            }

            if (idade >= 18)
            {
                Console.WriteLine("você pode tirar CNH!");
            }
            else
            {
                Console.WriteLine("você não pode tirar CNH");
            }

            Console.ReadKey();
        }
    }
}
