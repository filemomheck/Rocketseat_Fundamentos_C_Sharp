namespace Rocketseat_Fundamentos_C_Sharp.Exercicios;
internal class MathOperations
{
    internal double FirstNumber { get; set; }
    internal double SecondNumber { get; set; }

    internal MathOperations(double firstNumber, double secondNumber)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
    }

    internal double Sum()
    {
        return FirstNumber + SecondNumber;
    }

    internal double Subtraction()
    {
        return FirstNumber - SecondNumber;
    }

    internal double Multiplication()
    {
        return FirstNumber * SecondNumber;
    }

    internal double Division()
    {
        return FirstNumber / SecondNumber;
    }
}
