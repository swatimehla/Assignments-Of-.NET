using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Jagged_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Array in C# ");
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[3] { 1, 2, 3 };
            jaggedArr[1] = new int[4] { 2, 4, 6, 8 };
            jaggedArr[2] = new int[2] { 3, 6 };

            //for printing Elements of Jagged Array
            for(int i=0;i<jaggedArr.Length;i++)
            {
                Console.Write("\nElements of Jagged Array at Index {0} : ", i);
                for(int j=0;j<jaggedArr[i].Length;j++)
                {
                    Console.Write(jaggedArr[i][j]);
                }
            }

            //another way of Initiaizing Jagged array
            int[][] jaggedArr2 =
            {
                new int[] {4,8,12,16},
                new int[]{5,10,15},
                new int[]{6,12}
            };

             for(int i=0;i<jaggedArr2.Length;i++)
            {
                Console.Write("\nElements Of JAgged Array2 at Index {0} : ", i);
                for (int j = 0; j < jaggedArr2[i].Length; j++)
                {
                    Console.Write(jaggedArr2[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
