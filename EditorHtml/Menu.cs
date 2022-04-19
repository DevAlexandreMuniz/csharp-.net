public static class Menu{
    public static void Show(){
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawnScreen();
    }
    public static void DesnharLinha(){
        Console.Write("+");
        for (int i=0; i <= 30; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write("\n");
    }
    public static void DesnharColuna(){
        for (int linha=0; linha <=10; linha ++){
            Console.Write("|");
            for (int i=0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }   
    }

    public static void  DrawnScreen(){
        DesnharLinha();
        DesnharColuna();
        DesnharLinha();
    }
}