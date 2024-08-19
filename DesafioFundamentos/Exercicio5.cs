namespace DesafioFundamentos;

/* 1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, 
 * seguindo o padrão brasileiro válido até 2018:
 * - A placa deve ter 7 caracteres alfanuméricos;
 * - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
 * - Os quatro últimos caracteres são números;
 * Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário. */

public class Exercicio5
{
  public static void Executar()
  {
    Console.WriteLine("=== EXERCÍCIO 5 - VALIDAÇÃO PLACA VEÍCULO ===");
    Console.WriteLine();

    Console.Write("Digite a placa do veículo. Exemplo - 'AAA1234': ");
    string? placaVeiculo = Console.ReadLine();

    bool placaValida = ValidarPlaca(placaVeiculo);

    Console.WriteLine(String.Format("A placa digitada é {0}!", placaValida ? "VÁLIDA" : "INVÁLIDA"));
    Console.WriteLine();
  }

  private static bool ValidarPlaca(string placaVeiculo)
  {
    if (!(placaVeiculo.Length == 7)) return false;

    string placaPrimeiraParte = placaVeiculo.Substring(0, 3);
    string placaSegundaParte = placaVeiculo.Substring(3, 4);

    char caractere;

    for (int i = 0; i < placaPrimeiraParte.Length; i++)
    {
      caractere = placaPrimeiraParte[i];
      if (Char.IsDigit(caractere)) return false;
    }

    for (int i = 0; i < placaSegundaParte.Length; i++)
    {
      caractere = placaSegundaParte[i];
      if (Char.IsLetter(caractere)) return false;
    }

    return true;
  }
}
