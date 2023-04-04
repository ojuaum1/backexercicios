// entrada
Console.WriteLine(@$"
 ----------------------------------------------------
|                 Programa caculadora                |
| Informe a operaçào matematica que deseja efetuar:  |
| '+'                                                |            
| '-'                                                | 
| '*'                                                |
| '/'                                                | 
 ---------------------------------------------------
");

char operação = char.Parse (Console.ReadLine());

// entrada do primeiro numero 
Console.WriteLine($"digite o primeiro numero");
float numero1 = float.Parse (Console.ReadLine());

// entrada do segundo numero 
Console.WriteLine($"digite o primeiro numero");
float numero2 = float.Parse (Console.ReadLine());

// declarado variavel que receberá o resultado
float resultado = 0;

// processamento
switch (operação)



{
    case '+';
    resultado = (numero1 + numero2)
    Console.WriteLine($"o resultado da soma é {resultado}");
    break;

    case '-';
    resultado = (numero1 - numero2)
    Console.WriteLine($"o resultado da soma é {resultado}");
    
    case '+';
    resultado = (numero1 * numero2)
    Console.WriteLine($"o resultado da soma é {resultado}");
    
    case '+';
    resultado = (numero1 / numero2)
    Console.WriteLine($"o resultado da soma é {resultado}");
    
}



// saida