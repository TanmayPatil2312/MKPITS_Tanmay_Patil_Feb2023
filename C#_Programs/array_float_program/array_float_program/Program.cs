using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_float_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            float[] floatArray = new float[3];
            floatArray[0] = 1.23f;
            floatArray[1] = 22.3f;
            floatArray[2] = 33.2f;
            foreach (float val in floatArray)
            {
                Console.WriteLine(" Float Value is  = " + val);
                Console.ReadKey();
            }
        }
    }
}

