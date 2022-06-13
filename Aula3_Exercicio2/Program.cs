// See https://aka.ms/new-console-template for more information

/* Fraça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem:
 * "X é o maior".*/

int[] num = new int[3];

Console.WriteLine("\t ------> MAIOR NÚMERO <------");

for(int i = 0; i < 3; i++)
{
    Console.Write("Informe um número: ");
    num[i] = int.Parse(Console.ReadLine());
}

if (num[0] > num[1] && num[0] > num[2])
{
    Console.WriteLine($"{num[0]} é o maior!");
}
else if (num[1] > num[0] && num[1] > num[2])
{
    Console.WriteLine($"{num[1]} é o maior");
}
else
{
    Console.WriteLine($"{num[2]} é o maior");
}


