﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAmok
{
    public class Pet
    {
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public Pet()
        {
            Hunger = 5;
            Boredom = 5;
            Health = 5;
        }

        public void AddPet(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void InfoPet()
        {
            Console.WriteLine("\nYour pets name is " + Name + " and its species is a " + Species + "!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void StatsPet()
        {
            Console.WriteLine("\nYour pet status levels are:");
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Boredom: " + Boredom);
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void FeedPet()
        {
            Hunger--;
            Console.WriteLine("\nYou've fed your pet!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void PlayPet()
        {
            Boredom--;
            Console.WriteLine("\nYou've played with your pet!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void DoctorPet()
        {
            Health++;
            Console.WriteLine("\nYou've taken your pet to the doctor!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
    }
}