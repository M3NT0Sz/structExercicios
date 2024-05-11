using System;
using Struct;

//Exercicio A
// Jogador jogador1 = new();

// jogador1.nome = "Matheus";
// jogador1.altura = 1.80;
// jogador1.peso = 59;
// jogador1.time = "Corinthans";
// jogador1.cartaoAmarelo = 5;
// jogador1.cartaoVermelho = 2;

// jogador1.verificarVinculoClube();
// jogador1.registrarNumeroCartoesAmarelos(2);
// jogador1.registrarNumeroCartoesVermelhos(1);

// Console.WriteLine(jogador1.imprimir());

//Exercicio B
Equipe equipe1 = new();
equipe1.nome = "APS";
equipe1.quantidadeJogador = 4;
equipe1.campeonatosVencidos = 1;
equipe1.valorPremiacoes = 1500.25;
equipe1.anoEstreia = 2020;
equipe1.novataVeterana = "";

equipe1.registrarCampeonatoVencido(3);
equipe1.atualizarValorTotalPremiacoes(500.25);
equipe1.verificarAnoEstreia(equipe1.anoEstreia);
Console.WriteLine(equipe1.imprimir());

//Exercicio C
// Produto produto1 = new();
// produto1.nome = "Abacaxi";
// produto1.dataValidade = "15/05/2024";
// produto1.quantidade = "20";
// produto1.valor = 10;

// produto1.valorCupomDescontoValor = "";
// produto1.valorCupomDescontoPorcentagem = "";

// produto1.aplicarCupomDescontoValor(5.5);
// produto1.aplicarCupomDescontoPorcentagem(10);
// produto1.verificarQuantidadeEmEstoque(produto1.quantidade);
// Console.WriteLine(produto1.imprimir());

//Exercicio D
// Professor professor1 = new();
// professor1.nome = "Matheus";
// professor1.materia = "Matematica";
// professor1.cargaHoraria = 20;
// professor1.salario = 1500;
// professor1.reajusteSalarialValor = 0;
// professor1.reajusteSalarialPorcentagem = 0;
// professor1.descontoSalarialValor = 0;
// professor1.descontoSalarialPorcentagem = 0;
// professor1.aumentaCargaHoraria = 0;
// professor1.aumentaSalario = 0;

// professor1.reajusteSalarialEmValor(350);
// professor1.reajusteSalarialEmPorcentagem(10);
// professor1.descontoSalarialPorFaltaEmValor(2, 100);
// professor1.descontoSalarialPorFaltaEmPorcentagem(3, 10);
// professor1.aumentarCargaHorariaDeTrabalho(5, 250);

// Console.WriteLine(professor1.imprimir());
