using System;
class Aula20
{
    static void Main()
    {
        int[] num = new int[10];
        int i = 0;

        while (i<num.Length)
        {
            num[i] = 0;
            Console.WriteLine("@umbarao");
            i++;
        }
        Console.WriteLine("Fim do Loop");
    }
}