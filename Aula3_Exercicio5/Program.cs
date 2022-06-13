// See https://aka.ms/new-console-template for more information

/* A Blue resolveu darum aumento de salários a seus funcionários de acordo com os dados abaixo:
 * Salario de 0 até 400.00 ganha 15%
 * Salario de 400.01 até 800.00 ganha 12%
 * Salario de 800.01 até 1200.00 ganha 10%
 * Salario de 1200.01 até 2000.00 ganha 7%
 * Acima de 2000 ganha 4%
 * Leia o salário do funcionário e calcule e mostre o novo salário, bem como:
 *      reajuste de valor ganho e o indice reajustado, em percentual*/

double salario, aumento;
string per;

Console.WriteLine("\t------> SIMULADOR DE AUMENTO BLUE <------");

Console.WriteLine("Qual o valor do seu salário atual? ");
salario = double.Parse(Console.ReadLine());

if (salario < 400)
{
    aumento = salario * 0.15;
    salario = salario + aumento;
    per = "15%";
}
else if (salario >= 400 && salario <=800)
{
    aumento = salario * 0.12;
    salario = salario + aumento;
    per = "12%";
}
else if (salario > 800 && salario <= 1200)
{
    aumento = salario * 0.10;
    salario = salario + aumento;
    per = "10%";
}
else if (salario >= 1200 && salario <= 2000)
{
    aumento = salario * 0.07;
    salario = salario + aumento;
    per = "7%";
}
else
{
    aumento = salario * 0.04;
    salario = salario + aumento;
    per = "4%";
}

Console.WriteLine($"Novo salário: {salario.ToString("C")}\nReajuste: {aumento.ToString("C")}\nEm percentual: {per}");