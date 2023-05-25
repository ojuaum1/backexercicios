using MVC_console.Model;
using MVC_console.View;


namespace MVC_console.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();


        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);
        }



    }
}