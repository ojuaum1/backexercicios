// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else

// entrada

    // definir preco
const double PrecoSalgadinho = 10.90;
const double PrecoBolacha = 5.00;
const double PrecoMacarrao = 12.00;

Console.WriteLine(@$"
---------------------------------------------------
|              informe o produto que deseja        |
| 'S' salgadinho  preço  R$10,90                   | 
| 'M' Macarrao    preço  R$12,00                   | 
| 'B' bolacha     preço  R$ 5,00                   |
---------------------------------------------------
");
char produto = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"quantas unidades deseja ?");
int unidades = int.Parse (Console.ReadLine());

if(produto == 'S')
{
Console.WriteLine($"total de gasto = {PrecoSalgadinho * unidades}");
}
if(produto == 'M')
{
Console.WriteLine($"total de gasto = {PrecoMacarrao * unidades}");
}
if(produto == 'B')
{
Console.WriteLine($"total de gasto = {PrecoBolacha * unidades}");
}

if(unidades>=5){
    Console.WriteLine($"desconto de {produto*0.02}");
    
}
if(unidades<=10){
    Console.WriteLine($"desconto de {produto*0.03}");
    
}
if(unidades>10){
    Console.WriteLine($"desconto de {produto*0.05}");
    
}

