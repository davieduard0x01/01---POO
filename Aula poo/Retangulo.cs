using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo
{
    
        class Retangulo
        {
            
            public int Largura { get; set; }
            public int Altura { get; set; }

          
            public Retangulo(int largura, int altura)
            {
                Largura = largura;
                Altura = altura;
            }

          
            public void Exibir()
            {
                for (int i = 0; i < Altura; i++)
                {
                    for (int j = 0; j < Largura; j++)
                    {
                    if (i == 0 || i == Altura - 1 || j == 0 || j == Largura - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }
                    Console.WriteLine(); 
                }
            }
        }
   }

