using System;
class Aula12
{
    static void Main()
    {
        int n1, n2, n3, n4, total;
        n1 = n2 = n3 = n4 = total = 0;
        string resultado = "Reprovado";

        Console.Write("Digite sua Primeira Nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua Segunda Nota: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua Terceira Nota: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua Quarta Nota: ");
        n4 = int.Parse(Console.ReadLine());

        total = (n1 + n2 + n3 + n4) / 4;

        if (total >= 6)
        {
            resultado = "Aprovado";
        }
        Console.WriteLine("Nota: {0}\nResultado: {1}", total, resultado);

    }
}