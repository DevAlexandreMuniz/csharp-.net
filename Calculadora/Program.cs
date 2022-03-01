Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|        CALCULADORA         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Escolha uma operação    |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|         （っ＾▿＾）        |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|    1 - Adição              |");
    Console.WriteLine("|    2 - Subtração           |");
    Console.WriteLine("|    3 - Multiplicação       |");
    Console.WriteLine("|    4 - Divisão             |");
    Console.WriteLine("|    5 - Sair                |");
    Console.WriteLine("|____________________________|");
    Console.WriteLine("");
    Console.WriteLine("Digite aqui");
    short operacao = short.Parse(Console.ReadLine());

    switch (operacao)
    {
        case 1: Adicao(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: Confirmar(); break;
        default: Menu(); break;
    }
}

static void Adicao()
{
    Console.Clear();
    //Coleta os valores para fazer a soma
    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|           ADIÇÃO           |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Digite os valores que   |");
    Console.WriteLine("|    deseja somar            |");
    Console.WriteLine("|           (◠﹏◠)           |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|____________________________|");
    Console.WriteLine("");
    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adicionar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    //Somar os dois valores
    float resultado = v1 + v2;

    //Mostrar o resultado na tela, existem várias maneiras de exibir o resultado
    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|          RESULTADO         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|  O resultado da soma       |");
    Console.WriteLine($"|  dos valores é {resultado}           |");
    Console.WriteLine("|         (っ▀¯▀)つ          |");
    Console.WriteLine("|____________________________|");
    // Console.WriteLine($"O resultado da soma dos valores é {v1 + v2}");
    // Console.WriteLine("O resultado da soma dos valores é " + resultado);
    // Console.WriteLine("O resultado da soma dos valores é " + (v1 + v2));

    //Para não parar a execução do programa
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|          SUBTRAÇÃO         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Digite os valores que   |");
    Console.WriteLine("|    deseja subtrair         |");
    Console.WriteLine("|           (｡◕‿◕｡)          |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|____________________________|");
    Console.WriteLine("");
    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adiconmnar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float resultado = v1 - v2;

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|          RESULTADO         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|  O resultado da subtração  |");
    Console.WriteLine($"|  dos valores é {resultado}           |");
    Console.WriteLine("|         (っ▀¯▀)つ          |");
    Console.WriteLine("|____________________________|");

    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|        MULTIPLICAÇÃO       |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Digite os valores que   |");
    Console.WriteLine("|    deseja multiplicar      |");
    Console.WriteLine("|        ♪♪ ヽ(ˇ∀ˇ )ゞ       |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|____________________________|");
    Console.WriteLine("");
    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adicionar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float resultado = v1 * v2;

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|          RESULTADO         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|       O resultado da       |");
    Console.WriteLine("|       multiplicação        |");
    Console.WriteLine($"|       dos valores é {resultado}      |");
    Console.WriteLine("|         (っ▀¯▀)つ          |");
    Console.WriteLine("|____________________________|");

    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|           DIVISÃO          |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Digite os valores que   |");
    Console.WriteLine("|    deseja dividir          |");
    Console.WriteLine("|          ᕙ(⇀‸↼)ᕗ          |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|____________________________|");
    Console.WriteLine("");

    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adicionar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float resultado = v1 / v2;

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|          RESULTADO         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|  O resultado da divisão    |");
    Console.WriteLine($"|  dos valores é {resultado}           |");
    Console.WriteLine("|         (っ▀¯▀)つ          |");
    Console.WriteLine("|____________________________|");

    Console.ReadKey();
    Menu();
}

static void Confirmar()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|    Deseja me abandonar?    |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|          (´･_･`)           |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|                            |");
    Console.WriteLine("| Você realmente irá embora? |");
    Console.WriteLine("|   1 - Irei    2 - Ficarei  |");
    Console.WriteLine("|____________________________|");

    short confirmacao = short.Parse(Console.ReadLine());
    switch (confirmacao)
    {
        case 1: Vaimesmo(); break;
        case 2: Menu(); break;
        default: Confirmar(); break;
    }
}

static void Vaimesmo()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|         Vai mesmo?         |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|            ( ಥ_ಥ)            |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|   Me dá mais uma chance?   |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|  1 - Já decidi  2 - Tá bom |");
    Console.WriteLine("|____________________________|");

    short confirmacao = short.Parse(Console.ReadLine());
    switch (confirmacao)
    {
        case 1: Sair(); break;
        case 2: Menu(); break;
        default: Vaimesmo(); break;
    }
}

static void Sair()
{
    Console.Clear();

    Console.WriteLine(" ____________________________ ");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|       MUITO OBRIGADO       |");
    Console.WriteLine("|----------------------------|");
    Console.WriteLine("|  Volte outras vezes para   |");
    Console.WriteLine("|  receber ajuda com os      |");
    Console.WriteLine("|  problemas da vida.        |");
    Console.WriteLine("|                            |");
    Console.WriteLine("|         (⊃｡•́‿•̀｡)⊃          |");
    Console.WriteLine("|____________________________|");
    System.Environment.Exit(0);
}