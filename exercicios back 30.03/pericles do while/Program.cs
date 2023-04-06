bool idadecerta = false;

do
{
    Console.WriteLine($"qual a idade do pericles ?");
    int idade = int.Parse (Console.ReadLine());
    
    if (idade == 53)
    {
        idadecerta = true;
    }
}
while (idadecerta == false);