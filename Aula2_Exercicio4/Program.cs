// See https://aka.ms/new-console-template for more information

/*Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
Todo ano tem 365 dias, todo mês tem 30 dias.*/

int ano;

Console.WriteLine("\t ------> IDADE <------");

Console.Write("\n\nInforme sua idade: ");
ano = int.Parse(Console.ReadLine());

int meses = ano * 12;
int dias = meses * 365;

Console.WriteLine($"Você tem {ano} ano(s), correpondente a {meses} mes(es) ou {dias} dia(s) de idade.");
