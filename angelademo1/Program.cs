using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace angelademo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStuff = new string[3];
            myStuff[0]= "Angela";
            myStuff[1]= "October";
            myStuff[2]= "Black";

            for (int i = 0; i < 3; i = i + 1)
            {
                Console.WriteLine(myStuff[i]);
                       
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to close the window...");
            Console.ReadLine();
        }
    }
}
