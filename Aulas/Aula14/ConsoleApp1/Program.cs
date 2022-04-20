using System;
class Aula14
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

        if (total >= 6)
        {
            if (total >= 9)
            {
                if (total >= 9.9)
                {
                    resultado = "Aprovado com máximo de aproveitamento";
                }
                else
                {
                    resultado = "Aprovado com aproveitamento";
                }
            }
            else
            {
                resultado = "Aprovado";
            }
        }
        else
        {
            if (total >= 40)
            {
                resultado = "Recuperação";
            }
            else{
                resultado = "Reprovado";
            }
        }

        Console.WriteLine("Nota: {0}\nResultado: {1}", total, resultado);
    }
}