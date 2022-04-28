using System.Text;

public static class Editor
{
    public static void Exposicao()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-----------");
        Iniciar();
    }
    public static void Iniciar()
    {
        var arquivo = new StringBuilder();

        do {
            arquivo.Append(Console.ReadLine());
            arquivo.Append(Environment.NewLine);
        }while(Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-----------");
        Console.WriteLine("Deseja savar o arquivo?");
        Viewer.Exposicao(arquivo.ToString());
    }

}