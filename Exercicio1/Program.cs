// See https://aka.ms/new-console-template for more information

//Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
string nome;
string end;
string cep;
string telefone;

Console.WriteLine("\t -------> CADASTRO DE USUÁRIO <-------");

Console.Write("\nNome Completo: ");
nome = Console.ReadLine();

Console.Write("Endereço: ");
end = Console.ReadLine();

Console.Write("CEP: ");
cep = Console.ReadLine();

Console.Write("Telefone: ");
telefone = Console.ReadLine();

Console.WriteLine("\t \n-------> DADOS CADASTRADOS <-------");
Console.WriteLine($"\nNome completo: {nome}");
Console.WriteLine($"Endereço: {end}");
Console.WriteLine($"CEP: {cep}");   
Console.WriteLine($"Telefone: {telefone}"); 
