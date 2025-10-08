using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_One
{
    internal class _10_Solution
    {
        internal void sumDiagonal()
        {
            int i,j;
            int sumMain = 0;
            int sumSecondary = 0;
            int[,] matrix =
             {
            {1,2,3 },
            {4,5,6},
            {7,8,9 }
             };

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        sumMain += matrix[i,j];
                    }

                    if((i + j) == 2)
                    {
                        sumSecondary += matrix[i,j];
                    }
                }
            }

            Console.WriteLine("The sum of Left Diagonal is: " + sumMain);
            Console.WriteLine("The sum of Right Diagonal is: " + sumSecondary);
        }
    }
}
