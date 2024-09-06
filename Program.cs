namespace DesafiosTargetSistemas;

public class Program
{
    public static void Main()
    {
        var letraA = new LetraA();
        var fibonacci = new Fibonacci();

        var resultadoFib = fibonacci.ExisteNoFibonacci(5223372036854775807);
        var resultadoLet = letraA.ExisteLetraA("Realizando teste para vaga de estágio em desenvolvimento de software!!!");

        Console.WriteLine(resultadoFib);
        Console.WriteLine(resultadoLet);
    }
}