using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Plaese inter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter n2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for(int x= n1 =5; x<=n2;x++ )
            {
             
                int j;
                for (j=2;j<x;j++)
                {
                    if (x % j == 0)
                    {
                        break;
                    
                    }
                    
                }
               if (j==x)
                    Console.WriteLine(x);
            }
            Console.ReadKey();


                
                
            
        }
    }
}
