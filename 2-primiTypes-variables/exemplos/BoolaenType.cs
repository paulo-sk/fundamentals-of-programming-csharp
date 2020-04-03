using System;

class BooleanType {
    static void Main(){
        int a = 3;
        int b = 2;

        //which one is greater?
        bool greaterAB = (a > b);
        //is 'a' equal 1?
        bool equalA1 = (a == 1);

        if(greaterAB){
            Console.WriteLine("A > B.");
        }
        else
        {
            Console.WriteLine("A <= B");
        }

        Console.WriteLine("greaterAB = "+ greaterAB);
        Console.WriteLine("equalA1 = "+ equalA1);
    }
}