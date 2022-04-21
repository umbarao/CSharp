using System;
class exercicio1 //exercicio para mostrar valores na tela digitados pelo usuario em uma estrutura for
{
    static void Main()
    {
        int[] num = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.Write("Digite um numero: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Valores que você digitou na estrutura for: {0}", num[i]);
        }
    }
}