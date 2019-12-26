using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAmok
{
    class Shelter
    {
        public List<Pet> Pets = new List<Pet>();

        public void AddToShelter(Pet Pet)
        {
            Console.WriteLine("\nYou've added a new pet to the shelter!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
            Pets.Add(Pet);
        }
        public void ShowPets()
        {
            foreach (Pet pet in Pets)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("\nPet name: " + pet.Name);
                Console.WriteLine("\nPet species: " + pet.Species + "\n");
                Console.WriteLine("---------------------");
            }
        }
        public void ShowPetsStats()
        {
            foreach (Pet pet in Pets)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("\n" + pet.Name + " the " + pet.Species + " stats are:\n");
                Console.WriteLine("\nHealth: " + pet.Health + "\n");
                Console.WriteLine("\nHunger: " + pet.Hunger + "\n");
                Console.WriteLine("\nBoredom: " + pet.Boredom + "\n");
                Console.WriteLine("---------------------");
            }
        }
    }
}
