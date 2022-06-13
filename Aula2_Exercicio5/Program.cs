// See https://aka.ms/new-console-template for more information

/* Construa um conversor de moedas:
 *  Crie um programa que solicite um valor em real ao usuário e converta esse valor para:
 *  Dólar \ Euro \ Libra Esterlina \ Dólar canadense \ Peso Argentino \ Peso Chileno
 *  Mostrar o resultado no formato simbolo da moeda e valor.*/

double brasil;

Console.WriteLine("\t ------> CONVERSOR DE MOEDAS <------ ");

Console.Write("Informe o valor em reais: R$ ");
brasil = double.Parse(Console.ReadLine());

double usa = brasil * 4.99;
double europa = brasil * 5.24;
double inglaterra = brasil * 6.15;
double canada = brasil * 3.90;
double argentina = brasil * 0.041;
double chile = brasil * 0.0059;

Console.WriteLine($"\n{brasil.ToString("C")} equivale a: ");
Console.WriteLine($"\t US$ {usa.ToString("N2")} - Dólar");
Console.WriteLine($"\t EUR {europa.ToString("N2")} - Euro");
Console.WriteLine($"\t \u00A3 {inglaterra.ToString("N2")} - Libra Esterlina");
Console.WriteLine($"\t C$ {canada.ToString("N2")} - Dólar Canadense");
Console.WriteLine($"\t $ {argentina.ToString("N2")} ARS - Peso Argentino");
Console.WriteLine($"\t $ {chile.ToString("N2")} CLP - Peso Chileno");

