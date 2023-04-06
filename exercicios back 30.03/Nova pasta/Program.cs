//entrada
Console.WriteLine($"digite seu nome: ");
int nome = int.Parse (Console.ReadLine());

Console.WriteLine($"digite seu nome: ");
int idade = int.Parse (Console.ReadLine());

Console.WriteLine($"digite seu peso: ");
float peso = float.Parse (Console.ReadLine());

Console.WriteLine($"digite sua altura: ");
float altura = float.Parse (Console.ReadLine());




//processamento
float imc = peso / (altura * altura);

//saída
Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));

