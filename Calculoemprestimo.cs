using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Informações de conexão com o banco de dados
        string connectionString = "SuaConnectionString";
        string query = "SELECT juros_emprestimo FROM configuracoes_emprestimo";

        // Criar conexão com o banco de dados
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Abrir conexão
                connection.Open();

                // Criar comando SQL
                SqlCommand command = new SqlCommand(query, connection);

                // Executar consulta e obter o valor dos juros
                decimal juros = (decimal)command.ExecuteScalar();

                // Continuar com o restante do código
                Console.WriteLine("Informe o valor do salário mensal:");
                decimal salario = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o valor das despesas mensais:");
                decimal despesas = Convert.ToDecimal(Console.ReadLine());

                // Calcular valor disponível para pagar o empréstimo
                decimal valorParaPagarEmprestimo = salario - despesas;

                // Calcular o valor mínimo do empréstimo
                decimal valorMinimoEmprestimo = valorParaPagarEmprestimo * 12;

                // Calcular o valor do juros anual com base no valor recuperado do banco de dados
                decimal valorJurosAnual = valorMinimoEmprestimo * (juros / 100);

                // Exibir o resultado
                Console.WriteLine("O valor mínimo do empréstimo é: " + valorMinimoEmprestimo);
                Console.WriteLine("O valor do juros ao ano é: " + valorJurosAnual);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        Console.ReadLine();
    }
}
