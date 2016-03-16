using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0, a = 0;
            int q ;
            int[] z = new int[10];
            int[] y = new int[10];
            //int[] z = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] y = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 10 };
            Console.WriteLine("----How many numbers you want in your ARRAY1!!!!----");
            int array1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < array1; i++)
            {
                Console.Write("Enter No #"+(i + 1) + " =");
                z[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("----How many numbers you want in your ARRAY2!!!!----");
            int array2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < array2; i++)
            {
                Console.Write("Enter No #" + (i + 1) + " =");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("----------How many Quantum you want-----------");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine();

        l1:

            

            for (int i = r; i < q; i++)
            {
               
                if (i<array1)
                {

                   
                    Console.Write(z[i]+",");
                    r = i + 1;
                    
                }
                    
                 
                else
                {
                    break;
                }

                Console.WriteLine("..............from array 1");
                Console.WriteLine();
            }
        

                for (int i = a; i < q; i++)
                {
                    if (i<array2)
                    {
                        
                        Console.Write(y[i]+",");
                        a = i + 1;
                        
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine("--------------from array 2");
                    Console.WriteLine();
                }
               
                q = q + q;
                goto l1;
                Console.ReadLine();
        }
    }
}