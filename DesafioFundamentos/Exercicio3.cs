namespace DesafioFundamentos;

/* 1. Crie um programa com 2 valores do tipo `double` já declarados que retorne:
 * - A soma entre esses dois números;
 * - A subtração entre os dois números;
 * - A multiplicação entre os dois números;
 * - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
 * - A média entre os dois números. */

public class Exercicio3
{
  public static void Executar()
  {
    double numero1 = 45;
    double numero2 = 8;
    double resultado;

    Console.WriteLine("=== EXERCÍCIO 3 - OPERAÇÕES MATEMÁTICAS ===");

    resultado = numero1 + numero2;
    Console.WriteLine($"Resultado da soma: {resultado}");

    resultado = numero1 - numero2;
    Console.WriteLine($"Resultado da subtração: {resultado}");

    resultado = numero1 * numero2;
    Console.WriteLine($"Resultado da multiplicação: {resultado}");

    if (numero2 != 0)
    {
      resultado = numero1 / numero2;
      Console.WriteLine($"Resultado da divisão: {resultado}");
    }
    else
    {
      Console.WriteLine("Valor do Numero 2 é ZERO. Não é possível uma divisão por ZERO");
    }

    double[] numeros = [ numero1, numero2 ];
    resultado  = numeros.Average();
    Console.WriteLine($"Resultado da média: {resultado}");
    Console.WriteLine();
  }
}
