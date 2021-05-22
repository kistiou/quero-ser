using System;

namespace sequencia_até_50
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine("fizz");
                    if(i%9==0)
                {
                    Console.WriteLine("buzz");
                }
                    if(i%3==0 && i%9==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                }else
                {
                    Console.WriteLine(i);
                }
                
                
            }
            Console.ReadKey();
        }
    }
}
