namespace DesafioFundamentos;

/* Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo. */

public class Exercicio2
{
  public static void Executar()
  {
    Console.WriteLine("=== EXERCÍCIO 2 - CONCATENAR NOME ===");
    Console.WriteLine();

    Console.Write("Digite seu nome: ");
    string ?nome = Console.ReadLine();

    Console.Write("Digite seu sobrenome: ");
    string ?sobrenome = Console.ReadLine();

    Console.WriteLine("-- Concatenação 1 --");
    Console.WriteLine($"{nome} {sobrenome}");

    Console.WriteLine("-- Concatenação 2 --");
    Console.WriteLine(String.Format("{0} {1}", nome, sobrenome));
    Console.WriteLine();
  }
}
