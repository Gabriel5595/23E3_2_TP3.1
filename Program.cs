using System;

class Program
{
    static void Main()
    {
        // Instanciando funcionários com dados fictícios
        Funcionario assistente = new AssistenteComercial("João", 1000.0);
        Funcionario analista = new AnalistaDeVendas("Maria", 2000.0);
        Funcionario especialista = new Especialista("Carlos", 3000.0);

        // Calculando e exibindo as comissões
        Console.WriteLine(assistente);
        Console.WriteLine(analista);
        Console.WriteLine(especialista);
    }
}

class Funcionario
{
    protected string Nome { get; }
    protected double ValorVenda { get; }

    public Funcionario(string nome, double valorVenda)
    {
        Nome = nome;
        ValorVenda = valorVenda;
    }

    public virtual double CalcularComissao()
    {
        return ValorVenda * 0.05; // Comissão padrão de 5%
    }

    public override string ToString()
    {
        return $"{Nome} - Comissão: R${CalcularComissao():F2}";
    }
}

class AssistenteComercial : Funcionario
{
    public AssistenteComercial(string nome, double valorVenda) : base(nome, valorVenda) { }

    public override double CalcularComissao()
    {
        return base.CalcularComissao(); // Comissão igual à comissão padrão
    }
}

class AnalistaDeVendas : Funcionario
{
    public AnalistaDeVendas(string nome, double valorVenda) : base(nome, valorVenda) { }

    public override double CalcularComissao()
    {
        return base.CalcularComissao() + ValorVenda * 0.10; // Comissão padrão + 10%
    }
}

class Especialista : Funcionario
{
    public Especialista(string nome, double valorVenda) : base(nome, valorVenda) { }

    public override double CalcularComissao()
    {
        return ValorVenda * 0.30; // Comissão de especialista (30%)
    }
}
