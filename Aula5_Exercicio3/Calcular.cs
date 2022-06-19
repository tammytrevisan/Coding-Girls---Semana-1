using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Exercicio3
{
    internal class Calcular
    {
        public double vlr1;
        public double vlr2;
        public double resultado;

        public void Somar()
        {
            Console.WriteLine("Você escolheu ADIÇÃO");
            Console.Write("Informe o primeiro valor: ");
            vlr1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            vlr2 = double.Parse(Console.ReadLine());
            resultado = vlr1 + vlr2;
            Console.WriteLine(resultado);
        }
        public void Divisao()
        {
            Console.WriteLine("Você escolheu ADIÇÃO");
            Console.Write("Informe o primeiro valor: ");
            vlr1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            vlr2 = double.Parse(Console.ReadLine());
            resultado = vlr1 / vlr2;
            Console.WriteLine(resultado);
        }
        public void Multiplicar()
        {
            Console.WriteLine("Você escolheu MULTIPLICAÇÃO");
            Console.Write("Informe o primeiro valor: ");
            vlr1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            vlr2 = double.Parse(Console.ReadLine());
            resultado = vlr1 * vlr2;
            Console.WriteLine(resultado);
        }
        public void Subtrair()
        {
            Console.WriteLine("Você escolheu SUBTRAÇÃO");
            Console.Write("Informe o primeiro valor: ");
            vlr1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            vlr2 = double.Parse(Console.ReadLine());
            resultado = vlr1 - vlr2;
            Console.WriteLine(resultado);
        }
    }
}
