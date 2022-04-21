using System;
class Aula19 //ESTRUTURA DE REPETIÇÃO (FOR)
{
    static void Main()
    {
        /*int num;
        
        //for(variavel com valor inicial ; condição ; encremento/decremento(var++/var--)
        for (num = 1; num < 10; num++)
        {
            Console.WriteLine("{0} https://github.com/umbarao", num);
        }*/
        int[] num = new int[10];

        for(int i = 0; i < 10; i++)
        {
            num[i] = 0;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("O Valor de de num: {0}, Na posição: {1}", num[i], i);
        }

    }

}