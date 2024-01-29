using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace PROG8051_Assignment1
{

    class VirtualPetCareApp
    {
        static void Main(string[] args)

        {
            //List of pet types
            List<string> pets = new List<string>(4);
            pets.Add("1. Dog ");
            pets.Add("2. Cat ");
            pets.Add("3. Rabbit ");


            //Display a welcome message
            Console.WriteLine("---------Welcome to your virtual Pet Mart--------");
            Console.WriteLine();




            //Take iput from user to identify the type of the pet
            Console.WriteLine("Please choose a type of pet from the below list.");
            foreach (string pet in pets)
                Console.WriteLine(pet);

            Console.WriteLine();
            Console.Write(" User Input: ");
            int petType = Convert.ToInt32(Console.ReadLine());

            MenuItem menu = new MenuItem();
            //  PetActions petActions = new PetActions();

            //Validating the input
            if (petType >= 1 && petType <= pets.Count)
            {
                if (petType == 1)
                {
                    Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
                }

                else if (petType == 2)
                {
                    Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
                }

                else if (petType == 3)
                {
                    
                        Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
                    
                }

               
                Console.Write(" User Input: ");
                string petName = Console.ReadLine();
                Virtualpet virtualpet = new Virtualpet(petName);
                PetActions petActions = new PetActions(virtualpet);

                petActions.DisplayWelcomeMessage();
                while (true)
                {
                    petActions.DisplayPetActions();
                    Console.Write("User Input: ");
                    if (!int.TryParse(Console.ReadLine(), out int actionNo))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    petActions.PerformMenuAction(actionNo);
                    if (actionNo == 5)
                        break;
                }
            }
            
        }
    }
}
          