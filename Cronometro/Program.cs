using System.Threading;
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo a cronômetro");
    Console.WriteLine("S = Segundo => 10s => 10 Segundos");
    Console.WriteLine("M = Minuto => 1m => 1 Minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Escolha uma opção");

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
        System.Environment.Exit(0);

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
