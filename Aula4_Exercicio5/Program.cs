/*Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
O tabuleiro é uma matriz de três linhas e três colunas.
Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).
Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal ,
e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.
Quando um jogador conquista o objetivo ele é o vencedor. 
Se os dois jogadores jogarem sempre da melhor forma, o jogo terminará sempre em empate ou seja "Deu a Velha!".*/

string[,] jogadas = new string[3, 3];
string Jogador1;
string Jogador2;

Console.WriteLine("\t------> JOGO DA VELHA <------");

Console.Write("\tBem vindos! \nInforme o usuário que serguirá com a opção O: ");
string usuario1 = Console.ReadLine();
Console.Write("Informe o usuário que seguirá com a opção X: ");
string usuario2 = Console.ReadLine();

jogadas[0, 0] = "1";
jogadas[0, 1] = "2";
jogadas[0, 2] = "3";
jogadas[1, 0] = "4";
jogadas[1, 1] = "5";
jogadas[1, 2] = "6";
jogadas[2, 0] = "7";
jogadas[2, 1] = "8";
jogadas[2, 2] = "9";

// Tabuleiro
Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
Console.WriteLine("************");
Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
Console.WriteLine("************");
Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");


for (int i = 0; i < 9; i++)
{
    //verificar jogadas
    if (jogadas[0, 0] == "O" && jogadas[0, 1] == "O" && jogadas[0, 2] == "O" || jogadas[1, 0] == "O" && jogadas[1, 1] == "O" && jogadas[1, 2] == "O" || jogadas[2, 1] == "O" && jogadas[2, 1] == "O" && jogadas[2, 2] == "O" || jogadas[0, 0] == "O" && jogadas[1, 0] == "O" && jogadas[2, 0] == "0" || jogadas[0, 1] == "O" && jogadas[1, 1] == "O" && jogadas[2, 1] == "O" || jogadas[0, 2] == "O" && jogadas[1, 2] == "O" && jogadas[2, 2] == "O" || jogadas[0, 0] == "O" && jogadas[1, 1] == "O" && jogadas[2, 2] == "O" || jogadas[2, 0] == "O" && jogadas[1, 1] == "O" && jogadas[0, 2] == "O")
    {
        Console.WriteLine($"{usuario1} você ganhou!");
        i = 10;
        Console.WriteLine("\nFIM DE JOGO!");
    }
    else if (jogadas[0, 0] == "X" && jogadas[0, 1] == "X" && jogadas[0, 2] == "X" || jogadas[1, 0] == "X" && jogadas[1, 1] == "X" && jogadas[1, 2] == "X" || jogadas[2, 1] == "X" && jogadas[2, 1] == "X" && jogadas[2, 2] == "X" || jogadas[0, 0] == "X" && jogadas[1, 0] == "X" && jogadas[2, 0] == "X" || jogadas[0, 1] == "X" && jogadas[1, 1] == "X" && jogadas[2, 1] == "X" || jogadas[0, 2] == "X" && jogadas[1, 2] == "X" && jogadas[2, 2] == "X" || jogadas[0, 0] == "X" && jogadas[1, 1] == "X" && jogadas[2, 2] == "X" || jogadas[2, 0] == "X" && jogadas[1, 1] == "X" && jogadas[0, 2] == "X")
    {
        Console.WriteLine($"{usuario2} você ganhou!");
        i = 10;
        Console.WriteLine("\nFIM DE JOGO!");
    }
    else if (jogadas[0, 0] != "1" && jogadas[0, 1] != "2" && jogadas[0, 2] != "3" && jogadas[1, 0] != "4" && jogadas[1, 1] != "5" && jogadas[1, 2] != "6" && jogadas[2, 0] != "7" && jogadas[2, 1] != "8" && jogadas[2, 2] != "9")
    {
        Console.WriteLine("Deu velha!");
        i = 10;
    }
    else
    {
        Console.Write($"\n\t{usuario1} digite a posição da sua jogada O: ");
        Jogador1 = Console.ReadLine();

        switch (Jogador1)
        {
            case "1":

                jogadas[0, 0] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "2":

                jogadas[0, 1] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "3":

                jogadas[0, 2] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "4":

                jogadas[1, 0] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "5":

                jogadas[1, 1] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "6":

                jogadas[1, 2] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "7":

                jogadas[2, 0] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "8":

                jogadas[2, 1] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            case "9":

                jogadas[2, 2] = "O";

                Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                Console.WriteLine("************");
                Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                break;

            default:
                Console.WriteLine("Opção Inválida, perdeu a vez!");
                break;
        }

        if (jogadas[0, 0] == "O" && jogadas[0, 1] == "O" && jogadas[0, 2] == "O" || jogadas[1, 0] == "O" && jogadas[1, 1] == "O" && jogadas[1, 2] == "O" || jogadas[2, 1] == "O" && jogadas[2, 1] == "O" && jogadas[2, 2] == "O" || jogadas[0, 0] == "O" && jogadas[1, 0] == "O" && jogadas[2, 0] == "0" || jogadas[0, 1] == "O" && jogadas[1, 1] == "O" && jogadas[2, 1] == "O" || jogadas[0, 2] == "O" && jogadas[1, 2] == "O" && jogadas[2, 2] == "O" || jogadas[0, 0] == "O" && jogadas[1, 1] == "O" && jogadas[2, 2] == "O" || jogadas[2, 0] == "O" && jogadas[1, 1] == "O" && jogadas[0, 2] == "O")
        {
            Console.WriteLine($"{usuario1} você ganhou!");
            i = 10;
            Console.WriteLine("\nFIM DE JOGO!");
        }
        else if (jogadas[0, 0] == "X" && jogadas[0, 1] == "X" && jogadas[0, 2] == "X" || jogadas[1, 0] == "X" && jogadas[1, 1] == "X" && jogadas[1, 2] == "X" || jogadas[2, 1] == "X" && jogadas[2, 1] == "X" && jogadas[2, 2] == "X" || jogadas[0, 0] == "X" && jogadas[1, 0] == "X" && jogadas[2, 0] == "X" || jogadas[0, 1] == "X" && jogadas[1, 1] == "X" && jogadas[2, 1] == "X" || jogadas[0, 2] == "X" && jogadas[1, 2] == "X" && jogadas[2, 2] == "X" || jogadas[0, 0] == "X" && jogadas[1, 1] == "X" && jogadas[2, 2] == "X" || jogadas[2, 0] == "X" && jogadas[1, 1] == "X" && jogadas[0, 2] == "X")
        {
            Console.WriteLine($"{usuario2} você ganhou!");
            i = 10;
            Console.WriteLine("\nFIM DE JOGO!");
        }
        else if (jogadas[0, 0] != "1" && jogadas[0, 1] != "2" && jogadas[0, 2] != "3" && jogadas[1, 0] != "4" && jogadas[1, 1] != "5" && jogadas[1, 2] != "6" && jogadas[2, 0] != "7" && jogadas[2, 1] != "8" && jogadas[2, 2] != "9")
        {
            Console.WriteLine("Deu velha!");
            i = 10;
        }
        else
        {
            Console.Write($"\n\t{usuario2} digite a posição da sua jogada X: ");
            Jogador2 = Console.ReadLine();

            switch (Jogador2)
            {
                case "1":

                    jogadas[0, 0] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "2":

                    jogadas[0, 1] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "3":

                    jogadas[0, 2] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "4":

                    jogadas[1, 0] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "5":

                    jogadas[1, 1] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "6":

                    jogadas[1, 2] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "7":

                    jogadas[2, 0] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "8":

                    jogadas[2, 1] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                case "9":

                    jogadas[2, 2] = "X";

                    Console.WriteLine($"\n{jogadas[0, 0]} * {jogadas[0, 1]} * {jogadas[0, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[1, 0]} * {jogadas[1, 1]} * {jogadas[1, 2]} ");
                    Console.WriteLine("************");
                    Console.WriteLine($"{jogadas[2, 0]} * {jogadas[2, 1]} * {jogadas[2, 2]} ");
                    break;

                default:
                    Console.WriteLine("Opção Inválida! Perdeu a vez.");
                    break;
            }
        }
    }
}

