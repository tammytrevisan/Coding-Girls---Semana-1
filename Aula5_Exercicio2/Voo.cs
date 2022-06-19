using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Exercicio2
{
    public class Voo
    {
            public int[] aviao1 = new int[100];
            public int posicao;

            /*
            Console.WriteLine($"{aviao1[0, 0]} {aviao1[0, 1]} | {aviao1[0, 3]} {aviao1[0, 4]}");
            Console.WriteLine($"{aviao1[1, 0]} {aviao1[1, 1]} | {aviao1[1, 3]} {aviao1[1, 4]}");
            Console.WriteLine($"{aviao1[2, 0]} {aviao1[2, 1]} | {aviao1[2, 3]} {aviao1[2, 4]}");
            Console.WriteLine($"{aviao1[3, 0]} {aviao1[3, 1]} | {aviao1[3, 3]} {aviao1[3, 4]}");
            Console.WriteLine($"{aviao1[4, 0]} {aviao1[4, 1]} | {aviao1[4, 3]} {aviao1[4, 4]}");
            Console.WriteLine($"{aviao1[5, 0]} {aviao1[5, 1]} | {aviao1[5, 3]} {aviao1[5, 4]}");
            Console.WriteLine($"{aviao1[6, 0]} {aviao1[6, 1]} | {aviao1[6, 3]} {aviao1[6, 4]}");
            Console.WriteLine($"{aviao1[7, 0]} {aviao1[7, 1]} | {aviao1[7, 3]} {aviao1[7, 4]}");
            Console.WriteLine($"{aviao1[8, 0]} {aviao1[8, 1]} | {aviao1[8, 3]} {aviao1[8, 4]}");
            Console.WriteLine($"{aviao1[9, 0]} {aviao1[9, 1]} | {aviao1[9, 3]} {aviao1[9, 4]}");
            Console.WriteLine($"{aviao1[10, 0]} {aviao1[10, 1]} | {aviao1[10, 3]} {aviao1[10, 4]}");
            Console.WriteLine($"{aviao1[11, 0]} {aviao1[11, 1]} | {aviao1[11, 3]} {aviao1[11, 4]}");
            Console.WriteLine($"{aviao1[12, 0]} {aviao1[12, 1]} | {aviao1[12, 3]} {aviao1[12, 4]}");
            Console.WriteLine($"{aviao1[13, 0]} {aviao1[13, 1]} | {aviao1[13, 3]} {aviao1[13, 4]}");
            Console.WriteLine($"{aviao1[14, 0]} {aviao1[14, 1]} | {aviao1[14, 3]} {aviao1[14, 4]}");
            Console.WriteLine($"{aviao1[15, 0]} {aviao1[15, 1]} | {aviao1[15, 3]} {aviao1[15, 4]}");
            Console.WriteLine($"{aviao1[16, 0]} {aviao1[16, 1]} | {aviao1[16, 3]} {aviao1[16, 4]}");
            Console.WriteLine($"{aviao1[17, 0]} {aviao1[17, 1]} | {aviao1[17, 3]} {aviao1[17, 4]}");
            Console.WriteLine($"{aviao1[18, 0]} {aviao1[18, 1]} | {aviao1[18, 3]} {aviao1[18, 4]}");
            Console.WriteLine($"{aviao1[19, 0]} {aviao1[19, 1]} | {aviao1[19, 3]} {aviao1[19, 4]}");
            Console.WriteLine($"{aviao1[20, 0]} {aviao1[20, 1]} | {aviao1[20, 3]} {aviao1[20, 4]}");
            Console.WriteLine($"{aviao1[21, 0]} {aviao1[21, 1]} | {aviao1[21, 3]} {aviao1[21, 4]}");
            Console.WriteLine($"{aviao1[22, 0]} {aviao1[22, 1]} | {aviao1[22, 3]} {aviao1[22, 4]}");
            Console.WriteLine($"{aviao1[23, 0]} {aviao1[23, 1]} | {aviao1[23, 3]} {aviao1[23, 4]}");
            Console.WriteLine($"{aviao1[24, 0]} {aviao1[25, 1]} | {aviao1[24, 3]} {aviao1[24, 4]}");
            Console.WriteLine($"{aviao1[25, 0]} {aviao1[25, 1]} | {aviao1[25, 3]} {aviao1[25, 4]}");
            */
        }
        public void OcuparVaga(int aviao1, int posicao)
        {
            Console.WriteLine("Escolha uma posição de 1 a 100 ");
                int posicao = int.Parse(Console.ReadLine());
             
                if (aviao1[posicao] == 0)
                {
                    aviao1[posicao] = posicao; 
                    Console.WriteLine($"Posição {aviao1[posicao]} livre.");
                    Console.WriteLine($"Sua reserva foi confirmada");
                }
                else
                {
                    Console.WriteLine("Posição " + aviao1[posicao] + " esta ocupada.");
                }
}
       }
   

