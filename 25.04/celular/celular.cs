using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular
{
    public class celular
    {
        public string cor;
    public string modelo;
    public double tamanho;
    public bool ligado;

  

    public void ligar() {
        if (!this.ligado) {
            this.ligado = true;
            Console.WriteLine("Celular ligado.");
        } else {
            Console.WriteLine("O celular já está ligado.");
        }
    }

    public void desligar() {
        if (this.ligado) {
            this.ligado = false;
            Console.WriteLine("Celular desligado.");
        } 
        else {
            Console.WriteLine("O celular já está desligado.");
        }
    }

    public void fazerLigacao() {
        if (this.ligado) {
            Console.WriteLine($"Fazendo ligação para o número ********...");
        } 
        else 
        {
         Console.WriteLine($"Não é possível fazer ligação com o celular desligado");
            
        }
    }

    public void enviarMensagem() {
        if (this.ligado) {
            Console.WriteLine($"Enviando mensagem para o número *********");
        } 
        else {
            Console.WriteLine($"Não é possível enviar mensagem com o celular desligado");
            
        }
    }
    }
}