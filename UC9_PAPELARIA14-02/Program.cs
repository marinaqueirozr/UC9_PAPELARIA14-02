// Variáveis
string[,] produtos = new string[5, 4];
int linha = 0;
int coluna = 0;
double preco = 0;
double desconto = 0;
string codigo = "";
string retornar;
retornar = "S";
double total = 0;
double valortotal = 0;
int itens = 0;
string continuar = "";
string continuar2 = "";

// Cadastrar Produtos

for (linha = 0; linha <= 4; linha++)
{
    Console.Clear();
    Console.WriteLine("Informe a DESCRIÇÃO do produto:");
    produtos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o PREÇO do produto:");
    produtos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a COR do produto:");
    produtos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o DESCONTO A VISTA do produto:");
    produtos[linha, coluna++] = Console.ReadLine();

    coluna = 0;
}

for (linha = 0; linha <= 4; linha++)
{
    for (coluna = 0; coluna <= 3; coluna++)
    {
        Console.Write(produtos[linha, coluna] + " - ");
    }
    Console.WriteLine(" ");
}
while (continuar2 == "N")
{

    Console.WriteLine("Realizar pesquisa 1 - descrição | 2 - cor");
    codigo = Console.ReadLine();

    switch (codigo)
    {
        case "1":
            Console.WriteLine("Escolha Produto:");
            codigo = Console.ReadLine();
            Console.WriteLine("Deseja voltar ao menu?");
            continuar = Console.ReadLine();
            break;


        case "2":
            Console.WriteLine("Escolha Produto:");
            codigo = Console.ReadLine();
            Console.WriteLine("Deseja voltar ao menu?");
            continuar = Console.ReadLine();

            break;
    }
}







