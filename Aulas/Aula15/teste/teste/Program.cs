﻿using System;
class teste
{
    static void Main()
    {
        int click, saldo;
        click = saldo = 0;

        Console.WriteLine("Bem-Vindo ao Banco Suleste!!");
        Console.WriteLine("(1)Saldo\t(3)Extrato\n(2)Pagamento\t(4)Sair");
        click = int.Parse(Console.ReadLine());

        switch (click)
        {
            case 1:
                Console.WriteLine("Seu Saldo Disponível é R$ 2500,00");
                break;
            case 2:
                Console.WriteLine("Pagamento - Scaneie o código de barras para efetuar o pagamento");
                break;
            case 3:
                Console.WriteLine("Extrato do mês atual:\nR$ 50,00 - Supermercado filial\nR$ 33,25 - Barbearia ZK\nR$ 1,00 - KinderOvo\n...\n...\n...");
                break;
            case 4:
                Console.WriteLine("Retire seu Cartão");
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }
    }
}