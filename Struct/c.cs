namespace Struct;

public struct Produto
{
    public string nome;
    public string dataValidade;
    public string quantidade;
    public double valor;
    public string valorCupomDescontoValor;
    public string valorCupomDescontoPorcentagem;

    public Produto(string nome, string dataValidade, string quantidade, string valorCupomDescontoValor, string valorCupomDescontoPorcentagem, double valor)
    {
        this.nome = nome;
        this.dataValidade = dataValidade;
        this.quantidade = quantidade;
        this.valor = valor;
        this.valorCupomDescontoValor = valorCupomDescontoValor;
        this.valorCupomDescontoPorcentagem = valorCupomDescontoPorcentagem;
    }

    public void aplicarCupomDescontoValor(double valor)
    {
        double desconto = this.valor - valor;
        if (desconto < 0)
        {
            this.valorCupomDescontoValor = "Não foi possivel colocar desconto";
        }
        else
        {
            this.valorCupomDescontoValor = Convert.ToString(desconto);
        }
    }

    public void aplicarCupomDescontoPorcentagem(double porcentagem)
    {
        double desconto = this.valor - (this.valor * (porcentagem / 100));
        if (desconto < 0)
        {
            this.valorCupomDescontoPorcentagem = "Não foi possivel colocar desconto";
        }
        else
        {
            this.valorCupomDescontoPorcentagem = Convert.ToString(desconto);
        }
    }

    public void verificarQuantidadeEmEstoque(string quantidade)
    {
        if (quantidade == "0")
        {
            this.quantidade = "Não a nada no estoque";
        }
        else
        {
            this.quantidade = quantidade;
        }
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome + "\nData de validade: " + this.dataValidade + "\nValor: " + this.valor + "\nDesconto por Valor: " + this.valorCupomDescontoValor + "\nDesconto por Porcentagem: " + this.valorCupomDescontoPorcentagem + "\nEstoque: " + this.quantidade;
    }
}