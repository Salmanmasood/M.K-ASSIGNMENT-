using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class1
    {

      
        public void processmethod(int[] z, int logicalsize, int iz, int zi, int quantum, int phyicalsize,int zflag)
        {

            if (iz + zi <= logicalsize)
            {
                for (int i = iz; i < zi; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("process z is running...with quantum of {0} second and process # {1}", (i + 1), z[i]);
                }
                zi = zi + quantum;
                iz = iz + quantum;
                phyicalsize = phyicalsize + quantum;
            }
            else if (zflag == 0)
            {
                int help = 0;
                for (int i = iz; i < logicalsize; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("process z is running...with quantum of {0} second and process # {1}", (i + 1), z[i]);
                    help++;
                }
                phyicalsize = phyicalsize + help;
                zflag = 1;
            }
         
        }




    }
}
