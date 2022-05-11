using System;
class Aula25
{
    static void Main()
    {
        int num = 0;
        int num2 = 0;
        int num4 = 0;
        int chamar = 0;


        Console.WriteLine("Digite um valor: ");
        chamar = int.Parse(Console.ReadLine());
        multiplicar(ref chamar);
        Console.WriteLine("O Resultado da Multiplicação é: {0}", chamar);

        Console.WriteLine("Digite um valor: ");
        num = int.Parse(Console.ReadLine());
        dobrar(ref num);
        Console.WriteLine("O Resultado do Dobro é: {0}", num);

        Console.WriteLine("Digite um valor: ");
        num2 = int.Parse(Console.ReadLine());
        somar(ref num2);
        Console.WriteLine("O Resultado da Soma é: {0}", num2);

        Console.WriteLine("Digite um valor: ");
        num4 = int.Parse(Console.ReadLine());
        divisao(ref num4);
        Console.WriteLine(num4);
        Console.WriteLine("O Resultado da Divisão é: {0}", num4);

    }
    static void dobrar(ref int valor)
    {
        valor *= 2;
    }

    static void somar(ref int valor1)
    {
        valor1 = valor1 + valor1;
    }
    
    static void multiplicar(ref int valor2)
    {
        valor2 = valor2 * valor2;
    }

    static void divisao(ref int valor3)
    {
        valor3 = valor3 / valor3;
    }
}
