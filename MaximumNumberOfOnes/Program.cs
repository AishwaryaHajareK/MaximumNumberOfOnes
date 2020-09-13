using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfOnes
{
    //Code complexity of this code is O(n) as it is scanning the whole array and comparing the 1's
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int maxCount = 0;
            int rowWithMaxCount = 0;
            
            Console.WriteLine("Enter the number of Rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the number of Columns:");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            var matrix = new int[rows, columns];

            Console.Write("Enter the matrix elements:\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
            }
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<columns; j++)
                {
                    if(matrix[i,j] == 1)
                    {
                        count++;
                    }
                }
                if(maxCount < count)
                {
                    maxCount = count;
                    rowWithMaxCount = i;
                }
                count = 0;
            }

            Console.WriteLine("\n\nRow with maximum 1's is {0}", rowWithMaxCount+1);
            Console.ReadKey();
        }
    }
}
