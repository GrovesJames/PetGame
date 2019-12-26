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
                Console.WriteLine("Pet name: " + pet.Name + ". Pet species: " + pet.Species + ".");
            }
        }
    }
}
