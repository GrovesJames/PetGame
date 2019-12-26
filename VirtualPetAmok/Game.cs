using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetAmok
{
    class Game
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string MenuChoice { get; set; }
        public bool GameFinished { get; set; }
        public Pet ChosenPet = new Pet();
        public Shelter Shelter = new Shelter();
        Pet pet = new Pet();

        public Game()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("Welcome to Virtual Pets!\n");
            Console.WriteLine("Start a new game by pressing enter..");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("\nCreate a pet!\n");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            Console.WriteLine("Whats the name for your pet?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhats the species of your pet?");
            string species = Console.ReadLine();

            pet.AddPet(name, species);
            Shelter.AddToShelter(pet);
        }

        public void Interact()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("\nChoose an option to interact with your pet!");
            Console.WriteLine("\n1. View pet info (name, species)");
            Console.WriteLine("2. View pet status levels");
            Console.WriteLine("3. Feed your pet");
            Console.WriteLine("4. Play with your pet");
            Console.WriteLine("5. Take pet to the doctor\n");
            Console.WriteLine("6. Add another pet to the shelter");
            Console.WriteLine("7. View all pets in shelter");
            Console.WriteLine("8. View all pet stats in shelter\n");
            Console.WriteLine("0. Exit the game");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.WriteLine("\nYour pets name is " + pet.Name + " and its species is a " + pet.Species + "!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("\nYour pet status levels are:");
                Console.WriteLine("Hunger: " + pet.Hunger);
                Console.WriteLine("Health: " + pet.Health);
                Console.WriteLine("Boredom: " + pet.Boredom);
                Console.WriteLine("\nPress enter to continue..");

                Console.ReadLine();
            }
            else if (menuChoice == "3")
            {
                pet.FeedPet();
            }
            else if (menuChoice == "4")
            {
                pet.PlayPet();
            }
            else if (menuChoice == "5")
            {
                pet.DoctorPet();
            }
            else if (menuChoice == "6")
            {
                Console.WriteLine("\nWhats the name of your new pet?");
                string newName = Console.ReadLine();

                Console.WriteLine("\nWhats the species of your new pet?");
                string newSpecies = Console.ReadLine();

                Pet newPet = new Pet();
                newPet.AddPet(newName, newSpecies);
                Shelter.AddToShelter(newPet);
            }
            else if (menuChoice == "7")
            {
                Console.Clear();
                Shelter.ShowPets();
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "8")
            {
                Console.Clear();
                Shelter.ShowPetsStats();
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "0")
            {
                Console.WriteLine("\nThanks for playing!");
                Console.ReadLine();
                GameFinished = true;
            }
            else
            {
                Console.WriteLine("Thats not a choice, silly goose");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
        }
    }
}