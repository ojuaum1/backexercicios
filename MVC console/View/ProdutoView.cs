using MVC_console.Model;

namespace MVC_console.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            foreach(var item in produto)
            {
                Console.WriteLine($"\ncodigo:{item.Codigo}");
                Console.WriteLine($"\nNome:{item.Nome}");
                Console.WriteLine($"\npreço:{item.preço:c}");
                
                
                
            }

        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"informe o codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"informe o nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"informe o preço: ");
            novoProduto.preço = float.Parse(Console.ReadLine());

            return novoProduto;
             
        }
    }
}