public static class Menu
{
    public static void Exposicao()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DesenharTela();
        EscreverOpcoes();

        var opcao = short.Parse(Console.ReadLine());
        ManipularOpcoesMenu(opcao);
    }
    public static void DesnharLinha()
    {
        Console.Write("+");
        for (int i=0; i <= 30; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write("\n");
    }
    public static void DesnharColuna()
    {
        for (int linha=0; linha <=10; linha ++){
            Console.Write("|");
            for (int i=0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }   
    }
    public static void  DesenharTela()
    {
        DesnharLinha();
        DesnharColuna();
        DesnharLinha();
    }
    public static void EscreverOpcoes()
    {
        Console.SetCursorPosition(3,2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3,3);
        Console.WriteLine("===========");
        Console.SetCursorPosition(3,4);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("2 - Abrir um arquivo");
        Console.SetCursorPosition(3,9);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(3,10);
        Console.Write("Opção: ");
    }
    public static void ManipularOpcoesMenu(short opcao)
    {
        switch(opcao) {
            case 1: Editor.Exposicao(); break;
            case 2: Console.WriteLine("Visualizar"); break;
            case 0: {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default: Exposicao();break;
        }
    }
}