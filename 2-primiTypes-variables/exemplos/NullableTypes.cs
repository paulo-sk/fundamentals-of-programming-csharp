using System;

class NullableTypes{
    static void Main(){
        
        //para declarar um tipo nulo, vc coloca ? dps do tipo de dado
        /*o tipo nulo é apenas uma forma de permitir que um tipo de dado
        int possa ter um valor nulo;
        tipos nulos sao tipos de referencia, e nao podem ser usados como tipos primitivos
        */
        int i = 5;
        int? ni = i;
        Console.WriteLine("ni = "+ni); // 5

        //i = ni; isso gera erro
        Console.WriteLine("ni.HasValue? "+ni.HasValue); //True
        i = ni.Value; //pra isso vc tem que ter certeza de que ni tem um valor nao nulo
        Console.WriteLine("Entao i = ni que eh: "+i); //5

        ni = null;
        Console.WriteLine("ni = null.");
        Console.WriteLine("ni.hasValue? "+ni.HasValue); // false
        //i = ni gera erro aqui, pois ni é null e int nao pode ter valor null
        i = ni.GetValueOrDefault(); //ou pega o valor de ni se tiver, ou recebe o valor default,que é zero
        Console.WriteLine("i = ni.GetValueOrDefault. = "+i); //0

        /*Nullable types are used for storing information, which is not mandatory. For
        example, if we want to store data for a student such as the first name and
        last name as mandatory and age as not required, we can use type int? for
        the age variable:
        */
        string name = "jhon";
        int? age = null;
        Console.WriteLine("name: "+name);
        Console.WriteLine("age: "+age);
    }
}