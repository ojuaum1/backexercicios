// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
int formula,contador;

Console.WriteLine($"digite a tabuada desejada(1 a 10):");
int numero = int.Parse (Console.ReadLine());

// contador
 for (contador = 1; contador <= 10; ++contador)
            {
                formula =  numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);
                
            }

