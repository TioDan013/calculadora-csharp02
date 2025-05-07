using System;

class CalculadoraSimples
{
    static void Main(string[] args)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   Bem-vindo à Calculadora Simples!   ");
        Console.WriteLine("======================================\n");

        double numero1 = LerNumero("Por favor, digite o 1º número: ");
        double numero2 = LerNumero("Agora, digite o 2º número: ");

        char operacao = LerOperacao();
        double resultado;

        if (ExecutarOperacao(numero1, numero2, operacao, out resultado, out string nomeOperacao))
        {
            Console.WriteLine($"\nResultado da {nomeOperacao.ToLower()}: {numero1} {operacao} {numero2} = {resultado}");
        }
        else
        {
            Console.WriteLine("\nOps! Parece que você escolheu uma operação inválida.");
        }

        Console.WriteLine("\nObrigado por usar nossa calculadora! Até a próxima.");
    }

    static double LerNumero(string mensagem)
    {
        double numero;
        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.\n");
        }
    }

    static char LerOperacao()
    {
        Console.WriteLine("\nEscolha a operação desejada:");
        Console.WriteLine(" +  ➜  Adição");
        Console.WriteLine(" -  ➜  Subtração");
        Console.WriteLine(" *  ➜  Multiplicação");
        Console.WriteLine(" /  ➜  Divisão");
        Console.Write("Digite o símbolo da operação: ");
        return Console.ReadKey().KeyChar;
    }

    static bool ExecutarOperacao(double n1, double n2, char operacao, out double resultado, out string nomeOperacao)
    {
        resultado = 0;
        nomeOperacao = "";

        switch (operacao)
        {
            case '+':
                resultado = n1 + n2;
                nomeOperacao = "Adição";
                return true;
            case '-':
                resultado = n1 - n2;
                nomeOperacao = "Subtração";
                return true;
            case '*':
                resultado = n1 * n2;
                nomeOperacao = "Multiplicação";
                return true;
            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine("\nErro: Não é possível dividir por zero.");
                    return false;
                }
                resultado = n1 / n2;
                nomeOperacao = "Divisão";
                return true;
            default:
                return false;
        }
    }
}