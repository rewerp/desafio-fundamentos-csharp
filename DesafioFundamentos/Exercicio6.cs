using System.Globalization;
using System.Transactions;

namespace DesafioFundamentos;

/* 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
 * - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
 * - Apenas a data no formato "01/03/2024".
 * - Apenas a hora no formato de 24 horas.
 * - A data com o mês por extenso. */

public class Exercicio6
{
  public static void Executar()
  {
    Console.WriteLine("=== EXERCÍCIO 6 - FORMATAÇÃO DE DATA ===");

    DateTime dataAtual = DateTime.Now;

    Console.WriteLine("-- Formato Completo --");
    Console.WriteLine(dataAtual.ToString("F", new CultureInfo("pt-BR")));

    Console.WriteLine("-- Apenas Data DD/MM/AAAA --");
    Console.WriteLine(dataAtual.ToString("dd/MM/yyyy", new CultureInfo("pt-BR")));

    Console.WriteLine("-- Hora formato 24 horas --");
    Console.WriteLine(dataAtual.ToString("HH:mm", new CultureInfo("pt-BR")));

    Console.WriteLine("-- Mês por extenso --");
    Console.WriteLine(dataAtual.ToString("dd 'd'e MMMM 'd'e yyyy", new CultureInfo("pt-BR")));

    Console.WriteLine();
  }
}
