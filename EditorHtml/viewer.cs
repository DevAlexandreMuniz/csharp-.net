using System.Text.RegularExpressions;

public class Viewer
{
    public static void Exposicao(string texto)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("MODO DE  VISUALIZAÇÃO");
        Console.WriteLine("-----------");
        Replace(texto);
        Console.WriteLine("-----------");
        Console.ReadKey();
        Menu.Exposicao();
    }

    public static void Replace(string texto)
    {
        var strong = new Regex(@" <\s*strong[^>]*>(.*?)<\s*/\s*strong> ");

    }

}