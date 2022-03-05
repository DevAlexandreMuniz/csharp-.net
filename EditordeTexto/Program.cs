using System.IO;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao editor de textos.");
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo.");
    Console.WriteLine("2 - Criar novo arquivo.");
    Console.WriteLine("0 - Sair");

    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
    }
}

static void Abrir()
{

}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto aqui (Precione ESC para encerrar).");
    Console.WriteLine("---------------------------------------------------");

    //Aqui será armazenado o texto que o usuário digitar
    string texto = "";

    //Enquanto o texto digitado for diferente de ESC, o laço será repetido.
    do
    {
        texto += Console.ReadLine();

        //Para fazer a quebra de linha
        texto += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(texto);
}

static void Salvar(string texto)
{
    Console.Clear();
    Console.WriteLine("Qual caminho você deseja salvar o arquivo?");
    var caminho = Console.ReadLine();

    //Abre, escreve e fecha o arquivo
    using (var arquivo = new StreamWriter(caminho))
    {
        arquivo.Write(texto);
    }

    Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}