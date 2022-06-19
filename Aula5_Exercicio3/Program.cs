namespace Aula5_Exercicio3
{
    /*Crie uma classe Calculadora, que possui como métodos a multiplicação, divisão, subtração 
     * e soma de dois valores e exibe para o usuário.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t ------> CALCULADORA <------");

            Console.WriteLine("\nQual operação desesa fazer?");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Multiplicação");
            Console.WriteLine("3. Subtração");
            Console.WriteLine("4. Divisão");

            string opcao = Console.ReadLine();


            Calcular calculadora = new Calcular();

            switch (opcao)
            {
                case "1":
                    calculadora.Somar();
                    break;

                case "2":
                    calculadora.Multiplicar();

                    break;

                case "4":
                    calculadora.Subtrair();

                    break;
                case "5":
                    calculadora.Divisao();

                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }
    }
}