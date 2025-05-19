# Evidências de Teste – FinanceOperationsApp

## 1. Introdução

Este documento apresenta evidências de teste para a aplicação Console em C# que simula operações de compra e venda de ativos financeiros. O projeto foi desenvolvido com base em requisitos acadêmicos para fins de avaliação.

## 2. Funcionalidades Testadas

As funcionalidades testadas incluem:

- Registro de operações de compra e venda
- Listagem das operações com detalhes formatados
- Cálculo e exibição do valor total de operações por tipo (compra/venda)

## 3. Testes Realizados

Foram executados os seguintes testes manuais:

- Registro de 2 operações de COMPRA
- Registro de 1 operação de VENDA
- Listagem correta das operações com formatação polimórfica
- Exibição correta do valor total de compras e vendas

## 4. Execução

A aplicação foi executada em ambiente Windows com .NET 6.0. Abaixo, seguem prints da execução da aplicação com os testes mencionados.

```bash
--- Menu Principal ---
1 - Registrar operação
2 - Listar operações
3 - Mostrar valor total
0 - Sair
Escolha: 1

Tipo da operação (1 = Compra, 2 = Venda): 1
Código do ativo (ex: PETR4, VALE3): PETR4
Quantidade: 10
Preço unitário: 2

Operação registrada com sucesso!

--- Menu Principal ---
1 - Registrar operação
2 - Listar operações
3 - Mostrar valor total
0 - Sair
Escolha: 1

Tipo da operação (1 = Compra, 2 = Venda): 1
Código do ativo (ex: PETR4, VALE3): VALE3
Quantidade: 20
Preço unitário: 3

Operação registrada com sucesso!

--- Menu Principal ---
1 - Registrar operação
2 - Listar operações
3 - Mostrar valor total
0 - Sair
Escolha: 1

Tipo da operação (1 = Compra, 2 = Venda): 2
Código do ativo (ex: PETR4, VALE3): ITUB4
Quantidade: 10
Preço unitário: 2

Operação registrada com sucesso!

--- Menu Principal ---
1 - Registrar operação
2 - Listar operações
3 - Mostrar valor total
0 - Sair
Escolha: 2

--- Histórico de Operações ---
COMPRA: [001] 19/05/2025 20:45 - PETR4 x10 @ R$ 2,00 = R$ 20,00
COMPRA: [002] 19/05/2025 20:45 - VALE3 x20 @ R$ 3,00 = R$ 60,00
VENDA:  [003] 19/05/2025 20:46 - ITUB4 x10 @ R$ 2,00 = R$ 20,00

--- Menu Principal ---
1 - Registrar operação
2 - Listar operações
3 - Mostrar valor total
0 - Sair
Escolha: 3

Valor total de compras: R$ 80,00
Valor total de vendas:  R$ 20,00

```

## 5. Conclusão

A aplicação foi testada com sucesso, atendendo a todos os requisitos funcionais propostos. As funcionalidades foram implementadas com uso de POO, interface, polimorfismo, tratamento de exceções e armazenamento em memória.

---
Documento gerado em: 19/05/2025 01:13:01
