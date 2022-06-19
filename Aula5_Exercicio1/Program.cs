namespace Aula5_Exercicio1
{
    //1 classe - objetos: Alunos (guardam matricula, nome, 2 notas prova + 1 trabalho
    // Metodos: CM Exibe a média final do aluno
    // CF calcula quanto o aluno precisa tirar na prova final
    internal class Program
    {
        public int matricula;
        public string nome;
        public double nota1, nota2, notatrabalho;

        static void Main(string[] args)
        {
            Console.WriteLine("\t------> CADASTRAR ALUNO <-------");
            Aluno aluno = new Aluno();
            aluno.Cadastro();
        }
    }
}