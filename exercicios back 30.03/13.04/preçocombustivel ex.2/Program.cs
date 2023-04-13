// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


class Program {
  static void Main(string[] args) {
    // Definir preço por litro para cada tipo de combustível
    const double PRECO_GASOLINA = 5.30;
    const double PRECO_ALCOOL = 4.90;

    // Ler o número de litros e o tipo de combustível
    Console.WriteLine("Digite o número de litros vendidos:");
    double litros = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o tipo de combustível (A-álcool, G-gasolina):");
    char combustivel = char.Parse(Console.ReadLine().ToUpper());

    // Calcular desconto de acordo com o número de litros
    double desconto = 0;
    if (litros <= 20) {
      switch (combustivel) {
        case 'A':
          desconto = 0.03;
          break;
        case 'G':
          desconto = 0.04;
          break;
        default:
          Console.WriteLine("tipo de combustível inválido.");
          return;
      }
    } else {
      switch (combustivel) {
        case 'A':
          desconto = 0.05;
          break;
        case 'G':
          desconto = 0.06;
          break;
        default:
          Console.WriteLine("combustivel de combustível inválido.");
          return;
      }
    }

    // Calcular valor a ser pago pelo cliente com desconto
    double precoPorLitro = combustivel == 'A' ? PRECO_ALCOOL : PRECO_GASOLINA;
    double valorSemDesconto = litros * precoPorLitro;
    double valorComDesconto = valorSemDesconto - (valorSemDesconto * desconto);

    // Imprimir valor a ser pago pelo cliente
    Console.WriteLine("Valor a ser pago: R$ {0:F2}", valorComDesconto);
  }
}