using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment1
{
    internal class MenuItem
    {
        public void displayWelcomeMessage(String petName) {

            Console.WriteLine();
            Console.WriteLine("Welcome, " + petName + "! Let's take good care of your lovely pet.");
        }

        public void displayPetActions(string petName) {

            List<string> petAction = new List<string>(4);
            petAction.Add("1. Feed "+petName);
            petAction.Add("2. Play with "+petName);
            petAction.Add("3. Let "+petName+" Rest");
            petAction.Add("4. Check " + petName +"'s Status");
            petAction.Add("5. Exit");

            Console.WriteLine();
            Console.WriteLine("---Main menu of Actions---");
            foreach (string actions in petAction)
                Console.WriteLine(actions);

            Console.WriteLine();
            Console.Write(" User Input: ");


        }
    }
}
