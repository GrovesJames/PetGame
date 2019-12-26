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
        public Pet Pet { get; set; }
        public Shelter Shelter { get; set; }

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

            Console.WriteLine("Whats the species of your pet?");
            string species = Console.ReadLine();

            Pet = new Pet(name, species);
            Shelter = new Shelter();
            Shelter.AddToShelter(Pet);
        }

        public void Interact()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine("\nChoose an option to interact with your pet!");
            Console.WriteLine("\n1. View pet info (name, species)");
            Console.WriteLine("2. View pets status levels");
            Console.WriteLine("3. Feed your pet");
            Console.WriteLine("4. Play with your pet");
            Console.WriteLine("5. Take pet to the doctor\n");
            Console.WriteLine("6. View all pets in shelter\n");
            Console.WriteLine("0. Exit the game");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.WriteLine("Your pets name is " + Pet.Name + " and its species is a " + Pet.Species + "!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("Your pets status levels are:");
                Console.WriteLine("Hunger: " + Pet.Hunger);
                Console.WriteLine("Health: " + Pet.Health);
                Console.WriteLine("Boredom: " + Pet.Boredom);
                Console.WriteLine("\nPress enter to continue..");

                Console.ReadLine();
            }
            else if (menuChoice == "3")
            {
                Pet.FeedPet();
            }
            else if (menuChoice == "4")
            {
                Pet.PlayPet();
            }
            else if (menuChoice == "5")
            {
                Pet.DoctorPet();
            }
            else if (menuChoice == "6")
            {
                Shelter.ShowPets();
                Console.ReadLine();
            }
            else if (menuChoice == "0")
            {
                Console.WriteLine("Thanks for playing!");
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