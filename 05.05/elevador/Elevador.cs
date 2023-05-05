using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevador
{
    public class Elevadorzinho
    {
        public int pessoasEnt;
        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        public int pessoasPresentes;

        public void Elevador(int capacidade, int totalAndares)
        {
            this.andarAtual = 0;
            this.capacidade = capacidade;
            this.totalAndares = totalAndares;
            this.pessoasPresentes = 0;

        }

        public Elevadorzinho()
        {
        }

        public int getAndarAtual()
        {
            return this.andarAtual;
        }

        public void setAndarAtual(int andarAtual)
        {
            this.andarAtual = andarAtual;
        }

        public int getTotalAndares()
        {
            return this.totalAndares;
        }

        public void setTotalAndares(int totalAndares)
        {
            this.totalAndares = totalAndares;
        }

        public int getCapacidade()
        {
            return this.capacidade;
        }

        public void setCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public int getPessoasPresentes()
        {
            return this.pessoasPresentes;
        }

        public void setPessoasPresentes(int pessoasPresentes)
        {
            this.pessoasPresentes = pessoasPresentes;
        }

        public void entrar()
        {
            if (this.pessoasPresentes < this.capacidade)
            {
                // this.pessoasPresentes++;
                Console.WriteLine($"Entrou {this.pessoasEnt} no elevador");
            }
            else
            {
                Console.WriteLine("Não é possível entrar no elevador, capacidade máxima atingida");
            }
        }

        public void sair()
        {
            if (this.pessoasPresentes > 0)
            {
                this.pessoasPresentes--;
                Console.WriteLine("Saiu uma pessoa do elevador");
            }
            else
            {
                Console.WriteLine("Não há pessoas no elevador para sair");
            }
        }

        public void subir()
        {
            if (this.andarAtual < this.totalAndares)
            {
                this.andarAtual++;
                Console.WriteLine("O elevador subiu para o andar " + this.andarAtual);
            }
            else
            {
                Console.WriteLine("O elevador já está no último andar");
            }
        }

        public void descer()
        {
            if (this.andarAtual > 0)
            {
                this.andarAtual--;
                Console.WriteLine("O elevador desceu para o andar " + this.andarAtual);
            }
            else
            {
                Console.WriteLine("O elevador já está no térreo");
            }
        }
    }



}

