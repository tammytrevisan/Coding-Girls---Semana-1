// See https://aka.ms/new-console-template for more information

// Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

int ano, idade;

Console.WriteLine("\t ------> QUAL A IDADE DO USUÁRIO <------");

Console.WriteLine("Informe o ano do seu nascimento: ");
ano = int.Parse(Console.ReadLine());

idade = 2022 - ano;

Console.WriteLine("\nSua idade é " + idade);