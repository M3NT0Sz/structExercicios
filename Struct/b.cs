namespace Struct;

public struct Equipe
{
    public string nome;
    public int quantidadeJogador;
    public int campeonatosVencidos;
    public double valorPremiacoes;
    public int anoEstreia;
    public string novataVeterana;


    public Equipe(string nome, int quantidadeJogador, int campeonatosVencidos, double valorPremiacoes, int anoEstreia, string novataVeterana)
    {
        this.nome = nome;
        this.quantidadeJogador = quantidadeJogador;
        this.campeonatosVencidos = campeonatosVencidos;
        this.valorPremiacoes = valorPremiacoes;
        this.anoEstreia = anoEstreia;
        this.novataVeterana = novataVeterana;
    }


    public void registrarCampeonatoVencido(int valorPremio)
    {
        this.campeonatosVencidos += valorPremio;
        for (int i = 0; i < valorPremio; i++)
        {
            atualizarValorTotalPremiacoes(200);
        }
    }

    public void atualizarValorTotalPremiacoes(double valor)
    {
        this.valorPremiacoes += valor;
    }

    public void verificarAnoEstreia(int ano)
    {
        if (DateTime.Now.Year > ano)
        {
            this.novataVeterana = "Veterano";
        }
        else if (DateTime.Now.Year == ano)
        {
            this.novataVeterana = "Novato";
        }
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome + "\nQuantidade de Jogadores: " + this.quantidadeJogador + "\nCampeonatosVencidos: " + this.campeonatosVencidos + "\nValor Premiações: " + this.valorPremiacoes + "\nAno de Estreia: " + this.anoEstreia + "\nTime Novato ou Veterano: " + this.novataVeterana;
    }
}