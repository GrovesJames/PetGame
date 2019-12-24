using System;
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

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 5;
            Boredom = 5;
            Health = 5;
        }

        public void FeedPet()
        {
            Console.WriteLine("You've fed your pet!");
            Console.WriteLine("\nPress enter to continue..");
            Hunger--;
            Console.ReadLine();
        }
        public void PlayPet()
        {
            Console.WriteLine("You've played with your pet!");
            Console.WriteLine("\nPress enter to continue..");
            Boredom--;
            Console.ReadLine();
        }
        public void DoctorPet()
        {
            Console.WriteLine("You've taken your pet to the doctor!");
            Console.WriteLine("\nPress enter to continue..");
            Health++;
            Console.ReadLine();
        }
    }
}
