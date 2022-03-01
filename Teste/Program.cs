//Produtos e serviços da empresa
var livro = new Produto(1, "Livro Legal", 149.99, EProdutoTipo.Produto);
var ManutencaoEletrica = new Produto (2, "Manutenção elétrica residencial", 499.99, EProdutoTipo.Servico);
livro.Id = 5;

//Mostra na tela as propriedades do produto ou serviço
Console.WriteLine(livro.Id);
Console.WriteLine(livro.Nome);
Console.WriteLine(livro.Preco);
Console.WriteLine(livro.Tipo);
Console.WriteLine((int)livro.Tipo);

//Estrura
struct Produto {
    public Produto(int id, string nome, double preco, EProdutoTipo tipo)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Tipo = tipo;
    }

    public int Id;
    public string Nome;
    public double Preco;
    public EProdutoTipo Tipo;

    public double PecoEmDolar(double dolar)
    {
        return Preco * dolar;
    }
}

enum EProdutoTipo {
    Produto = 1,
    Servico = 2
}