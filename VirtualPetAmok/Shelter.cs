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
            Pets.Add(Pet);
        }

        public void ShowPets()
        {
            foreach (Pet pet in Pets)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("\nPet name: " + pet.Name + ". Pet species: " + pet.Species + ".\n");
                Console.WriteLine("---------------------");
            }
        }
    }
}
