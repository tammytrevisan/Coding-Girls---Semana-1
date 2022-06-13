// See https://aka.ms/new-console-template for more information

/*Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
 sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.*/
int mulherTech;

Console.WriteLine("\t ------> MULHERES NA HISTÓRIA DA TECNOLOGIA <------");
Console.WriteLine("\nVeja um pouco de algumas mulheres que fizeram parte da história da tecnologia.");
Console.WriteLine("Escolha um número: \n \t\t 1. Ada Lovelace \n \t\t 2. Irmã Mary Kenneth Keller \n \t\t 3. Jean Sammet \n \t\t 4. Grace Hopper \n \t\t 5. Karen Sparck Jones");
mulherTech = int.Parse(Console.ReadLine());

if (mulherTech == 1)
{
    Console.WriteLine("\n\n \t ADA LOVELACE \nTradutora \n Em 1843, Augusta Ada King, a Condessa de Lovelace, traduzia os textos de Luigi Menabrea, um matemático italiano, sobre as ferramentas analíticas usadas por Charles Babbage, um matemático inglês. Esse trabalho derivativo resultou no que, para muitos especialistas, é o primeiro algoritmo criado na história, muito antes da existência de máquinas que pudessem processá-lo.\n\t Fonte: https://canaltech.com.br/internet/as-dez-mulheres-mais-importantes-da-historia-da-tecnologia-59485/");
}
else if (mulherTech == 2)
{
    Console.WriteLine("\n\n \t IRMÃO MARY KENNETH KELLER \nDRA em Ciências da Computação \n Sua contribuição foi fundamental na criação da linguagem de programação BASIC, criada com fins didáticos e utilizada por décadas, até ser substituída pelo Pascal, mais arrojado, seguro e seguir de melhores práticas.Ela também foi uma das primeiras vozes pela inclusão das mulheres no ramo da informática \n\t Fonte: https://canaltech.com.br/internet/as-dez-mulheres-mais-importantes-da-historia-da-tecnologia-59485/");
}
else if (mulherTech == 3)
{
    Console.WriteLine("\n\n \t JEAN SAMMET \nPhD em Ciências da Computação \n Sammet foi a criadora de uma das primeiras linguagens computadorizadas existentes. O FORMAC, que entrou em uso no final dos anos 1960 pelas mãos da IBM, era utilizado para manipular fórmulas matemáticas e auxiliar em cálculos complexos. \n\t Fonte: https://canaltech.com.br/internet/as-dez-mulheres-mais-importantes-da-historia-da-tecnologia-59485/");
}
else if (mulherTech == 4)
{
    Console.WriteLine("\n\n \t GRACE HOPPER \nPhD em Matemática \n Grace foi uma das criadoras do COBOL, uma linguagem de programação para bancos de dados comerciais. Entretanto, sua história mais famosa é a que remonta à popularização do termo “bug” para indicar problemas em software. Em uma anedota jamais confirmada, ela teria resolvido um problema de processamento de dados ao remover uma mariposa que estava criando ninho dentro de um computador, indicando que um “debugging”, ou a remoção de um “inseto” é o melhor caminho para resolver falhas de funcionamento.\n\t Fonte: https://canaltech.com.br/internet/as-dez-mulheres-mais-importantes-da-historia-da-tecnologia-59485/");
}
else if (mulherTech == 5)
{
    Console.WriteLine("\n\n \t KAREN SPARCK JONE \n Jones realizou um trabalho focado em processamento de linguagem. Ela foi uma das criadoras do conceito de “inverso da frequência em documentos”, a base do que hoje são os sistemas de busca e localização de conteúdo e pedra fundamental de companhias como o Google, por exemplo.Trata-se de um sistema de recuperação de informações que minera de forma extremamente veloz os dados em um conjunto de documentos. A busca é feita pelos termos que mais aparecem nos textos, que quando cruzados com um sistema de filtragem, mostram a relevância de diferentes temas. É o que define, de forma básica, se uma página, por exemplo, está falando sobre a influência das mulheres no mundo da tecnologia ou se apenas cita as palavras “mulheres” e “tecnologia”, mas em um contexto completamente diferente.\n\t Fonte: https://canaltech.com.br/internet/as-dez-mulheres-mais-importantes-da-historia-da-tecnologia-59485/");
}
else
{
    Console.WriteLine("Opção digitado inválida!");
}
