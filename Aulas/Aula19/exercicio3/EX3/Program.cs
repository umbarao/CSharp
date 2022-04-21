using System;
class Exercicio3
{
    static void Main()
    {
        string[] nomes = new string[3]; int[] n1 = new int[3]; int[] n2 = new int[3]; int[] soma = new int[3];
        string[] decisao = new string[3];

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nome do Aluno: ");
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Nota primeiro semestre: ");
            n1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota segundo semestre: ");
            n2[i] = int.Parse(Console.ReadLine());

            soma[i] = (n1[i] + n2[i]) / 2;

            if (soma[i] >= 7)
            {
                decisao[i] = "Aprovado!";
            }
            else
            {
                decisao[i] = "Reprovado!";
            }
        }
        
        Console.Clear();

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("--- NOTA DO ALUNO ---\nAluno: {0}\nMédia do Aluno: {1}\n{2}\n", nomes[i], soma[i], decisao[i]);
        }
    }
}