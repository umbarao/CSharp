using System;
class Aula11
{
    static void Main()
    {
        /*int n1 = 10; conversão não explicita
        float n2 = n1;*/

        /*float n1 = 10.5f; conversão explicita (typecast)
        int n2 = (int)n1;*/

        int vInt = 10;
        short VShort = (short)vInt;
        Console.WriteLine(VShort);
    }
}