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
        enum ComputerType { desktop, laptop, server };

        // 2) declare struct Computer
        struct Computer
        {
            public int cores;
            public double frequency;
            public int memory;
            public int HDD;
            public ComputerType type;
        }

        static void Main(string[] args)
        {
            Computer Desctop_comp = new Computer();
            Desctop_comp.cores = 4;
            Desctop_comp.frequency = 2.5;
            Desctop_comp.memory = 6;
            Desctop_comp.HDD = 500;
            Desctop_comp.type = ComputerType.desktop;
            Computer Laptop_comp = new Computer();
            Laptop_comp.cores = 2;
            Laptop_comp.frequency = 1.7;
            Laptop_comp.memory = 4;
            Laptop_comp.HDD = 250;
            Laptop_comp.type = ComputerType.laptop;
            Computer Server_comp = new Computer();
            Server_comp.cores = 8;
            Server_comp.frequency = 3;
            Server_comp.memory = 16;
            Server_comp.HDD = 2000;
            Server_comp.type = ComputerType.server;
            // 3) declare jagged array of computers size 4 (4 departments)
            int[][] comp_num = new int[4][];

            // 4) set the size of every array in jagged array (number of computers)
            comp_num[0] = new int[3] { 2, 4, 1 };
            comp_num[1] = new int[3] { 5, 0, 0 };
            comp_num[2] = new int[3] { 0, 7, 0 };
            comp_num[3] = new int[3] { 2, 4, 3 };
            // 5) initialize array
            // Note: use loops and if-else statements
            

            // 6) count total number of every type of computers
            int desc_count = 0, lap_count= 0, srv_count = 0;
            for (int i = 0; i < 4; i++)
            {
                desc_count += comp_num[i][0];
                lap_count += comp_num[i][0];
                srv_count += comp_num[i][0];
            }
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            int total_count=0;
            total_count = desc_count + lap_count + srv_count;

 

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            int largest_HDD = -1;
            ComputerType largest_type = 0;
            if (largest_HDD < Desctop_comp.HDD)
            {
                largest_HDD = Desctop_comp.HDD;
                largest_type = Desctop_comp.type;
            }
            if (largest_HDD < Laptop_comp.HDD)
            {
                largest_HDD = Laptop_comp.HDD;
                largest_type = Laptop_comp.type;
            }
            if (largest_HDD < Server_comp.HDD)
            {
                largest_HDD = Server_comp.HDD;
                largest_type = Server_comp.type;
            }
            Console.WriteLine(largest_type + " has largest HDD");
            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            int lowest_CPU = 100;
            ComputerType lowest_CPU_type = 0;
            if (lowest_CPU > Desctop_comp.cores)
            {
                lowest_CPU = Desctop_comp.cores;
                lowest_CPU_type = Desctop_comp.type;
            }
            if (lowest_CPU > Laptop_comp.cores)
            {
                lowest_CPU = Laptop_comp.cores;
                lowest_CPU_type = Laptop_comp.type;
            }
            if (lowest_CPU > Server_comp.cores)
            {
                lowest_CPU = Server_comp.cores;
                lowest_CPU_type = Server_comp.type;
            }
            Console.WriteLine(lowest_CPU_type + " has least number of cores");

            int lowest_memory = 100;
            ComputerType lowest_memory_type = 0;
            if (lowest_memory > Desctop_comp.memory)
            {
                lowest_memory = Desctop_comp.memory;
                lowest_memory_type = Desctop_comp.type;
            }
            if (lowest_memory > Laptop_comp.memory)
            {
                lowest_memory = Laptop_comp.memory;
                lowest_memory_type = Laptop_comp.type;
            }
            if (lowest_memory > Server_comp.memory)
            {
                lowest_memory = Server_comp.memory;
                lowest_memory_type = Server_comp.type;
            }
            Console.WriteLine(lowest_memory_type + " has least frequency");
                // 10) make desktop upgrade: change memory up to 8
                // change value of memory to 8 for every desktop. Don't do it for other computers
                // Note: use loops and if-else statements
            Desctop_comp.cores = 8;
            Console.WriteLine("desctop now has " + Desctop_comp.cores + " cores");
            Console.ReadKey();
        }
 
    }
}
