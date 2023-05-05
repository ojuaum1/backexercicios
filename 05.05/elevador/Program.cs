using Elevador;
Elevadorzinho elevadorzinho = new Elevadorzinho();


Console.WriteLine(
                        @"O que você quer realizar?
                    1 - Entrar
                    2 - Sair
                    3 - Subir
                    4 - Descer");
string opcaoElevador = Console.ReadLine();

switch (opcaoElevador)
{
    case "1":
    Console.WriteLine($"qualandar está ?");
    elevadorzinho.andarAtual = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"qual é a capacidade do elevador? ");
    elevadorzinho.capacidade = int.Parse(Console.ReadLine());
    
        Console.WriteLine("Quantas pessoas entraram?");
        elevadorzinho.pessoasEnt = int.Parse(Console.ReadLine());
        elevadorzinho.entrar();
        break;
    case "2":
        Console.WriteLine("Quantas pessoas sairam?");
        int pessoassairam = int.Parse(Console.ReadLine());
        elevadorzinho.sair();
        break;
    case "3":
        Console.WriteLine("Qual andar?");
        int subiram = int.Parse(Console.ReadLine());
        elevadorzinho.subir();
        break;
    case "4":
        Console.WriteLine("qual andar ?");
        int descer = int.Parse(Console.ReadLine());
        elevadorzinho.descer();
        break;
}


