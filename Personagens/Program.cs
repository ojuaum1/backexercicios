using POO;

Personagem p1 = new Personagem();

Console.WriteLine($"digite o nome do seu personagem");
p1.nome = Console.ReadLine();

Console.WriteLine($"digite a idade do seu personagem");
p1.idade = int.Parse (Console.ReadLine());

Console.WriteLine($"digite o nome do seu personagem");
p1.armadura = Console.ReadLine();

Console.WriteLine($"digite o nome da ia personagem");
p1.ia = Console.ReadLine();


Console.WriteLine(@$"
{p1.nome},
{p1.idade},
{p1.armadura},
{p1.ia}
");

p1.atacar();
p1.restaurar();
p1.defender();






 
