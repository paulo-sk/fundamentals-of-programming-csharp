using System;

class IntegerType {
    static void Main(){

        //declare some variables
        byte centuries = 20;
        ushort years = 200;
        uint days = 730480;
        ulong hours = 17531520;

        //Print the resul on the console
        Console.WriteLine(centuries+" centuries are "+ years + " years, or "+days+" days or "+hours+ " hours. ");

        ulong maxIntValue = UInt64.MaxValue;
        Console.WriteLine(maxIntValue);

        Console.writeLine("--------------------------------\n")

        //float = 0.0f defalt value
        //float tem um range de 7 digitos decimais.
        //32-bit
        //se vc colocar um valor de 0.123456789 em um float, ele será arredondado para 0.1234568

        //abstraçoes matemática:
        // -1.0f / 0f = negative infinity (Single.NegativeInfinity)
        // 1.0f / 0.0f  = positive infinity (Single.PositiveInfinity)
        // 0.0f / 0.0f = Uncertainty (Single.NaN), isso significa que a operaçao nao é valida, assim tambem como tentar
        //calcular raiz de numero negativo
        
    }
}