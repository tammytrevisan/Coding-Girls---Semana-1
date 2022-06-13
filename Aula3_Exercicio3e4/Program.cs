// See https://aka.ms/new-console-template for more information

/* Exercicio 3
 * Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
 * Considere que cada nota pode ir de 0 até 10,0, sempre com uma casa decimal. 
 * Imprima se o aluno foi aprovado ou reprovado considerando a média 7.
 * 
 * Exercicio 4
 * Calcule a média do aluno:
 * ]< 6 - F / entre 6 e 7 - D / entre 7 e 8 - C / Entre 8 e 9 - B / entre 9 e 10 - um belo de um A */

double nota1;
double nota2;
double nota3;
double media;

Console.WriteLine("\t ------> MÉDIA PARA APROVAÇÃO <------");

Console.WriteLine("Informe a nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a nota: ");
nota3 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3)/ 3;

if (media <= 6)
{
    Console.WriteLine("Sua nota foi F - Reprovado");
}
else if (media > 6 && media < 7)
{
    Console.WriteLine("Sua nota foi D - Reprovado");
}
else if (media >= 7 && media < 8)
{
    Console.WriteLine("Sua nota foi C - Aprovado");
}
else if (media >= 8 && media < 9)
{
    Console.WriteLine("Sua nota foi B - Aprovado");
}
else if (media >= 7 && media < 8)
{
    Console.WriteLine("Sua nota foi C - Aprovado");
}
else if (media >= 9 && media < 10)
{
    Console.WriteLine("Sua nota foi A - Aprovado \nPARABÉNS!");
}
