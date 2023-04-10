// entrada
Console.WriteLine($"qual tabuada gostaria de saber ");

int tabuada = int.Parse (Console.ReadLine());
 ;

// processamento
for (var i = 1; i <=10 ; i++)
{
    Console.WriteLine($"{tabuada} x {i}= ({tabuada*i})");
    
}
