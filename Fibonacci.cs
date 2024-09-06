namespace DesafiosTargetSistemas;
public class Fibonacci
{
    public string ExisteNoFibonacci(long valor)
    {
        var fibonacci = new List<long>() { 0,1 };

        while(fibonacci.Last() < valor)
        {
            var proximo = fibonacci.Last() + fibonacci[fibonacci.Count - 2];

            if (proximo > valor)
                break;

            fibonacci.Add(proximo);
        }
        if (!fibonacci.Contains(valor))
        {
            return "O valor informado não existe na sequencia de Fibonacci!";
        }

        return "O valor informado existe na sequência de Fibonacci!";
    }
}
    
