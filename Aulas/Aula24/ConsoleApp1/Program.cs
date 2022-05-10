using System;
class Aula24
{
    static void Main()
    {
        int v1, v2;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());
        soma(v1,v2); 
    }

    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
        
    }
}