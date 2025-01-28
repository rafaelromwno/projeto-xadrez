# Jogo de Xadrez em C# (Aplicação Console) ♟

## Visão Geral

Este projeto é um **jogo de xadrez em modo console**, desenvolvido em C# como parte do curso de C# ministrado pelo **Professor Nélio Alves**. O objetivo do projeto é aplicar os principais conceitos da **Programação Orientada a Objetos (POO)** por meio do desenvolvimento de um jogo completo de xadrez.

O projeto segue uma arquitetura modular dividida em três camadas, o que facilita a manutenção e a escalabilidade do código.

## Arquitetura 📝

O sistema é dividido em três camadas principais: **Camada de Aplicação**, **Camada do Jogo de Xadrez** e **Camada do Tabuleiro**. Essa divisão proporciona uma separação clara de responsabilidades, favorecendo o baixo acoplamento e a alta coesão.

## Estrutura do Projeto

O projeto é organizado em diferentes classes e pastas, refletindo as camadas arquiteturais descritas acima:

- **Camada de Aplicação**: Responsável pela interação com o jogador.
- **Camada do Jogo de Xadrez**: Contém a lógica das regras e movimentos do jogo.
- **Camada do Tabuleiro**: Gerencia a representação do tabuleiro e movimentação das peças.

### 1. Camada de Aplicação

Esta camada é responsável pela **interação com o usuário**. Na versão de console, ela gerencia a entrada e a saída de dados, garantindo que o jogador possa:

- Iniciar uma nova partida de xadrez
- Inserir jogadas
- Visualizar o estado atual do jogo (o tabuleiro)
- Receber feedback sobre jogadas inválidas ou quando o jogo terminar

#### Responsabilidades:
- Gerenciar o fluxo da partida, incluindo turnos, estado do jogo e condições de fim (xeque-mate).
- Exibir o tabuleiro e mensagens de erro (quando uma jogada é inválida).
- Comunicar-se com a Camada de Jogo de Xadrez para validar as jogadas e executar a lógica do jogo.

### 2. Camada de Jogo de Xadrez

Essa camada contém as **regras e mecânicas do jogo de xadrez**. Ela garante que o jogo siga as regras oficiais do xadrez, validando cada movimento feito pelos jogadores e verificando condições como xeque e xeque-mate, além de jogadas especiais como roque, en passant e promoção de peão.

#### Responsabilidades:
- Implementar as regras do xadrez e os movimentos das peças.
- Validar se as jogadas são legais de acordo com as regras.
- Manter o estado atual da partida (peças no tabuleiro, turno do jogador, xeque/xeque-mate).
- Comunicar-se com a Camada de Aplicação e a Camada do Tabuleiro para gerenciar o andamento do jogo.

### 3. Camada do Tabuleiro

A **Camada do Tabuleiro** lida com a **representação do tabuleiro e das peças**. Ela define como as peças são colocadas no tabuleiro e como se movem de acordo com as regras.

#### Responsabilidades:
- Gerenciar a estrutura de dados que representa o tabuleiro (uma matriz 8x8).
- Implementar a lógica de movimentação das peças no tabuleiro.
- Manter o controle das posições das peças e atualizar o estado do tabuleiro após cada jogada.

## Funcionalidades

- **Validação de movimentos legais**: O jogo impõe todas as regras de movimento de cada tipo de peça (rei, dama, torre, bispo, cavalo, peão).
- **Detecção de xeque e xeque-mate**: O jogo verifica as condições de xeque e xeque-mate, encerrando o jogo quando necessário.
- **Jogadas especiais**: O jogo suporta roque, en passant e promoção de peão.
- **Mecânica de turnos**: Alterna os turnos entre dois jogadores, permitindo apenas movimentos legais.

## Como Começar

Para executar o jogo de xadrez, basta clonar este repositório e executar a aplicação console em um IDE que suporte C#.

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-repositorio/jogo-de-xadrez.git
2. Abra o projeto em um IDE como o Visual Studio.
3. Compile e execute a aplicação console.

## Como Jogar
- Os jogadores realizam suas jogadas inserindo movimentos no formato de notação algébrica (por exemplo, e2 para e4).
- O console exibirá o estado do tabuleiro após cada movimento.
- O jogo notificará o jogador se uma jogada for inválida.
- O jogo detectará automaticamente xeque e xeque-mate.

## Conhecimentos Aplicados

### Introdução à POO: Os Fundamentos
A primeira parte do curso se concentra nos conceitos básicos da POO, como:

- **Construtores**: Métodos especiais utilizados para inicializar objetos.
- **Palavra this**: Referência ao próprio objeto dentro de um método.
- **Sobrecarga**: Capacidade de ter múltiplos métodos com o mesmo nome, mas com diferentes parâmetros.
- **Encapsulamento**: Mecanismo de ocultar os detalhes internos de um objeto, protegendo seus dados e métodos.
- **Associações**: Relacionamentos entre objetos.
- **Avançando na POO**: Herança, Polimorfismo e Mais

### A segunda parte aprofunda os conceitos, introduzindo:

- **Herança**: Mecanismo que permite criar novas classes a partir de classes existentes, promovendo a reutilização de código.
- **Classe abstrata**: Classe que não pode ser instanciada, servindo como base para outras classes.
- **Sobreposição**: Capacidade de uma subclasse redefinir um método herdado da superclasse.
- **Polimorfismo**: Capacidade de um objeto assumir múltiplas formas, dependendo do contexto.

### Além dos conceitos puros da POO:

- **Elementos estáticos**: Membros de uma classe que pertencem à classe e não a objetos individuais.
- **Tipos enumerados**: Tipo de dado que consiste em um conjunto de constantes nomeadas.
- **Exceções**: Mecanismo para lidar com erros e situações inesperadas durante a execução de um programa.

### A parte final do curso se dedica ao estudo de estruturas de dados essenciais para a programação:

- **Vetores**: Coleções ordenadas de elementos do mesmo tipo.
- **Matrizes**: Arranjos bidimensionais de elementos.
- **Listas**: Coleções ordenadas que permitem a inserção e remoção de elementos.
- **Conjuntos**: Coleções não ordenadas de elementos únicos.

### Resultado do projeto

https://github.com/user-attachments/assets/4a19e189-977d-4661-8184-202fa3731c36
