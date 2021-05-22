using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {


            int [,] n=new int [1,5];
           n[0,0]=1;    
           n[0,1]=5;
           n[0,2]=1;
           n[0,3]=1;
           n[0,4]=1;
            int [,] n2=new int [1,5];
           n2[0,0]=1;
           n2[0,1]=5;
           n2[0,2]=1;
           n2[0,3]=1;
           n2[0,4]=1;
            int [,] n3=new int [1,5];
           n3[0,0]=1;
           n3[0,1]=5;
           n3[0,2]=1;
           n3[0,3]=1;
           n3[0,4]=1;
            int [,] n4=new int [1,5];
           n4[0,0]=1;
           n4[0,1]=5;
           n4[0,2]=1;
           n4[0,3]=1;
           n4[0,4]=1;
            int [,] n5=new int [1,5];
           n5[0,0]=1;
           n5[0,1]=5;
           n5[0,2]=1;
           n5[0,3]=1;
           n5[0,4]=1;

           
            
                int sequencia = n[0,1]*n2[0,1]*n3[0,1]*n4[0,1]*n5[0,1];
                Console.WriteLine("a sequencia dos valores iguais é: " + sequencia);
        
            


        }
    }
}
