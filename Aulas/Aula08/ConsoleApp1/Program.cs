using System;

class Aula08
{
    static void Main()
    {
        int n1, n2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite sua primeira nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        soma = n1 + n2;

        Console.WriteLine("O Aluno {0} tirou na primeira prova {1} e na segunda {2}, tendo o o total de {3}", nome, n1, n2, soma);
    }
}