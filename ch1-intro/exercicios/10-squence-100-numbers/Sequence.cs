using System;

class Sequence{
    static void Main(){
        int x = 2;
        while(x <= 102){

            if (x % 2 != 0){
                
                x *= -1;
                Console.WriteLine(x);
                x = x*-1 + 1;
            }
            else {
                Console.WriteLine(" "+x);
                x += 1;    
            }
                
        }
    }
}