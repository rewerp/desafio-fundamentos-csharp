namespace DesafioFundamentos;

/* Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas 
 * personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo! */

public class Exercicio1
{
  public static void Executar()
  {
    const string mensagemBoasVindas = "Olá, {0}! Seja muito bem-vindo!";

    Console.WriteLine("===EXERCÍCIO 1 -  BOAS VINDAS ===");
    Console.WriteLine();
    Console.Write("Digite o seu nome: ");
    string ?nome = Console.ReadLine();

    Console.WriteLine("-- Mensagem --");
    Console.WriteLine(String.Format(mensagemBoasVindas, nome));
    Console.WriteLine();
  }
}
