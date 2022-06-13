// See https://aka.ms/new-console-template for more information

/* Escreva um programa que leia o número de horas trabalhadas e um funcionário, o valor recebe por hora e 
calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.*/

double horas;
double valor;

Console.WriteLine("\t------> SALÁRIO <------");

Console.Write("Quantas horas você trabalhou? ");
horas = Convert.ToDouble(Console.ReadLine());

Console.Write("Quanto você recebe por horas? ");
valor = Convert.ToDouble(Console.ReadLine());

valor = horas * valor;

Console.WriteLine($"\nVocê receberá {valor.ToString("C")} por {horas} hora(s) trabalhada(s).");