using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_console.Model
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float preço { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; //database

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
        public List<Produto> Ler()
        {
            //intaciar lista

            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                //antes do split
                //001:coca;6,50

                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Codigo= int.Parse(atributos[0]);
                p.Nome= atributos[1];
                p.preço = float.Parse(atributos[2]);//6.50

                produtos.Add(p);
            }
            return produtos;

            
        }

        public string PreparaLinhaCSV(Produto p) 
        {
            return $"{p.Codigo};{p.Nome};{p.preço}";
            
        }

        public void Inserir(Produto p)
        {
            string[] linhas = {PreparaLinhaCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }

        


    }

}