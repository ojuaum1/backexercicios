// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"digite o ano que vc nasceu");
int nascimento = int.Parse (Console.ReadLine()) ;

if (nascimento<=2005)
{
    Console.WriteLine($"pode votar malandrinho");
    
}

else if (nascimento>=2006)
{
    Console.WriteLine($"ainda n pode votar");
    
}