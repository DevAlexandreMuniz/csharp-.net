using System.Threading;

Iniciar();

static void Iniciar()
{
    int tempo = 10;
    int tempoinicial = 0;

    while (tempoinicial != tempo)
    {
        Console.Clear();
        tempoinicial++;
        Console.WriteLine(tempoinicial);
        Thread.Sleep(1000);
    }
}
