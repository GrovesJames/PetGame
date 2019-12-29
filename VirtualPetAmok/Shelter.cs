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
                pet.InfoPet();
            }
        }
        public void ShowPetsStats()
        {
            foreach (Pet pet in Pets)
            {
                pet.StatsPet();
            }
        }
        public void FeedAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.FeedPet();
            }
        }
        public void PlayAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.PlayPet();
            }
        }
        public void DoctorAllPets()
        {
            foreach (Pet pet in Pets)
            {
                pet.DoctorPet();
            }
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
        public void AdoptPet(Pet chosenPet)
        {
            Pets.Remove(chosenPet);
        }
    }
}