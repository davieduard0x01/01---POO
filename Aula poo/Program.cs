using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura :");

            int largura = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");

            int altura = int.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            retangulo.Exibir();

            Console.ReadKey();
        }
    }
}
