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
                Console.Write("\nEnter No #"+(i + 1) + " =");
                z[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("----How many numbers you want in your ARRAY2!!!!----");
            int array2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < array2; i++)
            {
                Console.Write("\nEnter No #" + (i + 1) + " =");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("----------How many Quantum you want-----------");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int x = array1 + array2;
            int zi = 3;
            int yi = 3;
           int iz = 0,iy=0;
           int arr = 0, arr2 = 0,yflag=0,zflag=0;
            l1:

           if (iz+zi<=array1)
           {
               for (int i = iz; i < zi; i++)
               {
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine("process z is running...with quantum of {0} second and process # {1}", (i + 1), z[i]);
               }
               zi = zi + 3;
               iz = iz + 3;
               arr = arr + 3;
           }
           else if(zflag==0)
           {
               int help=0;
               for (int i = iz; i < array1; i++)
               {
                     Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine("process z is running...with quantum of {0} second and process # {1}", (i + 1), z[i]);
                   help++;
               }
               arr = arr + help;
               zflag = 1;
           }
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("process changed....");
           
            if (iy+yi<=array2)
            {
                for (int j = iy; j < yi; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("process y is running...with quantum of {0} second and process # {1}", (j + 1), y[j]);
                
                }
                yi = yi + 3;
                iy = iy + 3;
                arr2 = arr2 + 3;
            }

            else if(yflag==0)
            {
                int help2 = 0;
                for (int j = iy; j < array2; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("process y is running...with quantum of {0} second and process # {1}", (j + 1), y[j]);
                    help2++;
                }
                arr2 = arr2 + help2;
                yflag = 1;
            }
        
            if ((arr+arr2)<(array1+array2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("process changed....");
                goto l1;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("process END....");
                Console.ReadLine();
        }

        
    }
}