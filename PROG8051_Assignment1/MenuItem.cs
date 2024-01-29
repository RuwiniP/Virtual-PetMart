using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment1
{
    internal class MenuItem
    {
        public void inputName() {


            Console.Write(" User Input: ");
            string petName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome, " + petName + "! Let's take good care of your lovely pet.");
        }
    }
}
