using System;

class Age{
    static void Main(){
        Console.Write("Tell me your age: ");
        int age = int.Parse((Console.ReadLine()));
        age += 10;
        Console.WriteLine("You'll be "+age+"yo in 10 years!");
    }
}