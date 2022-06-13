// See https://aka.ms/new-console-template for more 

/* Crie um programa que lê 5 palavaras e as ordena em um vetor de strings pelo seu tamanho.
 Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.*/

Console.WriteLine("\t ------> PALAVRAS <------");

string[] palavras = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Fale uma palavra: ");
    palavras[i] = Console.ReadLine();
}
