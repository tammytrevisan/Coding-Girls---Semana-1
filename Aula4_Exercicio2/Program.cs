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

Console.WriteLine("\nNúmero(s) Par(es): ");
for (int i = 0; i < 10; i++)
{
    if (par[i] != 0)
    {
        Console.Write($"{par[i]} ");
    }
}

Console.WriteLine("\n\nNúmero(s) Impar(es): ");
for(int i = 0; i < 10; i++)
{ 
    if (impar[i] != 0)
    {
        Console.Write($"{impar[i]} ");
    }

}