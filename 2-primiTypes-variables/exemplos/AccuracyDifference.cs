using System;

class AccuracyDifference{
    static void Main(){
        // Declare some variables
        float floatPI = 3.141592653589793238f;
        double doublePI = 3.141592653589793238;
        // Print the results on the console
        Console.WriteLine("Float PI is: " + floatPI);
        Console.WriteLine("Double PI is: " + doublePI);

        // o tipo decimal é ideal para calculos financeiros, tem precisao de 28 casas decimais.
        decimal decimalPI = 3.14159265358979323846m;
        Console.WriteLine(decimalPI); // 3.14159265358979323846
        // Console output:
        // Float PI is: 3.141593 -->  7 digitos
        // Double PI is: 3.14159265358979 --> 15 digitos
    }
}