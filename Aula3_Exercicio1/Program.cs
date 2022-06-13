// See https://aka.ms/new-console-template for more information

/* Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário.
 * A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
 * As notas consideradas são de 100, 50, 20, 10, 5, 2. */

int cem = 0;
int cinquenta = 0;
int vinte = 0;
int dez = 0;
int cinco = 0;
int dois = 0;

Console.WriteLine("\t ------> CÁLCULO PARA TROCO DE NOTAS <------");

Console.WriteLine("\n Informe um valor: ");
double valor = double.Parse(Console.ReadLine());

while (valor > 100)
{
    valor = valor - 100;
    cem += 1; // cem + 1
}
while (valor > 50)
{
    valor = valor - 50;
    cinquenta += 1;
} 
while (valor > 20)
{
    valor = valor - 20;
    vinte += 1; 
}
while (valor > 10)
{
    valor = valor - 10;
    dez += 1;
}
while (valor > 5)
{
    valor = valor - 5;
    cinco += 1;
}
while (valor > 2)
{
    valor = valor - 5;
    dois += 1;
}

Console.WriteLine($"\n{cem} notas de R$100,00 \n{cinquenta} notas de R$50,00 \n{vinte} notas de R$20,00 \n{dez} notas de R$10,00 \n{cinco} notas de R$5,00 \n{dois} notas de R$2,00");