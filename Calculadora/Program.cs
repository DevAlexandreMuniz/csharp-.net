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
    Console.WriteLine("|    1 - Adição              |");
    Console.WriteLine("|    2 - Subtração           |");
    Console.WriteLine("|    3 - Multiplicação       |");
    Console.WriteLine("|    4 - Divisão             |");
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
        default: Menu(); break;
    }
}

static void Adicao()
{
    Console.Clear();
    //Coleta os valores para fazer a soma
    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adicionar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    //Somar os dois valores
    float resultado = v1 + v2;

    //Mostrar o resultado na tela, existem várias maneiras de exibir o resultado
    Console.WriteLine($"O resultado da soma dos valores é {resultado}");
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

    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adiconmnar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração dos valores é {resultado}");

    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adicionar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float resultado = v1 * v2;

    Console.WriteLine($"O resultdo da multiplicação dos valores é {resultado}");

    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Adicionar primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Adicionar segundo valor:");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    float resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão dos valores é {resultado}");

    Console.ReadKey();
    Menu();
}