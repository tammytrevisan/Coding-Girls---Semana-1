/*Utilizando os conceitos aprendidos até estruturas de repetição,
 * crie um programa que jogue pedra, papel e tesoura (Jokenpô) com você.
Permitir que eu decida quantas rodadas iremos fazer;
Ler a minha escolha (Pedra, papel ou tesoura);
Decidir de forma aleatória a decisão do computador;
Mostrar quantas rodadas cada jogador ganhou;
Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um
(computador e jogador);
Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, se não finalize o programa.*/


Random JokenpoComputador = new Random();
int ptscomputador = 0;
int ptsusuario = 0;

Console.WriteLine("\t\t ------> JOKENPO <------ ");

Console.Write("\n\nInforme seu nome: ");
string usuario = Console.ReadLine();

Console.Write($"\n{usuario}, quantas jogadas deseja fazer? ");
int jogadas = int.Parse(Console.ReadLine());
do
{
    for (int i = 1; i < jogadas + 1; i++)
    {
        Console.Clear();
        Console.WriteLine($"Jogada {i} de {jogadas}");
        Console.WriteLine("\nQual sua opção? \n\t1. Pedra\n\t2. Papel \n\t3. Tesoura");
        int opcao = int.Parse(Console.ReadLine());

        /* ***********************************
         *  REGRAS:                          *
         *  Pedra ganha do tesoura           *
         *  Tesoura ganha do papel;          *
         *  Papel ganha da pedra;            *
         *  **********************************/

        int computador = JokenpoComputador.Next(1, 3);
        Console.WriteLine($"Computador: {computador}");
        string computadorImpresso = Convert.ToString(computador);
        computadorImpresso = (computadorImpresso == "1" ? "Pedra" : computadorImpresso == "2" ? "Papel" : "Tesoura");

        switch (opcao)
        {
            case 1:

                Console.WriteLine($"\n{usuario}: Pedra X Computador: {computadorImpresso}");
                if (computador == 2 && opcao == 1)
                {
                    ptscomputador = ptscomputador + 1;
                    Console.WriteLine($"\nComputador: {ptscomputador} pontos \n{usuario}: {ptsusuario} pontos");
                }
                else if (opcao == 1 && computador == 3)
                {
                    ptsusuario = ptsusuario + 1;
                    Console.WriteLine($"\nComputador: {ptscomputador} pontos \n{usuario}: {ptsusuario} pontos");
                }
                else if (opcao == 1 && computador == 1)
                {
                    Console.WriteLine($"\n\n\tEmpate!");
                }
                Thread.Sleep(3000);
                break;
            case 2:
                Console.WriteLine($"\n{usuario}: Papel X Computador: {computadorImpresso}");
                if (computador == 1 && opcao == 2)
                {

                    ptsusuario = ptsusuario + 1;
                    Console.WriteLine($"\nComputador: {ptscomputador} pontos \n{usuario}: {ptsusuario} pontos");
                }
                else if (opcao == 2 && computador == 3)
                {

                    ptscomputador = ptscomputador + 1;
                    Console.WriteLine($"\nComputador: {ptscomputador} pontos \n{usuario}: {ptsusuario} pontos");
                }
                else if (opcao == 2 && computador == 2)
                {
                    Console.WriteLine($"\n\tEmpate!");
                }
                Thread.Sleep(3000);
                break;

            case 3:
                Console.WriteLine($"\n{usuario}: Tesoura X Computador: {computadorImpresso}");
                if (computador == 1 && opcao == 3)
                {

                    ptscomputador = ptscomputador + 1;
                    Console.WriteLine($"\nComputador: {ptscomputador} pontos \n{usuario}: {ptsusuario} pontos");
                }
                else if (opcao == 3 && computador == 2)
                {

                    ptsusuario = ptsusuario + 1;
                    Console.WriteLine($"\nComputador: {ptscomputador} pontos \n{usuario}: {ptsusuario} pontos");
                }
                else if (opcao == 3 && computador == 3)
                {
                    Console.WriteLine($"\n\tEmpate!");
                }
                Thread.Sleep(3000);
                break;
            default:
                Console.WriteLine("\nOpção Inválida. Digite uma opção: ");
                Thread.Sleep(3000);
                break;
        }

    }
    if (ptsusuario > ptscomputador)
    {
        Console.WriteLine($"\n Parabéns {usuario}! Você ganhou! \n {ptsusuario} X {ptscomputador}");
        Console.WriteLine("Se desejar continuar jogando, informe o número de jogadas ou 0 para finalizar.");
        jogadas = int.Parse(Console.ReadLine());
    }
    else if (ptscomputador == ptsusuario)
    {
        Console.WriteLine($"\n Empate! \n{usuario} - {ptsusuario} \n Computador - {ptscomputador}");
        Console.WriteLine("Se desejar continuar jogando, informe o número de jogadas ou 0 para finalizar.");
        jogadas = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"\n O computador ganhou! \n {ptscomputador} X {ptsusuario}");
        Console.WriteLine("Se desejar continuar jogando, informe o número de jogadas ou 0 para finalizar.");
        jogadas = int.Parse(Console.ReadLine());
    }
}
while (jogadas > 0);