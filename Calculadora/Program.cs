//Menu


static void Soma()
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
}

static void Divisao()
{

}

static void Multiplicacao()
{

}
