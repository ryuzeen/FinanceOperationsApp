using System;
using System.Collections.Generic;

class Program
{
    static List<Operation> operations = new List<Operation>();

    static void Main()
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Registrar operação");
            Console.WriteLine("2 - Listar operações");
            Console.WriteLine("3 - Mostrar valor total");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Entrada inválida!");
                Console.ReadKey();
                continue;
            }

            switch (option)
            {
                case 1:
                    RegisterOperation();
                    break;
                case 2:
                    ListOperations();
                    break;
                case 3:
                    ShowTotals();
                    break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (option != 0);
    }

    static void RegisterOperation()
    {
        try
        {
            Console.Write("Tipo (1=Compra, 2=Venda): ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Código do ativo (ex: PETR4): ");
            string code = Console.ReadLine().ToUpper();

            Console.Write("Quantidade: ");
            int qty = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Operation op = type == 1
                ? new BuyOperation(code, qty, price)
                : new SellOperation(code, qty, price);

            operations.Add(op);
            Console.WriteLine("Operação registrada com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao registrar operação: " + ex.Message);
        }
    }

    static void ListOperations()
    {
        Console.WriteLine("\n--- Histórico de Operações ---");
        if (operations.Count == 0)
        {
            Console.WriteLine("Nenhuma operação registrada.");
            return;
        }

        foreach (var op in operations)
        {
            Console.WriteLine(op.GetDetails());
        }
    }

    static void ShowTotals()
    {
        decimal totalCompras = 0;
        decimal totalVendas = 0;

        foreach (var op in operations)
        {
            if (op is BuyOperation)
                totalCompras += op.GetTotal();
            else if (op is SellOperation)
                totalVendas += op.GetTotal();
        }

        Console.WriteLine($"Valor total de compras: R$ {totalCompras:0.00}");
        Console.WriteLine($"Valor total de vendas:  R$ {totalVendas:0.00}");
    }
}
