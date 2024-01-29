using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment1
{


    internal class MenuItem

    {
        int hungerValue = 5;
        int happinessValue = 5;
        int healthValue = 5;

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


        }

        public void displayStatusforInput(string petName)
        {
            int petActionNo = 0;

                //Getting user input for actions
                Console.WriteLine();
                Console.Write(" User Input: ");
                petActionNo = Convert.ToInt32(Console.ReadLine());

            if (petActionNo == 1)
            {
                hungerValue = hungerValue - 2;
                healthValue = healthValue + 1;

                Console.WriteLine("*******************");
                Console.WriteLine("You fed " + petName + ". His hunger decreased and health slightly increased!");
                displayPetActions(petName);
                displayStatusforInput(petName);

            }

            else if (petActionNo == 2)
            {
                hungerValue = hungerValue + 1;
                happinessValue = happinessValue + 2;

                Console.WriteLine("*******************");
                Console.WriteLine("You played with " + petName + ". His happiness increased but he is feeling little bit hungry now!");
                displayPetActions(petName);
                displayStatusforInput(petName);


            }

            else if (petActionNo == 3)
            {
                healthValue = healthValue + 2;
                happinessValue = happinessValue - 1;

                Console.WriteLine("*******************");
                Console.WriteLine("You made " + petName + " to rest.His health improved but he is feeling little bit sad now!");
                displayPetActions(petName);
                displayStatusforInput(petName);

            }

            else if (petActionNo == 4)
            {

                Console.WriteLine();
                Console.WriteLine(petName + "'s Status Report:");
                Console.WriteLine("- Hunger :" + hungerValue);
                Console.WriteLine("- Hapiness :" + happinessValue);
                Console.WriteLine("- Health :" + healthValue);
                displayPetActions(petName);
                displayStatusforInput(petName);

            }

            else if (petActionNo == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for playing with " + petName + ". Good Bye!");
                return;
            }

            else
            {
                Console.WriteLine("Please input a valid number");
                displayPetActions(petName);
                displayStatusforInput(petName);
            }
        
            }
            

    }
}
