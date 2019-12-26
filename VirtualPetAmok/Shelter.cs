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
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\nPet name: " + pet.Name);
                Console.WriteLine("\nPet species: " + pet.Species + "\n");
                Console.WriteLine("------------------------------------------");
            }
        }
        public void ShowPetsStats()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Name     | Hunger | Boredom | Health |");
            foreach (Pet pet in Pets)
            {
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("| " + pet.Name + "     | " + pet.Hunger + "     | " + pet.Boredom + "      | " + pet.Health + "     |\n");
                Console.WriteLine("------------------------------------------");
            }
        }
        public void FeedAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.Hunger--;
            }
            Console.WriteLine("\nYou've fed all of the pets in the shelter!");
        }
        public void PlayAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.Boredom--;
            }
            Console.WriteLine("\nYou've played with all of the pets in the shelter!");
        }
        public void DoctorAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.Health++;
            }
            Console.WriteLine("\nYou've taken all of the pets in the shelter to the doctor!");
        }
        public Pet ChoosePet()
        {
            int petNum = 1;

            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("\n Select a pet:\n");

            foreach (Pet pet in Pets)
            {
                Console.WriteLine(petNum + ". " + pet.Name + " the " + pet.Species + "\n");
                petNum++;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");

            int petChoice = Convert.ToInt32(Console.ReadLine());
            Pet chosenPet = Pets[petChoice - 1];
            return chosenPet;
        }
    }
}
