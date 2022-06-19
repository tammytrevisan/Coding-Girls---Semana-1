// NÃO CONSEGUI DEIXAR NA ORDEM

/* Crie um programa que lê 5 palavaras e as ordena em um vetor de strings pelo seu tamanho.
 Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.*/

Console.WriteLine("\t ------> PALAVRAS <------");

string[] palavras = new string[5];
int[] ordem = new int[5];

for (int i = 0; i < palavras.Length ; i++)
{ 
    Console.Write("Digite uma palavra: ");
    palavras[i] = Console.ReadLine();
    ordem[i] = palavras[i].Length;
}

Array.Sort(ordem);

for (int i = 0; i < ordem.Length; i++)
{ 
    Console.WriteLine(ordem[i] + " " + palavras[i]); 
}

/*foreach (var s in ordem)
        Console.WriteLine(s);
*/