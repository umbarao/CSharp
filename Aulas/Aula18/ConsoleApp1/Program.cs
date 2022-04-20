using System;
class Aula18 //MATRIZES
{
    static void Main()
    {
        int[,] n = new int[3, 5];
        int[,] m = new int[2, 2];

        Console.Write("Digite Indice[0,0]: ");
        m[0,0] = int.Parse(Console.ReadLine());
        Console.Write("Digite Indice[0,1]: ");
        m[0, 1] = int.Parse(Console.ReadLine());
        Console.Write("Digite Indice[1,0]: ");
        m[1, 0] = int.Parse(Console.ReadLine());
        Console.Write("Digite Indice[1,1]: ");
        m[1, 1] = int.Parse(Console.ReadLine());

        /*
         * 10 20 30 40 50
         * 60 70 80 90 15
         * 25 35 45 55 65
        */

        n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 30; n[0, 3] = 40; n[0, 4] = 50;
        n[1, 0] = 60; n[1, 1] = 70; n[1, 2] = 80; n[1, 3] = 90; n[1, 4] = 15;
        n[2, 0] = 25; n[2, 1] = 35; n[2, 2] = 45; n[2, 3] = 55; n[2, 4] = 65;

        Console.WriteLine("Valores da sua Matriz:\t\n{0} {1}\t\n{2} {3}\n", m[0, 0], m[0, 1], m[1, 0], m[1, 1]);
        Console.WriteLine("\n{0} {1} {2} {3} {4}\n{5} {6} {7} {8} {9}\n{10} {11} {12} {13} {14}", n[0, 0], n[0, 1], n[0, 2], n[0, 3], n[0, 4], n[1, 0], n[1, 1], n[1, 2], n[1, 3], n[1, 4], n[2, 0], n[2, 1], n[2, 2], n[2, 3], n[2, 4]);

    }
}
