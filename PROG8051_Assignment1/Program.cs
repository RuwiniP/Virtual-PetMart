using System.Linq.Expressions;

namespace PROG8051_Assignment1
{

    class VirtualPet
    {
        static void Main(string[] args)

        {
            //List of pet types
            List<string> pets = new List<string>(3);
            pets.Add("1. Dog ");
            pets.Add("2. Cat ");
            pets.Add("3. Rabbit ");


            //Display a welcome message
            Console.WriteLine("---------Welcome to your virtual Pet Mart--------");
            Console.WriteLine();

            try{
                //Take iput from user to identify the type of the pet
                Console.WriteLine("Please choose a type of pet from the below list.");
                foreach (string pet in pets)
                    Console.WriteLine(pet);

                Console.WriteLine();
                Console.Write(" User Input: ");
                int petType = Convert.ToInt32(Console.ReadLine());

                MenuItem menu = new MenuItem();

                //Validating the input
                if (petType == 1)
                {
                      Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
                      Console.Write(" User Input: ");
                      string petName = Console.ReadLine();
                      menu.displayWelcomeMessage(petName);
                      menu.displayPetActions(petName);
                      menu.displayStatusforInput(petName);

                }

                else if (petType == 2)
                {

                    Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
                    Console.Write(" User Input: ");
                    string petName = Console.ReadLine();
                    menu.displayWelcomeMessage(petName);
                    menu.displayPetActions(petName);
                }


                else if (petType == 3)
                {

                    Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
                    Console.Write(" User Input: ");
                    string petName = Console.ReadLine();
                    menu.displayWelcomeMessage(petName);
                    menu.displayPetActions(petName);
                }

                else
                {

                    Console.WriteLine("SORRY!.Please input a valid petType from the list.");
                }
            }

            catch(FormatException)
            {
                Console.WriteLine("INVALID NUMBER!. Please input a NUMBER from the list to proceed.");
            }
         }


        
    }
}