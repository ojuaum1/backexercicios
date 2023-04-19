// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.




    string[] Nome =new string[10];
    float[] Preco= new float[10];
    bool[] Promocao = new bool[10];
string[]ListarProdutos= new string[10]:

for (var i = 1; i < 10; i++)
{
    Console.WriteLine($"digite o produto que gostaria de cadastrar");
Nome[i] = Console.ReadLine();

Console.WriteLine($"digite o preco ");
Preco[i] =float.Parse (Console.ReadLine());

Console.WriteLine($"o produto está em promocao? s/n ");
Promocao[i] = bool.Parse (Console.ReadLine());

Console.WriteLine($"\nProduto '{nome}' cadastrado com sucesso.");
}



         
           static void ListarProdutos() {
          Console.WriteLine("\nProdutos cadastrados:");
Console.WriteLine($"Text");

      }

      public void MostrarMenu() {
          Console.WriteLine("\n=== Menu ===");
          Console.WriteLine("1 - Cadastrar produto");
          Console.WriteLine("2 - Listar produtos");
          Console.WriteLine("0 - Sair do programa");
      }

      public void Executar() {
          while (true) {
              MostrarMenu();

              Console.Write("\nDigite a opção desejada: ");
              string opcao = Console.ReadLine();

              switch (opcao) {
                  case "1":
                      CadastrarProduto();
                      break;
                  case "2":
                      ListarProdutos();
                      break;
                  case "0":
                      Console.WriteLine("\nEncerrando o programa...");
                      return;
                  default:
                      Console.WriteLine("\nOpção inválida. Por favor, tente novamente.");
                      break;
              }
          }
      }
  }

  class Program {
      static void Main(string[] args) {
          GerenciadorProdutos gerenciador = new GerenciadorProdutos();
          gerenciador.Executar();
      }
  }


