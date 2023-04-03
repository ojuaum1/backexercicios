   Console.Write("Digite a média do aluno: ");
        double media = double.Parse(Console.ReadLine());

        Console.Write("Digite a frequência do aluno (%): ");
        double frequencia = double.Parse(Console.ReadLine());

        if (frequencia < 75)
        {
            Console.WriteLine("Aluno REPROVADO por faltas.");
        }
        else if (media >= 7)
        {
            Console.WriteLine("Aluno APROVADO.");
        }
        else if (media >= 3)
        {
            Console.WriteLine("Aluno em RECUPERAÇÃO.");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO por média.");
        }
