using System;
using Struct;

//Exercicio A
// Jogador jogador1 = new();

// jogador1.nome = "Matheus";
// jogador1.altura = 1.80;
// jogador1.peso = 59;
// jogador1.time = "Abobora";
// jogador1.cartaoAmarelo = 5;
// jogador1.cartaoVermelho = 2;

// jogador1.verificarVinculoClube("Corinthans");
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