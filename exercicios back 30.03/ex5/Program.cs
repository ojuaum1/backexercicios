Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double valor;

        if (quantidade < 12)
        {
            valor = quantidade * 0.3;
        }
        else
        {
            valor = quantidade * 0.25;
        }

        Console.WriteLine("Valor total da compra: R$ " + valor.ToString("F2"));
    