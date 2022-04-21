using System;
class Exercicio3 //CALCULO MÉDIA DOS ALUNOS
{
    static void Main()
    {
        
        int qtd =0;


        Console.Write("Quantidade de Alunos: ");
        qtd = int.Parse(Console.ReadLine());

        string[] nomes = new string[qtd]; int[] n1 = new int[qtd]; int[] n2 = new int[qtd]; int[] soma = new int[qtd];
        string[] decisao = new string[qtd];

        for (int i = 0; i < qtd; i++)
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

        Console.WriteLine("NOTA DO(S) {0} ALUNO(S)", qtd);

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("----------------\nAluno: {0}\nMédia do Aluno: {1}\n{2}\n----------------\n", nomes[i], soma[i], decisao[i]);
        }
    }
}