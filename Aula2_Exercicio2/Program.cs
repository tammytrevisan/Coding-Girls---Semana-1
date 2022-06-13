// See https://aka.ms/new-console-template for more information

// Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.
int valor;
int soma = 0;

Console.WriteLine("\t ------> SOMATÓRIA <------");

for (int i = 1; i < 11; i++)
{
    Console.Write(i + ". Informe um número: ");
    valor = Convert.ToInt32(Console.ReadLine());
    soma = soma + valor;
}
Console.WriteLine("\n \tA soma é: " + soma);