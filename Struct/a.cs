namespace Struct;

public struct Jogador
{
    public string nome;
    public double altura;
    public double peso;
    public string time;
    public int cartaoAmarelo;
    public int cartaoVermelho;

    public Jogador(string nome, double altura, double peso, string time, int cartaoAmarelo, int cartaoVermelho)
    {
        this.nome = nome;
        this.altura = altura;
        this.peso = peso;
        this.time = time;
        this.cartaoAmarelo = cartaoAmarelo;
        this.cartaoVermelho = cartaoVermelho;
    }

    public void verificarVinculoClube(string time)
    {
        this.time = time;
    }
    public void registrarNumeroCartoesAmarelos(int cartao)
    {
        this.cartaoAmarelo += cartao;
    }

    public void registrarNumeroCartoesVermelhos(int cartao)
    {
        this.cartaoVermelho += cartao;
    }


    public string imprimir()
    {
        return "\nNome: " + this.nome + "\nAltura: " + this.altura + "\nPeso: " + this.peso + "\nTime: " + this.time + "\nCartões Amarelos: " + this.cartaoAmarelo + "\nCartões Vermelhos: " + this.cartaoVermelho;
    }
}