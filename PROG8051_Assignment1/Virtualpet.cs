﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment1
{
    internal class Virtualpet(string petname)
    {
        public string petName { get; private set; } = petname;
        public int hungerValue { get; private set; } = 5;
        public int happinessValue { get; private set; } = 5;
        public int healthValue { get; private set; } = 5;

        public void Feedpet()
        {

            hungerValue = hungerValue - 2;
            healthValue = healthValue + 1;
            hungerValue = hungerValue < 0 ? 0 : hungerValue; //to avoid having values more than 10 or less than 0
            healthValue = healthValue > 10 ? 10 : healthValue;

            Console.WriteLine($"You fed {petName}. His hunger decreased and health slightly increased!");
        }

        public void Play()
        {

            hungerValue = hungerValue + 1;
            happinessValue = happinessValue + 2;

            hungerValue = hungerValue > 10 ? 10 : hungerValue; //to avoid having values more than 10
            happinessValue = happinessValue > 10 ? 10 : happinessValue;

            Console.WriteLine($"You played with {petName}. His happiness increased but he is feeling a little bit hungry now!");
        }

        public void Rest()
        {
            healthValue = healthValue + 2;
            happinessValue = happinessValue - 1;
            happinessValue = happinessValue < 0 ? 0 : happinessValue; //to avoid having values more than 10 or less than 0
            healthValue = healthValue > 10 ? 10 : healthValue;
            Console.WriteLine($"You made {petName} rest. His health improved but he is feeling a little bit sad now!");
        }

        public void DisplayStatusReport()
        {

            Console.WriteLine();
            Console.WriteLine($"{petName}'s Status:");
            Console.WriteLine("- Hunger: " + hungerValue);
            Console.WriteLine("- Happiness: " + happinessValue);
            Console.WriteLine("- Health: " + healthValue);
        }
    }

}