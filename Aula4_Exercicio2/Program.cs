// See https://aka.ms/new-console-template for more information

/*Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: um somente para os números pares,
 * e outro para os números impares. Após, exiba os valores dos dois vetores, um em cada linha.*/

Console.WriteLine("\t ------> PARES / IMPARES <------");

int num;
int[] par = new int[10];
int[] impar = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Informe um número: ");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        par[i] = num;
    }
    else
    {
        impar[i] = num;
    }
}
Console.WriteLine($"\nPAR: {par[0]} {par[1]} {par[2]} {par[3]} {par[4]} {par[5]} {par[6]} {par[7]} {par[8]} {par[9]}");
Console.WriteLine($"\nIMPAR: {impar[0]} {impar[1]} {impar[2]} {impar[3]} {impar[4]} {impar[5]} {impar[6]} {impar[7]} {impar[8]} {impar[9]}");