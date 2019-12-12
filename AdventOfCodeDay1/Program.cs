using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream LinktoFile = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            StreamReader ReadFromFile = new StreamReader(LinktoFile);


            int mass = 0;
            decimal finalmass = 0;
            decimal total = 0;
            decimal result = -1;
            decimal fuelmass = 0;

            ReadFromFile.BaseStream.Seek(0, SeekOrigin.Begin);

       /*     Console.WriteLine("please enter a mass");
            mass = int.Parse(Console.ReadLine());
            total = 0;
            finalmass = mass / 3;
            finalmass = Math.Floor(finalmass);
            finalmass = finalmass - 2;

            total = total + finalmass;
            Console.WriteLine(total);

            result = total;

            do
            {
                result = Math.Floor((result / 3)) - 2;
                if (result < 0)
                {
                    result = 0;
                }
                Console.WriteLine("result" + result);
                fuelmass = fuelmass + result;
            } while (result > 0);
            fuelmass = fuelmass + total;
            Console.WriteLine("fuelmass" + fuelmass);

           */
            while (ReadFromFile.Peek() > -1)
            {

                mass = int.Parse(ReadFromFile.ReadLine());
                Console.WriteLine(mass);

        total = 0;
        finalmass = mass / 3;
        finalmass = Math.Floor(finalmass);
        finalmass = finalmass - 2;

        total = total + finalmass;
        Console.WriteLine(total);

        result = total;

        do
        {
            result = Math.Floor((result / 3)) - 2;
            if (result < 0)
            {
                result = 0;
            }
            Console.WriteLine("result" + result);
            fuelmass = fuelmass + result;
        } while (result > 0);
        fuelmass = fuelmass + total;
        Console.WriteLine("fuelmass" + fuelmass);

            }
            Console.WriteLine("the mass is" + fuelmass);
            Console.ReadLine();
        
    }

    }
}
