# DesafioFunçãoExemplo

Crie uma função chamada `calcular_dano` que recebe dois parâmetros: `ataque` e `defesa`. A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

dano = ataque - defesa


Se o valor do dano for negativo, ele deve ser considerado zero.

## Entrada

Seu programa deverá receber uma entrada para a função `calcular_dano`, que irá solicitar ao usuário que insira dois valores: o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.

## Saída

A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. Caso o valor do dano seja negativo, deve ser exibido zero.

### Exemplo

Se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função `calcular_dano` deve resultar na seguinte saída:

O dano causado pelo ataque foi: 2


## Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Ataque | Defesa | Saída                           |
|--------|--------|---------------------------------|
| 10     | 8      | O dano causado pelo ataque foi: 2 |
| 5      | 10     | O dano causado pelo ataque foi: 0 |
| 7      | 3      | O dano causado pelo ataque foi: 4 |
| 15     | 15     | O dano causado pelo ataque foi: 0 |
