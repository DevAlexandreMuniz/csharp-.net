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

    Console.WriteLine(dado);
    Console.WriteLine(tipo);

}

static void Iniciar(int tempo)
{
    int tempoinicial = 0;

    while (tempoinicial != tempo)
    {

        Console.Clear();
        tempoinicial++;
        Console.WriteLine(tempoinicial);

        //pausa o programa temporariamente.
        Thread.Sleep(1000);
        Console.WriteLine("Cronômetro finalizado");
        Thread.Sleep(2500);
        Menu();
    }
}
