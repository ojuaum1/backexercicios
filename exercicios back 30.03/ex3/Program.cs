// 3)

// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine("Digite as medidas dos lados do triângulo:");

Console.Write("Lado 1: ");
double lado1 = double.Parse(Console.ReadLine());

Console.Write("Lado 2: ");
double lado2 = double.Parse(Console.ReadLine());

Console.Write("Lado 3: ");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("Triângulo Isósceles");
}
else
{
    Console.WriteLine("Triângulo Escaleno");
}
