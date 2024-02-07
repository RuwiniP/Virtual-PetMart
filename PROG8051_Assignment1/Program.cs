using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PROG8051_Assignment1
{
    class VirtualPetCareApp
    {
        static void Main(string[] args)
        {
            List<string> pets = new List<string>(3);
            pets.Add("1. Dog");
            pets.Add("2. Cat");
            pets.Add("3. Rabbit");

            Console.WriteLine("---------Welcome to your virtual Pet Mart--------");
            Console.WriteLine();

            int petType;
            while (true)
            {
                Console.WriteLine("Please choose a type of pet from the below list:");
                foreach (string pet in pets)
                    Console.WriteLine(pet);

                Console.WriteLine();
                Console.Write("User Input: ");
                if (!int.TryParse(Console.ReadLine(), out petType))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a number!");
                    continue;
                }

                if (petType >= 1 && petType <= pets.Count)
                    break;
                else
                    Console.WriteLine();
                    Console.WriteLine("Invalid pet type. Please enter a number from the list!");
            }

            string petName;
            switch (petType)
            {
                case 1:
                    Console.WriteLine("You've chosen a Dog. What would you like to name your pet?");
                    break;
                case 2:
                    Console.WriteLine("You've chosen a Cat. What would you like to name your pet?");
                    break;
                case 3:
                    Console.WriteLine("You've chosen a Rabbit. What would you like to name your pet?");
                    break;
            }

            Console.WriteLine();
            Console.Write("User Input: ");
            petName = Console.ReadLine();

            Virtualpet virtualpet = new Virtualpet(petName);
            PetActions petActions = new PetActions(virtualpet);

            petActions.DisplayWelcomeMessage();
            while (true)
            {
                petActions.DisplayPetActions();
                Console.WriteLine();
                Console.Write("User Input: ");
                if (!int.TryParse(Console.ReadLine(), out int actionNo))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a number!");
                    continue;
                }

                petActions.PerformMenuAction(actionNo);
                if (actionNo == 5)
                    break;
                
            }
        }
    }
}
