using System; 
class Aula26
{
    static void Main()
    {
        int divid, divis, quoc, rest;
        divid = 0;
        divis = 0;

        Console.WriteLine("***CALCULO DE DIVISÂO***");

        Console.Write("Digite o Dividendo: ");
        divid = int.Parse(Console.ReadLine());

        Console.Write("Digite o Divisor: ");
        divis = int.Parse(Console.ReadLine());

        quoc = divide(divid, divis, out rest);

        Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", divid, divis, quoc, rest);
    }
    
    static int divide(int dividendo, int divisor, out int resto)
    {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;

    }
}