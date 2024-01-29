using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment1
{
    internal class PetActions(Virtualpet virtualPet)
    {
        private Virtualpet virtualPet = virtualPet;

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine($"Welcome, {virtualPet.petName}! Let's take good care of your lovely pet.");
        }

        public void DisplayPetActions()
        {
            Console.WriteLine();
            Console.WriteLine("---Main menu of Actions---");
            Console.WriteLine("1. Feed " + virtualPet.petName);
            Console.WriteLine("2. Play with " + virtualPet.petName);
            Console.WriteLine("3. Let " + virtualPet.petName + " Rest");
            Console.WriteLine("4. Check " + virtualPet.petName + "'s Status");
            Console.WriteLine("5. Exit");
        }

        public void PerformMenuAction(int petActionNo)
        {
            switch (petActionNo)
            {
                case 1:
                    virtualPet.Feedpet();
                    break;
                case 2:
                    virtualPet.Play();
                    break;
                case 3:
                    virtualPet.Rest();
                    break;
                case 4:
                    virtualPet.DisplayStatusReport();
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine($"Thank you for playing with {virtualPet.petName}. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Please input a valid number");
                    break;
            }
        }
    }

}
