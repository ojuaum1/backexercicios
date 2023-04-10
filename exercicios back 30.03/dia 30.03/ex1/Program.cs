 // 1) Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.Write($"qual é o seu salário rapaz: ");
float salário = float.Parse (Console.ReadLine());

Console.Write($"quanto você gastou safadão ?");
float gasto = float.Parse (Console.ReadLine());

float total = (salário - gasto);

if (gasto > salário )
{
    Console.WriteLine($"está quebrado:{total} R$ !");
    
}

else if (salário == gasto )
{
    Console.WriteLine($"está no limite: {total} R$");
}

else 
{
    Console.WriteLine($"ta sobrando ein: {total} R$");
    
}







