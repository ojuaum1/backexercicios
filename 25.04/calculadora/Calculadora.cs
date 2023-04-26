using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora
{
    public class Calculadora
    {
         // propriedades
        public float n1;
        public float n2;

        
        // métodos
        public float Somar()
        {
            return  this.n1 + this.n2;
        }
        public float Subtrair()
        {
            return  this.n1 - this.n2;
        }
        public float Multiplicar()
        {
            return  this.n1 * this.n2;
        }
        public float Dividir()
        {
            return  this.n1 / this.n2;
        }
    }
}