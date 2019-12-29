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
        public Pet chosenPet = new Pet();
        public Shelter Shelter = new Shelter();

        public Game()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\nWelcome to Virtual Pets!\n");
            Console.WriteLine("Start a new game by pressing enter..\n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");

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

            Console.WriteLine("\nWhat is the make up of your pet?");
            Console.WriteLine("1. Organic");
            Console.WriteLine("2. Robotic\n");
            int makeUp = Convert.ToInt32(Console.ReadLine());

            if (makeUp == 1)
            {
                Pet organic = new Organic();
                organic.AddPet(name, species);
                Shelter.AddToShelter(organic);
            }
            else if (makeUp == 2)
            {
                Pet robotic = new Robotic();
                robotic.AddPet(name, species);
                Shelter.AddToShelter(robotic);
            }
        }

        public void Interact()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\nChoose an option to interact with your pet!");
            Console.WriteLine("\n1. View pet info (name, species, makeup)");
            Console.WriteLine("2. View pet status levels");
            Console.WriteLine("3. Feed/Oil a pet");
            Console.WriteLine("4. Play with your pet");
            Console.WriteLine("5. Take pet to the doctor/mechanic\n");
            Console.WriteLine("6. Add another pet to the shelter");
            Console.WriteLine("7. View all pets in shelter");
            Console.WriteLine("8. View all pet stats in shelter");
            Console.WriteLine("9. Feed/oil all pets in the shelter");
            Console.WriteLine("10. Play with all pets in the shelter");
            Console.WriteLine("11. Take all pets in the shelter to the doctor/mechanic");
            Console.WriteLine("12. Adopt a pet from the shelter\n");
            Console.WriteLine("0. Exit the game");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                chosenPet = Shelter.ChoosePet();
                chosenPet.InfoPet();
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "2")
            {
                chosenPet = Shelter.ChoosePet();
                chosenPet.StatsPet();
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "3")
            {
                chosenPet = Shelter.ChoosePet();
                chosenPet.FeedPet();
                Console.WriteLine("\nYou've filled the oil/fed your pet(s)!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "4")
            {
                chosenPet = Shelter.ChoosePet();
                chosenPet.PlayPet();
                Console.WriteLine("\nYou've played with your pet(s)!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "5")
            {
                chosenPet = Shelter.ChoosePet();
                chosenPet.DoctorPet();
                Console.WriteLine("\nYou've taken your pet(s) to the doctor/mechanic!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "6")
            {
                Console.Clear();
                Console.WriteLine("Whats the name for your pet?");
                string name = Console.ReadLine();

                Console.WriteLine("\nWhats the species of your pet?");
                string species = Console.ReadLine();

                Console.WriteLine("\nWhat is the make up of your pet?");
                Console.WriteLine("1. Organic");
                Console.WriteLine("2. Robotic\n");
                int makeUp = Convert.ToInt32(Console.ReadLine());

                if (makeUp == 1)
                {
                    Pet organic = new Organic();
                    organic.AddPet(name, species);
                    Shelter.AddToShelter(organic);
                }
                else if (makeUp == 2)
                {
                    Pet robotic = new Robotic();
                    robotic.AddPet(name, species);
                    Shelter.AddToShelter(robotic);
                }
                Console.WriteLine("\nYou've added a new pet to the shelter!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
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
            else if (menuChoice == "9")
            {
                Shelter.FeedAllPets();
                Console.WriteLine("\nYou've filled the oil/fed your pet(s)!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "10")
            {
                Shelter.PlayAllPets();
                Console.WriteLine("\nYou've played with your pet(s)!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "11")
            {
                Shelter.DoctorAllPets();
                Console.WriteLine("\nYou've taken your pet(s) to the doctor/mechanic!");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (menuChoice == "12")
            {
                chosenPet = Shelter.ChoosePet();
                Shelter.AdoptPet(chosenPet);
                Console.WriteLine("\nYou've adopted " + chosenPet.Name + " from the shelter!");
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