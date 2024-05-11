using System;
using Struct;

Jogador jogador1 = new();

jogador1.nome = "Matheus";
jogador1.altura = 1.80;
jogador1.peso = 59;
jogador1.time = "Abobora";
jogador1.cartaoAmarelo = 5;
jogador1.cartaoVermelho = 2;

jogador1.verificarVinculoClube("Corinthans");
jogador1.registrarNumeroCartoesAmarelos(2);
jogador1.registrarNumeroCartoesVermelhos(1);

Console.WriteLine(jogador1.imprimir());