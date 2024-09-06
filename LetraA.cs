namespace DesafiosTargetSistemas;
public class LetraA
{
    private int contador;
    public string ExisteLetraA(string texto)
    {

        foreach (var letra in texto.ToUpper())
        {
            if (letra == 'A')
            {
                contador++;
            }
        }
        if (contador > 0)
        {
            return $"Existe a letra 'a' no texto informado, a mesma se repete {contador} vezes";
        }
        return "Não existe a letra 'a' no texto informado";
    }
}  
    