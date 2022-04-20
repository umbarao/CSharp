using System;
class Aula17
{
    static void Main()
    {
        //int n1, n2, n3, n4, n5;
        //Arrays/Vetores (abaixo 3 tipos de Arrays/Vetores)
        int[] n = new int[5];
        int[] num = new int[3] { 111, 222, 333 };
        int[] val = { 111, 222, 333 };

        //Arrays/Vetores em Strings
        string[] veiculos = new string[3];

        veiculos[0] = "carro";
        veiculos[1] = "onibus";
        veiculos[2] = "avião";
        

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;

        Console.WriteLine(n[0]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num[1]);
        Console.WriteLine("Transportes Disponíveis: {0}, {1} e {2}", veiculos[0], veiculos[1], veiculos[2]);

    }
}