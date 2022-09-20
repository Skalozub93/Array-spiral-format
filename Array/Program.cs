using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] Array = new int[5, 5];

            int x = 0;
            int y = 0;
            int steps = 5;
            int g = 0;
            int c = 0;

            for (int i = 1; i <= 25; i++)
            {
                Array[x, y] = i;
                steps--;

                if (steps == 0)
                {
                    g++;

                    if (g == 4)
                        g = 0;

                    if (g == 1 || g == 3)
                        c++;

                    steps = 5 - c;
                }

                if (g == 0)
                    x++;
                if (g == 1)
                    y++;
                if (g == 2)
                    x--;
                if (g == 3)
                    y--;
                if (g == 4)
                    x++;
            }

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j <  Array.GetLength(1); j++)
                {
                    Console.Write(Array[i,j] + "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write("{0,4}", intArray1[i, j]);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();