using System;

class FloatTypes{
    static void Main(){

        float floatPI = 3.14f;
        Console.WriteLine(floatPI); 
        
        double doublePI = 3.14;
        Console.WriteLine(doublePI);

        double nan = Double.NaN;
        Console.WriteLine(nan);

        double infinity = Double.NegativeInfinity;
        Console.WriteLine(infinity);
    }
}