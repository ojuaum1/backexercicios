

namespace POO
{
    public class Personagem
    {
        // declarar as propriedades
        //assinaturas tipo nome = valor 
        public string nome = "tony stark";

        public int idade = 35; 

        public string armadura ="bleeding edge";

        public string ia = "jarvis";

        public void atacar()
        {
            Console.WriteLine($"o personagem atacou!!");
            
        }
        public void defender ()
        {
            Console.WriteLine($"o personagem defendeu!");
            
        }
        public void restaurar()
        {
            Console.WriteLine($"o personagem restaurou a armadura!!");
            
        }
    }
}