using System;
class exercicio2
{
    static void Main()
    {
        string nome = "", cpf = "", nasc = "", cep = ""; int click;

        inicio:

        Console.Clear();

        Console.WriteLine("-------------------------------------\nPONTO GRAFICO COMPUTACAO GRAFICA LTDA\n---Cadastro de Clientes---\n-------------------------------------");
        Console.WriteLine("Menu Principal\n-------------------------------------");
        Console.WriteLine("1 - Cadastrar Cliente\n2 - Consultar Cliente\n3 - Numero de Clientes");
        click = int.Parse(Console.ReadLine());

        switch (click)
        {
            case 1:
                Console.WriteLine("Vamos criar seu cadastro!");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("CPF(000.000.000-00): ");
                cpf = Console.ReadLine();
                Console.Write("Data de Nascimento(_/_/_): ");
                nasc = Console.ReadLine();
                Console.Write("CEP(00000-000): ");
                cep = Console.ReadLine();
                break;

            case 2:
                Console.WriteLine("--------------------\nDADOS DO CLIENTE \n{0}\n--------------------", nome);
                Console.WriteLine("NOME: {0}\nCPF: {1}\nDATA DE NASCIMENTO: {2}\nCEP: {3}", nome, cpf, nasc, cep);


                break;
        }

        Console.WriteLine("Você gostaria de continuar?\nSIM[1]\tNÃO[2]");
        click = int.Parse(Console.ReadLine());

        if(click == 1)
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.Write("Fim da Operação");
        }

        

    }

}