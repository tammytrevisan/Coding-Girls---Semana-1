using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Exercicio1
{
    public class Aluno
    {

        public int matricula;
        public string nome = string.Empty;
        public double nota1, nota2, notatrabalho;
        public double media;
        public void Cadastro()
        {

            Console.Write("\nMatricula: ");
            matricula = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota Trabalho: ");
            notatrabalho = double.Parse(Console.ReadLine());

            Console.Write("Média: ");
            NMedia();
            Console.Write("Nota final:");
            CalculaNotaFinal();
        }

        private void NMedia()
        {

            media = (nota1 + nota2 + notatrabalho) / 3;
            Console.WriteLine(media.ToString("F2"));

        }

        private void CalculaNotaFinal()
        {
            Console.WriteLine("Exercicio não especificou média para aprovação");
        }
    }
}
