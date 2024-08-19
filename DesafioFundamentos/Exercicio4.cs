namespace DesafioFundamentos;

/* Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem. */

public class Exercicio4
{
  public static void Executar()
  {
    Console.WriteLine("=== EXERCÍCIO 4 - QUANTIDADE DE CARACTERES ===");
    Console.WriteLine();

    Console.Write("Digite uma ou mais palavras: ");
    string ?texto = Console.ReadLine();

    string textoAjustado = texto.Replace(" ", "");

    Console.WriteLine($"Quantidade de caracteres: {textoAjustado.Length}");
    Console.WriteLine();
  }
}
