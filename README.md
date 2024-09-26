# ProjetoEmEquipe
Atividades em grupo no Uneding

  ## Calculadora
1. Fazer um requerimento dos números equanto verifica se os dados inseridos são aceitáveis.
2. Pedir uma das operações aceitáveis do código (multiplicação, divisão, soma e subtração).
3. De acordo com a operação escolhida, realizar a operação e armazenar o valor em uma variável.
  ```case "Operador": resultado = valor1 + valor2;``` 
4. Entregar o resultado com formatação, indicando as informações inseridas pelo usuário.
  ```Console.WriteLine($"O resultado da "Operação" é:{resultado}");```<br><br>
Obs:
- Para realizar uma verificação de uma possivel valor invalido no código:<br>
  ```if("Variavel Requerida".TryParse(Console.ReadLine(),out "Variável Requerida" "Variável com o valor caso seja aceita"))```
- Na operação de divisão foi utilizado a Biblioteca:<br>
  ```Math.Round(Variável,Número de casas decimais)```

  ## Pedra, Papel e Tesoura
1. Lista com as opções do jogo.<br>
```string[] opcoes = { "pedra", "papel", "tesoura" };```
2. Dar a opção de sair ou jogar para o usuário.<br>
```Console.WriteLine("Escolha: pedra, papel ou tesoura (ou 'sair' para encerrar): ");```
3. Escolher um valor aleatório para o computador.<br>
```string computador = opcoes[random.Next(opcoes.Length)];```
4. Comparar o valor do usuário com o do computador.<br>
```if (usuario == computador){}else if ((usuario == "pedra" && computador == "tesoura") ||(usuario == "papel" && computador == "pedra") ||(usuario == "tesoura" && computador == "papel"))```
5. E entregue o resultado com a formatação preferível.<br><br>
Obs:
- Foi feito dentro de uma estrutura de repetição com um ```while(true)``` e damos um ```break;``` caso o usuário selecione a opção de "sair".

  ## Backlog
- [ ] Jogo de Adivinhação de Números.
- [ ] Gerador de Senhas Aleatórias.
- [ ] Conversor de Temperatura.
- [ ] Simulador de Lançamento de Dados.
- [ ] Calculadora de IMC (Índice de Massa Corporal).
- [ ] Decisão de Almoço (Aleatória).
- [ ] Cronômetro.

# Conclusão
Foi dada como atividade o controle de postagem e formatação do "Readme" para um líder, e os outros integrantes deveriam postar alguns códigos relacionados às atividades dadas anteriomente em sala de aula. É de suma importância o controle e uso das ferramentas do GitHub. Com o objetivo de concluir a atividade, cada aluno utilizou as diversas ferramentas no Git em seu próprio desktop. Dessa forma, foi possível postar atividades pelo "Fork" e, posteriomente, serem aceitas pelo lider.
