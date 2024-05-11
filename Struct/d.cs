using System.Security.Cryptography.X509Certificates;

namespace Struct;

public struct Professor
{
    public string nome;
    public string materia;
    public double cargaHoraria;
    public double salario;
    public double reajusteSalarialValor;
    public double reajusteSalarialPorcentagem;
    public double descontoSalarialValor;
    public double descontoSalarialPorcentagem;
    public double aumentaCargaHoraria;
    public double aumentaSalario;

    public Professor(string nome, string materia, double cargaHoraria, double salario, double reajusteSalarialValor, double reajusteSalarialPorcentagem, double descontoSalarialValor, double descontoSalarialPorcentagem, double aumentaCargaHoraria, double aumentaSalario)
    {
        this.nome = nome;
        this.materia = materia;
        this.cargaHoraria = cargaHoraria;
        this.salario = salario;
        this.reajusteSalarialValor = reajusteSalarialValor;
        this.reajusteSalarialPorcentagem = reajusteSalarialPorcentagem;
        this.descontoSalarialValor = descontoSalarialValor;
        this.descontoSalarialPorcentagem = descontoSalarialPorcentagem;
        this.aumentaCargaHoraria = aumentaCargaHoraria;
        this.aumentaSalario = aumentaSalario;
    }

    public void reajusteSalarialEmValor(double valor)
    {
        reajusteSalarialValor = salario + valor;
    }

    public void reajusteSalarialEmPorcentagem(double porcentagem)
    {
        reajusteSalarialPorcentagem = salario + (salario * (porcentagem / 100));
    }

    public void descontoSalarialPorFaltaEmValor(int falta, double valor)
    {
        double salarioA = salario;
        for (int i = 0; i < falta; i++)
        {
            salarioA -= valor;
        }
        descontoSalarialValor = salarioA;
    }

    public void descontoSalarialPorFaltaEmPorcentagem(int falta, double porcentagem)
    {
        double salarioA = salario;
        for (int i = 0; i < falta; i++)
        {
            salarioA -= salarioA * (porcentagem / 100);
        }
        descontoSalarialPorcentagem = salarioA;
    }

    public void aumentarCargaHorariaDeTrabalho(double auCargaHoraria, double valor)
    {
        aumentaCargaHoraria += cargaHoraria + auCargaHoraria;
        aumentaSalario += salario + valor;
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome + "\nMatéria: " + this.materia + "\nCarga Horaria: " + this.cargaHoraria + " Horas\nSalario: " + this.salario + "\nSalario com Reajuste em Valor: " + this.reajusteSalarialValor + "\nSalario com Reajuste em Porcentagem: " + this.reajusteSalarialPorcentagem + "\nDesconto Salarial em Valor: " + this.descontoSalarialValor + "\nDesconto Salarial em Porcentagem: " + this.descontoSalarialPorcentagem + "\nCarga Horaria Reajustada: " + this.aumentaCargaHoraria + " Horas" + "\nValor Reajustado: " + this.aumentaSalario;
    }
}