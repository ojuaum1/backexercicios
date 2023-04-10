// Uma certa empresa fez uma
// pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.    
// O número de pessoas que responderam SIM.

// B.    
// O número de pessoas que responderam NÃO;

// C.   
// O número de mulheres que responderam SIM;

// D.   
// A porcentagem de homens que responderam NÃO entre todos

// E.    
// os homens analisados.



// processamento
int sim = 0, nao = 0, mulheresSim = 0, mulheresNao=0, totalMulheres=0, homensNao = 0, homensSim= 0, totalHomens = 0;  double porcentagemhomemnao =0;
char sexo, resposta; 

for (int i = 1; i <= 3; i++)
{
    Console.Write(@$"Digite o sexo da pessoa 
    (M)masculino 
    (F)feminino: ");
    sexo = char.Parse(Console.ReadLine().ToUpper());

    Console.Write(@$"A pessoa gostou do produto? 
    (S)sim 
    (N)nao: ");
    resposta = char.Parse(Console.ReadLine().ToUpper());

    if (resposta == 'S')
    {
        sim++;

        if (sexo == 'F')
        {
            mulheresSim++;
            totalMulheres++;
        }
        else if (sexo == 'M')
        {
           homensSim++;
            totalHomens++;
        }
    }
    else if (resposta == 'N')
    {
        nao++;

        if (sexo == 'F')
        {
           mulheresNao++;
            totalMulheres++;
        }
        else if (sexo == 'M')
        {
           homensNao++;
            totalHomens++;
        }
    }

    // Console.WriteLine(homensNao/totalHomens*100);
    // float porcentagem = float.Parse (Console.ReadLine());
   
} porcentagemhomemnao = Math.Round (((double)homensNao/(double)totalHomens)*100,2);
Console.WriteLine($"quantidade de sim {sim}");
Console.WriteLine($"quantidade de nao {nao}");
Console.WriteLine($"mulheres que falaram sim {mulheresSim}");
Console.WriteLine($"mulheres que falaram nao {mulheresNao}");
Console.WriteLine($"total de mulheres {totalMulheres}");
Console.WriteLine($"homens que falaram sim {homensSim}");
Console.WriteLine($"homens que falaram não {homensNao}");
Console.WriteLine($"total de homens {totalHomens}");


Console.WriteLine($"porcentagem de homens que responderam não {porcentagemhomemnao}%");
