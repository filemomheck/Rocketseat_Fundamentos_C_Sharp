using Rocketseat_Fundamentos_C_Sharp.Exercicios;

namespace Rocketseat_Fundamentos_C_Sharp;

public class Program()
{
    static void Main()
    {
        // =================================================================================================
        // Exercício 01:
        Console.WriteLine("Por favor, digite seu nome:");
        var userName = Console.ReadLine();

        Console.WriteLine($"Olá, {userName}! Seja muito bem-vindo!");

        // =================================================================================================
        // Exercício 02:
        Console.WriteLine("Por favor, insira seu primeiro nome:");
        var firstName = Console.ReadLine();

        Console.WriteLine("Insira seu sobrenome:");
        var secondName = Console.ReadLine();

        Console.WriteLine($"Olá, {firstName} {secondName}");

        // =================================================================================================
        // Exercício 03:
        Console.WriteLine("Digite um numero...");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite mais um numero...");
        double secondNumber = double.Parse(Console.ReadLine());

        var mathOperations = new MathOperations(firstNumber, secondNumber);

        Console.WriteLine($"Soma de {firstNumber} + {secondNumber} = {mathOperations.Sum()}");
        Console.WriteLine($"Subtração de {firstNumber} - {secondNumber} = {mathOperations.Subtraction()}");
        Console.WriteLine($"Multiplicação de {firstNumber} x {secondNumber} = {mathOperations.Multiplication()}");
        Console.WriteLine($"Divisão de {firstNumber} / {secondNumber} = {mathOperations.Division()}");

        // =================================================================================================
        // Exercício 04:
        Console.WriteLine("Digite um texto...");
        var text1 = Console.ReadLine();

        var letterCount = text1.LongCount();

        Console.WriteLine(letterCount);

        // =================================================================================================
        // Exercício 05:
        Console.WriteLine("Digite a placa do seu veiculo...");
        var plate = Console.ReadLine();

        var carPlate = new CarPlate { Plate = plate };

        if (carPlate.CheckPlate())
        {
            Console.WriteLine("Placa valida!");
        }
        else
        {
            Console.WriteLine("Placa inválida!");
        }

        // =================================================================================================
        // Exercício 06:
        Console.Write(
            "Bem-vindo ao programa #EscolhaComoVcQuerVerADataDeHoje...\n" +
            "Escolha uma das opções abaixo:\n\n" +
            "\t1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).\n" +
            "\t2 - Apenas a data no formato \"01/03/2024\".\n" +
            "\t3 - Apenas a hora no formato de 24 horas.\n" +
            "\t4 - A data com o mês por extenso.\n\n" +
            "Escolha a opção (1, 2, 3, 4): ");

        var option = Console.ReadLine();

        DateTime currentDate = DateTime.Now;

        switch (option)
        {
            case "1":
                // Formato completo
                Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;

            case "2":
                // Apenas a data no formato "01/03/2024"
                Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
                break;

            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine(currentDate.ToString("HH:mm"));
                break;

            case "4":
                // A data com o mês por extenso
                Console.WriteLine($"{currentDate:dd} de {currentDate:MMMM} de {currentDate:yyyy}");
                break;

            default:
                // Caso o usuário digite uma opção inválida
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção entre 1 e 4.");
                break;
        }

    }
}
