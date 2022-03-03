using System.Threading;
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|         CRONÔMETRO         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Escreva até quanto      |");
    Console.WriteLine("|    deseja contar e use:    |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|        （っ＾▿＾）         |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|    S - para segundos       |");
    Console.WriteLine("|    M - para minutos        |");
    Console.WriteLine("|    Ex: 10s                 |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|    0s - para Sair          |");
    Console.WriteLine("|____________________________|");

    //Coleta os dados escolhidos pelo usuário e converte para minúsculas.
    string dado = Console.ReadLine().ToLower();

    //Seleciona o último caractere de dado.
    //Substring podemos pegar uma parte da cadeia de caracteres.
    //data.lenght conta o total de caracteres de uma string, nos diz o cumprimento. 
    char tipo = char.Parse(dado.Substring(dado.Length - 1, 1));

    //Seleciona todos os caracteres de dado menos o último.
    int tempo = int.Parse(dado.Substring(0, dado.Length - 1));


    //Nosso cronômetro avança a cada segundo
    //O programa começa em "s", com o multiplicador valendo 1.
    int multiplicador = 1;

    //Caso o usuário escolha "m", o multiplicador valerá 60.
    if (tipo == 'm')
        multiplicador = 60;

    //Se o usuário escolher 0 o programa será encerrado.
    if (tempo == 0)
        Sair();

    //Chamando o contador.
    PreIniciar(tempo * multiplicador);
}

static void PreIniciar(int tempo)
{
    Console.Clear();
    Console.WriteLine("Preparar...");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar...");
    Thread.Sleep(1000);
    Console.WriteLine("Fogo!");
    Thread.Sleep(2000);

    Iniciar(tempo);
}

static void Iniciar(int tempo)
{
    int tempoinicial = 0;

    while (tempoinicial != tempo)
    {

        Console.Clear();
        tempoinicial++;
        Console.WriteLine(tempoinicial);

        //pausa o programa por um segundo.
        Thread.Sleep(1000);
    }
    Console.WriteLine("Cronômetro finalizado");
    Thread.Sleep(2500);
    Menu();
}

static void Sair()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|       MUITO OBRIGADO       |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|  O tempo é uma das coisas  |");
    Console.WriteLine("|  mais importantes em       |");
    Console.WriteLine("|  nossas vidas, conte       |");
    Console.WriteLine("|  comigo para ajudá-lo      |");
    Console.WriteLine("|  a contar os segundos.     |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|         (⊃｡•́‿•̀｡)⊃          |");
    Console.WriteLine("|____________________________|");
    System.Environment.Exit(0);
}