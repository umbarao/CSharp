using System;
class Aula14
{
    static void Main()
    {
        int n1, n2, n3, n4, total;
        total = n1 = n2 = n3 = n4 = 0;
        string res;

        Console.Write("Digite sua primeira Nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua segunda Nota: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua terçeira Nota: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua quarta Nota: ");
        n4 = int.Parse(Console.ReadLine());

        total = (n1 + n2 + n3 + n4) / 4;

        if (total >= 6)
        {
            if (total >= 9)
            {
                if (total >= 10)
                {
                    res = "Aprovado com máximo de aproveitamento";
                }
                else
                {
                    res = "Aprovado com aproveitamento";
                }
            }
            else
            {
                res = "Aprovado";
            }
        }
        else
        {
            if (total >= 4)
            {
                res = "Recuperação";

            }
            else
            {
                res = "Reprovado";
            }
        }

            Console.WriteLine("Nota:{0}\nResultado:{1}", total, res);



    }
}