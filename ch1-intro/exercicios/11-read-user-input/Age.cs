using System;

class Age{
    static void Main(){
        Console.Write("Tell me your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        age += 10;
        Console.WriteLine("You'll be "+age+"yo in 10 years!");
    }
}