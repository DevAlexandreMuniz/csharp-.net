Console.Clear();
Console.WriteLine("Digite o texto que deseja formatar");

var palavra = Console.ReadLine();
palavra = palavra.ToLower();

var palavraFormatada = "";
var colocarLetraEmMaiusculo = true;

foreach (var letra in palavra)
{
    var novaLetra = letra.ToString();

    if (colocarLetraEmMaiusculo)
        novaLetra = novaLetra.ToUpper();

    palavraFormatada = palavraFormatada + novaLetra;
    colocarLetraEmMaiusculo = !colocarLetraEmMaiusculo;
}

Console.WriteLine(palavraFormatada);