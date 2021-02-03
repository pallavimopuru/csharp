using System;
 
namespace freshers
{
    class Increment
    {
        static void Main(string[] args)
        {
            int a=10;
            int b=50;
            int c= a+b;
            Console.WriteLine("Value of c is:"+c);
 
            Console.WriteLine("Value of c is:"+c);
 
            Console.WriteLine("value of a before applying increment operators:"+a);
 //increment pre increment
            ++a;
            Console.WriteLine("Value of a after preincrement is:"+a);
 //post increment
            a++;
            Console.WriteLine("Value of a after postincrement is:"+a);
 
            Console.WriteLine("value of a before applying decrement operators:"+a);
 //pre decrement
            --a;
            Console.WriteLine("Value of c after predecrement is:"+a);
 //post decrement
            a--;
            Console.WriteLine("Value of c after postdecrement is:"+a);
 
        }
    }
}
 
