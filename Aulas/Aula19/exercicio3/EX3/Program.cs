using System;
class Exercicio3
{
    static void Main()
    {
        string aluno = ""; int n1 = 0, n2 = 0, soma=0;

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nome do Aluno: ");
            aluno = Console.ReadLine();
            Console.WriteLine("Nota primeiro semestre: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota segundo semestre: ");
            n2 = int.Parse(Console.ReadLine());

            soma = (n1 + n2) / 2;
        }

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Aluno: {0}\nMédia do Aluno: {1}", aluno, soma);
        }
    }
}