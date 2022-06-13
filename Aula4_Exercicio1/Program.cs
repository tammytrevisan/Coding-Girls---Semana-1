// See https://aka.ms/new-console-template for more information

/*Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando-os em um vetor,
 * e então monte outro vetor com os valores do primeiro multiplicados por 5.
 * Exiba os valores dos dois vetores na tela, um em cada linha.*/

int[] vet1 = new int[10];
int[] vet2 = new int[10];

Console.WriteLine("\n ------> MULTIPLICANDO POR 5 <------");

for(int i = 0; i < 10; i++)
{
    Console.Write($"Informe um número: ");
    vet1[i] = int.Parse(Console.ReadLine());
    vet2[i] = vet1[i] * 5;
}

Console.WriteLine($"Vetor 1: {vet1[0]} {vet1[1]} {vet1[2]} {vet1[3]} {vet1[4]} {vet1[5]} {vet1[6]} {vet1[7]} {vet1[8]} {vet1[9]}");
Console.WriteLine($"Vetor 1: {vet2[0]} {vet2[1]} {vet2[2]} {vet2[3]} {vet2[4]} {vet2[5]} {vet2[6]} {vet2[7]} {vet2[8]} {vet2[9]}");

