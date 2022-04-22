using System;
class Ex1
{
    static void Main()
    {
        int[] num = new int[10];

        int i = 10;
        
        while(i > 0){ // 10 > 0 sim 9>0 sim ...... 0>0 nao o codigo para
            Console.WriteLine(i);

            i--;
        }

        Console.WriteLine("_________________");

        int[] num1 = new int[10]; // vetor num com tamanho 10
        int u = num1.Length; ; // variavel u recebeu o valor do tamanho tamanho do vetor num 
     
        while(u > 0) // u > 0; como foi declarado que u recebe valor  do tamanho do vetor a condição se aplica enquanto 10 for > 0, o laço se repete
        {
            Console.WriteLine(u); // vai printar na tela o valor de u até que o laço pare

            u--; // decremento - o valor de u vai diminuindo até que a condição seja satisfeita 0>0 'false'
        }
    }
}