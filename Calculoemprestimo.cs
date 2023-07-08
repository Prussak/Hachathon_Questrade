using System;

class Program
{
    static void Main()
    {
        // Obter informações do usuário
        Console.WriteLine("Informe o valor do salário mensal:");
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Informe o valor das despesas mensais:");
        decimal despesas = Convert.ToDecimal(Console.ReadLine());

        // Calcular valor disponível para pagar o empréstimo
        decimal valorParaPagarEmprestimo = salario - despesas;

        // Calcular o valor inicial do empréstimo
        decimal valorInicialEmprestimo = valorParaPagarEmprestimo * 12;

        // Exibir o resultado
        Console.WriteLine(valorInicialEmprestimo);

        Console.ReadLine();
    }
}
