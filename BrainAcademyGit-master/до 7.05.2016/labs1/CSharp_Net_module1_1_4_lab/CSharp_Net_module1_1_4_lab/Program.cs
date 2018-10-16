using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType { type1 };

        // 2) declare struct Computer
        struct Computer
        { }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            int[][] jagged_array = new int[4][];

            // 4) set the size of every array in jagged array (number of computers)
            for (int i =0; i <4; i++)
            {
                if (i % 2 == 0)
                { jagged_array[i] = new int[2]; }
                else
                { jagged_array[i] = new int[3]; }
            }
            

            // 5) initialize array
            // Note: use loops and if-else statements
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 2; j++)
                    { jagged_array[i][j] = 2; }
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    { jagged_array[i][j] = 3; } 
                }
            }

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

 

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


                // 10) make desktop upgrade: change memory up to 8
                // change value of memory to 8 for every desktop. Don't do it for other computers
                // Note: use loops and if-else statements

        }
 
    }
}
