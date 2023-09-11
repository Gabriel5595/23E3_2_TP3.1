# Teste de Performance 3
## Exercício #1
Implemente um programa no qual o usuário controle um sistema de comissão de venda, onde seja necessário calcular a comissão de diferentes tipos de funcionários, dentre os quais são: assistente comercial, analista de vendas e especialista.

### Requisitos:

1. Comissão padrão para todos os funcionários: 5% do valor vendido
2. Comissão para assistente: igual à comissão padrão
3. Comissão para analista: comissão padrão + 10% do valor vendido
4. Comissão para especialista: 30% do valor vendido

### Requisitos técnicos:

1. Defina uma classe base para representar todos os funcionários (com comissão padrão). Defina um construtor parametrizado que receba nome e valor da venda;
2. Crie um método na classe base do item anterior, com o cálculo da comissão padrão;
3. Crie classes usando o recurso de herança para representar os três tipos de funcionário herdando da classe base (item 1);
4. Instancie no programa principal a criação de um assistente, de um analista e de um especialista (informe dados fictícios);
5. Para cada tipo de funcionário instanciado, informe o valor total da comissão. Use o método ToString sobrescrito para exibir o valor total da comissão;
6. Utilize a classe Console apenas no programa principal;