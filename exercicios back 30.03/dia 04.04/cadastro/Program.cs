//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));




// entrada
Console.WriteLine($"bem vindo ao nosso sistema de cadastro");
Console.WriteLine($"precisamos de algumas informações, vamos lá ?");


Console.Write(@$"digite seu nome: ");
string nome = Console.ReadLine();

Console.Write(@$"digite sua idade (entre 0 e 100): ");
int idade = int.Parse(Console.ReadLine());

Console.Write($"digite seu salario (maior que zero): ");
float salario = float.Parse(Console.ReadLine());

Console.Write(@$"digite seu estado civil 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)) :");
char civil = char.Parse(Console.ReadLine());




// processamento
while (nome.Length == 0)
{
    Console.WriteLine($"digite seu nome novamente");
    nome = Console.ReadLine();

}

while (idade <= 0 || idade >= 100)
{
    Console.WriteLine($"digite sua idade novamente");
    idade = int.Parse(Console.ReadLine());


}

while (salario <= 0)
{
    Console.WriteLine($"digite seu salario");
    salario = float.Parse(Console.ReadLine());


}

while (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.WriteLine($"digite seu estado civil novamente");
    civil = char.Parse(Console.ReadLine());


}


// saida

Console.WriteLine($"cadastro feito");
