

Console.WriteLine($"digite seu nome de usuario");
string usuario = (Console.ReadLine());

Console.WriteLine($"digite sua senha");
string senha = (Console.ReadLine());

 while(usuario == senha)
    {
        Console.WriteLine($" senha incorreta digite sua senha novamente");
        senha = (Console.ReadLine());
        
    }

    Console.WriteLine($"parabens acesso permitido");
    