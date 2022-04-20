using System;
class Aula13
{
    static void Main()
    {
        int n1, n2, n3, n4, total;
        total = n1 = n2 = n3 = n4 = 0;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        total = (n1 + n2 + n3 + n4) / 4;

        if(total < 4)
        {
            resultado = "Reprovado";
        }
        else if (total  < 6)
        {
            resultado = "Recuperação";
        }
        else
        {
            resultado = "Aprovado";
        }
        Console.WriteLine("Nota: {0}\nResultado: {1}", total, resultado);
    }
}